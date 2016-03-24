namespace SFA.Apprenticeships.Web.Manage.UnitTests.Mediators.Vacancy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Common.ViewModels;
    using Common.ViewModels.Locations;
    using Domain.Entities.Raa.Vacancies;
    using Raa.Common.ViewModels.Provider;
    using Raa.Common.ViewModels.Vacancy;

    public static class VacancyMediatorTestHelper
    {
        public static IEnumerable<DashboardVacancySummaryViewModel> GetPendingVacancies(IEnumerable<int> vacancyReferenceNumbers )
        {
            return vacancyReferenceNumbers.Select(vacancyReferenceNumber => new DashboardVacancySummaryViewModel
            {
                VacancyReferenceNumber = vacancyReferenceNumber,
                Status = VacancyStatus.Submitted
            });
        }

        public static VacancyViewModel GetValidVacancyViewModel(int vacancyReferenceNumber)
        {
            return new VacancyViewModel
            {
                VacancyReferenceNumber = vacancyReferenceNumber,
                IsEmployerLocationMainApprenticeshipLocation = true,
                Status = VacancyStatus.Submitted,
                Address = new AddressViewModel
                {
                    Town = "London",
                    AddressLine1 = "Somewhere",
                    County = "LND"
                },
                ContactDetailsAndVacancyHistory = new ContactDetailsAndVacancyHistoryViewModel
                {
                    DateFirstSubmitted = DateTime.UtcNow,
                    DateLastUpdated = DateTime.UtcNow,
                    DateSubmitted = DateTime.UtcNow,
                    Email = "hello@gmail.com",
                    FullName = "fullname",
                    PhoneNumber = "0123456789",
                    ProviderName = "ProviderName"
                },
                FurtherVacancyDetailsViewModel = new FurtherVacancyDetailsViewModel
                {
                    VacancyReferenceNumber = vacancyReferenceNumber,
                    VacancyDatesViewModel = new VacancyDatesViewModel
                    {
                        ClosingDate = new DateViewModel(DateTime.UtcNow.AddDays(20)),
                        PossibleStartDate = new DateViewModel(DateTime.UtcNow.AddDays(30))
                    },
                    Duration = 3,
                    DurationType = DurationType.Years,
                    LongDescription = "A description",
                    WageType = WageType.ApprenticeshipMinimum,
                    HoursPerWeek = 30,
                    WorkingWeek = "A working week"
                },
                NewVacancyViewModel = new NewVacancyViewModel
                {
                    Title = "title",
                    ShortDescription = "vacancy summary",
                    OfflineVacancy = false,
                    VacancyType = VacancyType.Apprenticeship
                },
                ProviderSite = new ProviderSiteViewModel
                {
                    Address = new AddressViewModel
                    {
                        Town = "London",
                        AddressLine1 = "Somewhere",
                        County = "LND"
                    }
                },
                TrainingDetailsViewModel = new TrainingDetailsViewModel
                {
                    VacancyType = VacancyType.Apprenticeship,
                    TrainingProvided = "training",
                    TrainingType = TrainingType.Frameworks,
                    FrameworkCodeName = "ABC",
                    ApprenticeshipLevel = ApprenticeshipLevel.Higher
                },
                VacancyQuestionsViewModel = new VacancyQuestionsViewModel(),
                VacancyRequirementsProspectsViewModel = new VacancyRequirementsProspectsViewModel
                {
                    VacancyType = VacancyType.Apprenticeship,
                    DesiredSkills = "skills",
                    FutureProspects = "future prospects",
                    PersonalQualities = "personal qualities",
                    DesiredQualifications = "qualifications"
                }
            };
        }
    }
}