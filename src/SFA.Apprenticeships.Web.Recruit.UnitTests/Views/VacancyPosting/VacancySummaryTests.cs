﻿using FluentAssertions;
using NUnit.Framework;
using RazorGenerator.Testing;
using SFA.Apprenticeships.Web.Recruit.ViewModels.Vacancy;
using SFA.Apprenticeships.Web.Recruit.Views.VacancyPosting;

namespace SFA.Apprenticeships.Web.Recruit.UnitTests.Views.VacancyPosting
{
    using Converters;

    [TestFixture]
    public class VacancySummaryTests : ViewUnitTest
    {
        [Test]
        public void ShouldShowSaveAndExitButton()
        {
            var details = new VacancySummary();

            var viewModel = new VacancySummaryViewModel
            {
                WageUnits = ApprenticeshipVacancyConverter.GetWageUnits(),
                DurationTypes = ApprenticeshipVacancyConverter.GetDurationTypes()
            };
           
            var view = details.RenderAsHtml(viewModel);

            view.GetElementbyId("vacancySummaryAndExit").Should().NotBeNull("Should exists a save and exit button");
        }
    }
}