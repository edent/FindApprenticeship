﻿namespace SFA.Apprenticeships.Application.Provider
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using CuttingEdge.Conditions;
    using Domain.Entities.Raa.Parties;
    using Domain.Raa.Interfaces.Repositories;
    using Domain.Raa.Interfaces.Repositories.Models;
    using Interfaces;
    using Interfaces.Employers;
    using Interfaces.Generic;
    using Interfaces.Providers;

    public class ProviderService : IProviderService
    {
        private readonly IEmployerService _employerService;
        private readonly ILogService _logService;
        private readonly IProviderReadRepository _providerReadRepository;
        private readonly IProviderWriteRepository _providerWriteRepository;
        private readonly IProviderSiteReadRepository _providerSiteReadRepository;
        private readonly IProviderSiteWriteRepository _providerSiteWriteRepository;
        private readonly IVacancyPartyReadRepository _vacancyPartyReadRepository;
        private readonly IVacancyPartyWriteRepository _vacancyPartyWriteRepository;

        public ProviderService(IProviderReadRepository providerReadRepository,
            IProviderSiteReadRepository providerSiteReadRepository,
            IVacancyPartyReadRepository vacancyPartyReadRepository,
            IVacancyPartyWriteRepository vacancyPartyWriteRepository,
            ILogService logService, IEmployerService employerService, IProviderWriteRepository providerWriteRepository, IProviderSiteWriteRepository providerSiteWriteRepository)
        {
            _providerReadRepository = providerReadRepository;
            _providerSiteReadRepository = providerSiteReadRepository;
            _vacancyPartyReadRepository = vacancyPartyReadRepository;
            _vacancyPartyWriteRepository = vacancyPartyWriteRepository;
            _logService = logService;
            _employerService = employerService;
            _providerWriteRepository = providerWriteRepository;
            _providerSiteWriteRepository = providerSiteWriteRepository;
        }

        public Provider GetProvider(int providerId)
        {
            return _providerReadRepository.GetById(providerId);
        }

        public Provider GetProvider(string ukprn, bool errorIfNotFound = true)
        {
            Condition.Requires(ukprn).IsNotNullOrEmpty();

            _logService.Debug("Calling ProviderReadRepository to get provider with UKPRN='{0}'.", ukprn);

            return _providerReadRepository.GetByUkprn(ukprn, errorIfNotFound);
        }

        public IEnumerable<Provider> GetProviders(IEnumerable<int> providerIds)
        {
            return _providerReadRepository.GetByIds(providerIds);
        }

        public IEnumerable<Provider> SearchProviders(ProviderSearchParameters searchParameters)
        {
            return _providerReadRepository.Search(searchParameters);
        }

        public ProviderSite GetProviderSite(int providerSiteId)
        {
            return _providerSiteReadRepository.GetById(providerSiteId);
        }

        public ProviderSite GetProviderSite(string edsUrn)
        {
            Condition.Requires(edsUrn).IsNotNullOrEmpty();

            _logService.Debug("Calling ProviderSiteReadRepository to get provider site with ERN='{0}'.", edsUrn);

            return _providerSiteReadRepository.GetByEdsUrn(edsUrn);
        }

        public IEnumerable<ProviderSite> GetProviderSites(int providerId)
        {
            return _providerSiteReadRepository.GetByProviderId(providerId);
        }

        public IEnumerable<ProviderSite> GetProviderSites(string ukprn)
        {
            Condition.Requires(ukprn).IsNotNullOrEmpty();

            _logService.Debug(
                "Calling ProviderSiteReadRepository to get provider sites for provider with UKPRN='{0}'.", ukprn);

            var provider = _providerReadRepository.GetByUkprn(ukprn);
            if (provider == null)
            {
                throw new Exception($"Provider cannot be found with ukprn={ukprn}");
            }

            return _providerSiteReadRepository.GetByProviderId(provider.ProviderId);
        }

        public IReadOnlyDictionary<int, ProviderSite> GetProviderSites(IEnumerable<int> providerSiteIds)
        {
            return _providerSiteReadRepository.GetByIds(providerSiteIds);
        }

        public IEnumerable<ProviderSite> GetOwnedProviderSites(int providerId)
        {
            var providerSites = _providerSiteReadRepository.GetByProviderId(providerId);
            return providerSites.Where(ps => ps.ProviderSiteRelationships.Any(psr => psr.ProviderId == providerId && psr.ProviderSiteRelationShipTypeId == ProviderSiteRelationshipTypes.Owner));
        }

        public IEnumerable<ProviderSite> SearchProviderSites(ProviderSiteSearchParameters searchParameters)
        {
            return _providerSiteReadRepository.Search(searchParameters);
        }

        public VacancyParty GetVacancyParty(int vacancyPartyId, bool currentOnly = true)
        {
            return _vacancyPartyReadRepository.GetByIds(new[] {vacancyPartyId}, currentOnly).FirstOrDefault();
        }

        public IReadOnlyDictionary<int, VacancyParty> GetVacancyParties(IEnumerable<int> vacancyPartyIds,
            bool currentOnly = true)
        {
            return
                _vacancyPartyReadRepository.GetByIds(vacancyPartyIds, currentOnly).ToDictionary(vp => vp.VacancyPartyId);
        }

        public VacancyParty GetVacancyParty(int providerSiteId, string edsUrn)
        {
            Condition.Requires(providerSiteId);
            Condition.Requires(edsUrn).IsNotNullOrEmpty();

            _logService.Debug("Calling Employer Service to get employer with EDSURN='{0}'.", edsUrn);

            var employer = _employerService.GetEmployer(edsUrn);

            _logService.Debug(
                "Calling VacancyPartyReadRepository to get vacancy party for provider site with Id='{0}' and employer with Id='{1}'.",
                providerSiteId, employer.EmployerId);

            var vacancyParty =
                _vacancyPartyReadRepository.GetByProviderSiteAndEmployerId(providerSiteId, employer.EmployerId) ??
                new VacancyParty {ProviderSiteId = providerSiteId, EmployerId = employer.EmployerId};

            return vacancyParty;
        }

        public bool IsADeletedVacancyParty(int providerSiteId, string edsUrn)
        {
            Condition.Requires(providerSiteId);
            Condition.Requires(edsUrn).IsNotNullOrEmpty();

            _logService.Debug("Calling Employer Service to get employer with EDSURN='{0}'.", edsUrn);

            var employer = _employerService.GetEmployer(edsUrn);

            _logService.Debug(
                "Calling VacancyPartyReadRepository to check if the vacancy party has been deleted for provider site with Id='{0}' and employer with Id='{1}'.",
                providerSiteId, employer.EmployerId);

            return _vacancyPartyReadRepository.IsADeletedVacancyParty(providerSiteId, employer.EmployerId);
        }

        public void ResurrectVacancyParty(int providerSiteId, string edsUrn)
        {
            Condition.Requires(providerSiteId);
            Condition.Requires(edsUrn).IsNotNullOrEmpty();

            _logService.Debug("Calling Employer Service to get employer with EDSURN='{0}'.", edsUrn);

            var employer = _employerService.GetEmployer(edsUrn);

            _logService.Debug(
                "Calling VacancyPartyWriteRepository to resurrect the vacancy party for provider site with Id='{0}' and employer with Id='{1}'.",
                providerSiteId, employer.EmployerId);

            _vacancyPartyWriteRepository.ResurrectVacancyParty(providerSiteId, employer.EmployerId);
        }

        public VacancyParty SaveVacancyParty(VacancyParty vacancyParty)
        {
            return _vacancyPartyWriteRepository.Save(vacancyParty);
        }

        public IEnumerable<VacancyParty> GetVacancyParties(int providerSiteId)
        {
            return _vacancyPartyReadRepository.GetByProviderSiteId(providerSiteId);
        }

        public Pageable<VacancyParty> GetVacancyParties(EmployerSearchRequest request, int currentPage, int pageSize)
        {
            var results = GetVacancyParties(request);

            var pageable = new Pageable<VacancyParty>
            {
                CurrentPage = currentPage
            };

            var resultCount = results.Count;

            pageable.Page = results.Skip((currentPage - 1)*pageSize).Take(pageSize).ToList();
            pageable.ResultsCount = resultCount;
            pageable.TotalNumberOfPages = resultCount/pageSize + 1;

            return pageable;
        }

        public Provider CreateProvider(Provider provider)
        {
            return _providerWriteRepository.Create(provider);
        }

        public ProviderSite CreateProviderSite(ProviderSite providerSite)
        {
            return _providerSiteWriteRepository.Create(providerSite);
        }

        public ProviderSite SaveProviderSite(ProviderSite providerSite)
        {
            return _providerSiteWriteRepository.Update(providerSite);
        }

        private List<VacancyParty> GetVacancyParties(EmployerSearchRequest request)
        {
            Condition.Requires(request).IsNotNull();

            _logService.Debug(
                "Calling VacancyPartyReadRepository to get vacancy party for provider site with Id='{0}'.",
                request.ProviderSiteId);

            var vacancyParties = _vacancyPartyReadRepository.GetByProviderSiteId(request.ProviderSiteId).ToList();

            if (request.IsQuery)
            {
                var employers = _employerService.GetEmployers(vacancyParties.Select(v => v.EmployerId).Distinct());

                if (request.IsEmployerEdsUrnQuery)
                {
                    employers = employers.Where(e => e.EdsUrn == request.EmployerEdsUrn);
                }
                else if (request.IsNameAndLocationQuery)
                {
                    employers = employers.Where(employer =>
                        employer.Name.ToLower().Contains(request.Name.ToLower()) &&
                        IsMatchingAddress(request, employer));
                }
                else if (request.IsNameQuery)
                {
                    employers = employers.Where(e => e.Name.ToLower().Contains(request.Name.ToLower()));
                }
                else if (request.IsLocationQuery)
                {
                    employers = employers.Where(e => IsMatchingAddress(request, e));
                }

                vacancyParties = vacancyParties.Where(vp => employers.Any(e => e.EmployerId == vp.EmployerId)).ToList();
            }

            return vacancyParties;
        }

        private static bool IsMatchingAddress(EmployerSearchRequest request, Employer e)
        {
            return
                (e.Address.Postcode != null &&
                 Regex.Replace(e.Address.Postcode, @"\s+", "").ToLower().Contains(request.Location.ToLower())) ||
                (e.Address.AddressLine4 != null &&
                 Regex.Replace(e.Address.AddressLine4, @"\s+", "").ToLower().Contains(request.Location.ToLower())) ||
                (e.Address.Town != null &&
                 Regex.Replace(e.Address.Town, @"\s+", "").ToLower().Contains(request.Location.ToLower()));
        }
    }
}