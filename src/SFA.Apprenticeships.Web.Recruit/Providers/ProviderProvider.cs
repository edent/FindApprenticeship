﻿using System.Collections.Generic;
using SFA.Apprenticeships.Web.Recruit.ViewModels.Provider;

namespace SFA.Apprenticeships.Web.Recruit.Providers
{
    public class ProviderProvider : IProviderProvider
    {
        public ProviderViewModel GetProviderViewModel(string ukprn)
        {
            //Stub code for removal
            if (ukprn == "hasproviderprofile")
            {
                return new ProviderViewModel {ProviderName = "Key Training Ltd"};
            }
            if (ukprn == "onesite")
            {
                return new ProviderViewModel
                {
                    ProviderName = "Key Training Ltd",
                    ProviderSiteViewModels = new List<ProviderSiteViewModel>
                    {
                        new ProviderSiteViewModel
                        {
                            Ern = "00001",
                            Name = "Basing View"
                        }
                    }
                };
            }

            return null;
            //end stub code
        }

        public ProviderSiteViewModel GetProviderSiteViewModel(string ern)
        {
            return new ProviderSiteViewModel
            {
                Ern = ern,
                Name = "Basing View",
                EmailAddress = "basing-view@keytraining.co.uk",
                PhoneNumber = "01256 320222"
            };
        }
    }
}