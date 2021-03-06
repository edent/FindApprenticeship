﻿namespace SFA.Apprenticeships.Infrastructure.Repositories.Mongo.Employers.IoC
{
    using Domain.Raa.Interfaces.Repositories;

    using SFA.Apprenticeships.Application.Interfaces;
    using SFA.Infrastructure.Interfaces;
    using Sql.Schemas.dbo;
    using StructureMap.Configuration.DSL;

    public class EmployerRepositoryRegistry : Registry
    {
        public EmployerRepositoryRegistry()
        {
            For<IMapper>().Singleton().Use<EmployerMappers>().Name = "EmployerMappers";
            For<IEmployerReadRepository>().Use<EmployerRepository>().Ctor<IMapper>().Named("EmployerMappers");
            For<IEmployerWriteRepository>().Use<EmployerRepository>().Ctor<IMapper>().Named("EmployerMappers");
        }
    }
}