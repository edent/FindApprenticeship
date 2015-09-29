﻿namespace SFA.Apprenticeships.Web.Recruit.Mediators.ProviderUser
{
    public static class ProviderUserMediatorCodes
    {
        public class Authorize
        {
            public const string EmptyUsername = "ProviderUser.Authorize.EmptyUsername";
            public const string MissingProviderIdentifier = "ProviderUser.Authorize.MissingProviderIdentifier";
            public const string MissingServicePermission = "ProviderUser.Authorize.MissingServicePermission";
            public const string NoProviderProfile = "ProviderUser.Authorize.NoProviderProfile";
            public const string FailedMinimumSitesCountCheck = "ProviderUser.Authorize.FailedMinimumSitesCountCheck";
            public const string FirstUser = "ProviderUser.Authorize.FirstUser";
            public const string NoUserProfile = "ProviderUser.Authorize.NoUserProfile";
            public const string EmailAddressNotVerified = "ProviderUser.Authorize.EmailAddressNotVerified";
            public const string Ok = "ProviderUser.Authorize.Ok";
        }

        public static class GetProviderUserViewModel
        {
            public const string Ok = "ProviderUser.GetProviderUserViewModel.Ok";
        }
        public static class GetSettingsViewModel
        {
            public const string Ok = "ProviderUser.GetSettingsViewModel.Ok";
            public const string DoesntExist = "ProviderUser.GetSettingsViewModel.DoesntExist";
        }

        public static class UpdateUser
        {
            public const string Ok = "ProviderUser.UpdateUser.Ok";
            public const string FailedValidation = "ProviderUser.UpdateUser.FailedValidation";
            public const string EmailUpdated = "ProviderUser.UpdateUser.EmailUpdated";
        }

        public static class VerifyEmailAddress
        {
            public const string Ok = "ProviderUser.VerifyEmailAddress.Ok";
            public const string FailedValidation = "ProviderUser.VerifyEmailAddress.FailedValidation";
            public const string InvalidCode = "ProviderUser.VerifyEmailAddress.InvalidCode";
        }

        public static class ResendVerificationCode
        {
            public const string Ok = "ProviderUser.ResendVerificationCode.Ok";
            public const string Error = "ProviderUser.ResendVerificationCode.Error";
        }
    }
}