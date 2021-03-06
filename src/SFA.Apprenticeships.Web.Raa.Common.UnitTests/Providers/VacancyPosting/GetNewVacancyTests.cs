﻿namespace SFA.Apprenticeships.Web.Raa.Common.UnitTests.Providers.VacancyPosting
{
    using System;
    using Domain.Entities.Raa.Parties;
    using FluentAssertions;
    using Moq;
    using NUnit.Framework;
    using Ploeh.AutoFixture;

    [TestFixture]
    [Parallelizable]
    public class GetNewVacancyTests : TestBase
    {
        private const int ProviderSiteId = 1;
        private const int EmployerId = 2;
        private const int VacancyOwnerRelationshipId = 4;
        private static readonly Guid VacancyGuid = Guid.NewGuid();

        private static readonly VacancyOwnerRelationship VacancyOwnerRelationship = new VacancyOwnerRelationship
        {
            ProviderSiteId = ProviderSiteId,
            EmployerId = EmployerId
        };

        [SetUp]
        public void SetUp()
        {
            MockProviderService
                .Setup(mock => mock.GetVacancyOwnerRelationship(VacancyOwnerRelationshipId, true))
                .Returns(VacancyOwnerRelationship);
            MockEmployerService.Setup(s => s.GetEmployer(VacancyOwnerRelationship.EmployerId, true))
                .Returns(new Fixture().Build<Employer>().Create());
        }

        [Test]
        public void ShouldDefaultToPreferredSite()
        {
            // Arrange.
            var provider = GetVacancyPostingProvider();

            // Act.
            var viewModel = provider.GetNewVacancyViewModel(VacancyOwnerRelationshipId, VacancyGuid, null);

            // Assert.
            MockProviderService.Verify(mock =>
                mock.GetVacancyOwnerRelationship(VacancyOwnerRelationshipId, true), Times.Once);
            MockEmployerService.Verify(s => s.GetEmployer(EmployerId, true), Times.Once);

            viewModel.Should().NotBeNull();
            viewModel.VacancyOwnerRelationship.ProviderSiteId.Should().Be(ProviderSiteId);
        }
    }
}
