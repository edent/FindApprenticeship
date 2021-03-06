﻿namespace SFA.Apprenticeships.Application.UserProfile
{
    using System.Collections.Generic;
    using Domain.Entities.Raa.Users;
    using Domain.Raa.Interfaces.Repositories;
    using Domain.Raa.Interfaces.Repositories.Models;
    using Interfaces.Users;

    public class UserProfileService : IUserProfileService
    {
        private readonly IProviderUserReadRepository _providerUserReadRepository;
        private readonly IProviderUserWriteRepository _providerUserWriteRepository;
        private readonly IAgencyUserReadRepository _agencyUserReadRepository;
        private readonly IAgencyUserWriteRepository _agencyUserWriteRepository;

        public UserProfileService(IProviderUserReadRepository providerUserReadRepository, IProviderUserWriteRepository providerUserWriteRepository, IAgencyUserReadRepository agencyUserReadRepository, IAgencyUserWriteRepository agencyUserWriteRepository)
        {
            _providerUserReadRepository = providerUserReadRepository;
            _providerUserWriteRepository = providerUserWriteRepository;
            _agencyUserReadRepository = agencyUserReadRepository;
            _agencyUserWriteRepository = agencyUserWriteRepository;
        }

        public ProviderUser GetProviderUser(int providerUserId)
        {
            return _providerUserReadRepository.GetById(providerUserId);
        }

        public ProviderUser GetProviderUser(string username)
        {
            return _providerUserReadRepository.GetByUsername(username);
        }

        public IEnumerable<ProviderUser> GetProviderUsers(string ukprn)
        {
            return _providerUserReadRepository.GetAllByUkprn(ukprn);
        }

        public IEnumerable<ProviderUser> SearchProviderUsers(ProviderUserSearchParameters searchParameters)
        {
            return _providerUserReadRepository.Search(searchParameters);
        }

        public ProviderUser CreateProviderUser(ProviderUser providerUser)
        {
            //Check if email is being updated and set pending, verification code, send email etc
            return _providerUserWriteRepository.Create(providerUser);
        }

        public ProviderUser UpdateProviderUser(ProviderUser providerUser)
        {
            //Check if email is being updated and set pending, verification code, send email etc
            return _providerUserWriteRepository.Update(providerUser);
        }

        public AgencyUser GetAgencyUser(string username)
        {
            return _agencyUserReadRepository.GetByUsername(username);
        }

        public AgencyUser SaveUser(AgencyUser agencyUser)
        {
            return _agencyUserWriteRepository.Save(agencyUser);
        }

        public IEnumerable<Role> GetRoles()
        {
            //TODO: Get these from config or a repo once the design and full list has been agreed
            return new []
            {
                GetRole("Helpdesk_advisor", "Helpdesk adviser"),
                GetRole("QA_advisor", "Vacancy reviewer", true)
            };
        }

        private static Role GetRole(string id, string name, bool isDefault = false)
        {
            return new Role
            {
                Id = id,
                Name = name,
                IsDefault = isDefault
            };
        }
    }
}
