﻿namespace SFA.Apprenticeships.Web.Raa.Common.Constants.ViewModels
{
    using Web.Common.Constants;

    public class ProviderSiteEmployerLinkViewModelMessages
    {
        public static class Description
        {
            public const string LabelText = "Employer description for your vacancies";
            public const string RequiredErrorText = "Please enter an employer description for your vacancies";
            public const string WhiteListRegularExpression = Whitelists.FreetextWhitelist.RegularExpression;
            public const string WhiteListErrorText = "Employer description for your vacancies " + Whitelists.FreetextWhitelist.ErrorText;
        }
        public static class WebsiteUrl
        {
            public const string LabelText = "Website (optional)";
            public const string ErrorUriText = "Please enter a valid website url";
        }

        public class NumberOfPositions
        {
            public const string LabelText = "Number of positions";
            public const string RequiredErrorText = "Please enter the number of positions of the vacancy";
            public const string LengthErrorText = "You must enter at least 1 position";
        }

        public class IsEmployerLocationMainApprenticeshipLocation
        {
            public const string RequiredErrorText = "Select whether the employer’s address is the main apprenticeship location or not";
        }
    }
}