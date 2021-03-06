﻿using SFA.Apprenticeships.Web.Common.Constants;

namespace SFA.Apprenticeships.Web.Raa.Common.Constants.ViewModels
{
    public class ProviderViewModelMessages
    {
        public const string UkprnAlreadyExists = "The supplied UKPRN is already associated with a provider";
        public const string ProviderCreatedSuccessfully = "New provider added successfully";
        public const string ProviderSavedSuccessfully = "The changes to the provider were saved successfully";
        public const string ProviderSaveError = "An error occured when saving the provider. Please check your entries and try again";

        public static class Ukprn
        {
            public const string LabelText = "UKPRN";
            public const string RequiredErrorText = "Enter the provider's UKPRN";
            public const string RequiredLengthErrorText = "UKPRN must be 8 digits";
            public const string WhiteListRegularExpression = Whitelists.NumericalWhitelist.RegularExpression;
            public const string WhiteListErrorText = "UKPRN " + Whitelists.NumericalWhitelist.ErrorText;
        }

        public static class FullName
        {
            public const string LabelText = "Full name";
            public const string RequiredErrorText = "Enter the provider's full name";
            public const string TooLongErrorText = "Full name must not be more than 255 characters";
            public const string WhiteListRegularExpression = Whitelists.FreetextWhitelist.RegularExpression;
            public const string WhiteListErrorText = "Full name " + Whitelists.FreetextWhitelist.ErrorText;
        }

        public static class TradingName
        {
            public const string LabelText = "Trading name";
            public const string RequiredErrorText = "Enter the provider's trading name";
            public const string TooLongErrorText = "Trading name must not be more than 255 characters";
            public const string WhiteListRegularExpression = Whitelists.FreetextWhitelist.RegularExpression;
            public const string WhiteListErrorText = "Trading name " + Whitelists.FreetextWhitelist.ErrorText;
        }

        public static class ProviderStatusType
        {
            public const string LabelText = "Status";
        }
    }
}