﻿using System.Collections.Generic;
using SFA.Apprenticeships.Web.Raa.Common.ViewModels;
using SFA.Apprenticeships.Web.Raa.Common.ViewModels.Vacancy;

namespace SFA.Apprenticeships.Web.Raa.Common.Providers
{
    using FluentValidation.Results;

    public interface IVacancyProvider
    {
		List<VacancyViewModel> GetVacanciesForProvider(string ukprn, string providerSiteErn);
	
        List<DashboardVacancySummaryViewModel> GetPendingQAVacanciesOverview();

        List<DashboardVacancySummaryViewModel> GetPendingQAVacancies();

        void ApproveVacancy(long vacancyReferenceNumber);

        void RejectVacancy(long vacancyReferenceNumber);

        VacancyViewModel ReserveVacancyForQA(long vacancyReferenceNumber);

        VacancySummaryViewModel UpdateVacancy(VacancySummaryViewModel viewModel);

        NewVacancyViewModel UpdateVacancy(NewVacancyViewModel viewModel);

        VacancyRequirementsProspectsViewModel UpdateVacancy(VacancyRequirementsProspectsViewModel viewModel);

        VacancyQuestionsViewModel UpdateVacancy(VacancyQuestionsViewModel viewModel);
    }
}
