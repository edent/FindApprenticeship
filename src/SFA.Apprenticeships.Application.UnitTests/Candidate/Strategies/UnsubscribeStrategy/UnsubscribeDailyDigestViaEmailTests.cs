﻿namespace SFA.Apprenticeships.Application.UnitTests.Candidate.Strategies.UnsubscribeStrategy
{
    using System;
    using Application.Candidate.Strategies;
    using Application.Candidate.Strategies.SavedSearches;
    using Domain.Entities.Candidates;
    using Domain.Entities.UnitTests.Builder;
    using Domain.Interfaces.Repositories;
    using FluentAssertions;
    using Interfaces.Communications;
    using Interfaces.Logging;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class UnsubscribeDailyDigestViaEmailTests
    {
        private Mock<ILogService> _mockLogger;
        private Mock<ICandidateReadRepository> _mockCandidateRepository;
        private Mock<ISaveCandidateStrategy> _mockSaveCandidateStrategy;
        private Mock<IRetrieveSavedSearchesStrategy> _mockRetrieveSavedSearchesStrategy;
        private Mock<IUpdateSavedSearchStrategy> _mockUpdateSavedSearchStrategy;

        [SetUp]
        public void SetUp()
        {
            _mockLogger = new Mock<ILogService>();
            _mockCandidateRepository = new Mock<ICandidateReadRepository>();
            _mockSaveCandidateStrategy = new Mock<ISaveCandidateStrategy>();
            _mockRetrieveSavedSearchesStrategy = new Mock<IRetrieveSavedSearchesStrategy>();
            _mockUpdateSavedSearchStrategy = new Mock<IUpdateSavedSearchStrategy>();
        }

        [Test]
        public void ShouldUnsubscribe()
        {
            // Arrange.
            var strategy = new UnsubscribeStrategy(
                _mockLogger.Object,
                _mockCandidateRepository.Object,
                _mockSaveCandidateStrategy.Object,
                _mockRetrieveSavedSearchesStrategy.Object,
                _mockUpdateSavedSearchStrategy.Object);

            // Act.
            var candidateId = Guid.NewGuid();
            var subscriberId = Guid.NewGuid();

            var candidate = BuildSubscribedCandidate(candidateId);

            _mockCandidateRepository.Setup(mock => mock
                .GetBySubscriberId(subscriberId, true))
                .Returns(candidate);

            var unsubscribed = strategy.Unsubscribe(subscriberId, SubscriptionTypes.DailyDigestViaEmail);
            
            // Assert.
            unsubscribed.Should().BeTrue();

            candidate.CommunicationPreferences.Should().NotBeNull();
            candidate.CommunicationPreferences.ApplicationStatusChangePreferences.Should().NotBeNull();
            candidate.CommunicationPreferences.ApplicationStatusChangePreferences.EnableEmail.Should().BeFalse();

            candidate.CommunicationPreferences.ExpiringApplicationPreferences.Should().NotBeNull();
            candidate.CommunicationPreferences.ExpiringApplicationPreferences.EnableEmail.Should().BeFalse();

            _mockSaveCandidateStrategy.Verify(mock => mock
                .SaveCandidate(candidate), Times.Once);

            _mockLogger.Verify(mock => mock
                .Info(It.IsAny<string>(), It.IsAny<object[]>()), Times.Once);
        }

        #region Helpers

        private static Candidate BuildSubscribedCandidate(Guid candidateId)
        {
            return new CandidateBuilder(candidateId)
                .EnableApplicationStatusChangeAlertsViaEmail(true)
                .EnableApplicationStatusChangeAlertsViaText(true)
                .EnableExpiringApplicationAlertsViaEmail(true)
                .EnableExpiringApplicationAlertsViaText(true)
                .EnableExpiringApplicationAlertsViaEmail(true)
                .EnableSavedSearchAlertsViaEmail(true)
                .Build();
        }

        #endregion
    }
}