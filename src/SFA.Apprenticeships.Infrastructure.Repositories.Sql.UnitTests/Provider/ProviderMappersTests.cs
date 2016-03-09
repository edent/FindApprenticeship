﻿namespace SFA.Apprenticeships.Infrastructure.Repositories.Sql.UnitTests.Provider
{
    using FluentAssertions;
    using NUnit.Framework;
    using Ploeh.AutoFixture;
    using Schemas.Provider;
    using DatabaseProvider = Schemas.Provider.Entities.Provider;
    using DomainProvider = Domain.Entities.Raa.Parties.Provider;

    [TestFixture]
    public class ProviderMappersTests
    {
        private ProviderMappers _mapper;

        [SetUp]
        public void SetUp()
        {
            _mapper = new ProviderMappers();
            _mapper.Initialise();
        }

        [Test]
        public void ShouldBeValidMapperConfiguration()
        {
            // Assert
            _mapper.Mapper.AssertConfigurationIsValid();
        }

        [Test]
        public void ShouldMapFromDatabaseToDomainProvider()
        {
            // Arrange.
            var dbProvider = new Fixture().Create<DatabaseProvider>();

            // Act.
            var domainProvider = _mapper.Map<DatabaseProvider, DomainProvider>(dbProvider);

            // Assert.
            domainProvider.ProviderId.Should().Be(dbProvider.ProviderId);
            domainProvider.Ukprn.Should().Be(dbProvider.Ukprn.ToString());
            domainProvider.Name.Should().Be(dbProvider.FullName);
        }
    }
}