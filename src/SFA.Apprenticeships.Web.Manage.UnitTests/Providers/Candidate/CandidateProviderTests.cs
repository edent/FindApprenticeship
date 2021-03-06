﻿namespace SFA.Apprenticeships.Web.Manage.UnitTests.Providers.Candidate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Application.Interfaces.Applications;
    using Application.Interfaces.Candidates;
    using Application.Interfaces.Employers;
    using Application.Interfaces.Providers;
    using Application.Interfaces.VacancyPosting;
    using Domain.Entities.Candidates;
    using Domain.Entities.Locations;
    using Domain.Interfaces.Repositories;
    using FluentAssertions;
    using Moq;
    using NUnit.Framework;
    using Ploeh.AutoFixture;
    using Raa.Common.Mappers;
    using Raa.Common.Providers;
    using Raa.Common.ViewModels.Candidate;
    using Application.Interfaces;
    using Application.Interfaces.Security;
    using Raa.Common.ViewModels.Application;

    [TestFixture]
    [Parallelizable]
    public class CandidateProviderTests
    {
        private ICandidateProvider _provider;
        private Mock<ICandidateSearchService> _candidateSearchService;
        private Mock<IVacancyQAProvider> _vacancyQAProvider;

        [SetUp]
        public void SetUp()
        {
            _candidateSearchService = new Mock<ICandidateSearchService>();
            _vacancyQAProvider = new Mock<IVacancyQAProvider>();      
            _provider = new CandidateProvider(_candidateSearchService.Object, new CandidateMappers(), new Mock<ICandidateApplicationService>().Object, new Mock<IApprenticeshipApplicationService>().Object, new Mock<ITraineeshipApplicationService>().Object, new Mock<IVacancyPostingService>().Object, new Mock<IProviderService>().Object, new Mock<IEmployerService>().Object, new Mock<ILogService>().Object, new Mock<IConfigurationService>().Object, new Mock<IEncryptionService<AnonymisedApplicationLink>>().Object, new Mock<IDateTimeService>().Object, _vacancyQAProvider.Object);
        }

        [Test]
        public void TestRequestConversion()
        {
            //Arrange
            var viewModel = new CandidateSearchViewModel
            {
                FirstName = "First",
                LastName = "Last",
                DateOfBirth = "10/02/1990",
                Postcode = "CV1 2WT"
            };

            //Act
            _provider.SearchCandidates(viewModel, null);

            //Assert
            var expectedDate = new DateTime(1990, 2, 10);
            _candidateSearchService.Verify(s => s.SearchCandidates(It.Is<CandidateSearchRequest>(r => 
                r.FirstName == viewModel.FirstName 
                && r.LastName == viewModel.LastName 
                && r.DateOfBirth == expectedDate 
                && r.Postcode == viewModel.Postcode)));
        }

        [Test]
        public void TestEmptyDateRequestConversion()
        {
            //Arrange
            var viewModel = new CandidateSearchViewModel
            {
                FirstName = "First",
                LastName = "Last",
                DateOfBirth = "",
                Postcode = "CV1 2WT"
            };

            //Act
            _provider.SearchCandidates(viewModel, null);

            //Assert
            _candidateSearchService.Verify(s => s.SearchCandidates(It.Is<CandidateSearchRequest>(r => 
                r.FirstName == viewModel.FirstName 
                && r.LastName == viewModel.LastName 
                && r.DateOfBirth == null 
                && r.Postcode == viewModel.Postcode)));
        }

        [TestCase("80A219E (003-682-944)", "80A219E", 3682944)]
        [TestCase("80A 219E (003-682-944)", "80A219E", 3682944)]
        [TestCase("80A219E", "80A219E", 0)]
        [TestCase("003-682-944", null, 3682944)]
        public void TestApplicantIdConversion(string applicantId, string expectedCandidateGuidPrefix, int expectedCandidateId)
        {
            //Arrange
            var viewModel = new CandidateSearchViewModel
            {
                ApplicantId = applicantId
            };

            //Act
            _provider.SearchCandidates(viewModel, null);

            //Assert
            _candidateSearchService.Verify(s => s.SearchCandidates(It.Is<CandidateSearchRequest>(r => 
                r.CandidateGuidPrefix == expectedCandidateGuidPrefix
                && r.CandidateId == (expectedCandidateId == 0 ? (int?)null : expectedCandidateId))));
        }

        [Test]
        public void TestResponseConversion()
        {
            //Arrange
            var viewModel = new CandidateSearchViewModel();
            var candidateSummaries = new Fixture().Build<CandidateSummary>().CreateMany(3).ToList();
            _candidateSearchService.Setup(s => s.SearchCandidates(It.IsAny<CandidateSearchRequest>())).Returns(candidateSummaries);

            //Act
            var response = _provider.SearchCandidates(viewModel, null);

            //Assert
            response.Should().NotBeNull();
            response.SearchViewModel.Should().Be(viewModel);
            response.Candidates.Should().NotBeNull();
            response.Candidates.Page.Should().NotBeNull();
            var candidateSummaryViewModels = response.Candidates.Page.ToList();
            candidateSummaryViewModels.Count.Should().Be(candidateSummaries.Count);
            foreach (var candidateSummary in candidateSummaries)
            {
                candidateSummaryViewModels.Should().Contain(c => 
                c.Id == candidateSummary.EntityId && 
                c.Name == candidateSummary.FirstName + " " + candidateSummary.LastName &&
                c.Address.AddressLine1 == candidateSummary.Address.AddressLine1 &&
                c.DateOfBirth == candidateSummary.DateOfBirth);
            }
        }

        [Test]
        public void TestPageLimit()
        {
            //Arrange
            var viewModel = new CandidateSearchViewModel();
            var candidateSummaries = new Fixture().Build<CandidateSummary>().CreateMany(13).ToList();
            _candidateSearchService.Setup(s => s.SearchCandidates(It.IsAny<CandidateSearchRequest>())).Returns(candidateSummaries);

            //Act
            var response = _provider.SearchCandidates(viewModel, null);

            //Assert
            var candidateSummaryViewModels = response.Candidates.Page.ToList();
            candidateSummaryViewModels.Count.Should().Be(10);
            response.Candidates.ResultsCount.Should().Be(candidateSummaries.Count);
            response.Candidates.CurrentPage.Should().Be(1);
            response.Candidates.TotalNumberOfPages.Should().Be(2);
        }

        [Test]
        public void TestPaging()
        {
            //Arrange
            var viewModel = new CandidateSearchViewModel
            {
                CurrentPage = 2
            };
            var candidateSummaries = new Fixture().Build<CandidateSummary>().CreateMany(13).ToList();
            _candidateSearchService.Setup(s => s.SearchCandidates(It.IsAny<CandidateSearchRequest>())).Returns(candidateSummaries);

            //Act
            var response = _provider.SearchCandidates(viewModel, null);

            //Assert
            var candidateSummaryViewModels = response.Candidates.Page.ToList();
            candidateSummaryViewModels.Count.Should().Be(3);
            response.Candidates.ResultsCount.Should().Be(candidateSummaries.Count);
            response.Candidates.CurrentPage.Should().Be(2);
            response.Candidates.TotalNumberOfPages.Should().Be(2);
        }

        [Test]
        public void TestOrdering()
        {
            //Arrange
            var viewModel = new CandidateSearchViewModel();
            var candidateSummaries = new List<CandidateSummary>
            {
                new CandidateSummary { EntityId = Guid.NewGuid(), FirstName = "bbb", LastName = "ddd", Address = new Address { AddressLine1 = "1", Postcode = "zzz"}},
                new CandidateSummary { EntityId = Guid.NewGuid(), FirstName = "aaa", LastName = "ddd", Address = new Address { AddressLine1 = "3", Postcode = "ccc"}},
                new CandidateSummary { EntityId = Guid.NewGuid(), FirstName = "bbb", LastName = "ddd", Address = new Address { AddressLine1 = "2", Postcode = "ccc"}},
                new CandidateSummary { EntityId = Guid.NewGuid(), FirstName = "bbb", LastName = "ddd", Address = new Address { AddressLine1 = "1", Postcode = "ccc"}},
                new CandidateSummary { EntityId = Guid.NewGuid(), FirstName = "bbb", LastName = "ccc", Address = new Address { AddressLine1 = "1", Postcode = "ccc"}},
            };
            var expectedOrder = new[] {4, 1, 3, 2, 0};
            _candidateSearchService.Setup(s => s.SearchCandidates(It.IsAny<CandidateSearchRequest>())).Returns(candidateSummaries);

            //Act
            var response = _provider.SearchCandidates(viewModel, null);

            //Assert
            var index = 0;
            foreach (var candidateSummaryViewModel in response.Candidates.Page)
            {
                var candidateSummary = candidateSummaries[expectedOrder[index]];
                candidateSummaryViewModel.Id.Should().Be(candidateSummary.EntityId);
                candidateSummaryViewModel.Name.Should().Be(candidateSummary.FirstName + " " + candidateSummary.LastName);
                index++;
            }
        }
    }
}