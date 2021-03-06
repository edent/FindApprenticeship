﻿namespace SFA.Apprenticeships.Infrastructure.Repositories.Sql.UnitTests.Provider
{
    using System;
    using FluentAssertions;
    using NUnit.Framework;
    using Ploeh.AutoFixture;
    using Sql.Schemas.Provider;
    using Database = Schemas.Provider.Entities;
    using Domain = Domain.Entities.Raa.Users;

    [TestFixture]
    [Parallelizable]
    public class ProviderUserMappersTests
    {
        private ProviderUserMappers _mapper;

        [SetUp]
        public void SetUp()
        {
            _mapper = new ProviderUserMappers();
        }

        [Test]
        public void ShouldCreateMap()
        {
            // Assert.
            _mapper.Mapper.AssertConfigurationIsValid();
        }

        [TestCase(903008386)]
        [TestCase(null)]
        public void ShouldMapFromDomainToDatabaseProviderUser(int? preferredProviderSiteId)
        {
            // Arrange.
            var fixture = new Fixture();

            var source = fixture
                .Build<Domain.ProviderUser>()
                .With(each => each.PreferredProviderSiteId, preferredProviderSiteId)
                .Create();

            // Act.
            var destination = _mapper.Map<Domain.ProviderUser, Database.ProviderUser>(source);

            // Assert.
            destination.Should().NotBeNull();

            destination.ProviderUserId.Should().Be(source.ProviderUserId);
            destination.ProviderId.Should().Be(source.ProviderId);
            destination.ProviderUserGuid.Should().Be(source.ProviderUserGuid);
            destination.CreatedDateTime.Should().Be(source.CreatedDateTime);
            destination.UpdatedDateTime.Should().Be(source.UpdatedDateTime);
            destination.Username.Should().Be(source.Username);
            destination.Fullname.Should().Be(source.Fullname);
            destination.PreferredProviderSiteId.Should().Be(source.PreferredProviderSiteId);
            destination.Email.Should().Be(source.Email);
            destination.EmailVerificationCode.Should().Be(source.EmailVerificationCode);
            destination.EmailVerifiedDateTime.Should().Be(source.EmailVerifiedDate);
            destination.PhoneNumber.Should().Be(source.PhoneNumber);
        }

        [TestCase(Domain.ProviderUserStatus.Registered, 10)]
        [TestCase(Domain.ProviderUserStatus.EmailVerified, 20)]
        public void ShouldMapFromDomainToDatabaseProviderUserStatus(
            Domain.ProviderUserStatus providerUserStatus, int expectedProviderUserStatusId)
        {
            // Arrange.
            var fixture = new Fixture();

            var source = fixture
                .Build<Domain.ProviderUser>()
                .With(each => each.PreferredProviderSiteId, fixture.Create<int>())
                .With(each => each.Status, providerUserStatus)
                .Create();

            // Act.
            var destination = _mapper.Map<Domain.ProviderUser, Database.ProviderUser>(source);

            // Assert.
            destination.Should().NotBeNull();
            destination.ProviderUserStatusId.Should().Be(expectedProviderUserStatusId);
        }

        [TestCase(903008386)]
        [TestCase(null)]
        public void ShouldMapFromDatabaseToDomainProviderUser(int? preferredProviderSiteId)
        {
            // Arrange.
            var fixture = new Fixture();

            var source = fixture
                .Build<Database.ProviderUser>()
                .With(each => each.PreferredProviderSiteId, preferredProviderSiteId)
                .With(each => each.ProviderUserStatusId, (int)Domain.ProviderUserStatus.Registered)
                .Create();

            // Act.
            var destination = _mapper.Map<Database.ProviderUser, Domain.ProviderUser>(source);

            // Assert.
            destination.Should().NotBeNull();

            destination.ProviderUserId.Should().Be(source.ProviderUserId);
            destination.ProviderId.Should().Be(source.ProviderId);
            destination.ProviderUserGuid.Should().Be(source.ProviderUserGuid);
            destination.CreatedDateTime.Should().Be(source.CreatedDateTime);
            destination.UpdatedDateTime.Should().Be(source.UpdatedDateTime);
            destination.Username.Should().Be(source.Username);
            destination.Fullname.Should().Be(source.Fullname);

            destination.PreferredProviderSiteId.Should().Be(source.PreferredProviderSiteId);

            destination.Email.Should().Be(source.Email);
            destination.EmailVerificationCode.Should().Be(source.EmailVerificationCode);
            destination.EmailVerifiedDate.Should().Be(source.EmailVerifiedDateTime);
            destination.PhoneNumber.Should().Be(source.PhoneNumber);
        }

        [Test]
        public void ShouldThrowWhenCannotMapFromSqlToDomainProviderUserStatus()
        {
            // Arrange.
            var fixture = new Fixture();

            var source = fixture
                .Build<Database.ProviderUser>()
                .With(each => each.ProviderUserStatusId, 42)
                .Create();

            // Act.
            Action action = () => _mapper.Map<Database.ProviderUser, Domain.ProviderUser>(source);

            // Assert.
            action.ShouldThrow<Exception>();
        }
    }
}
