﻿namespace SFA.Apprenticeships.Web.Raa.Common.ViewModels.Application
{
    using Domain.Entities.Raa.Vacancies;
    using System;
    using Web.Common.ViewModels;
    using Web.Common.ViewModels.Locations;

    public class VacancyApplicationsViewModel
    {
        public VacancyApplicationsSearchViewModel VacancyApplicationsSearch { get; set; }

        public VacancyType VacancyType { get; set; }

        public string Title { get; set; }

        public string EmployerName { get; set; }

        public GeoPointViewModel EmployerGeoPoint { get; set; }

        public string ShortDescription { get; set; }

        public DateTime ClosingDate { get; set; }

        public VacancyStatus Status { get; set; }

        public int NewApplicationsCount { get; set; }

        public int InProgressApplicationsCount { get; set; }

        public int SuccessfulApplicationsCount { get; set; }

        public int UnsuccessfulApplicationsCount { get; set; }

        public int TotalNumberOfApplications => NewApplicationsCount + InProgressApplicationsCount + SuccessfulApplicationsCount +
                                                UnsuccessfulApplicationsCount;
        public int TotalNumberOfApplicationsWithPendingDecisions => NewApplicationsCount + InProgressApplicationsCount;

        public PageableViewModel<ApplicationSummaryViewModel> ApplicationSummaries { get; set; }

        public bool HasApplications => TotalNumberOfApplications > 0;
    }
}