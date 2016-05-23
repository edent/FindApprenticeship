﻿namespace SFA.Apprenticeships.Data.Migrate.Faa.Repository.Sql
{
    using System.Collections.Generic;
    using System.Linq;
    using Entities.Sql;
    using Infrastructure.Repositories.Sql.Common;

    public class ApplicationHistoryRepository
    {
        private readonly IGetOpenConnection _getOpenConnection;

        public ApplicationHistoryRepository(IGetOpenConnection getOpenConnection)
        {
            _getOpenConnection = getOpenConnection;
        }

        public IDictionary<int, Dictionary<int, int>> GetApplicationHistoryIdsByApplicationIds(IEnumerable<int> applicationIds)
        {
            var applicationHistoryIds = _getOpenConnection.Query<ApplicationHistoryIds>("SELECT ApplicationHistoryId, ApplicationId, ApplicationHistoryEventSubTypeId FROM ApplicationHistory WHERE ApplicationId in @applicationIds", new { applicationIds });
            return applicationHistoryIds.GroupBy(ah => ah.ApplicationId).ToDictionary(g => g.Key, g => g.ToDictionary(gah => gah.ApplicationHistoryEventSubTypeId, gah => gah.ApplicationHistoryId));
        }

        // ReSharper disable once ClassNeverInstantiated.Local
        private class ApplicationHistoryIds
        {
            // ReSharper disable UnusedAutoPropertyAccessor.Local
            public int ApplicationHistoryId { get; set; }
            public int ApplicationId { get; set; }
            public int ApplicationHistoryEventSubTypeId { get; set; }
            // ReSharper restore UnusedAutoPropertyAccessor.Local
        }

        public IDictionary<int, List<ApplicationHistorySummary>> GetApplicationHistorySummariesByApplicationIds(IEnumerable<int> applicationIds)
        {
            var applicationHistorySummaries = _getOpenConnection.Query<ApplicationHistorySummary>("SELECT ApplicationHistoryId, ApplicationId, ApplicationHistoryEventDate, ApplicationHistoryEventSubTypeId FROM ApplicationHistory WHERE ApplicationId in @applicationIds", new { applicationIds });
            return applicationHistorySummaries.GroupBy(ah => ah.ApplicationId).ToDictionary(g => g.Key, g => g.ToList());
        }
    }
}