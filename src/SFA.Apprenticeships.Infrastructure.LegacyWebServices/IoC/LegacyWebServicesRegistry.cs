﻿namespace SFA.Apprenticeships.Infrastructure.LegacyWebServices.IoC
{
    using Application.ApplicationUpdate;
    using Application.Candidate;
    using Application.Vacancy;
    using Application.VacancyEtl;
    using CreateApplication;
    using CreateCandidate;
    using Domain.Entities.Vacancies.Apprenticeships;
    using Domain.Entities.Vacancies.Traineeships;
    using Domain.Interfaces.Mapping;
    using GatewayServiceProxy;
    using GetCandidateApplicationStatuses;
    using Mappers;
    using Mappers.Apprenticeships;
    using StructureMap.Configuration.DSL;
    using VacancyDetail;
    using VacancySummary;
    using Wcf;

    public class LegacyWebServicesRegistry : Registry
    {
        public LegacyWebServicesRegistry(): this(false) { }

        public LegacyWebServicesRegistry(bool useCache)
        {
            For<IMapper>().Use<LegacyVacancySummaryMapper>().Name = "LegacyWebServices.LegacyVacancySummaryMapper";
            For<IMapper>().Use<LegacyApprenticeshipVacancyDetailMapper>().Name = "LegacyWebServices.LegacyApprenticeshipVacancyDetailMapper";
            For<IMapper>().Use<LegacyTraineeshipVacancyDetailMapper>().Name = "LegacyWebServices.LegacyTraineeshipVacancyDetailMapper";
            For<IWcfService<GatewayServiceContract>>().Use<WcfService<GatewayServiceContract>>();

            For<IVacancyIndexDataProvider>()
                .Use<LegacyVacancyIndexDataProvider>()
                .Ctor<IMapper>()
                .Named("LegacyWebServices.LegacyVacancySummaryMapper");

            #region Vacancy Data Service And Providers

            For<IVacancyDataProvider<ApprenticeshipVacancyDetail>>()
                .Use<LegacyVacancyDataProvider<ApprenticeshipVacancyDetail>>()
                .Ctor<IMapper>()
                .Named("LegacyWebServices.LegacyApprenticeshipVacancyDetailMapper")
                .Name = "LegacyApprenticeshipVacancyDataProvider";

            For<IVacancyDataProvider<TraineeshipVacancyDetail>>()
                .Use<LegacyVacancyDataProvider<TraineeshipVacancyDetail>>()
                .Ctor<IMapper>()
                .Named("LegacyWebServices.LegacyTraineeshipVacancyDetailMapper")
                .Name = "LegacyTraineeshipVacancyDataProvider";

            if (useCache)
            {
                For<IVacancyDataProvider<ApprenticeshipVacancyDetail>>()
                    .Use<CachedLegacyVacancyDataProvider<ApprenticeshipVacancyDetail>>()
                    .Ctor<IVacancyDataProvider<ApprenticeshipVacancyDetail>>()
                    .IsTheDefault()
                    .Ctor<IVacancyDataProvider<ApprenticeshipVacancyDetail>>()
                    .Named("LegacyApprenticeshipVacancyDataProvider");

                For<IVacancyDataProvider<TraineeshipVacancyDetail>>()
                    .Use<CachedLegacyVacancyDataProvider<TraineeshipVacancyDetail>>()
                    .Ctor<IVacancyDataProvider<TraineeshipVacancyDetail>>()
                    .IsTheDefault()
                    .Ctor<IVacancyDataProvider<TraineeshipVacancyDetail>>()
                    .Named("LegacyTraineeshipVacancyDataProvider");
            }

            For<IVacancyStatusProvider>().Use<LegacyVacancyStatusProvider>();

            #endregion

            #region Candidate and Application Providers

            For<ILegacyCandidateProvider>().Use<LegacyCandidateProvider>();

            For<ILegacyApplicationProvider>().Use<LegacyApplicationProvider>();

            For<IMapper>().Use<ApplicationStatusSummaryMapper>()
                .Name = "LegacyWebServices.ApplicationStatusSummaryMapper";

            For<ILegacyApplicationStatusesProvider>()
                .Use<LegacyCandidateApplicationStatusesProvider>()
                .Ctor<IMapper>()
                .Named("LegacyWebServices.ApplicationStatusSummaryMapper")
                .Name = "LegacyCandidateApplicationStatusesProvider";

            #endregion
        }
    }
}