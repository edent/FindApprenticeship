﻿namespace SFA.Apprenticeships.Web.Manage.Mediators.Admin
{
    public class AdminMediatorCodes
    {
        public class SearchProviders
        {
            public const string FailedValidation = "AdminMediatorCodes.SearchProviders.FailedValidation";
            public const string Ok = "AdminMediatorCodes.SearchProviders.Ok";
        }

        public class GetProvider
        {
            public const string Ok = "AdminMediatorCodes.GetProvider.Ok";
        }

        public class CreateProvider
        {
            public const string FailedValidation = "AdminMediatorCodes.CreateProvider.FailedValidation";
            public const string UkprnAlreadyExists = "AdminMediatorCodes.CreateProvider.UkprnAlreadyExists";
            public const string Ok = "AdminMediatorCodes.CreateProvider.Ok";
        }
    }
}