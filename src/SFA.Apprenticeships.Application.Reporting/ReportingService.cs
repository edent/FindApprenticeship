﻿namespace SFA.Apprenticeships.Application.Reporting
{
    using System;
    using System.Collections.Generic;
    using Domain.Raa.Interfaces.Reporting.Models;
    using Interfaces.Reporting;

    public class ReportingService : IReportingService
    {
        private IReportingProvider _reportingProvider;

        public ReportingService(IReportingProvider reportingProvider)
        {
            _reportingProvider = reportingProvider;
        }

        public IList<ReportVacanciesResultItem> ReportVacanciesList(DateTime fromDate, DateTime toDate)
        {
            return _reportingProvider.ReportVacanciesList(fromDate, toDate);
        }

        public IList<ReportUnsuccessfulCandidatesResultItem> ReportUnsuccessfulCandidates(string reportType, DateTime fromDate, DateTime toDate, string ageRange)
        {
            return _reportingProvider.ReportUnsuccessfulCandidates(reportType, fromDate, toDate, ageRange);
        }

        public Dictionary<string, string> LocalAuthorityManagerGroups()
        {
            return _reportingProvider.LocalAuthorityManagerGroups();
        }

        public Dictionary<string, string> RegionsIncludingAll()
        {
            return _reportingProvider.RegionsIncludingAll();
        }
    }
}
