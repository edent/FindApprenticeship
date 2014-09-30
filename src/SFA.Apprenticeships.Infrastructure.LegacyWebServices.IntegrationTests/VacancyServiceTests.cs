﻿namespace SFA.Apprenticeships.Infrastructure.LegacyWebServices.IntegrationTests
{
    using System.Collections.Generic;
    using System.Linq;
    using Application.VacancyEtl;
    using Domain.Entities.Vacancies;
    using FluentAssertions;
    using NUnit.Framework;
    using StructureMap;

    [TestFixture]
    public class VacancyServiceTests
    {
        [TestCase, Category("Integration"), Ignore("Passing when is run alone.")]
        public void ShouldReturnMappedCollectionFromGetVacancySummary()
        {
            var service = ObjectFactory.GetInstance<IVacancyIndexDataProvider>();
            List<VacancySummary> result = service.GetVacancySummaries(1).ToList();

            result.Should().NotBeNullOrEmpty();
            result.ForEach(r => r.VacancyLocationType.Should().Be(VacancyLocationType.NonNational));
        }
    }
}