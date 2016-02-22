﻿namespace SFA.Apprenticeships.Infrastructure.Repositories.Mongo.Employers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Common;
    using Common.Configuration;
    using Domain.Entities.Raa.Parties;
    using Domain.Raa.Interfaces.Repositories;
    using Entities;
    using MongoDB.Bson;
    using MongoDB.Driver.Builders;
    using MongoDB.Driver.Linq;
    using SFA.Infrastructure.Interfaces;

    public class EmployerRepository : GenericMongoClient2<MongoEmployer>, IEmployerReadRepository, IEmployerWriteRepository
    {
        private readonly IMapper _mapper;
        private readonly ILogService _logger;

        public EmployerRepository(IConfigurationService configurationService, IMapper mapper, ILogService logger)
        {
            var config = configurationService.Get<MongoConfiguration>();
            Initialise(config.EmployersDb, "employers");
            _mapper = mapper;
            _logger = logger;
        }

        public Employer Get(int employerId)
        {
            _logger.Debug("Called Mongodb to get employer with Id={0}", employerId);

            var mongoEntity = Collection.AsQueryable().SingleOrDefault(e => e.EmployerId == employerId);

            return mongoEntity == null ? null : _mapper.Map<MongoEmployer, Employer>(mongoEntity);
        }

        public Employer GetByEdsErn(string edsErn)
        {
            _logger.Debug("Called Mongodb to get employer with edsErn={0}", edsErn);

            var mongoEntity = Collection.AsQueryable().SingleOrDefault(e => e.EdsErn == edsErn);

            return mongoEntity == null ? null : _mapper.Map<MongoEmployer, Employer>(mongoEntity);
        }

        public List<Employer> GetByIds(IEnumerable<int> employerIds)
        {
            var mongoEntities = Collection.Find(Query.In("EmployerId", new BsonArray(employerIds)));

            return mongoEntities.Select(e => _mapper.Map<MongoEmployer, Employer>(e)).ToList();
        }

        public void Delete(int employerId)
        {
            _logger.Debug("Calling repository to delete employer with Id={0}", employerId);

            Collection.Remove(Query<MongoEmployer>.EQ(e => e.EmployerId, employerId));

            _logger.Debug("Deleted employer with Id={0}", employerId);
        }

        public Employer Save(Employer entity)
        {
            _logger.Debug("Called Mongodb to save employer with ERN={0}", entity.EdsErn);

            SetCreatedDateTime(entity);
            SetUpdatedDateTime(entity);

            var mongoEntity = _mapper.Map<Employer, MongoEmployer>(entity);

            Collection.Save(mongoEntity);

            _logger.Debug("Saved employer to Mongodb with ERN={0}", entity.EdsErn);

            return _mapper.Map<MongoEmployer, Employer>(mongoEntity);
        }
    }
}
