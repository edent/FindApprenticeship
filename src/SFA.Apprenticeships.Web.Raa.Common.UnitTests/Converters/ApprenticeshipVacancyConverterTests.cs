﻿namespace SFA.Apprenticeships.Web.Raa.Common.UnitTests.Converters
{
    using Common.Converters;
    using Domain.Entities.Raa.Vacancies;
    using FluentAssertions;
    using NUnit.Framework;
    using Ploeh.AutoFixture;

    [TestFixture]
    [Parallelizable]
    public class ApprenticeshipVacancyConverterTests
    {
        [Test]
        public void ApprenticeshipDurationTypes()
        {
            //Arrange
            var vacancy = new Fixture().Build<Vacancy>().With(v => v.VacancyType, VacancyType.Apprenticeship).Create();

            //Act
            var viewModel = vacancy.ConvertToVacancySummaryViewModel();

            //Assert
            viewModel.DurationTypes.Count.Should().Be(3);
            viewModel.DurationTypes[0].Value.Should().Be(DurationType.Weeks.ToString());
            viewModel.DurationTypes[0].Text.Should().Be(DurationType.Weeks.ToString().ToLower());
            viewModel.DurationTypes[1].Value.Should().Be(DurationType.Months.ToString());
            viewModel.DurationTypes[1].Text.Should().Be(DurationType.Months.ToString().ToLower());
            viewModel.DurationTypes[2].Value.Should().Be(DurationType.Years.ToString());
            viewModel.DurationTypes[2].Text.Should().Be(DurationType.Years.ToString().ToLower());
        }

        [Test]
        public void TraineeshipDurationTypes()
        {
            //Arrange
            var vacancy = new Fixture().Build<Vacancy>().With(v => v.VacancyType, VacancyType.Traineeship).Create();

            //Act
            var viewModel = vacancy.ConvertToVacancySummaryViewModel();

            //Assert
            viewModel.DurationTypes.Count.Should().Be(2);
            viewModel.DurationTypes[0].Value.Should().Be(DurationType.Weeks.ToString());
            viewModel.DurationTypes[0].Text.Should().Be(DurationType.Weeks.ToString().ToLower());
            viewModel.DurationTypes[1].Value.Should().Be(DurationType.Months.ToString());
            viewModel.DurationTypes[1].Text.Should().Be(DurationType.Months.ToString().ToLower());
        }
    }
}