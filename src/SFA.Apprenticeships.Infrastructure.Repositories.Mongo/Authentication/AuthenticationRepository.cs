﻿namespace SFA.Apprenticeships.Infrastructure.Repositories.Mongo.Authentication
{
    using System;
    using Domain.Entities.Exceptions;
    using Domain.Entities.Users;
    using Domain.Interfaces.Repositories;
    using Entities;
    using Common;
    using Common.Configuration;
    using MongoDB.Driver.Builders;

    using SFA.Apprenticeships.Application.Interfaces;
    using SFA.Infrastructure.Interfaces;
    using UsersErrorCodes = Application.Interfaces.Users.ErrorCodes;

    public class AuthenticationRepository : GenericMongoClient<MongoUserCredentials>, IAuthenticationRepository
    {
        private readonly ILogService _logger;
        private readonly IMapper _mapper;

        public AuthenticationRepository(IConfigurationService configurationService, IMapper mapper, ILogService logger)
        {
            var config = configurationService.Get<MongoConfiguration>();
            Initialise(config.AuthenticationDb, "userCredentials");
            _mapper = mapper;
            _logger = logger;
        }

        public UserCredentials Get(Guid id)
        {
            _logger.Debug("Calling repository to get UserCredentials for user {0}", id);

            var mongoEntity = Collection.FindOneById(id);

            LogOutcome(id, mongoEntity);

            return mongoEntity == null ? null : _mapper.Map<MongoUserCredentials, UserCredentials>(mongoEntity);
        }

        public UserCredentials Get(Guid id, bool errorIfNotFound)
        {
            _logger.Debug("Calling repository to get UserCredentials for user \"{0}\"", id);

            var mongoEntity = Collection.FindOneById(id);

            if (mongoEntity == null && errorIfNotFound)
            {
                var message = string.Format("Unknown userCredentials for user with Id=\"{0}\"", id);
                _logger.Debug(message);

                throw new CustomException(message, UsersErrorCodes.UserDirectoryAccountDoesNotExistError);
            }

            LogOutcome(id, mongoEntity);

            return mongoEntity == null ? null : _mapper.Map<MongoUserCredentials, UserCredentials>(mongoEntity);
        }

        private void LogOutcome(Guid id, MongoUserCredentials mongoEntity)
        {
            var message = mongoEntity == null
                ? "Found no UserCredentials with for user \"{0}\""
                : "Found UserCredentials for user \"{0}\"";

            _logger.Debug(message, id);
        }

        public void Delete(Guid id)
        {
            _logger.Debug("Calling repository to delete MongoUserCredentials with Id={0}", id);

            Collection.Remove(Query<MongoUserCredentials>.EQ(o => o.Id, id));

            _logger.Debug("Deleted MongoUserCredentials with Id={0}", id);
        }

        public UserCredentials Save(UserCredentials entity)
        {
            _logger.Debug("Calling repository to save UserCredentials for user \"{0}\"", entity.EntityId);

            var mongoEntity = _mapper.Map<UserCredentials, MongoUserCredentials>(entity);

            UpdateEntityTimestamps(mongoEntity);

            Collection.Save(mongoEntity);

            _logger.Debug("Saved UserCredentials to repository for user \"{0}\"", entity.EntityId);

            return _mapper.Map<MongoUserCredentials, UserCredentials>(mongoEntity);
        }
    }
}