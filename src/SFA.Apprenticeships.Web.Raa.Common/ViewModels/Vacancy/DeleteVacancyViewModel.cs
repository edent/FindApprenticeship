﻿namespace SFA.Apprenticeships.Web.Raa.Common.ViewModels.Vacancy
{
    using ProviderUser;

    public class DeleteVacancyViewModel : VacanciesSummarySearchViewModel
    {
        public DeleteVacancyViewModel()
        {
        }

        public DeleteVacancyViewModel(VacanciesSummarySearchViewModel vacanciesSummarySearch) : base(vacanciesSummarySearch)
        {
        }

        public int VacancyId { get; set; }
        public string VacancyTitle { get; set; }
    }
}