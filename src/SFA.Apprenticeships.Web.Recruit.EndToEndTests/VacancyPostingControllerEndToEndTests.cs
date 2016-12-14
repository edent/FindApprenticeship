﻿namespace SFA.Apprenticeships.Web.Recruit.EndToEndTests
{
    using Common.ViewModels.Locations;
    using Controllers;
    using Domain.Entities.Raa.Vacancies;
    using Domain.Entities.Vacancies;
    using FluentAssertions;
    using Infrastructure.Repositories.Mongo.Vacancies.Entities;
    using NUnit.Framework;
    using Raa.Common.ViewModels.Employer;
    using Raa.Common.ViewModels.Provider;
    using Raa.Common.ViewModels.VacancyPosting;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using ApprenticeshipLevel = Domain.Entities.Raa.Vacancies.ApprenticeshipLevel;
    using TrainingType = Domain.Entities.Raa.Vacancies.TrainingType;
    using VacancyLocationType = Domain.Entities.Raa.Vacancies.VacancyLocationType;

    [TestFixture, Category("Acceptance")]
    public class VacancyPostingControllerEndToEndTests : RecruitWebEndToEndTestsBase
    {
        //TODO: Alter these acceptance tests to use SQL repo

        [Test]
        public async Task CloneAVacancyShouldCreateANewOneWithSomeFieldsReset()
        {
            // Arrange
            const int vacancyReferenceNumber = 1;
            const string title = "Vacancy title";

            var vacancy = GetCorrectVacancy(vacancyReferenceNumber, title);

            InitializeDatabaseWithVacancy(vacancy);

            var vacancyPostingController = Container.GetInstance<VacancyPostingController>();

            // Act
            var result = await vacancyPostingController.CloneVacancy(vacancyReferenceNumber);


            // Assert
            result.Should().BeOfType<RedirectToRouteResult>();
            var redirection = result as RedirectToRouteResult;
            redirection.RouteName.Should().Be("ConfirmEmployer");

            var newVacancyGuid = (Guid)redirection.RouteValues.Values.Last();

            newVacancyGuid.Should().NotBe(vacancy.VacancyGuid);
            var clonedVacancy = Collection.FindOneById(newVacancyGuid);
            clonedVacancy.Title.Should().StartWith("(Copy of) ");
            clonedVacancy.CreatedDateTime.Should().BeCloseTo(DateTime.UtcNow, 1000); // inject fake date time service?
            clonedVacancy.VacancyReferenceNumber.Should().NotBe(vacancyReferenceNumber);
            clonedVacancy.DateSubmitted.Should().NotHaveValue();
            clonedVacancy.DateStartedToQA.Should().NotHaveValue();
            clonedVacancy.DateQAApproved.Should().NotHaveValue();
            clonedVacancy.Status.Should().Be(VacancyStatus.Draft);
            clonedVacancy.ClosingDate.Should().NotHaveValue();
            clonedVacancy.PossibleStartDate.Should().NotHaveValue();
            CheckAllCommentsAreNull(clonedVacancy);
        }

        [Test]
        public void GetConfirmEmployerShouldReturnAPoviderSiteEmployerViewModelWithMainLocationAsTrue()
        {
            const int providerSiteId = 101282923;
            const string edsUrn = "100608868";
            var vacancyGuid = Guid.NewGuid();

            var vacancyPostingController = Container.GetInstance<VacancyPostingController>();

            var result = vacancyPostingController.ConfirmEmployer(providerSiteId, edsUrn, vacancyGuid, false, null);
            result.Should().BeOfType<ViewResult>();
            var view = result as ViewResult;
            view.Model.Should().BeOfType<VacancyOwnerRelationshipViewModel>();
            var viewModel = view.Model as VacancyOwnerRelationshipViewModel;
            viewModel.VacancyLocationType.Should().Be(VacancyLocationType.SpecificLocation);
            viewModel.NumberOfPositions.Should().NotHaveValue();
        }

        [Test]
        public void ConfirmEmployerShouldSaveLocationTypeAndNumberOfPositionsInDB()
        {
            const int providerSiteId = 101282923;
            const int employerId = 100608868;
            const int numberOfPositions = 5;
            const VacancyLocationType employerApprenticeshipLocation = VacancyLocationType.SpecificLocation;
            var vacancyGuid = Guid.NewGuid();
            var viewModel = GetProviderSiteEmployerLinkViewModel(employerId, employerApprenticeshipLocation, numberOfPositions, providerSiteId, vacancyGuid);

            var savedVacancy = new MongoVacancy
            {
                VacancyGuid = vacancyGuid
            };
            Collection.Save(savedVacancy);

            var vacancyPostingController = Container.GetInstance<VacancyPostingController>();

            vacancyPostingController.ConfirmEmployer(viewModel).Wait();

            var vacancy = Collection.FindOneById(vacancyGuid);
            vacancy.VacancyLocationType.Should().Be(VacancyLocationType.SpecificLocation);
            vacancy.NumberOfPositions.Should().Be(numberOfPositions);
        }

        [Test]
        public async Task ConfirmEmployerWithLocationTypeAsDifferentFromEmployerLocationShouldRedirectToLocationView()
        {
            const int providerSiteId = 101282923;
            const int employerId = 100608868;
            // const string ukprn = 
            const VacancyLocationType employerApprenticeshipLocation = VacancyLocationType.MultipleLocations;
            var vacancyGuid = Guid.NewGuid();
            var viewModel = GetProviderSiteEmployerLinkViewModel(employerId, employerApprenticeshipLocation, null, providerSiteId, vacancyGuid);

            var savedVacancy = new MongoVacancy
            {
                VacancyGuid = vacancyGuid
            };
            Collection.Save(savedVacancy);

            var vacancyPostingController = Container.GetInstance<VacancyPostingController>();

            var result = await vacancyPostingController.ConfirmEmployer(viewModel);
            result.Should().BeOfType<RedirectToRouteResult>();
            var redirection = result as RedirectToRouteResult;
            redirection.RouteName.Should().Be("AddLocations");
        }

        [Test]
        public void AddLocationsShouldStoreLocationsInDB()
        {
            const string providerSiteErn = "101282923";
            const string edsUrn = "100608868";
            const string additionalLocationInformation = "additional location information";
            var numberOfPositions = 5;
            var address1 = new VacancyLocationAddressViewModel
            {
                Address =
                {
                    Postcode = "HA0 1TW",
                    AddressLine1 = "Abbeydale Road",
                    AddressLine4 = "Wembley"
                },
                NumberOfPositions = numberOfPositions
            };

            var vacancyGuid = Guid.NewGuid();
            var viewModel = new LocationSearchViewModel
            {
                ProviderSiteEdsUrn = providerSiteErn,
                EmployerEdsUrn = edsUrn,
                AdditionalLocationInformation = additionalLocationInformation,
                Addresses = new List<VacancyLocationAddressViewModel> { address1 },
                VacancyGuid = vacancyGuid
            };

            var savedVacancy = new MongoVacancy
            {
                VacancyGuid = vacancyGuid
            };
            Collection.Save(savedVacancy);
            var vacancyPostingController = Container.GetInstance<VacancyPostingController>();

            var result = vacancyPostingController.Locations(viewModel);
            result.Should().BeOfType<RedirectToRouteResult>();
            var redirection = result as RedirectToRouteResult;
            redirection.RouteName.Should().Be("CreateVacancy");

            var vacancy = Collection.FindOneById(vacancyGuid);
            /*vacancy.LocationAddresses.Should().HaveCount(1);
            vacancy.LocationAddresses[0].Address.AddressLine1.Should().Be(address1.Address.AddressLine1);
            vacancy.LocationAddresses[0].Address.AddressLine2.Should().Be(address1.Address.AddressLine2);
            vacancy.LocationAddresses[0].Address.AddressLine3.Should().Be(address1.Address.AddressLine3);
            vacancy.LocationAddresses[0].Address.AddressLine4.Should().Be(address1.Address.AddressLine4);
            vacancy.LocationAddresses[0].Address.Postcode.Should().Be(address1.Address.Postcode);
            vacancy.LocationAddresses[0].NumberOfPositions.Should().Be(numberOfPositions);
            vacancy.AdditionalLocationInformation.Should().Be(additionalLocationInformation);*/
        }

        private static VacancyOwnerRelationshipViewModel GetProviderSiteEmployerLinkViewModel(int employerId,
            VacancyLocationType employerApprenticeshipLocation, int? numberOfPositions, int providerSiteId,
            Guid vacancyGuid)
        {
            return new VacancyOwnerRelationshipViewModel
            {
                EmployerDescription = "desciption",
                Employer = new EmployerViewModel
                {
                    Address = new AddressViewModel
                    {
                        AddressLine1 = "Address line 1",
                        AddressLine2 = "Address line 2",
                        AddressLine3 = "Address line 3",
                        AddressLine4 = "Address line 4",
                        GeoPoint = new GeoPointViewModel(),
                        Postcode = "postcode",
                        Uprn = "uprn"
                    },
                    FullName = "some employer",
                    EmployerId = employerId
                },
                VacancyLocationType = employerApprenticeshipLocation,
                NumberOfPositions = numberOfPositions,
                ProviderSiteId = providerSiteId,
                VacancyGuid = vacancyGuid
            };
        }

        private static void CheckAllCommentsAreNull(MongoVacancy clonedVacancy)
        {
            clonedVacancy.WorkingWeekComment.Should().BeNull();
            clonedVacancy.ApprenticeshipLevelComment.Should().BeNull();
            clonedVacancy.ClosingDateComment.Should().BeNull();
            clonedVacancy.DesiredQualificationsComment.Should().BeNull();
            clonedVacancy.DesiredSkillsComment.Should().BeNull();
            clonedVacancy.DurationComment.Should().BeNull();
            clonedVacancy.FirstQuestionComment.Should().BeNull();
            clonedVacancy.FrameworkCodeNameComment.Should().BeNull();
            clonedVacancy.FutureProspectsComment.Should().BeNull();
            clonedVacancy.LongDescriptionComment.Should().BeNull();
        }

        private static MongoVacancy GetCorrectVacancy(int vacancyReferenceNumber, string title, VacancyStatus status = VacancyStatus.Submitted)
        {
            return new MongoVacancy
            {
                Title = title,
                ApprenticeshipLevel = ApprenticeshipLevel.Advanced,
                VacancyReferenceNumber = vacancyReferenceNumber,
                ClosingDate = DateTime.UtcNow.AddDays(30),
                CreatedDateTime = DateTime.UtcNow.AddDays(-1),
                DateSubmitted = DateTime.UtcNow.AddDays(-1),
                DesiredQualifications = "desired qualifications",
                DesiredSkills = "desired skills",
                Duration = 3,
                DurationType = DurationType.Years,
                VacancyGuid = Guid.NewGuid(),
                FutureProspects = "future prospects",
                LongDescription = "long description",
                OfflineVacancy = false,
                PersonalQualities = "personal qualities",
                PossibleStartDate = DateTime.UtcNow.AddDays(100),
                VacancyOwnerRelationshipId = 42,
                ShortDescription = "short description",
                Status = status,
                TrainingType = TrainingType.Standards,
                StandardId = 1,
                WorkingWeek = "Working week",
                Wage = new Wage(WageType.Custom, 0, null, null, null, WageUnit.NotApplicable, 40, null)
            };
        }

        private void InitializeDatabaseWithVacancy(MongoVacancy vacancy)
        {
            Collection.Save(vacancy);
        }

        [Test]
        public async Task CloneAVacancyInDeferredStateShouldNotCreateNewVacancyAndReturnToDashboard()
        {
            // Arrange
            const int vacancyReferenceNumber = 1;
            const string title = "Vacancy title";

            var vacancy = GetCorrectVacancy(vacancyReferenceNumber, title, VacancyStatus.Referred);

            InitializeDatabaseWithVacancy(vacancy);

            var vacancyPostingController = Container.GetInstance<VacancyPostingController>();

            // Act
            var result = await vacancyPostingController.CloneVacancy(vacancyReferenceNumber);


            // Assert
            result.Should().BeOfType<RedirectToRouteResult>();
            var redirection = result as RedirectToRouteResult;
            redirection.RouteName.Should().Be("RecruitmentHome");

            Collection.Count().Should().Be(1);
        }
    }
}