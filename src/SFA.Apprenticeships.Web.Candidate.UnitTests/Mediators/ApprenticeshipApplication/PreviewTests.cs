﻿namespace SFA.Apprenticeships.Web.Candidate.UnitTests.Mediators.ApprenticeshipApplication
{
    using System;
    using Candidate.Mediators;
    using Candidate.ViewModels.Applications;
    using Domain.Entities.Applications;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class PreviewTests : TestsBase
    {
        private const int ValidVacancyId = 1;
        private const int InvalidVacancyId = 99999;

        [Test]
        public void VacancyNotFound()
        {
            ApprenticeshipApplicationProvider.Setup(p => p.GetOrCreateApplicationViewModel(It.IsAny<Guid>(), InvalidVacancyId)).Returns(new ApprenticeshipApplicationViewModel { Status = ApplicationStatuses.ExpiredOrWithdrawn });
            
            var response = Mediator.Preview(Guid.NewGuid(), InvalidVacancyId);

            response.AssertCode(Codes.ApprenticeshipApplication.Preview.VacancyNotFound, false);
        }

        [Test]
        public void HasError()
        {
            ApprenticeshipApplicationProvider.Setup(p => p.GetOrCreateApplicationViewModel(It.IsAny<Guid>(), InvalidVacancyId)).Returns(new ApprenticeshipApplicationViewModel("Vacancy not found"));
            
            var response = Mediator.Preview(Guid.NewGuid(), InvalidVacancyId);

            response.AssertCode(Codes.ApprenticeshipApplication.Preview.HasError, false);
        }

        [Test]
        public void Ok()
        {
            ApprenticeshipApplicationProvider.Setup(p => p.GetOrCreateApplicationViewModel(It.IsAny<Guid>(), ValidVacancyId)).Returns(new ApprenticeshipApplicationViewModel());
            
            var response = Mediator.Preview(Guid.NewGuid(), ValidVacancyId);

            response.AssertCode(Codes.ApprenticeshipApplication.Preview.Ok, true);
        }
    }
}