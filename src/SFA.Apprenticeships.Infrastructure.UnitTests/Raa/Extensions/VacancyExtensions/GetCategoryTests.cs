﻿namespace SFA.Apprenticeships.Infrastructure.UnitTests.Raa.Extensions.VacancyExtensions
{
    using System.Collections.Generic;
    using Domain.Entities.Raa.Vacancies;
    using Domain.Entities.ReferenceData;
    using FluentAssertions;
    using Infrastructure.Raa.Extensions;
    using NUnit.Framework;
    using Ploeh.AutoFixture;

    [TestFixture]
    [Parallelizable]
    public class GetCategoryTests
    {
        private List<Category> _categories;

        [SetUp]
        public void SetUp()
        {
            _categories = new List<Category>
            {
                new Category(15, "SSAT1.ICT", "Information and Communication Technology", CategoryType.SectorSubjectAreaTier1, CategoryStatus.Active,
                    new List<Category>
                    {
                        new Category(101, "FW.101", "Software Developer", "SSAT1.ICT", CategoryType.Framework, CategoryStatus.Active),
                        new Category(201, "STDSEC.201", "Digital Industries", "SSAT1.ICT", CategoryType.StandardSector, CategoryStatus.Active, 
                            new List<Category>
                            {
                                new Category(1, "STD.1", "Network Engineer", "STDSEC.201", CategoryType.Standard, CategoryStatus.Active),
                                new Category(2, "STD.2", "Software Developer", "STDSEC.201", CategoryType.Standard, CategoryStatus.Active)
                            }
                        )
                    }
                ),
                new Category(15, "SSAT1.AHR", "Business, Administration and Law", CategoryType.SectorSubjectAreaTier1, CategoryStatus.Active,
                    new List<Category>
                    {
                        new Category(0, "FW.589|STDSEC.15", "Insurance", "SSAT1.AHR", CategoryType.Combined, CategoryStatus.Active,
                            new List<Category>
                            {
                                new Category(41, "STD.41", "Insurance Practitioner", "FW.589|STDSEC.15", CategoryType.Standard, CategoryStatus.Active)
                            }
                        )
                    }
                )
            };
        }

        [TestCase(VacancyType.Apprenticeship, "101", "SSAT1.ICT", "Information and Communication Technology")]
        [TestCase(VacancyType.Apprenticeship, "FW.101", "SSAT1.ICT", "Information and Communication Technology")]
        [TestCase(VacancyType.Apprenticeship, "589", "SSAT1.AHR", "Business, Administration and Law")]
        [TestCase(VacancyType.Apprenticeship, "FW.589", "SSAT1.AHR", "Business, Administration and Law")]
        [TestCase(VacancyType.Apprenticeship, null, "SSAT1.UNKNOWN", "Unknown Sector Subject Area Tier 1")]
        [TestCase(VacancyType.Apprenticeship, "XXX", "SSAT1.UNKNOWN", "Unknown Sector Subject Area Tier 1")]
        [TestCase(VacancyType.Traineeship, "101", "SSAT1.INVALID", "Invalid Sector Subject Area Tier 1")]
        [TestCase(VacancyType.Traineeship, null, "SSAT1.INVALID", "Invalid Sector Subject Area Tier 1")]
        public void ShouldGetCategoryForFramework(
            VacancyType vacancyType, string frameworkCodeName, string expectedCategoryCode, string expectedCategoryName)
        {
            // Arrange.
            var vacancySummary = new Fixture()
                .Build<VacancySummary>()
                .With(each => each.VacancyType, vacancyType)
                .With(each => each.TrainingType, TrainingType.Frameworks)
                .With(each => each.FrameworkCodeName, frameworkCodeName)
                .Create();

            // Act.
            var category = vacancySummary.GetCategory(_categories);

            // Assert.
            category.CodeName.Should().Be(expectedCategoryCode);
            category.FullName.Should().Be(expectedCategoryName);
        }

        [TestCase(VacancyType.Apprenticeship, 2, "SSAT1.ICT", "Information and Communication Technology")]
        [TestCase(VacancyType.Apprenticeship, 41, "SSAT1.AHR", "Business, Administration and Law")]
        [TestCase(VacancyType.Apprenticeship, null, "SSAT1.UNKNOWN", "Unknown Sector Subject Area Tier 1")]
        [TestCase(VacancyType.Apprenticeship, -1, "SSAT1.UNKNOWN", "Unknown Sector Subject Area Tier 1")]
        [TestCase(VacancyType.Traineeship, 2, "SSAT1.INVALID", "Invalid Sector Subject Area Tier 1")]
        [TestCase(VacancyType.Traineeship, null, "SSAT1.INVALID", "Invalid Sector Subject Area Tier 1")]
        public void ShouldGetCategoryForStandard(
            VacancyType vacancyType, int? standardId, string expectedCategoryCode, string expectedCategoryName)
        {
            // Arrange.
            var vacancySummary = new Fixture()
                .Build<VacancySummary>()
                .With(each => each.VacancyType, vacancyType)
                .With(each => each.TrainingType, TrainingType.Standards)
                .With(each => each.StandardId, standardId)
                .Create();

            // Act.
            var category = vacancySummary.GetCategory(_categories);

            // Assert.
            category.CodeName.Should().Be(expectedCategoryCode);
            category.FullName.Should().Be(expectedCategoryName);
        }

        [TestCase(VacancyType.Traineeship, "ICT", "SSAT1.ICT", "Information and Communication Technology")]
        [TestCase(VacancyType.Traineeship, "SSAT1.ICT", "SSAT1.ICT", "Information and Communication Technology")]
        [TestCase(VacancyType.Traineeship, "AHR", "SSAT1.AHR", "Business, Administration and Law")]
        [TestCase(VacancyType.Traineeship, "SSAT1.AHR", "SSAT1.AHR", "Business, Administration and Law")]
        [TestCase(VacancyType.Traineeship, null, "SSAT1.UNKNOWN", "Unknown Sector Subject Area Tier 1")]
        [TestCase(VacancyType.Traineeship, "XXX", "SSAT1.UNKNOWN", "Unknown Sector Subject Area Tier 1")]
        [TestCase(VacancyType.Apprenticeship, "ICT", "SSAT1.INVALID", "Invalid Sector Subject Area Tier 1")]
        [TestCase(VacancyType.Apprenticeship, null, "SSAT1.INVALID", "Invalid Sector Subject Area Tier 1")]
        public void ShouldGetCategoryForSector(
            VacancyType vacancyType, string sectorCodeName, string expectedCategoryCode, string expectedCategoryName)
        {
            // Arrange.
            var vacancySummary = new Fixture()
                .Build<VacancySummary>()
                .With(each => each.VacancyType, vacancyType)
                .With(each => each.TrainingType, TrainingType.Sectors)
                .With(each => each.SectorCodeName, sectorCodeName)
                .Create();

            // Act.
            var category = vacancySummary.GetCategory(_categories);

            // Assert.
            category.CodeName.Should().Be(expectedCategoryCode);
            category.FullName.Should().Be(expectedCategoryName);
        }

        [TestCase(VacancyType.Apprenticeship, "101", "SSAT1.ICT", "Information and Communication Technology")]
        [TestCase(VacancyType.Apprenticeship, "FW.101", "SSAT1.ICT", "Information and Communication Technology")]
        [TestCase(VacancyType.Apprenticeship, "589", "SSAT1.AHR", "Business, Administration and Law")]
        [TestCase(VacancyType.Apprenticeship, "FW.589", "SSAT1.AHR", "Business, Administration and Law")]
        [TestCase(VacancyType.Apprenticeship, null, "SSAT1.UNKNOWN", "Unknown Sector Subject Area Tier 1")]
        [TestCase(VacancyType.Apprenticeship, "XXX", "SSAT1.UNKNOWN", "Unknown Sector Subject Area Tier 1")]
        [TestCase(VacancyType.Traineeship, "101", "SSAT1.INVALID", "Invalid Sector Subject Area Tier 1")]
        [TestCase(VacancyType.Traineeship, null, "SSAT1.INVALID", "Invalid Sector Subject Area Tier 1")]
        public void ShouldGetCategoryForUnknown(
            VacancyType vacancyType, string frameworkCodeName, string expectedCategoryCode, string expectedCategoryName)
        {
            // Arrange.
            var vacancySummary = new Fixture()
                .Build<VacancySummary>()
                .With(each => each.VacancyType, vacancyType)
                .With(each => each.TrainingType, TrainingType.Unknown)
                .With(each => each.FrameworkCodeName, frameworkCodeName)
                .Create();

            // Act.
            var category = vacancySummary.GetCategory(_categories);

            // Assert.
            category.CodeName.Should().Be(expectedCategoryCode);
            category.FullName.Should().Be(expectedCategoryName);
        }

        [TestCase(VacancyType.Apprenticeship, "101", "FW.101", "Software Developer")]
        [TestCase(VacancyType.Apprenticeship, "FW.101", "FW.101", "Software Developer")]
        [TestCase(VacancyType.Apprenticeship, "589", "FW.589|STDSEC.15", "Insurance")]
        [TestCase(VacancyType.Apprenticeship, "FW.589", "FW.589|STDSEC.15", "Insurance")]
        [TestCase(VacancyType.Apprenticeship, null, "FW.UNKNOWN", "Unknown Framework")]
        [TestCase(VacancyType.Apprenticeship, "XXX", "FW.UNKNOWN", "Unknown Framework")]
        [TestCase(VacancyType.Traineeship, "101", "FW.INVALID", "Invalid Framework")]
        [TestCase(VacancyType.Traineeship, null, "FW.INVALID", "Invalid Framework")]
        public void ShouldGetSubCategoryForFramework(
            VacancyType vacancyType, string frameworkCodeName, string expectedSubCategoryCode, string expectedCategoryName)
        {
            // Arrange.
            var vacancySummary = new Fixture()
                .Build<VacancySummary>()
                .With(each => each.VacancyType, vacancyType)
                .With(each => each.TrainingType, TrainingType.Frameworks)
                .With(each => each.FrameworkCodeName, frameworkCodeName)
                .Create();

            // Act.
            var subCategory = vacancySummary.GetSubCategory(_categories);

            // Assert.
            subCategory.CodeName.Should().Be(expectedSubCategoryCode);
            subCategory.FullName.Should().Be(expectedCategoryName);
        }

        [TestCase(VacancyType.Apprenticeship, 2, "STDSEC.201", "Digital Industries > Software Developer")]
        [TestCase(VacancyType.Apprenticeship, 41, "FW.589|STDSEC.15", "Insurance > Insurance Practitioner")]
        [TestCase(VacancyType.Apprenticeship, null, "STDSEC.UNKNOWN", "Unknown Standard Sector")]
        [TestCase(VacancyType.Apprenticeship, -1, "STDSEC.UNKNOWN", "Unknown Standard Sector")]
        [TestCase(VacancyType.Traineeship, 2, "STDSEC.INVALID", "Invalid Standard Sector")]
        [TestCase(VacancyType.Traineeship, null, "STDSEC.INVALID", "Invalid Standard Sector")]
        public void ShouldGetSubCategoryForStandard(
            VacancyType vacancyType, int? standardId, string expectedSubCategoryCode, string expectedCategoryName)
        {
            // Arrange.
            var vacancySummary = new Fixture()
                .Build<VacancySummary>()
                .With(each => each.VacancyType, vacancyType)
                .With(each => each.TrainingType, TrainingType.Standards)
                .With(each => each.StandardId, standardId)
                .Create();

            // Act.
            var subCategory = vacancySummary.GetSubCategory(_categories);

            // Assert.
            subCategory.CodeName.Should().Be(expectedSubCategoryCode);
            subCategory.FullName.Should().Be(expectedCategoryName);
        }

        [TestCase(VacancyType.Apprenticeship, "ICT", "SEC.INVALID", "Invalid Sector")]
        [TestCase(VacancyType.Apprenticeship, "SEC.ICT", "SEC.INVALID", "Invalid Sector")]
        [TestCase(VacancyType.Apprenticeship, null, "SEC.INVALID", "Invalid Sector")]
        [TestCase(VacancyType.Apprenticeship, "XXX", "SEC.INVALID", "Invalid Sector")]
        [TestCase(VacancyType.Traineeship, "ICT", "SEC.INVALID", "Invalid Sector")]
        [TestCase(VacancyType.Traineeship, null, "SEC.INVALID", "Invalid Sector")]
        public void ShouldGetSubCategoryForSector(
            VacancyType vacancyType, string sectorCodeName, string expectedSubCategoryCode, string expectedCategoryName)
        {
            // Arrange.
            var vacancySummary = new Fixture()
                .Build<VacancySummary>()
                .With(each => each.VacancyType, vacancyType)
                .With(each => each.TrainingType, TrainingType.Sectors)
                .With(each => each.SectorCodeName, sectorCodeName)
                .Create();

            // Act.
            var subCategory = vacancySummary.GetSubCategory(_categories);

            // Assert.
            subCategory.CodeName.Should().Be(expectedSubCategoryCode);
            subCategory.FullName.Should().Be(expectedCategoryName);
        }

        [TestCase(VacancyType.Apprenticeship, "101", "FW.101", "Software Developer")]
        [TestCase(VacancyType.Apprenticeship, "FW.101", "FW.101", "Software Developer")]
        [TestCase(VacancyType.Apprenticeship, "589", "FW.589|STDSEC.15", "Insurance")]
        [TestCase(VacancyType.Apprenticeship, "FW.589", "FW.589|STDSEC.15", "Insurance")]
        [TestCase(VacancyType.Apprenticeship, null, "FW.UNKNOWN", "Unknown Framework")]
        [TestCase(VacancyType.Apprenticeship, "XXX", "FW.UNKNOWN", "Unknown Framework")]
        [TestCase(VacancyType.Traineeship, "101", "FW.INVALID", "Invalid Framework")]
        [TestCase(VacancyType.Traineeship, null, "FW.INVALID", "Invalid Framework")]
        public void ShouldGetSubCategoryForUnknown(
            VacancyType vacancyType, string frameworkCodeName, string expectedSubCategoryCode, string expectedCategoryName)
        {
            // Arrange.
            var vacancySummary = new Fixture()
                .Build<VacancySummary>()
                .With(each => each.VacancyType, vacancyType)
                .With(each => each.TrainingType, TrainingType.Unknown)
                .With(each => each.FrameworkCodeName, frameworkCodeName)
                .Create();

            // Act.
            var subCategory = vacancySummary.GetSubCategory(_categories);

            // Assert.
            subCategory.CodeName.Should().Be(expectedSubCategoryCode);
            subCategory.FullName.Should().Be(expectedCategoryName);
        }
    }
}