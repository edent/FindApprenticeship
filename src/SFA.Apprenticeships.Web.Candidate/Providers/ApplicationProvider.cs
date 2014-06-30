﻿namespace SFA.Apprenticeships.Web.Candidate.Providers
{
    using System;
    using System.Collections.Generic;
    using ViewModels.Applications;
    using ViewModels.Candidate;
    using ViewModels.Locations;

    internal class ApplicationProvider : IApplicationProvider
    {
        private readonly IVacancyDetailProvider _vacancyDetailProvider;

        public ApplicationProvider(IVacancyDetailProvider vacancyDetailProvider)
        {
            _vacancyDetailProvider = vacancyDetailProvider;
        }

        public ApplicationViewModel GetApplicationViewModel(int vacancyId, int dummyProfileId)
        {
            var profile = GetDummyCandidateViewModel(dummyProfileId);

            var vacancy = _vacancyDetailProvider.GetVacancyDetailViewModel(vacancyId);

            if (vacancy == null)
            {
                return null;
            }

            var appViewModel = new ApplicationViewModel
            {
                Candidate = profile,
                VacancyId = vacancy.Id,
                EmployerName = vacancy.EmployerName,
                VacancySummary = vacancy.Description,
                VacancyTitle = vacancy.Title
            };

            return appViewModel;
        }

        public void SaveApplication(ApplicationViewModel applicationViewModel)
        {
            throw new System.NotImplementedException();
        }

        private CandidateViewModel GetDummyCandidateViewModel(int dummyProfileId)
        {
            switch (dummyProfileId)
            {
                case 1:
                    return BuildCandidateViewModel("John Doe", 
                                                    "john.doe@test-apprentice.com",
                                                    new DateTime(1997, 01, 01), 
                                                    "077-JOHN-DOE",
                                                    "10 Johndoe Road",
                                                    "MissingInAction Town",
                                                    "JD1 MIA"
                                                    );
                case 2:
                    return BuildCandidateViewModel("Susan Defoe", 
                                                    "susan.defoe@test-apprentice.com", 
                                                    new DateTime(1996, 02, 02), 
                                                    "076-SUS-DEFOE",
                                                    "11 William Road",
                                                    "Deerstown",
                                                    "WD2 V1T");
                case 3:
                    return BuildCandidateViewModel("Mike Snow", 
                                                    "mike.snow@test-apprentice.com", 
                                                    new DateTime(1996, 03, 03), 
                                                    "075-MIKE-SNOW",
                                                    "12 Salted Drive",
                                                    "Musical Avenue",
                                                    "MS3 9VT");
                case 4:
                    return BuildCandidateViewModel("Barley Mow", 
                                                    "barley.mow@test-apprentice.com", 
                                                    new DateTime(1996, 04, 04), 
                                                    "075-BARLEY-MOW",
                                                    "13 Wheaty fields",
                                                    "Oatsville",
                                                    "BW12 1OT");
                default:
                    return null;
            }
        }

        private CandidateViewModel BuildCandidateViewModel(string fullName, string emailAddress, DateTime dateOfBirth, string phoneNumber, string addressLine1, string town, string postCode)
        {
            var candidate = new CandidateViewModel()
            {
                FullName = fullName,
                EmailAddress = emailAddress,
                DateOfBirth = dateOfBirth,
                PhoneNumber = phoneNumber,
                Address = new AddressViewModel { AddressLine1 = addressLine1, AddressLine4 = town, Postcode = postCode },
                AboutYou = new AboutYouViewModel(),
                Qualifications = new List<QualificationsViewModel>(),
                WorkExperience = new List<WorkExperienceViewModel>()
            };

            return candidate;
        }
    }
}