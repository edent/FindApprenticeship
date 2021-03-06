﻿namespace SFA.Apprenticeships.Web.Recruit.Constants
{
    public class RecruitmentRouteNames
    {
        
        public const string RecruitmentHome = "RecruitmentHome";

        // Provider set up
        public const string ManageProviderSites = "ManageProviderSites";
        public const string AddProviderSite = "AddProviderSite";
        public const string EditProviderSite = "EditProviderSite";

        // Account set up
        public const string Settings = "Settings";
        public const string VerifyEmail = "VerifyEmail";
        public const string ResendVerificationCode = "ResendVerificationCode";

        // Authetication
        public const string SignIn = "SignIn";
        public const string SignOut = "SignOut";
        public const string Authorize = "Authorize";
        public const string AuthorizationError = "AuthorizationError";
        public const string SessionTimeout = "SessionTimeout";
        public const string SignOutCallback = "SignOutCallback";

        // Site furniture
        public const string LandingPage = "Landing";
        public const string Privacy = "Privacy";
        public const string TermsAndConditions = "TermsAndConditions";
        public const string ContactUs = "ContactUs";

        // Vacancy posting
        public const string CreateVacancy = "CreateVacancy";
        public const string EditVacancy = "EditVacancy";
        public const string SubmitVacancy = "SubmitVacancy";
        public const string VacancySubmitted = "VacancySubmitted";
        public const string VacancyQuestions = "VacancyQuestions";
        public const string VacancySummary = "VacancySummary";
        public const string PreviewVacancy = "PreviewVacancy";

        // Vacancy posting - existing employer
        public const string SelectExistingEmployer = "SelectExistingEmployer";
        public const string SearchExistingEmployer = "SearchExistingEmployer";
        public const string PageExistingEmployer = "PageExistingEmployer";
        public const string SearchExistingEmployerByErn = "SearchExistingEmployerByErn";
        public const string SearchExistingEmployerByNameAndOrLocation = "SearchExistingEmployerByNameAndOrLocation";
        public const string AddEmployer = "AddEmployer";
        public const string ComfirmEmployer = "ConfirmEmployer";

        // Vacancy posting - new employer
        public const string SelectNewEmployer = "SelectNewEmployer";
        public const string AddNewEmployer = "AddNewEmployer";
        public const string ComfirmNewEmployer = "ConfirmNewEmployer";
        public const string VacancyRequirementsProspects = "VacancyRequirementsProspects";
    }
}
