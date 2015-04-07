﻿namespace SFA.Apprenticeships.Web.Common.Configuration
{
    public class WebConfiguration
    {
        public int VacancyResultsPerPage { get; set; }

        public int LocationResultLimit { get; set; }

        public bool EnableWebTrends { get; set; }

        public string WebTrendsDscId { get; set; }

        public string SiteDomainName { get; set; }

        public string SiteRootRedirectUrl { get; set; }

        public string TermsAndConditionsVersion { get; set; }

        public string BlacklistedCategoryCodes { get; set; }

        public string FeedbackUrl { get; set; }

        public bool IsWebsiteOffline { get; set; }

        public string WebsiteOfflineMessage { get; set; }

        public string CodeGenerator { get; set; }

        public int UnsuccessfulApplicationsToShowTraineeshipsPrompt { get; set; }

        public string PlannedOutageMessage { get; set; }

        public Features Features { get ; set; }
    }

    public class Features
    {
        public bool SavedSearchesEnabled { get; set; }

        public bool SmsEnabled { get; set; }
    }
}
