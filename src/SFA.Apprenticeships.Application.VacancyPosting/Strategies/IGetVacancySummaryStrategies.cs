﻿namespace SFA.Apprenticeships.Application.VacancyPosting.Strategies
{
    using System.Collections.Generic;
    using Domain.Entities.Raa.Vacancies;
    using Domain.Raa.Interfaces.Repositories.Models;

    public interface IGetVacancySummaryStrategies
    {
        IList<VacancySummary> GetWithStatus(VacancySummaryByStatusQuery query, out int totalRecords);

        IReadOnlyList<VacancySummary> GetVacancySummariesByIds(IEnumerable<int> vacancyIds);

        IReadOnlyDictionary<int, IEnumerable<IMinimalVacancyDetails>> GetMinimalVacancyDetails(IEnumerable<int> vacancyOwnerRelationshipIds, int providerId, IEnumerable<int> providerSiteIds);
        IList<RegionalTeamMetrics> GetRegionalTeamMetrics(VacancySummaryByStatusQuery query);
    }
}