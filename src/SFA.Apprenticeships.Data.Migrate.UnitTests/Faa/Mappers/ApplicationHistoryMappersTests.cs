﻿namespace SFA.Apprenticeships.Data.Migrate.UnitTests.Faa.Mappers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Builders;
    using FluentAssertions;
    using Migrate.Faa.Entities.Mongo;
    using Migrate.Faa.Entities.Sql;
    using Migrate.Faa.Mappers;
    using NUnit.Framework;

    [TestFixture]
    public class ApplicationHistoryMappersTests
    {
        [Test]
        public void SavedVacancyApplicationTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Saved).Build();

            //Act
            var applicationHistory = vacancyApplication.MapApplicationHistory(vacancyApplication.LegacyApplicationId, new Dictionary<int, Dictionary<int, int>>(), new Dictionary<int, List<ApplicationHistorySummary>>());

            //Assert
            applicationHistory.Should().NotBeNullOrEmpty();
            applicationHistory.Count.Should().Be(1);
            var draftHistory = applicationHistory.First();
            draftHistory.ApplicationId.Should().Be(vacancyApplication.LegacyApplicationId);
            draftHistory.UserName.Should().Be("");
            draftHistory.ApplicationHistoryEventDate.Should().Be(vacancyApplication.DateCreated);
            draftHistory.ApplicationHistoryEventTypeId.Should().Be(1);
            draftHistory.ApplicationHistoryEventSubTypeId.Should().Be(0);
            draftHistory.Comment.Should().Be("Status Change");
        }

        [Test]
        public void DraftVacancyApplicationTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Draft).Build();

            //Act
            var applicationHistory = vacancyApplication.MapApplicationHistory(vacancyApplication.LegacyApplicationId, new Dictionary<int, Dictionary<int, int>>(), new Dictionary<int, List<ApplicationHistorySummary>>());

            //Assert
            applicationHistory.Should().NotBeNullOrEmpty();
            applicationHistory.Count.Should().Be(1);
            var draftHistory = applicationHistory.First();
            draftHistory.ApplicationId.Should().Be(vacancyApplication.LegacyApplicationId);
            draftHistory.UserName.Should().Be("");
            draftHistory.ApplicationHistoryEventDate.Should().Be(vacancyApplication.DateCreated);
            draftHistory.ApplicationHistoryEventTypeId.Should().Be(1);
            draftHistory.ApplicationHistoryEventSubTypeId.Should().Be(1);
            draftHistory.Comment.Should().Be("Status Change");
        }

        [Test]
        public void SubmittingVacancyApplicationTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Submitting).Build();

            //Act
            var applicationHistory = vacancyApplication.MapApplicationHistory(vacancyApplication.LegacyApplicationId, new Dictionary<int, Dictionary<int, int>>(), new Dictionary<int, List<ApplicationHistorySummary>>());

            //Assert
            applicationHistory.Should().NotBeNullOrEmpty();
            applicationHistory.Count.Should().Be(1);
            var draftHistory = applicationHistory.First();
            draftHistory.ApplicationId.Should().Be(vacancyApplication.LegacyApplicationId);
            draftHistory.UserName.Should().Be("");
            draftHistory.ApplicationHistoryEventDate.Should().Be(vacancyApplication.DateCreated);
            draftHistory.ApplicationHistoryEventTypeId.Should().Be(1);
            draftHistory.ApplicationHistoryEventSubTypeId.Should().Be(1);
            draftHistory.Comment.Should().Be("Status Change");
        }

        [Test]
        public void SubmittedVacancyApplicationTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Submitted).Build();

            //Act
            var applicationHistory = vacancyApplication.MapApplicationHistory(vacancyApplication.LegacyApplicationId, new Dictionary<int, Dictionary<int, int>>(), new Dictionary<int, List<ApplicationHistorySummary>>());

            //Assert
            applicationHistory.Should().NotBeNullOrEmpty();
            applicationHistory.Count.Should().Be(2);
            var draftHistory = applicationHistory[0];
            draftHistory.ApplicationHistoryEventSubTypeId.Should().Be(1);
            var submittedHistory = applicationHistory[1];
            submittedHistory.ApplicationId.Should().Be(vacancyApplication.LegacyApplicationId);
            submittedHistory.UserName.Should().Be("");
            // ReSharper disable once PossibleInvalidOperationException
            submittedHistory.ApplicationHistoryEventDate.Should().Be(vacancyApplication.DateApplied.Value);
            submittedHistory.ApplicationHistoryEventTypeId.Should().Be(1);
            submittedHistory.ApplicationHistoryEventSubTypeId.Should().Be(2);
            submittedHistory.Comment.Should().Be("Status Change");
        }

        [Test]
        public void InProgressVacancyApplicationTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.InProgress).Build();

            //Act
            var applicationHistory = vacancyApplication.MapApplicationHistory(vacancyApplication.LegacyApplicationId, new Dictionary<int, Dictionary<int, int>>(), new Dictionary<int, List<ApplicationHistorySummary>>());

            //Assert
            applicationHistory.Should().NotBeNullOrEmpty();
            applicationHistory.Count.Should().Be(3);
            var draftHistory = applicationHistory[0];
            draftHistory.ApplicationHistoryEventSubTypeId.Should().Be(1);
            var submittedHistory = applicationHistory[1];
            submittedHistory.ApplicationHistoryEventSubTypeId.Should().Be(2);
            var inProgressHistory = applicationHistory[2];
            inProgressHistory.ApplicationId.Should().Be(vacancyApplication.LegacyApplicationId);
            inProgressHistory.UserName.Should().Be("");
            // ReSharper disable once PossibleInvalidOperationException
            inProgressHistory.ApplicationHistoryEventDate.Should().Be(vacancyApplication.DateUpdated.Value);
            inProgressHistory.ApplicationHistoryEventTypeId.Should().Be(1);
            inProgressHistory.ApplicationHistoryEventSubTypeId.Should().Be(3);
            inProgressHistory.Comment.Should().Be("Status Change");
        }

        [Test]
        public void WithdrawnVacancyApplicationTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.ExpiredOrWithdrawn).Build();

            //Act
            var applicationHistory = vacancyApplication.MapApplicationHistory(vacancyApplication.LegacyApplicationId, new Dictionary<int, Dictionary<int, int>>(), new Dictionary<int, List<ApplicationHistorySummary>>());

            //Assert
            applicationHistory.Should().NotBeNullOrEmpty();
            applicationHistory.Count.Should().Be(2);
            var draftHistory = applicationHistory[0];
            draftHistory.ApplicationHistoryEventSubTypeId.Should().Be(1);
            var withdrawnHistory = applicationHistory[1];
            withdrawnHistory.ApplicationId.Should().Be(vacancyApplication.LegacyApplicationId);
            withdrawnHistory.UserName.Should().Be("");
            // ReSharper disable once PossibleInvalidOperationException
            withdrawnHistory.ApplicationHistoryEventDate.Should().Be(vacancyApplication.DateUpdated.Value);
            withdrawnHistory.ApplicationHistoryEventTypeId.Should().Be(1);
            withdrawnHistory.ApplicationHistoryEventSubTypeId.Should().Be(4);
            withdrawnHistory.Comment.Should().Be("Status Change");
        }

        [Test]
        public void UnsuccessfulVacancyApplicationTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Unsuccessful).Build();

            //Act
            var applicationHistory = vacancyApplication.MapApplicationHistory(vacancyApplication.LegacyApplicationId, new Dictionary<int, Dictionary<int, int>>(), new Dictionary<int, List<ApplicationHistorySummary>>());

            //Assert
            applicationHistory.Should().NotBeNullOrEmpty();
            applicationHistory.Count.Should().Be(4);
            var draftHistory = applicationHistory[0];
            draftHistory.ApplicationHistoryEventSubTypeId.Should().Be(1);
            var submittedHistory = applicationHistory[1];
            submittedHistory.ApplicationHistoryEventSubTypeId.Should().Be(2);
            var inProgressHistory = applicationHistory[2];
            inProgressHistory.ApplicationHistoryEventSubTypeId.Should().Be(3);
            var unsuccessfulHistory = applicationHistory[3];
            unsuccessfulHistory.ApplicationId.Should().Be(vacancyApplication.LegacyApplicationId);
            unsuccessfulHistory.UserName.Should().Be("");
            // ReSharper disable once PossibleInvalidOperationException
            unsuccessfulHistory.ApplicationHistoryEventDate.Should().Be(vacancyApplication.UnsuccessfulDateTime.Value);
            unsuccessfulHistory.ApplicationHistoryEventTypeId.Should().Be(1);
            unsuccessfulHistory.ApplicationHistoryEventSubTypeId.Should().Be(5);
            unsuccessfulHistory.Comment.Should().Be("Status Change");
        }

        [Test]
        public void SuccessfulVacancyApplicationTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Successful).Build();

            //Act
            var applicationHistory = vacancyApplication.MapApplicationHistory(vacancyApplication.LegacyApplicationId, new Dictionary<int, Dictionary<int, int>>(), new Dictionary<int, List<ApplicationHistorySummary>>());

            //Assert
            applicationHistory.Should().NotBeNullOrEmpty();
            applicationHistory.Count.Should().Be(4);
            var draftHistory = applicationHistory[0];
            draftHistory.ApplicationHistoryEventSubTypeId.Should().Be(1);
            var submittedHistory = applicationHistory[1];
            submittedHistory.ApplicationHistoryEventSubTypeId.Should().Be(2);
            var inProgressHistory = applicationHistory[2];
            inProgressHistory.ApplicationHistoryEventSubTypeId.Should().Be(3);
            var successfulHistory = applicationHistory[3];
            successfulHistory.ApplicationId.Should().Be(vacancyApplication.LegacyApplicationId);
            successfulHistory.UserName.Should().Be("");
            // ReSharper disable once PossibleInvalidOperationException
            successfulHistory.ApplicationHistoryEventDate.Should().Be(vacancyApplication.SuccessfulDateTime.Value);
            successfulHistory.ApplicationHistoryEventTypeId.Should().Be(1);
            successfulHistory.ApplicationHistoryEventSubTypeId.Should().Be(6);
            successfulHistory.Comment.Should().Be("Status Change");
        }

        [Test]
        public void SuccessfulVacancyApplicationDictionaryTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Successful).Build();

            //Act
            var applicationHistory = vacancyApplication.MapApplicationHistory(vacancyApplication.LegacyApplicationId, new Dictionary<int, Dictionary<int, int>>(), new Dictionary<int, List<ApplicationHistorySummary>>());
            var applicationHistoryDictionary = applicationHistory.MapApplicationHistoryDictionary();

            //Assert
            applicationHistoryDictionary.Should().NotBeNullOrEmpty();
            applicationHistoryDictionary.Count.Should().Be(4);
            var draftHistory = applicationHistoryDictionary[0];
            draftHistory["ApplicationHistoryEventSubTypeId"].Should().Be(1);
            var submittedHistory = applicationHistoryDictionary[1];
            submittedHistory["ApplicationHistoryEventSubTypeId"].Should().Be(2);
            var inProgressHistory = applicationHistoryDictionary[2];
            inProgressHistory["ApplicationHistoryEventSubTypeId"].Should().Be(3);
            var successfulHistory = applicationHistoryDictionary[3];
            successfulHistory["ApplicationId"].Should().Be(vacancyApplication.LegacyApplicationId);
            successfulHistory["UserName"].Should().Be("");
            // ReSharper disable once PossibleInvalidOperationException
            successfulHistory["ApplicationHistoryEventDate"].Should().Be(vacancyApplication.SuccessfulDateTime.Value);
            successfulHistory["ApplicationHistoryEventTypeId"].Should().Be(1);
            successfulHistory["ApplicationHistoryEventSubTypeId"].Should().Be(6);
            successfulHistory["Comment"].Should().Be("Status Change");
        }

        [Test]
        public void NoApplicationIdVacancyApplicationTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Draft).WithLegacyApplicationId(0).Build();

            //Act
            var applicationHistory = vacancyApplication.MapApplicationHistory(vacancyApplication.LegacyApplicationId, new Dictionary<int, Dictionary<int, int>>(), new Dictionary<int, List<ApplicationHistorySummary>>());

            //Assert
            applicationHistory[0].ApplicationHistoryId.Should().Be(0);
        }

        [Test]
        public void MatchingApplicationIdVacancyApplicationTest()
        {
            //Arrange
            const int applicationId = 42;
            const int applicationHistoryId = 43;
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Submitted).WithLegacyApplicationId(applicationId).Build();
            var applicationHistoryIds = new Dictionary<int, Dictionary<int, int>>
            {
                { applicationId, new Dictionary<int, int> {{ 1, applicationHistoryId }}}
            };

            //Act
            var applicationHistory = vacancyApplication.MapApplicationHistory(vacancyApplication.LegacyApplicationId, applicationHistoryIds, new Dictionary<int, List<ApplicationHistorySummary>>());

            //Assert
            applicationHistory[0].ApplicationHistoryId.Should().Be(43);
            applicationHistory[1].ApplicationHistoryId.Should().Be(0);
        }

        [Test]
        public void UnsuccessfulVacancyApplicationDateFromSourceTest()
        {
            //Arrange
            const int applicationId = 42;
            const int applicationHistoryId = 43;
            var applicationHistoryIds = new Dictionary<int, Dictionary<int, int>>
            {
                { applicationId, new Dictionary<int, int> {{ 5, applicationHistoryId }}}
            };
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Unsuccessful).WithLegacyApplicationId(applicationId).Build();
            var unsuccessfulDateTime = DateTime.Now.AddDays(-3);
            var sourceApplicationHistorySummaries = new Dictionary<int, List<ApplicationHistorySummary>>
            {
                {
                    applicationId, new List<ApplicationHistorySummary>
                    {
                        new ApplicationHistorySummary {ApplicationHistoryEventSubTypeId = 5, ApplicationHistoryEventDate = unsuccessfulDateTime},
                        new ApplicationHistorySummary {ApplicationHistoryEventSubTypeId = 5, ApplicationHistoryEventDate = unsuccessfulDateTime.AddHours(-6)}
                    }
                }
            };

            //Act
            var applicationHistory = vacancyApplication.MapApplicationHistory(vacancyApplication.LegacyApplicationId, applicationHistoryIds, sourceApplicationHistorySummaries);

            //Assert
            var unsuccessfulHistory = applicationHistory[3];
            unsuccessfulHistory.ApplicationHistoryEventDate.Should().Be(unsuccessfulDateTime);
        }

        [Test]
        public void SuccessfulVacancyApplicationDateFromSourceTest()
        {
            //Arrange
            const int applicationId = 42;
            const int applicationHistoryId = 43;
            var applicationHistoryIds = new Dictionary<int, Dictionary<int, int>>
            {
                { applicationId, new Dictionary<int, int> {{ 6, applicationHistoryId }}}
            };
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Successful).WithLegacyApplicationId(applicationId).Build();
            var successfulDateTime = DateTime.Now.AddDays(-2);
            var sourceApplicationHistorySummaries = new Dictionary<int, List<ApplicationHistorySummary>>
            {
                {
                    applicationId, new List<ApplicationHistorySummary>
                    {
                        new ApplicationHistorySummary {ApplicationHistoryEventSubTypeId = 6, ApplicationHistoryEventDate = successfulDateTime.AddHours(-3)},
                        new ApplicationHistorySummary {ApplicationHistoryEventSubTypeId = 6, ApplicationHistoryEventDate = successfulDateTime}
                    }
                }
            };

            //Act
            var applicationHistory = vacancyApplication.MapApplicationHistory(vacancyApplication.LegacyApplicationId, applicationHistoryIds, sourceApplicationHistorySummaries);

            //Assert
            var successfulHistory = applicationHistory[3];
            successfulHistory.ApplicationHistoryEventDate.Should().Be(successfulDateTime);
        }
    }
}