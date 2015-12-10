﻿namespace SFA.Apprenticeships.Infrastructure.Raa.IoC
{
    using Application.Vacancies;
    using Application.Vacancy;
    using Common.Configuration;
    using Domain.Entities.Vacancies.Apprenticeships;
    using Domain.Entities.Vacancies.Traineeships;
    using StructureMap.Configuration.DSL;

    public class RaaRegistry : Registry
    {
        public RaaRegistry(ServicesConfiguration servicesConfiguration)
        {
            if (servicesConfiguration.ServiceImplementation == "Raa")
            {
                For<IVacancyIndexDataProvider>().Use<VacancyIndexDataProvider>();

                For<IVacancyDataProvider<ApprenticeshipVacancyDetail>>()
                    .Use<ApprenticeshipVacancyDataProvider>();

                For<IVacancyDataProvider<TraineeshipVacancyDetail>>()
                    .Use<TraineeshipVacancyDataProvider>();
            }
        }
    }
}