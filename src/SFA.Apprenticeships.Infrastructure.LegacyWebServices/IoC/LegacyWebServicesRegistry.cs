﻿using SFA.Apprenticeships.Infrastructure.LegacyWebServices.GatewayServiceProxy;

namespace SFA.Apprenticeships.Infrastructure.LegacyWebServices.IoC
{
    using Application.Candidate.Strategies;
    using Application.Interfaces.ReferenceData;
    using Application.ReferenceData;
    using Application.VacancyEtl;
    using Application.Interfaces.Vacancies;
    using CreateCandidate;
    using Domain.Interfaces.Mapping;
    using Configuration;
    using Mappers;
    using ReferenceDataProxy;
    using VacancyDetail;
    using VacancyDetailProxy;
    using VacancySummary;
    using VacancySummaryProxy;
    using StructureMap.Configuration.DSL;
    using ReferenceData;
    using Wcf;

    public class LegacyWebServicesRegistry : Registry
    {
        public LegacyWebServicesRegistry()
        {
            For<IMapper>().Use<VacancySummaryMapper>().Name = "LegacyWebServices.VacancySummaryMapper";
            For<IMapper>().Use<VacancyDetailMapper>().Name = "LegacyWebServices.VacancyDetailMapper";
            For<ILegacyServicesConfiguration>().Singleton().Use(LegacyServicesConfiguration.Instance);
            For<IWcfService<IVacancySummary>>().Use<WcfService<IVacancySummary>>();
            For<IWcfService<IVacancyDetails>>().Use<WcfService<IVacancyDetails>>();
            For<IWcfService<IReferenceData>>().Use<WcfService<IReferenceData>>();
            For<IWcfService<GatewayServiceContract>>().Use<WcfService<GatewayServiceContract>>();
            For<IVacancyIndexDataProvider>().Use<LegacyVacancyIndexDataProvider>().Ctor<IMapper>().Named("LegacyWebServices.VacancySummaryMapper");
            For<IVacancyDataProvider>().Use<LegacyVacancyDataProvider>().Ctor<IMapper>().Named("LegacyWebServices.VacancyDetailMapper");
            For<IReferenceDataProvider>().Use<LegacyReferenceDataProvider>();
            For<IReferenceDataService>().Use<ReferenceDataService>().Name = "Base.ReferenceDataService";
            For<IReferenceDataService>().Use<CachedReferenceDataService>().Ctor<IReferenceDataService>().Named("Base.ReferenceDataService");
            For<ILegacyCandidateProvider>().Use<LegacyCandidateProvider>();
        }
    }
}
