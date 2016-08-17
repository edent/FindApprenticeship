﻿namespace SFA.Apprenticeships.Infrastructure.Repositories.Mongo.Providers
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

    using SFA.Apprenticeships.Application.Interfaces;
    using SFA.Infrastructure.Interfaces;

    public class VacancyPartyRepository : GenericMongoClient2<MongoVacancyParty>, IVacancyPartyReadRepository, IVacancyPartyWriteRepository
    {
        private readonly IMapper _mapper;
        private readonly ILogService _logger;

        public VacancyPartyRepository(IConfigurationService configurationService, IMapper mapper, ILogService logger)
        {
            var config = configurationService.Get<MongoConfiguration>();
            Initialise(config.ProvidersDb, "vacancyParties");
            _mapper = mapper;
            _logger = logger;
        }

        public VacancyParty GetByProviderSiteAndEmployerId(int providerSiteId, int employerId)
        {
            _logger.Debug("Called Mongodb to get provider site employer link with providerSiteErn={0}, edsUrn={1}", providerSiteId, employerId);

            var mongoEntity = Collection.AsQueryable().SingleOrDefault(e => e.ProviderSiteId == providerSiteId && e.EmployerId == employerId);

            return mongoEntity == null ? null : _mapper.Map<MongoVacancyParty, VacancyParty>(mongoEntity);
        }

        public IEnumerable<VacancyParty> GetByIds(IEnumerable<int> vacancyPartyIds, bool currentOnly = true)
        {
            var mongoEntities = Collection.Find(Query.In("VacancyPartyId", new BsonArray(vacancyPartyIds)));

            return mongoEntities.Select(e => _mapper.Map<MongoVacancyParty, VacancyParty>(e)).ToList(); // TODO: Should be filtering by status
        }

        public IEnumerable<VacancyParty> GetByProviderSiteId(int providerSiteId)
        {
            _logger.Debug("Called Mongodb to get provider site employer links for provider site with ERN={0}", providerSiteId);

            var mongoEntities = Collection.Find(Query<MongoVacancyParty>.EQ(e => e.ProviderSiteId, providerSiteId));

            var entities = _mapper.Map<IEnumerable<MongoVacancyParty>, IEnumerable<VacancyParty>>(mongoEntities).ToList();

            _logger.Debug("Found {1} provider site employer links for provider site with ERN={0}", providerSiteId, entities.Count);

            return entities;
        }

        public VacancyParty Save(VacancyParty vacancyParty)
        {
            _logger.Debug("Called Mongodb to save provider site employer link with ERN={0}", vacancyParty.EmployerId);

            if (vacancyParty.VacancyPartyGuid == Guid.Empty)
            {
                vacancyParty.VacancyPartyGuid = Guid.NewGuid();
                vacancyParty.VacancyPartyId = vacancyParty.VacancyPartyGuid.GetHashCode();
            }

            var mongoEntity = _mapper.Map<VacancyParty, MongoVacancyParty>(vacancyParty);

            Collection.Save(mongoEntity);

            _logger.Debug("Saved provider site employer link to Mongodb with ERN={0}", vacancyParty.EmployerId);

            return _mapper.Map<MongoVacancyParty, VacancyParty>(mongoEntity);
        }
    }
}