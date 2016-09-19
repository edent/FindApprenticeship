﻿namespace SFA.Apprenticeships.Infrastructure.Repositories.Sql.Schemas.dbo
{
    using System.Collections.Generic;
    using System.Linq;
    using Common;
    using Domain.Entities.Raa.Parties;
    using Domain.Raa.Interfaces.Repositories;
    using Entities;
    using Application.Interfaces;

    public class VacancyPartyRepository : IVacancyPartyReadRepository, IVacancyPartyWriteRepository
    {
        private enum VacancyOwnerRelationshipStatusTypes
        {
            Deleted = 3,
            Live = 4
        };

        private readonly IGetOpenConnection _getOpenConnection;
        private readonly IMapper _mapper;
        private readonly ILogService _logger;
        
        public VacancyPartyRepository(IGetOpenConnection getOpenConnection, IMapper mapper, ILogService logger)
        {
            _getOpenConnection = getOpenConnection;
            _mapper = mapper;
            _logger = logger;
        }

        public VacancyParty GetByProviderSiteAndEmployerId(int providerSiteId, int employerId)
        {
            const string sql = @"
                SELECT * FROM dbo.VacancyOwnerRelationship
                WHERE ProviderSiteID = @ProviderSiteId
                AND EmployerId = @EmployerId
                AND StatusTypeId = @StatusTypeId";

            var sqlParams = new
            {
                ProviderSiteId = providerSiteId,
                EmployerId = employerId,
                StatusTypeId = VacancyOwnerRelationshipStatusTypes.Live
            };

            var vacancyParty = _getOpenConnection.Query<VacancyOwnerRelationship>(sql, sqlParams).SingleOrDefault();

            return _mapper.Map<VacancyOwnerRelationship, VacancyParty>(vacancyParty);
        }

        public IEnumerable<VacancyParty> GetByIds(IEnumerable<int> vacancyPartyIds, bool currentOnly = true)
        {
            var vacancyPartyIdsArray = vacancyPartyIds.Distinct().ToArray();

            _logger.Debug("Calling database to get vacancy parties with Ids={0}", string.Join(", ", vacancyPartyIdsArray));

            string sql = @"
                SELECT *
                FROM   dbo.VacancyOwnerRelationship
                WHERE  VacancyOwnerRelationshipId IN @VacancyPartyIds
" + (currentOnly ? "AND StatusTypeId = @StatusTypeId" : "");

            List<VacancyOwnerRelationship> vacancyOwnerRelationships = new List<VacancyOwnerRelationship>();
            var splitVacancyPartyIdsArray = DbHelpers.SplitIds(vacancyPartyIdsArray);
            foreach (int[] ids in splitVacancyPartyIdsArray)
            {
                var sqlParams = new
                {
                    VacancyPartyIds = ids,
                    StatusTypeId = VacancyOwnerRelationshipStatusTypes.Live
                };
                var vacancyParties = _getOpenConnection.Query<VacancyOwnerRelationship>(sql, sqlParams);
                vacancyOwnerRelationships.AddRange(vacancyParties);
            }

            return _mapper.Map<IEnumerable<VacancyOwnerRelationship>, IEnumerable<VacancyParty>>(vacancyOwnerRelationships);
        }

        public IEnumerable<VacancyParty> GetByProviderSiteId(int providerSiteId)
        {
            const string sql = @"
                SELECT * FROM dbo.VacancyOwnerRelationship
                WHERE ProviderSiteID = @ProviderSiteId
                AND StatusTypeId = @StatusTypeId";

            var sqlParams = new
            {
                ProviderSiteID = providerSiteId,
                StatusTypeId = VacancyOwnerRelationshipStatusTypes.Live
            };

            var vacancyParties = _getOpenConnection.Query<VacancyOwnerRelationship>(sql, sqlParams);

            return _mapper.Map<IEnumerable<VacancyOwnerRelationship>, IEnumerable<VacancyParty>>(vacancyParties);
        }

        public VacancyParty Save(VacancyParty vacancyParty)
        {
            var dbVacancyOwnerRelationship = _mapper.Map<VacancyParty, VacancyOwnerRelationship>(vacancyParty);

            dbVacancyOwnerRelationship.StatusTypeId = (int)VacancyOwnerRelationshipStatusTypes.Live;
            dbVacancyOwnerRelationship.EditedInRaa = true;

            if (dbVacancyOwnerRelationship.VacancyOwnerRelationshipId == 0)
            {
                dbVacancyOwnerRelationship.VacancyOwnerRelationshipId = (int)_getOpenConnection.Insert(dbVacancyOwnerRelationship);
            }
            else
            {
                const string sql = @"
                    SELECT * FROM dbo.VacancyOwnerRelationship
                    WHERE VacancyOwnerRelationshipId = @VacancyOwnerRelationshipId
                    AND StatusTypeId = @StatusTypeId";

                var sqlParams = new
                {
                    dbVacancyOwnerRelationship.VacancyOwnerRelationshipId,
                    dbVacancyOwnerRelationship.StatusTypeId
                };

                var existingVacancyOwnerRelationship = _getOpenConnection.Query<VacancyOwnerRelationship>(sql, sqlParams).Single();

                dbVacancyOwnerRelationship.ContractHolderIsEmployer = existingVacancyOwnerRelationship.ContractHolderIsEmployer;
                dbVacancyOwnerRelationship.ManagerIsEmployer = existingVacancyOwnerRelationship.ManagerIsEmployer;
                dbVacancyOwnerRelationship.Notes = existingVacancyOwnerRelationship.Notes;
                dbVacancyOwnerRelationship.EmployerLogoAttachmentId = existingVacancyOwnerRelationship.EmployerLogoAttachmentId;
                dbVacancyOwnerRelationship.NationWideAllowed = existingVacancyOwnerRelationship.NationWideAllowed;

                _getOpenConnection.UpdateSingle(dbVacancyOwnerRelationship);
            }

            return GetByIds(new[] { dbVacancyOwnerRelationship.VacancyOwnerRelationshipId }).Single();
        }

        public bool IsADeletedVacancyParty(int providerSiteId, int employerId)
        {
            const string sql = @"
                SELECT StatusTypeId FROM dbo.VacancyOwnerRelationship
                WHERE ProviderSiteID = @ProviderSiteId
                AND EmployerId = @EmployerId";

            var sqlParams = new
            {
                ProviderSiteId = providerSiteId,
                EmployerId = employerId
            };

            return _getOpenConnection.Query<VacancyOwnerRelationship>(sql, sqlParams).SingleOrDefault()?.StatusTypeId == (int)VacancyOwnerRelationshipStatusTypes.Deleted;
        }

        public void ResurrectVacancyParty(int providerSiteId, int employerId)
        {
            const string sql = @"
                UPDATE dbo.VacancyOwnerRelationship SET StatusTypeId = @StatusTypeId
                WHERE ProviderSiteID = @ProviderSiteId
                AND EmployerId = @EmployerId";

            var sqlParams = new
            {
                ProviderSiteId = providerSiteId,
                EmployerId = employerId,
                StatusTypeId = VacancyOwnerRelationshipStatusTypes.Live
            };

            _getOpenConnection.MutatingQuery<object>(sql, sqlParams);

        }
    }
}