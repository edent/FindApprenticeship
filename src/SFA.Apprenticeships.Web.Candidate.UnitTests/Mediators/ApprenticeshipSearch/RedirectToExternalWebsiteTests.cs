﻿namespace SFA.Apprenticeships.Web.Candidate.UnitTests.Mediators.ApprenticeshipSearch
{
    using Candidate.Mediators.Search;
    using Candidate.ViewModels.VacancySearch;
    using Common.Constants;
    using Common.UnitTests.Mediators;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable]
    public class RedirectToExternalWebsiteTests : TestsBase
    {
        private const string Id = "1";

        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(" 491802")]
        [TestCase("VAC000547307")]
        [TestCase("[[imgUrl]]")]
        [TestCase("separator.png")]
        public void GivenInvalidVacancyIdString_ThenVacancyNotFound(string vacancyId)
        {
            var response = Mediator.RedirectToExternalWebsite(vacancyId);

            response.AssertCode(ApprenticeshipSearchMediatorCodes.RedirectToExternalWebsite.VacancyNotFound, false);
        }

        [Test]
        public void Ok()
        {
            //Arrange
            var vacancyDetailViewModel = new ApprenticeshipVacancyDetailViewModel();

            ApprenticeshipVacancyProvider.Setup(p => p.IncrementClickThroughFor(It.IsAny<int>()))
                .Returns(vacancyDetailViewModel);

            //Act
            var response = Mediator.RedirectToExternalWebsite(Id);

            //Assert
            response.AssertCode(ApprenticeshipSearchMediatorCodes.RedirectToExternalWebsite.Ok, true);
        }

        [Test]
        public void VacancyHasError()
        {
            //Arrange
            const string message = "The vacancy has an error";

            var vacancyDetailViewModel = new ApprenticeshipVacancyDetailViewModel
            {
                ViewModelMessage = message
            };

            ApprenticeshipVacancyProvider.Setup(p => p.IncrementClickThroughFor(It.IsAny<int>()))
                .Returns(vacancyDetailViewModel);

            //Act
            var response = Mediator.RedirectToExternalWebsite(Id);

            //Assert
            response.AssertMessage(ApprenticeshipSearchMediatorCodes.RedirectToExternalWebsite.VacancyHasError, message,
                UserMessageLevel.Warning, true);
        }

        [Test]
        public void VacancyNotFound()
        {
            var response = Mediator.RedirectToExternalWebsite(Id);

            response.AssertCode(ApprenticeshipSearchMediatorCodes.RedirectToExternalWebsite.VacancyNotFound, false);
        }
    }
}