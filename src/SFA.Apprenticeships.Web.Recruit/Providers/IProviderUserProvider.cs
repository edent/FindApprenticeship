﻿namespace SFA.Apprenticeships.Web.Recruit.Providers
{
    using System.Collections.Generic;
    using ViewModels.ProviderUser;

    public interface IProviderUserProvider
    {
        ProviderUserViewModel GetUserProfileViewModel(string username);

        IEnumerable<ProviderUserViewModel> GetUserProfileViewModels(string ukprn);

        bool ValidateEmailVerificationCode(string username, string code);
    }
}