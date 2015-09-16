﻿namespace SFA.Apprenticeships.Web.Recruit.Providers
{
    using ViewModels.ProviderUser;

    public interface IProviderUserProvider
    {
        ProviderUserViewModel GetUserProfileViewModel(string username);
    }
}