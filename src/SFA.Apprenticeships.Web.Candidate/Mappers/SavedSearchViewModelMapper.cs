﻿namespace SFA.Apprenticeships.Web.Candidate.Mappers
{
    using Domain.Entities.Candidates;
    using ViewModels.Account;

    public static class SavedSearchViewModelMapper
    {
        public static SavedSearchViewModel ToViewModel(this SavedSearch savedSearch, int subCategoriesFullNamesLimit)
        {
            var viewModel = new SavedSearchViewModel
            {
                Id = savedSearch.EntityId,
                Name = savedSearch.Name(),
                SearchUrl = savedSearch.SearchUrl(),
                AlertsEnabled = savedSearch.AlertsEnabled,
                ApprenticeshipLevel = savedSearch.ApprenticeshipLevel,
                SubCategoriesFullNames = savedSearch.TruncatedSubCategoriesFullNames(subCategoriesFullNamesLimit),
                DateCreated = savedSearch.DateCreated,
                DateProcessed = savedSearch.DateProcessed
            };

            return viewModel;
        }
    }
}