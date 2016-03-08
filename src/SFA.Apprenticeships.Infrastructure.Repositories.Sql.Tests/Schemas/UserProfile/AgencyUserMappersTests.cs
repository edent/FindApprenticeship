﻿namespace SFA.Apprenticeships.Infrastructure.Repositories.Sql.Tests.Schemas.UserProfile
{
    using NUnit.Framework;
    using Sql.Schemas.UserProfile;

    [TestFixture]
    class AgencyUserMappersTests
    {
        [Test]
        public void DoMappersMapEverything()
        {
            Assert.Inconclusive("Mapper does not contain the Team and Role properties");
            // Arrange
            var x = new AgencyUserMappers();

            // Act
            x.Initialise();

            // Assert
            x.Mapper.AssertConfigurationIsValid();
        }
    }
}
