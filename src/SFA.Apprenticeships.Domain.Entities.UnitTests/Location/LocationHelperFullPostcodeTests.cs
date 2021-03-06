﻿namespace SFA.Apprenticeships.Domain.Entities.UnitTests.Location
{
    using NUnit.Framework;
    using Locations;

    [TestFixture]
    [Parallelizable]
    public class LocationHelperFullPostcodeTests
    {
        [TestCase("CV12WT")]
        [TestCase("cv12wt")]
        [TestCase("CV1 2WT")]
        [TestCase(" CV1 2WT ")]
        public void ShouldBeIdentitiedAsPostcode(string postcode)
        {
            Assert.IsTrue(LocationHelper.IsPostcode(postcode));
        }

        [TestCase("London")]
        [TestCase(" C V 1 2WT ")]
        [TestCase("")]
        [TestCase(default(string))]
        [TestCase(" CV1 2WT , 99")]
        public void ShouldNotBeIdentitiedAsPostcode(string postcode)
        {
            Assert.IsFalse(LocationHelper.IsPostcode(postcode));
        }
    }
}
