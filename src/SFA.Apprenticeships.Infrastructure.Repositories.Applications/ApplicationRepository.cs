﻿namespace SFA.Apprenticeships.Infrastructure.Repositories.Applications
{
    using System;
    using Common.Configuration;
    using Domain.Entities.Applications;
    using Domain.Interfaces.Mapping;
    using Domain.Interfaces.Repositories;
    using Entities;
    using Mongo.Common;
    using MongoDB.Driver.Builders;

    public class ApplicationRepository : GenericMongoRepository<MongoApplicationDetail>, IApplicationWriteRepository
    {
        private readonly IMapper _mapper;

        protected ApplicationRepository(IConfigurationManager configurationManager, IMapper mapper)
            : base(configurationManager, "Applications.mongoDB", "applications")
        {
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            Collection.Remove(Query<MongoApplicationDetail>.EQ(o => o.Id, id));
        }

        public ApplicationDetail Save(ApplicationDetail entity)
        {
            var mongoEntity = _mapper.Map<ApplicationDetail, MongoApplicationDetail>(entity);

            Collection.Save(mongoEntity);

            return _mapper.Map<MongoApplicationDetail, ApplicationDetail>(mongoEntity);
        }
    }
}
