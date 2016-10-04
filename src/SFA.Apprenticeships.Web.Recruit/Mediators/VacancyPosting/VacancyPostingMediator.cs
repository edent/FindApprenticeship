﻿namespace SFA.Apprenticeships.Web.Recruit.Mediators.VacancyPosting
{
    using System;
    using System.Collections.Generic;
    using Raa.Common.Validators.Vacancy;
    using System.Linq;
    using Apprenticeships.Application.Interfaces.Locations;
    using FluentValidation;
    using Common.Constants;
    using Common.Mediators;
    using Common.Validators;
    using Common.Validators.Extensions;
    using Common.ViewModels;
    using Constants.Messages;
    using Domain.Entities.Exceptions;
    using Domain.Entities.Raa.Vacancies;
    using Raa.Common.Constants.ViewModels;
    using Infrastructure.Presentation;
    using Raa.Common.Validators.Provider;
    using Raa.Common.ViewModels.Provider;
    using Raa.Common.ViewModels.Vacancy;
    using Raa.Common.Converters;
    using Raa.Common.ViewModels.VacancyPosting;
    using Raa.Common.Providers;
    using Raa.Common.Validators.VacancyPosting;

    public class VacancyPostingMediator : MediatorBase, IVacancyPostingMediator
    {
        private readonly IVacancyPostingProvider _vacancyPostingProvider;
        private readonly IProviderProvider _providerProvider;
        private readonly IEmployerProvider _employerProvider;
        private readonly ILocationsProvider _locationsProvider;
        private readonly IGeoCodingProvider _geoCodingProvider;
        private readonly NewVacancyViewModelServerValidator _newVacancyViewModelServerValidator;
        private readonly NewVacancyViewModelClientValidator _newVacancyViewModelClientValidator;
        private readonly VacancySummaryViewModelServerValidator _vacancySummaryViewModelServerValidator;
        private readonly VacancySummaryViewModelClientValidator _vacancySummaryViewModelClientValidator;
        private readonly VacancyRequirementsProspectsViewModelServerValidator _vacancyRequirementsProspectsViewModelServerValidator;
        private readonly VacancyRequirementsProspectsViewModelClientValidator _vacancyRequirementsProspectsViewModelClientValidator;
        private readonly VacancyQuestionsViewModelServerValidator _vacancyQuestionsViewModelServerValidator;
        private readonly VacancyQuestionsViewModelClientValidator _vacancyQuestionsViewModelClientValidator;
        private readonly VacancyViewModelValidator _vacancyViewModelValidator;
        private readonly VacancyPartyViewModelValidator _vacancyPartyViewModelValidator;
        private readonly EmployerSearchViewModelServerValidator _employerSearchViewModelServerValidator;
        private readonly LocationSearchViewModelServerValidator _locationSearchViewModelServerValidator;
        private readonly TrainingDetailsViewModelServerValidator _trainingDetailsViewModelServerValidator;
        private readonly TrainingDetailsViewModelClientValidator _trainingDetailsViewModelClientValidator;

        public VacancyPostingMediator(
            IVacancyPostingProvider vacancyPostingProvider,
            IProviderProvider providerProvider,
            IEmployerProvider employerProvider,
            IGeoCodingProvider geoCodingProvider,
            NewVacancyViewModelServerValidator newVacancyViewModelServerValidator,
            NewVacancyViewModelClientValidator newVacancyViewModelClientValidator,
            VacancySummaryViewModelServerValidator vacancySummaryViewModelServerValidator,
            VacancySummaryViewModelClientValidator vacancySummaryViewModelClientValidator,
            VacancyRequirementsProspectsViewModelServerValidator vacancyRequirementsProspectsViewModelServerValidator,
            VacancyRequirementsProspectsViewModelClientValidator vacancyRequirementsProspectsViewModelClientValidator,
            VacancyQuestionsViewModelServerValidator vacancyQuestionsViewModelServerValidator,
            VacancyQuestionsViewModelClientValidator vacancyQuestionsViewModelClientValidator,
            VacancyViewModelValidator vacancyViewModelValidator,
            VacancyPartyViewModelValidator vacancyPartyViewModelValidator, 
            EmployerSearchViewModelServerValidator employerSearchViewModelServerValidator, 
            LocationSearchViewModelServerValidator locationSearchViewModelServerValidator, 
            ILocationsProvider locationsProvider, 
            TrainingDetailsViewModelServerValidator trainingDetailsViewModelServerValidator, 
            TrainingDetailsViewModelClientValidator trainingDetailsViewModelClientValidator)
        {
            _vacancyPostingProvider = vacancyPostingProvider;
            _providerProvider = providerProvider;
            _employerProvider = employerProvider;
            _geoCodingProvider = geoCodingProvider;
            _newVacancyViewModelServerValidator = newVacancyViewModelServerValidator;
            _newVacancyViewModelClientValidator = newVacancyViewModelClientValidator;
            _vacancyPartyViewModelValidator = vacancyPartyViewModelValidator;
            _employerSearchViewModelServerValidator = employerSearchViewModelServerValidator;
            _locationSearchViewModelServerValidator = locationSearchViewModelServerValidator;
            _locationsProvider = locationsProvider;
            _trainingDetailsViewModelServerValidator = trainingDetailsViewModelServerValidator;
            _trainingDetailsViewModelClientValidator = trainingDetailsViewModelClientValidator;
            _vacancySummaryViewModelServerValidator = vacancySummaryViewModelServerValidator;
            _vacancySummaryViewModelClientValidator = vacancySummaryViewModelClientValidator;
            _vacancyRequirementsProspectsViewModelServerValidator = vacancyRequirementsProspectsViewModelServerValidator;
            _vacancyRequirementsProspectsViewModelClientValidator = vacancyRequirementsProspectsViewModelClientValidator;
            _vacancyQuestionsViewModelServerValidator = vacancyQuestionsViewModelServerValidator;
            _vacancyQuestionsViewModelClientValidator = vacancyQuestionsViewModelClientValidator;
            _vacancyViewModelValidator = vacancyViewModelValidator;
        }

        public MediatorResponse<EmployerSearchViewModel> GetProviderEmployers(int providerSiteId, Guid? vacancyGuid, bool? comeFromPreview)
        {
            var viewModel = _providerProvider.GetVacancyPartyViewModels(providerSiteId);
            viewModel.ComeFromPreview = comeFromPreview ?? false;

            var validationResult = _employerSearchViewModelServerValidator.Validate(viewModel);

            if (!validationResult.IsValid)
            {
                return GetMediatorResponse(VacancyPostingMediatorCodes.GetProviderEmployers.FailedValidation, viewModel, validationResult);
            }

            viewModel.VacancyGuid = vacancyGuid;

            if ((viewModel.EmployerResults == null || !viewModel.EmployerResults.Any()) && (viewModel.EmployerResultsPage == null || viewModel.EmployerResultsPage.ResultsCount == 0))
            {
                return GetMediatorResponse(VacancyPostingMediatorCodes.GetProviderEmployers.NoResults, viewModel);
            }
            
            return GetMediatorResponse(VacancyPostingMediatorCodes.GetProviderEmployers.Ok, viewModel);
        }

        public MediatorResponse<EmployerSearchViewModel> GetProviderEmployers(EmployerSearchViewModel employerFilterViewModel)
        {
            var validationResult = _employerSearchViewModelServerValidator.Validate(employerFilterViewModel);

            if (!validationResult.IsValid)
            {
                return GetMediatorResponse(VacancyPostingMediatorCodes.GetProviderEmployers.FailedValidation, employerFilterViewModel, validationResult);
            }

            //TODO: pull this into the view and use hidden form inputs
            //OR: just use a model that caters for it.
            if (!string.IsNullOrWhiteSpace(employerFilterViewModel.EdsUrn))
            {
                employerFilterViewModel.FilterType = EmployerFilterType.EdsUrn;
            }
            else if (!string.IsNullOrWhiteSpace(employerFilterViewModel.Location) && !string.IsNullOrWhiteSpace(employerFilterViewModel.Name))
            {
                employerFilterViewModel.FilterType = EmployerFilterType.NameAndLocation;
            }
            else if (!string.IsNullOrWhiteSpace(employerFilterViewModel.Location) || !string.IsNullOrWhiteSpace(employerFilterViewModel.Name))
            {
                employerFilterViewModel.FilterType = EmployerFilterType.NameOrLocation;
            }
            else
            {
                employerFilterViewModel.FilterType = EmployerFilterType.Undefined;
            }

            var viewModel = _providerProvider.GetVacancyPartyViewModels(employerFilterViewModel);

            if ((viewModel.EmployerResults == null || !viewModel.EmployerResults.Any()) && (viewModel.EmployerResultsPage == null || viewModel.EmployerResultsPage.ResultsCount == 0))
            {
                return GetMediatorResponse(VacancyPostingMediatorCodes.GetProviderEmployers.NoResults, viewModel);
            }

            return GetMediatorResponse(VacancyPostingMediatorCodes.GetProviderEmployers.Ok, viewModel);
        }

        public MediatorResponse<EmployerSearchViewModel> GetEmployers(EmployerSearchViewModel employerFilterViewModel)
        {
            var viewModel = _employerProvider.GetEmployerViewModels(employerFilterViewModel);
            return GetMediatorResponse(VacancyPostingMediatorCodes.GetProviderEmployers.Ok, viewModel);
        }

        public MediatorResponse<VacancyPartyViewModel> GetEmployer(int providerSiteId, string edsUrn, Guid vacancyGuid, bool? comeFromPreview, bool? useEmployerLocation)
        {
            var viewModel = _providerProvider.GetVacancyPartyViewModel(providerSiteId, edsUrn);
            viewModel.VacancyGuid = vacancyGuid;
            viewModel.ComeFromPreview = comeFromPreview ?? false;

            var existingVacancy = _vacancyPostingProvider.GetVacancy(vacancyGuid);

            if (existingVacancy != null)
            {
                viewModel.IsEmployerLocationMainApprenticeshipLocation =
                    existingVacancy.NewVacancyViewModel.IsEmployerLocationMainApprenticeshipLocation;
                viewModel.NumberOfPositions = existingVacancy.NewVacancyViewModel.NumberOfPositions;
                viewModel.Status = existingVacancy.Status;
                viewModel.VacancyReferenceNumber = existingVacancy.VacancyReferenceNumber;
                viewModel.EmployerDescriptionComment = existingVacancy.NewVacancyViewModel.EmployerDescriptionComment;
                viewModel.EmployerWebsiteUrlComment = existingVacancy.NewVacancyViewModel.EmployerWebsiteUrlComment;
                viewModel.NumberOfPositionsComment = existingVacancy.NewVacancyViewModel.NumberOfPositionsComment;
            }

            if (useEmployerLocation.HasValue && useEmployerLocation.Value)
            {
                viewModel.IsEmployerLocationMainApprenticeshipLocation = true;
            }

            try
            {
                if (_geoCodingProvider.EmployerHasAValidAddress(viewModel.Employer.EmployerId) ==
                    GeoCodeAddressResult.InvalidAddress)
                {
                    viewModel.IsEmployerAddressValid = false;
                    viewModel.IsEmployerLocationMainApprenticeshipLocation = false;

                    return GetMediatorResponse(VacancyPostingMediatorCodes.GetEmployer.InvalidEmployerAddress,
                        viewModel, VacancyPartyViewModelMessages.InvalidEmployerAddress.ErrorText, UserMessageLevel.Info);
                }
            }
            catch (CustomException ex) when (ex.Code == ErrorCodes.GeoCodeLookupProviderFailed)
            {
                return GetMediatorResponse(VacancyPostingMediatorCodes.GetEmployer.FailedGeoCodeLookup, viewModel,
                    ApplicationPageMessages.PostcodeLookupFailed, UserMessageLevel.Error);
            }

            return GetMediatorResponse(VacancyPostingMediatorCodes.GetEmployer.Ok, viewModel);
        }

        public MediatorResponse<VacancyPartyViewModel> ConfirmEmployer(VacancyPartyViewModel viewModel, string ukprn)
        {
            var validationResult = _vacancyPartyViewModelValidator.Validate(viewModel);

            if (!validationResult.IsValid)
            {
                var existingViewModel = PatchVacancyPartyViewModelWithErrors(viewModel);

                return GetMediatorResponse(VacancyPostingMediatorCodes.ConfirmEmployer.FailedValidation, existingViewModel, validationResult);
            }

            var vacancyPreviousState = _vacancyPostingProvider.GetVacancy(viewModel.VacancyReferenceNumber);
            var newViewModel = _providerProvider.ConfirmVacancyParty(viewModel);
            var existingVacancy = _vacancyPostingProvider.GetVacancy(viewModel.VacancyReferenceNumber);

            if (existingVacancy != null)
            {
                UpdateVacancy(viewModel, ukprn, existingVacancy, vacancyPreviousState);
            }
            else
            {
                viewModel.VacancyPartyId = newViewModel.VacancyPartyId;

                try
                {
                    CreateNewVacancy(viewModel, ukprn);
                }
                catch (CustomException ce) when (ce.Code == ErrorCodes.GeoCodeLookupProviderFailed)
                {
                    PatchVacancyPartyViewModelWithoutErrors(viewModel, newViewModel);
                    return
                        GetMediatorResponse(
                            VacancyPostingMediatorCodes.ConfirmEmployer.FailedGeoCodeLookup, newViewModel, ApplicationPageMessages.PostcodeLookupFailed, UserMessageLevel.Error);
                }
            }

            PatchVacancyPartyViewModelWithoutErrors(viewModel, newViewModel);

            return GetMediatorResponse(VacancyPostingMediatorCodes.ConfirmEmployer.Ok, newViewModel);
        }

        private VacancyPartyViewModel PatchVacancyPartyViewModelWithErrors(VacancyPartyViewModel viewModel)
        {
            var existingViewModel = _providerProvider.GetVacancyPartyViewModel(viewModel.ProviderSiteId,
                viewModel.Employer.EdsUrn);
            existingViewModel.EmployerWebsiteUrl = viewModel.EmployerWebsiteUrl;
            existingViewModel.EmployerDescription = viewModel.EmployerDescription;
            existingViewModel.IsEmployerLocationMainApprenticeshipLocation =
                viewModel.IsEmployerLocationMainApprenticeshipLocation;
            existingViewModel.NumberOfPositions = viewModel.NumberOfPositions;
            existingViewModel.VacancyGuid = viewModel.VacancyGuid;
            return existingViewModel;
        }

        private void PatchVacancyPartyViewModelWithoutErrors(VacancyPartyViewModel viewModel,
            VacancyPartyViewModel newViewModel)
        {
            newViewModel.VacancyGuid = viewModel.VacancyGuid;
            newViewModel.IsEmployerLocationMainApprenticeshipLocation = viewModel.IsEmployerLocationMainApprenticeshipLocation;
            newViewModel.NumberOfPositions = viewModel.NumberOfPositions;
            newViewModel.VacancyReferenceNumber = viewModel.VacancyReferenceNumber;
        }

        private void CreateNewVacancy(VacancyPartyViewModel viewModel, string ukprn)
        {
            _vacancyPostingProvider.CreateVacancy(new VacancyMinimumData
            {
                IsEmployerLocationMainApprenticeshipLocation =
                    viewModel.IsEmployerLocationMainApprenticeshipLocation.Value,
                NumberOfPositions = viewModel.NumberOfPositions,
                Ukprn = ukprn,
                VacancyGuid = viewModel.VacancyGuid,
                VacancyPartyId = viewModel.VacancyPartyId,
                EmployerWebsiteUrl = viewModel.EmployerWebsiteUrl,
                EmployerDescription = viewModel.EmployerDescription
            });
        }

        private void UpdateVacancy(VacancyPartyViewModel viewModel, string ukprn, VacancyViewModel existingVacancy,
            VacancyViewModel vacancyPreviousState)
        {
            if (viewModel.IsEmployerLocationMainApprenticeshipLocation.HasValue &&
                viewModel.IsEmployerLocationMainApprenticeshipLocation.Value)
            {
                _vacancyPostingProvider.RemoveLocationAddresses(viewModel.VacancyGuid);

                var vacancyData = new VacancyMinimumData
                {
                    IsEmployerLocationMainApprenticeshipLocation =
                        viewModel.IsEmployerLocationMainApprenticeshipLocation.Value,
                    NumberOfPositions = viewModel.NumberOfPositions,
                    Ukprn = ukprn,
                    VacancyGuid = viewModel.VacancyGuid,
                    VacancyPartyId = existingVacancy.NewVacancyViewModel.OwnerParty.VacancyPartyId,
                    EmployerWebsiteUrl = viewModel.EmployerWebsiteUrl,
                    EmployerDescription = viewModel.EmployerDescription
                };
                _vacancyPostingProvider.UpdateVacancy(vacancyData);
            }

            /*
            var employerHasChanged = vacancyPreviousState != null &&
                                     existingVacancy.NewVacancyViewModel.OwnerParty.Employer.EmployerId !=
                                     vacancyPreviousState.NewVacancyViewModel.OwnerParty.Employer.EmployerId;*/

            var changedFromSameLocationAsEmployerToDifferentLocation =
                vacancyPreviousState != null &&
                viewModel.IsEmployerLocationMainApprenticeshipLocation.HasValue &&
                viewModel.IsEmployerLocationMainApprenticeshipLocation.Value == false &&
                vacancyPreviousState.NewVacancyViewModel.IsEmployerLocationMainApprenticeshipLocation == true;

            if (changedFromSameLocationAsEmployerToDifferentLocation /*|| employerHasChanged*/)
            {
                _vacancyPostingProvider.EmptyVacancyLocation(vacancyPreviousState.VacancyReferenceNumber);
            }
        }

        public MediatorResponse<LocationSearchViewModel> SearchLocations(LocationSearchViewModel viewModel, List<VacancyLocationAddressViewModel> alreadyAddedLocations)
        {
            if (string.IsNullOrWhiteSpace(viewModel.PostcodeSearch))
            {
                AddAlreadyAddedLocations(viewModel, alreadyAddedLocations);

                return GetMediatorResponse(VacancyPostingMediatorCodes.SearchLocations.NotFullPostcode, viewModel);
            }

            try
            {
                viewModel = _locationsProvider.GetAddressesFor(viewModel);

                AddAlreadyAddedLocations(viewModel, alreadyAddedLocations);

                return GetMediatorResponse(VacancyPostingMediatorCodes.SearchLocations.Ok, viewModel);
            }
            catch (CustomException)
            {
                return GetMediatorResponse(VacancyPostingMediatorCodes.SearchLocations.NotFullPostcode, viewModel);
            }
        }

        private void AddAlreadyAddedLocations(LocationSearchViewModel viewModel, List<VacancyLocationAddressViewModel> alreadyAddedLocations)
        {
            var existingVacancy = _vacancyPostingProvider.GetVacancy(viewModel.VacancyGuid);
            viewModel.Addresses = existingVacancy.LocationAddresses;
        }

        public MediatorResponse<LocationSearchViewModel> UseLocation(LocationSearchViewModel viewModel, int locationIndex, string postCodeSearch)
        {
            viewModel.PostcodeSearch = postCodeSearch;
            var searchResult = SearchLocations(viewModel, viewModel.Addresses);

            if (searchResult.ViewModel.SearchResultAddresses != null &&
                searchResult.ViewModel.SearchResultAddresses.Page != null
                && searchResult.ViewModel.SearchResultAddresses.Page.Count() > locationIndex)
            {
                var addressToAdd = searchResult.ViewModel.SearchResultAddresses.Page.ToList()[locationIndex];

                var isNewAddress = viewModel.Addresses.TrueForAll(v => !v.Address.Equals(addressToAdd.Address));
                if (isNewAddress)
                {
                    viewModel.Addresses.Add(addressToAdd);
                }
            }

            viewModel.SearchResultAddresses = new PageableViewModel<VacancyLocationAddressViewModel>();
            viewModel.CurrentPage = 1;
            viewModel.TotalNumberOfPages = 1;
            viewModel.PostcodeSearch = string.Empty;

            return GetMediatorResponse(VacancyPostingMediatorCodes.UseLocation.Ok, viewModel);
        }

        public MediatorResponse<LocationSearchViewModel> RemoveLocation(LocationSearchViewModel viewModel, int locationIndex)
        {
            viewModel.Addresses.RemoveAt(locationIndex);
            viewModel.SearchResultAddresses = new PageableViewModel<VacancyLocationAddressViewModel>();
            viewModel.PostcodeSearch = string.Empty;
            viewModel.CurrentPage = 1;
            viewModel.TotalNumberOfPages = 1;

            return GetMediatorResponse(VacancyPostingMediatorCodes.RemoveLocation.Ok, viewModel);
        }

        public MediatorResponse ClearLocationInformation(Guid vacancyGuid)
        {
            _vacancyPostingProvider.RemoveVacancyLocationInformation(vacancyGuid);
            var result = new MediatorResponse {Code = VacancyPostingMediatorCodes.ClearLocationInformation.Ok};

            return result;
        }

        public MediatorResponse<VacancyPartyViewModel> CloneVacancy(int vacancyReferenceNumber)
        {
            var existingVacancy = _vacancyPostingProvider.GetVacancy(vacancyReferenceNumber);
            if (existingVacancy.Status == VacancyStatus.Referred)
            {
                return GetMediatorResponse<VacancyPartyViewModel>(VacancyPostingMediatorCodes.CloneVacancy.VacancyInIncorrectState);
            }

            var viewModel = _vacancyPostingProvider.CloneVacancy(vacancyReferenceNumber);
            return GetMediatorResponse(VacancyPostingMediatorCodes.CloneVacancy.Ok, viewModel);
        }
        
        public MediatorResponse<NewVacancyViewModel> GetNewVacancyViewModel(int vacancyPartyId, Guid vacancyGuid, int? numberOfPositions)
        {
            var viewModel = _vacancyPostingProvider.GetNewVacancyViewModel(vacancyPartyId, vacancyGuid, numberOfPositions);

            return GetMediatorResponse(VacancyPostingMediatorCodes.GetNewVacancyViewModel.Ok, viewModel);
        }

        public MediatorResponse<NewVacancyViewModel> GetNewVacancyViewModel(int vacancyReferenceNumber, bool validate, bool? comeFromPreview)
        {
            var viewModel = _vacancyPostingProvider.GetNewVacancyViewModel(vacancyReferenceNumber);
            viewModel.ComeFromPreview = comeFromPreview ?? false;

            if (!viewModel.IsEmployerLocationMainApprenticeshipLocation.HasValue ||
                (viewModel.IsEmployerLocationMainApprenticeshipLocation.Value == false &&
                !viewModel.LocationAddresses.Any()))
            {
                return GetMediatorResponse(VacancyPostingMediatorCodes.GetNewVacancyViewModel.LocationNotSet, viewModel);
            }

            if (validate)
            {
                var validationResult = _newVacancyViewModelServerValidator.Validate(viewModel);

                if (!validationResult.IsValid)
                {
                    return GetMediatorResponse(VacancyPostingMediatorCodes.GetNewVacancyViewModel.FailedValidation, viewModel, validationResult);
                }
            }

            return GetMediatorResponse(VacancyPostingMediatorCodes.GetNewVacancyViewModel.Ok, viewModel);
        }

        public MediatorResponse<TrainingDetailsViewModel> SelectFrameworkAsTrainingType(TrainingDetailsViewModel viewModel)
        {
            viewModel.TrainingType = TrainingType.Frameworks;
            viewModel.ApprenticeshipLevel = ApprenticeshipLevel.Unknown;
            viewModel.FrameworkCodeName = null;
            viewModel.SectorCodeName = null;
            viewModel.Standards = _vacancyPostingProvider.GetStandards();
            viewModel.SectorsAndFrameworks = _vacancyPostingProvider.GetSectorsAndFrameworks();
            viewModel.Sectors = _vacancyPostingProvider.GetSectors();

            return GetMediatorResponse(VacancyPostingMediatorCodes.GetTrainingDetailsViewModel.Ok, viewModel);
        }

        public MediatorResponse<TrainingDetailsViewModel> SelectStandardAsTrainingType(TrainingDetailsViewModel viewModel)
        {
            viewModel.TrainingType = TrainingType.Standards;
            viewModel.StandardId = null;
            viewModel.SectorCodeName = null;
            viewModel.ApprenticeshipLevel = ApprenticeshipLevel.Unknown;
            viewModel.Standards = _vacancyPostingProvider.GetStandards();
            viewModel.SectorsAndFrameworks = _vacancyPostingProvider.GetSectorsAndFrameworks();
            viewModel.Sectors = _vacancyPostingProvider.GetSectors();

            return GetMediatorResponse(VacancyPostingMediatorCodes.GetTrainingDetailsViewModel.Ok, viewModel);
        }

        public MediatorResponse<NewVacancyViewModel> CreateVacancy(NewVacancyViewModel newVacancyViewModel, string ukprn)
        {
            var validationResult = _newVacancyViewModelServerValidator.Validate(newVacancyViewModel);

            if (!validationResult.IsValid)
            {
                UpdateReferenceDataFor(newVacancyViewModel);
                UpdateCommentsFor(newVacancyViewModel);

                return GetMediatorResponse(VacancyPostingMediatorCodes.CreateVacancy.FailedValidation, newVacancyViewModel, validationResult);
            }

            var storedVacancy = GetStoredVacancy(newVacancyViewModel);

            newVacancyViewModel.LocationAddresses = storedVacancy?.LocationAddresses;
            
            var createdVacancyViewModel = _vacancyPostingProvider.UpdateVacancy(newVacancyViewModel);

            return SwitchingFromOnlineToOfflineVacancy(newVacancyViewModel, storedVacancy)
                ? GetMediatorResponse(VacancyPostingMediatorCodes.CreateVacancy.OkWithWarning, createdVacancyViewModel,
                    NewVacancyViewModelMessages.OptionalQuestions.WontBeVisible, UserMessageLevel.Info)
                : GetMediatorResponse(VacancyPostingMediatorCodes.CreateVacancy.Ok, createdVacancyViewModel);
        }

        public MediatorResponse<NewVacancyViewModel> CreateVacancyAndExit(NewVacancyViewModel newVacancyViewModel, string ukprn)
        {
            var validationResult = _newVacancyViewModelClientValidator.Validate(newVacancyViewModel);

            if (!validationResult.IsValid)
            {
                UpdateReferenceDataFor(newVacancyViewModel);
                UpdateCommentsFor(newVacancyViewModel);

                return GetMediatorResponse(VacancyPostingMediatorCodes.CreateVacancy.FailedValidation, newVacancyViewModel, validationResult);
            }

            var createdVacancyViewModel = _vacancyPostingProvider.UpdateVacancy(newVacancyViewModel);

            return GetMediatorResponse(VacancyPostingMediatorCodes.CreateVacancy.Ok, createdVacancyViewModel);
        }

        private void UpdateReferenceDataFor(NewVacancyViewModel newVacancyViewModel)
        {
            newVacancyViewModel.OwnerParty =
                _providerProvider.GetVacancyPartyViewModel(
                    newVacancyViewModel.OwnerParty.VacancyPartyId);
        }

        private void UpdateCommentsFor(NewVacancyViewModel newVacancyViewModel)
        {
            var storedVacancy = GetStoredVacancy(newVacancyViewModel);
            if (storedVacancy != null && storedVacancy.NewVacancyViewModel != null)
            {
                newVacancyViewModel.OfflineApplicationInstructionsComment = storedVacancy.NewVacancyViewModel.OfflineApplicationInstructionsComment;
                newVacancyViewModel.OfflineApplicationUrlComment = storedVacancy.NewVacancyViewModel.OfflineApplicationUrlComment;
                newVacancyViewModel.ShortDescriptionComment = storedVacancy.NewVacancyViewModel.ShortDescriptionComment;
                newVacancyViewModel.TitleComment = storedVacancy.NewVacancyViewModel.TitleComment;
            }
        }

        private VacancyViewModel GetStoredVacancy(NewVacancyViewModel newVacancyViewModel)
        {
            return GetStoredVacancy(newVacancyViewModel.VacancyReferenceNumber);
        }

        private VacancyViewModel GetStoredVacancy(int? vacancyReferenceNumber)
        {
            VacancyViewModel storedVacancy = null;

            if (vacancyReferenceNumber.HasValue)
            {
                storedVacancy = _vacancyPostingProvider.GetVacancy(vacancyReferenceNumber.Value);
            }

            return storedVacancy;
        }

        private static bool SwitchingFromOnlineToOfflineVacancy(NewVacancyViewModel newVacancyViewModel, VacancyViewModel existingVacancy)
        {
            return existingVacancy != null 
                && existingVacancy.NewVacancyViewModel.OfflineVacancy == false
                && newVacancyViewModel.OfflineVacancy.HasValue
                && newVacancyViewModel.OfflineVacancy.Value
                && ( !string.IsNullOrWhiteSpace(existingVacancy.VacancyQuestionsViewModel.FirstQuestion) || !string.IsNullOrWhiteSpace(existingVacancy.VacancyQuestionsViewModel.SecondQuestion));
        }

        public MediatorResponse<TrainingDetailsViewModel> GetTrainingDetailsViewModel(int vacancyReferenceNumber, bool validate, bool? comeFromPreview)
        {
            var viewModel = _vacancyPostingProvider.GetTrainingDetailsViewModel(vacancyReferenceNumber);
            viewModel.ComeFromPreview = comeFromPreview ?? false;

            if (validate)
            {
                var validationResult = _trainingDetailsViewModelServerValidator.Validate(viewModel);

                if (!validationResult.IsValid)
                {
                    return GetMediatorResponse(VacancyPostingMediatorCodes.GetTrainingDetailsViewModel.FailedValidation, viewModel, validationResult);
                }
            }

            return GetMediatorResponse(VacancyPostingMediatorCodes.GetTrainingDetailsViewModel.Ok, viewModel);
        }

        private VacancyViewModel GetStoredVacancy(TrainingDetailsViewModel trainingDetailsViewModel)
        {
            return GetStoredVacancy(trainingDetailsViewModel.VacancyReferenceNumber);
        }

        public MediatorResponse<TrainingDetailsViewModel> UpdateVacancy(TrainingDetailsViewModel viewModel)
        {
            var validationResult = _trainingDetailsViewModelServerValidator.Validate(viewModel);

            if (!validationResult.IsValid)
            {
                UpdateReferenceDataFor(viewModel);
                return GetMediatorResponse(VacancyPostingMediatorCodes.UpdateVacancy.FailedValidation, viewModel, validationResult);
            }

            var updatedViewModel = _vacancyPostingProvider.UpdateVacancy(viewModel);

            return GetMediatorResponse(VacancyPostingMediatorCodes.UpdateVacancy.Ok, updatedViewModel);
        }

        public MediatorResponse<TrainingDetailsViewModel> UpdateVacancyAndExit(TrainingDetailsViewModel viewModel)
        {
            var validationResult = _trainingDetailsViewModelClientValidator.Validate(viewModel);

            if (!validationResult.IsValid)
            {
                UpdateReferenceDataFor(viewModel);
                return GetMediatorResponse(VacancyPostingMediatorCodes.UpdateVacancy.FailedValidation, viewModel, validationResult);
            }

            var updatedViewModel = _vacancyPostingProvider.UpdateVacancy(viewModel);

            return GetMediatorResponse(VacancyPostingMediatorCodes.UpdateVacancy.Ok, updatedViewModel);
        }

        private void UpdateReferenceDataFor(TrainingDetailsViewModel trainingDetailsViewModel)
        {
            trainingDetailsViewModel.SectorsAndFrameworks = _vacancyPostingProvider.GetSectorsAndFrameworks();
            trainingDetailsViewModel.Standards = _vacancyPostingProvider.GetStandards();
            trainingDetailsViewModel.Sectors = _vacancyPostingProvider.GetSectors();
            if (trainingDetailsViewModel.TrainingType == TrainingType.Standards && trainingDetailsViewModel.StandardId.HasValue)
            {
                var standard = _vacancyPostingProvider.GetStandard(trainingDetailsViewModel.StandardId);
                trainingDetailsViewModel.ApprenticeshipLevel = standard?.ApprenticeshipLevel ?? ApprenticeshipLevel.Unknown;
            }
        }

        private void UpdateCommentsFor(TrainingDetailsViewModel trainingDetailsViewModel)
        {
            var storedVacancy = GetStoredVacancy(trainingDetailsViewModel);
            trainingDetailsViewModel.ApprenticeshipLevelComment = storedVacancy.TrainingDetailsViewModel.ApprenticeshipLevelComment;
            trainingDetailsViewModel.FrameworkCodeNameComment = storedVacancy.TrainingDetailsViewModel.FrameworkCodeNameComment;
            trainingDetailsViewModel.StandardIdComment = storedVacancy.TrainingDetailsViewModel.StandardIdComment;
            trainingDetailsViewModel.SectorCodeNameComment = storedVacancy.TrainingDetailsViewModel.SectorCodeNameComment;
        }

        public MediatorResponse<FurtherVacancyDetailsViewModel> GetVacancySummaryViewModel(int vacancyReferenceNumber, bool validate, bool? comeFromPreview)
        {
            var vacancyViewModel = _vacancyPostingProvider.GetVacancySummaryViewModel(vacancyReferenceNumber);
            vacancyViewModel.ComeFromPreview = comeFromPreview ?? false;

            if (validate)
            {
                var validationResult = _vacancySummaryViewModelServerValidator.Validate(vacancyViewModel, ruleSet: RuleSets.ErrorsAndWarnings);

                if (!validationResult.IsValid)
                {
                    vacancyViewModel.WarningsHash = validationResult.GetWarningsHash();

                    if (
                    validationResult.Errors.Any(
                        e =>
                            e.PropertyName.EndsWith(
                                VacancySummaryViewModelBusinessRulesExtensions.HaveAValidHourRatePropertyName)))
                    {
                        return GetMediatorResponse(VacancyPostingMediatorCodes.ManageDates.FailedCrossFieldValidation,
                            vacancyViewModel, validationResult, VacancyViewModelMessages.FailedCrossFieldValidation, UserMessageLevel.Warning);
                    }

                    return GetMediatorResponse(VacancyPostingMediatorCodes.GetVacancySummaryViewModel.FailedValidation, vacancyViewModel, validationResult);
                }
            }

            return GetMediatorResponse(VacancyPostingMediatorCodes.GetVacancySummaryViewModel.Ok, vacancyViewModel);
        }

        public MediatorResponse<FurtherVacancyDetailsViewModel> UpdateVacancy(FurtherVacancyDetailsViewModel viewModel, bool acceptWarnings)
        {
            var validationResult = _vacancySummaryViewModelServerValidator.Validate(viewModel, ruleSet: RuleSets.ErrorsAndWarnings);

            var warningsAccepted = validationResult.HasWarningsOnly() && validationResult.IsWarningsHashMatch(viewModel.WarningsHash) && acceptWarnings;

            if (!validationResult.IsValid && !warningsAccepted)
            {
                viewModel.WageUnits = ApprenticeshipVacancyConverter.GetWageUnits();
                viewModel.DurationTypes = ApprenticeshipVacancyConverter.GetDurationTypes(viewModel.VacancyType);
                viewModel.WarningsHash = validationResult.GetWarningsHash();

                return GetMediatorResponse(VacancyPostingMediatorCodes.UpdateVacancy.FailedValidation, viewModel, validationResult);
            }

            var updatedViewModel = _vacancyPostingProvider.UpdateVacancy(viewModel);

            return GetMediatorResponse(VacancyPostingMediatorCodes.UpdateVacancy.Ok, updatedViewModel);
        }

        public MediatorResponse<FurtherVacancyDetailsViewModel> UpdateVacancyDates(FurtherVacancyDetailsViewModel viewModel, bool acceptWarnings)
        {
            viewModel = MergeVacancyDates(viewModel);

            var validationResult = _vacancySummaryViewModelServerValidator.Validate(viewModel, ruleSet: RuleSets.ErrorsAndWarnings);

            var warningsAccepted = validationResult.HasWarningsOnly() && validationResult.IsWarningsHashMatch(viewModel.WarningsHash) && acceptWarnings;

            if (!validationResult.IsValid && !warningsAccepted)
            {
                viewModel.WarningsHash = validationResult.GetWarningsHash();

                if (
                    validationResult.Errors.Any(
                        e =>
                            e.PropertyName.EndsWith(
                                VacancySummaryViewModelBusinessRulesExtensions.HaveAValidHourRatePropertyName)))
                {
                    return GetMediatorResponse(VacancyPostingMediatorCodes.ManageDates.FailedCrossFieldValidation,
                        viewModel, validationResult, VacancyViewModelMessages.FailedCrossFieldValidation, UserMessageLevel.Warning);
                }

                return GetMediatorResponse(VacancyPostingMediatorCodes.ManageDates.FailedValidation, viewModel,
                    validationResult);
            }

            var result = _vacancyPostingProvider.UpdateVacancyDates(viewModel);
            switch (result.VacancyApplicationsState)
            {
                case VacancyApplicationsState.HasApplications:
                    return GetMediatorResponse(VacancyPostingMediatorCodes.ManageDates.UpdatedHasApplications, viewModel);
                case VacancyApplicationsState.NoApplications:
                    return GetMediatorResponse(VacancyPostingMediatorCodes.ManageDates.UpdatedNoApplications, viewModel);
                case VacancyApplicationsState.Invalid:
                    return GetMediatorResponse(VacancyPostingMediatorCodes.ManageDates.InvalidState, viewModel);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private FurtherVacancyDetailsViewModel MergeVacancyDates(FurtherVacancyDetailsViewModel viewModel)
        {
            var existingViewModel = _vacancyPostingProvider.GetVacancySummaryViewModel(viewModel.VacancyReferenceNumber);
            if (existingViewModel != null)
            {
                existingViewModel.WarningsHash = viewModel.WarningsHash;
                existingViewModel.VacancyDatesViewModel.ClosingDate = viewModel.VacancyDatesViewModel.ClosingDate;
                existingViewModel.VacancyDatesViewModel.PossibleStartDate = viewModel.VacancyDatesViewModel.PossibleStartDate;
                if (existingViewModel.Wage != null && viewModel.Wage != null)
                {
                    existingViewModel.Wage.Type = viewModel.Wage.Type;
                    existingViewModel.Wage.Amount = viewModel.Wage.Amount;
                    existingViewModel.Wage.Unit = viewModel.Wage.Unit;
                }

                viewModel = existingViewModel;
            }
            viewModel.ComeFromPreview = true;
            return viewModel;
        }

        public MediatorResponse<LocationSearchViewModel> AddLocations(LocationSearchViewModel viewModel, string ukprn)
        {
            var validationResult = _locationSearchViewModelServerValidator.Validate(viewModel);

            if (!validationResult.IsValid)
            {
                return GetMediatorResponse(VacancyPostingMediatorCodes.CreateVacancy.FailedValidation, viewModel, validationResult);
            }

            try
            {
                var locationSearchViewModel = _vacancyPostingProvider.AddLocations(viewModel);
                return GetMediatorResponse(VacancyPostingMediatorCodes.CreateVacancy.Ok, locationSearchViewModel);
            }
            catch (CustomException ex) when (ex.Code == ErrorCodes.GeoCodeLookupProviderFailed)
            {
                return GetMediatorResponse(VacancyPostingMediatorCodes.CreateVacancy.FailedGeoCodeLookup, viewModel,
                    ApplicationPageMessages.PostcodeLookupFailed, UserMessageLevel.Error);
            }
        }

        public MediatorResponse<LocationSearchViewModel> GetLocationAddressesViewModel(int providerSiteId,
            int employerId, string ukprn, Guid vacancyGuid, bool? comeFromPreview)
        {
            var locationSearchViewModel = _vacancyPostingProvider.LocationAddressesViewModel(ukprn, providerSiteId,
                employerId, vacancyGuid);
            locationSearchViewModel.CurrentPage = 1;
            locationSearchViewModel.ComeFromPreview = comeFromPreview ?? false;

            return GetMediatorResponse(VacancyPostingMediatorCodes.GetLocationAddressesViewModel.Ok,
                locationSearchViewModel);
        }

        public MediatorResponse<FurtherVacancyDetailsViewModel> UpdateVacancyAndExit(FurtherVacancyDetailsViewModel viewModel)
        {
            var validationResult = _vacancySummaryViewModelClientValidator.Validate(viewModel);

            if (!validationResult.IsValid)
            {
                viewModel.WageUnits = ApprenticeshipVacancyConverter.GetWageUnits();
                viewModel.DurationTypes = ApprenticeshipVacancyConverter.GetDurationTypes(viewModel.VacancyType);
                return GetMediatorResponse(VacancyPostingMediatorCodes.UpdateVacancy.FailedValidation, viewModel, validationResult);
            }

            var updatedViewModel = _vacancyPostingProvider.UpdateVacancy(viewModel);

            return GetMediatorResponse(VacancyPostingMediatorCodes.UpdateVacancy.Ok, updatedViewModel);
        }

        public MediatorResponse<VacancyRequirementsProspectsViewModel> GetVacancyRequirementsProspectsViewModel(
            int vacancyReferenceNumber, bool validate, bool? comeFromPreview)
        {
            var vacancyViewModel =
                _vacancyPostingProvider.GetVacancyRequirementsProspectsViewModel(vacancyReferenceNumber);
            vacancyViewModel.ComeFromPreview = comeFromPreview ?? false;

            if (validate)
            {
                var validationResult = _vacancyRequirementsProspectsViewModelServerValidator.Validate(vacancyViewModel);

                if (!validationResult.IsValid)
                {
                    return
                        GetMediatorResponse(
                            VacancyPostingMediatorCodes.GetVacancyRequirementsProspectsViewModel.FailedValidation,
                            vacancyViewModel, validationResult);
                }
            }

            return GetMediatorResponse(VacancyPostingMediatorCodes.GetVacancyRequirementsProspectsViewModel.Ok,
                vacancyViewModel);
        }

        public MediatorResponse<VacancyRequirementsProspectsViewModel> UpdateVacancy(VacancyRequirementsProspectsViewModel viewModel)
        {
            var validationResult = _vacancyRequirementsProspectsViewModelServerValidator.Validate(viewModel);

            if (!validationResult.IsValid)
            {
                return GetMediatorResponse(VacancyPostingMediatorCodes.UpdateVacancy.FailedValidation, viewModel, validationResult);
            }

            var updatedViewModel = _vacancyPostingProvider.UpdateVacancy(viewModel);

            var completeViewModel = GetVacancyViewModel(viewModel.VacancyReferenceNumber);
            updatedViewModel.ComeFromPreview = viewModel.ComeFromPreview;

            return
                GetMediatorResponse(
                    completeViewModel.ViewModel.NewVacancyViewModel.OfflineVacancy.HasValue &&
                    completeViewModel.ViewModel.NewVacancyViewModel.OfflineVacancy.Value
                        ? VacancyPostingMediatorCodes.UpdateVacancy.OfflineVacancyOk
                        : VacancyPostingMediatorCodes.UpdateVacancy.OnlineVacancyOk, updatedViewModel);
        }

        public MediatorResponse<VacancyRequirementsProspectsViewModel> UpdateVacancyAndExit(VacancyRequirementsProspectsViewModel viewModel)
        {
            var validationResult = _vacancyRequirementsProspectsViewModelClientValidator.Validate(viewModel);

            if (!validationResult.IsValid)
            {
                return GetMediatorResponse(VacancyPostingMediatorCodes.UpdateVacancy.FailedValidation, viewModel, validationResult);
            }

            var updatedViewModel = _vacancyPostingProvider.UpdateVacancy(viewModel);

            return GetMediatorResponse(VacancyPostingMediatorCodes.UpdateVacancy.OkAndExit, updatedViewModel);
        }

        public MediatorResponse<VacancyQuestionsViewModel> GetVacancyQuestionsViewModel(int vacancyReferenceNumber, bool validate, bool? comeFromPreview)
        {
            var vacancyViewModel = _vacancyPostingProvider.GetVacancyQuestionsViewModel(vacancyReferenceNumber);
            vacancyViewModel.ComeFromPreview = comeFromPreview ?? false;
            if (validate)
            {
                var validationResult = _vacancyQuestionsViewModelServerValidator.Validate(vacancyViewModel);

                if (!validationResult.IsValid)
                {
                    return GetMediatorResponse(VacancyPostingMediatorCodes.GetVacancyQuestionsViewModel.FailedValidation, vacancyViewModel, validationResult);
                }
            }

            return GetMediatorResponse(VacancyPostingMediatorCodes.GetVacancyQuestionsViewModel.Ok, vacancyViewModel);
        }

        public MediatorResponse<VacancyQuestionsViewModel> UpdateVacancy(VacancyQuestionsViewModel viewModel)
        {
            var validationResult = _vacancyQuestionsViewModelServerValidator.Validate(viewModel);

            if (!validationResult.IsValid)
            {
                return GetMediatorResponse(VacancyPostingMediatorCodes.UpdateVacancy.FailedValidation, viewModel, validationResult);
            }

            var updatedViewModel = _vacancyPostingProvider.UpdateVacancy(viewModel);

            return GetMediatorResponse(VacancyPostingMediatorCodes.UpdateVacancy.Ok, updatedViewModel);
        }

        public MediatorResponse<VacancyQuestionsViewModel> UpdateVacancyAndExit(VacancyQuestionsViewModel viewModel)
        {
            var validationResult = _vacancyQuestionsViewModelClientValidator.Validate(viewModel);

            if (!validationResult.IsValid)
            {
                return GetMediatorResponse(VacancyPostingMediatorCodes.UpdateVacancy.FailedValidation, viewModel, validationResult);
            }

            var updatedViewModel = _vacancyPostingProvider.UpdateVacancy(viewModel);

            return GetMediatorResponse(VacancyPostingMediatorCodes.UpdateVacancy.Ok, updatedViewModel);
        }

        private MediatorResponse<VacancyViewModel> GetVacancyViewModel(int vacancyReferenceNumber)
        {
            var vacancyViewModel = _vacancyPostingProvider.GetVacancy(vacancyReferenceNumber);

            return GetMediatorResponse(VacancyPostingMediatorCodes.GetVacancyViewModel.Ok, vacancyViewModel);
        }

        public MediatorResponse<VacancyViewModel> GetPreviewVacancyViewModel(int vacancyReferenceNumber)
        {
            var vacancyViewModel = _vacancyPostingProvider.GetVacancy(vacancyReferenceNumber);
            vacancyViewModel.IsEditable = vacancyViewModel.Status.IsStateEditable();

            var messages = new List<string>();
            if (vacancyViewModel.Status == VacancyStatus.Completed)
            {
                messages.Add(VacancyViewModelMessages.VacancyHasBeenArchived);
            }

            if (vacancyViewModel.Status.CanHaveApplicationsOrClickThroughs())
            {
                if (vacancyViewModel.NewVacancyViewModel.OfflineVacancy == true)
                {
                    if (vacancyViewModel.OfflineApplicationClickThroughCount == 0)
                    {
                        messages.Add(VacancyViewModelMessages.NoClickThroughs);
                        return GetMediatorResponse(VacancyPostingMediatorCodes.GetPreviewVacancyViewModel.Ok, vacancyViewModel, messages, UserMessageLevel.Info);
                    }
                }
                else if (vacancyViewModel.ApplicationCount == 0)
                {
                    messages.Add(VacancyViewModelMessages.NoApplications);
                    return GetMediatorResponse(VacancyPostingMediatorCodes.GetPreviewVacancyViewModel.Ok, vacancyViewModel, messages, UserMessageLevel.Info);
                }
            }
            else if(vacancyViewModel.Status.IsStateEditable())
            {
                var validationResult = _vacancyViewModelValidator.Validate(vacancyViewModel, ruleSet: RuleSets.ErrorsAndWarnings);

                if (!validationResult.IsValid)
                {
                    return GetMediatorResponse(VacancyPostingMediatorCodes.GetPreviewVacancyViewModel.FailedValidation, vacancyViewModel, validationResult);
                }
            }

            return messages.Any()
                ? GetMediatorResponse(VacancyPostingMediatorCodes.GetPreviewVacancyViewModel.Ok, vacancyViewModel,
                    messages, UserMessageLevel.Info)
                : GetMediatorResponse(VacancyPostingMediatorCodes.GetPreviewVacancyViewModel.Ok, vacancyViewModel);
        }

        public MediatorResponse<VacancyViewModel> SubmitVacancy(int vacancyReferenceNumber, bool resubmitOptin)
        {
            var viewModelToValidate = _vacancyPostingProvider.GetVacancy(vacancyReferenceNumber);
            viewModelToValidate.ResubmitOption = resubmitOptin;
            
            var resubmission = viewModelToValidate.Status == VacancyStatus.Referred;

            var validationResult = _vacancyViewModelValidator.Validate(viewModelToValidate, ruleSet: RuleSets.ErrorsAndResubmission);

            if (!validationResult.IsValid)
            {
                return GetMediatorResponse(VacancyPostingMediatorCodes.SubmitVacancy.FailedValidation, viewModelToValidate, validationResult);
            }

            var vacancyViewModel = _vacancyPostingProvider.SubmitVacancy(vacancyReferenceNumber);
            vacancyViewModel.IsEditable = vacancyViewModel.Status.IsStateEditable();

            if (resubmission)
            {
                return GetMediatorResponse(VacancyPostingMediatorCodes.SubmitVacancy.ResubmitOk, vacancyViewModel);
            }

            return GetMediatorResponse(VacancyPostingMediatorCodes.SubmitVacancy.SubmitOk, vacancyViewModel);
        }

        public MediatorResponse<SubmittedVacancyViewModel> GetSubmittedVacancyViewModel(int vacancyReferenceNumber, bool resubmitted)
        {
            var vacancyViewModel = _vacancyPostingProvider.GetVacancy(vacancyReferenceNumber);

            var viewModel = new SubmittedVacancyViewModel
            {
                VacancyReferenceNumber = vacancyViewModel.VacancyReferenceNumber, ProviderSiteId = vacancyViewModel.NewVacancyViewModel.OwnerParty.ProviderSiteId,
                Resubmitted = resubmitted,
                IsMultiLocationVacancy = vacancyViewModel.IsUnapprovedMultiLocationParentVacancy,
                VacancyType = vacancyViewModel.VacancyType
            };

            if (vacancyViewModel.VacancyType == VacancyType.Traineeship)
            {
                viewModel.VacancyText = vacancyViewModel.IsUnapprovedMultiLocationParentVacancy ? "Multi location traineeship opportunity" : "Traineeship opportunity";
            }
            else
            {
                viewModel.VacancyText = vacancyViewModel.IsUnapprovedMultiLocationParentVacancy ? "Multi location vacancy" : "Vacancy";
            }

            return GetMediatorResponse(VacancyPostingMediatorCodes.GetSubmittedVacancyViewModel.Ok, viewModel);
        }

        public MediatorResponse<EmployerSearchViewModel> SelectNewEmployer(EmployerSearchViewModel viewModel)
        {
            EmployerSearchViewModel result = viewModel;

            if (viewModel.FilterType == EmployerFilterType.Undefined)
            {
                result = new EmployerSearchViewModel
                {
                    ProviderSiteId = viewModel.ProviderSiteId, FilterType = EmployerFilterType.Undefined, EmployerResults = Enumerable.Empty<EmployerResultViewModel>(), EmployerResultsPage = new PageableViewModel<EmployerResultViewModel>(), VacancyGuid = viewModel.VacancyGuid, ComeFromPreview = viewModel.ComeFromPreview
                };
            }
            else
            {
                result.EmployerResultsPage = result.EmployerResultsPage ?? new PageableViewModel<EmployerResultViewModel>();

                var validationResult = _employerSearchViewModelServerValidator.Validate(result);

                if (!validationResult.IsValid)
                {
                    return GetMediatorResponse(VacancyPostingMediatorCodes.SelectNewEmployer.FailedValidation, result, validationResult);
                }

                result = _employerProvider.GetEmployerViewModels(viewModel);
                result.ComeFromPreview = viewModel.ComeFromPreview;

                if ((result.EmployerResults == null || !result.EmployerResults.Any()) && (result.EmployerResultsPage == null || result.EmployerResultsPage.ResultsCount == 0))
                {
                    return GetMediatorResponse(VacancyPostingMediatorCodes.SelectNewEmployer.NoResults, result);
                }
            }

            return GetMediatorResponse(VacancyPostingMediatorCodes.SelectNewEmployer.Ok, result, EmployerSearchViewModelMessages.ErnAdviceText, UserMessageLevel.Info);
        }
    }
}
