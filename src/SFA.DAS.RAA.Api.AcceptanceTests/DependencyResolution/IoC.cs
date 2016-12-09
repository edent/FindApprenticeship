namespace SFA.DAS.RAA.Api.AcceptanceTests.DependencyResolution
{
    using Apprenticeships.Application.Communication.IoC;
    using Apprenticeships.Application.Employer.IoC;
    using Apprenticeships.Application.Organisation.IoC;
    using Apprenticeships.Application.Provider.IoC;
    using Apprenticeships.Application.VacancyPosting.IoC;
    using Apprenticeships.Infrastructure.EmployerDataService.IoC;
    using Apprenticeships.Infrastructure.Logging.IoC;
    using Apprenticeships.Infrastructure.Postcode.IoC;
    using StructureMap;

    public static class IoC
    {
        public static IContainer Initialize()
        {
            /*var container = new Container(x =>
            {
                x.AddRegistry<CommonRegistry>();
                x.AddRegistry<LoggingRegistry>();
            });

            var configurationService = container.GetInstance<IConfigurationService>();
            var cacheConfig = configurationService.Get<CacheConfiguration>();
            var sqlConfiguration = configurationService.Get<SqlConfiguration>();
            var azureServiceBusConfiguration = configurationService.Get<AzureServiceBusConfiguration>();*/

            return new Container(c =>
            {
                //c.AddRegistry(new CommonRegistry(cacheConfig));
                c.AddRegistry<LoggingRegistry>();

                //c.AddCachingRegistry(cacheConfig);

                //c.AddRegistry(new RepositoriesRegistry(sqlConfiguration));

                //c.AddRegistry(new AzureServiceBusRegistry(azureServiceBusConfiguration));

                //c.AddRegistry<VacancyRepositoryRegistry>();
                //c.AddRegistry<ProviderRepositoryRegistry>();
                //c.AddRegistry<EmployerRepositoryRegistry>();

                c.AddRegistry<ProviderServiceRegistry>();
                c.AddRegistry<EmployerServiceRegistry>();
                c.AddRegistry<OrganisationServiceRegistry>();
                c.AddRegistry<EmployerDataServicesRegistry>();
                c.AddRegistry<CommunicationServiceRegistry>();

                c.AddRegistry<PostcodeRegistry>();
                c.AddRegistry<VacancyPostingServiceRegistry>();

                c.AddRegistry<AcceptanceTestsRegistry>();
            });
        }
    }
}