﻿namespace SFA.Apprenticeships.Web.Raa.Common.Providers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;
    using ViewModels.Vacancy;
    using ViewModels.VacancyPosting;

    public interface IVacancyQAProvider
    {
        DashboardVacancySummariesViewModel GetPendingQAVacanciesOverview(DashboardVacancySummariesSearchViewModel searchViewModel);

        List<DashboardVacancySummaryViewModel> GetPendingQAVacancies();

        void ApproveVacancy(long vacancyReferenceNumber);

        void RejectVacancy(long vacancyReferenceNumber);

        VacancyViewModel ReserveVacancyForQA(long vacancyReferenceNumber);

        NewVacancyViewModel GetNewVacancyViewModel(long vacancyReferenceNumber);

        TrainingDetailsViewModel GetTrainingDetailsViewModel(long vacancyReferenceNumber);

        FurtherVacancyDetailsViewModel GetVacancySummaryViewModel(long vacancyReferenceNumber);

        VacancyRequirementsProspectsViewModel GetVacancyRequirementsProspectsViewModel(long vacancyReferenceNumber);

        VacancyQuestionsViewModel GetVacancyQuestionsViewModel(long vacancyReferenceNumber);

        FurtherVacancyDetailsViewModel UpdateVacancyWithComments(FurtherVacancyDetailsViewModel viewModel);

        NewVacancyViewModel UpdateVacancyWithComments(NewVacancyViewModel viewModel);

        TrainingDetailsViewModel UpdateVacancyWithComments(TrainingDetailsViewModel viewModel);

        VacancyRequirementsProspectsViewModel UpdateVacancyWithComments(VacancyRequirementsProspectsViewModel viewModel);

        VacancyQuestionsViewModel UpdateVacancyWithComments(VacancyQuestionsViewModel viewModel);

        List<SelectListItem> GetSectorsAndFrameworks();

        List<StandardViewModel> GetStandards();

        List<SelectListItem> GetSectors();

        void RemoveLocationAddresses(Guid vacancyGuid);

        NewVacancyViewModel UpdateEmployerInformationWithComments(NewVacancyViewModel existingVacancy);

        LocationSearchViewModel LocationAddressesViewModel(string ukprn, int providerSiteId, int employerId, Guid vacancyGuid);

        LocationSearchViewModel AddLocations(LocationSearchViewModel viewModel);

        VacancyViewModel GetVacancy(Guid vacancyGuid);

        VacancyViewModel GetVacancy(long vacancyReferenceNumber);
    }
}
