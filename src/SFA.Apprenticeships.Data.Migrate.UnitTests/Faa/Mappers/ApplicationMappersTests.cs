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
    using Moq;
    using NUnit.Framework;

    using SFA.Apprenticeships.Application.Interfaces;

    [TestFixture]
    public class ApplicationMappersTests
    {
        private readonly IApplicationMappers _applicationMappers = new ApplicationMappers(new Mock<ILogService>().Object);

        [Test]
        public void SavedVacancyApplicationTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Saved).Build();
            var candidate = new CandidateSummaryBuilder().WithCandidateId(vacancyApplication.CandidateId).Build();

            //Act
            var application = _applicationMappers.MapApplication(vacancyApplication, candidate.LegacyCandidateId, new Dictionary<Guid, int>(), new Dictionary<int, ApplicationSummary>(), new Dictionary<int, int>(), new Dictionary<int, SubVacancy>()).Application;

            //Assert
            application.ApplicationId.Should().Be(vacancyApplication.LegacyApplicationId);
            application.CandidateId.Should().Be(candidate.LegacyCandidateId);
            application.VacancyId.Should().Be(vacancyApplication.Vacancy.Id);
            application.ApplicationStatusTypeId.Should().Be(0);
            application.WithdrawnOrDeclinedReasonId.Should().Be(0);
            application.UnsuccessfulReasonId.Should().Be(0);
            application.OutcomeReasonOther.Should().Be(null);
            application.NextActionId.Should().Be(0);
            application.NextActionOther.Should().Be(null);
            application.AllocatedTo.Should().Be(null);
            application.CVAttachmentId.Should().Be(null);
            application.BeingSupportedBy.Should().Be(null);
            application.LockedForSupportUntil.Should().Be(null);
            application.WithdrawalAcknowledged.Should().Be(true);
            application.ApplicationGuid.Should().Be(vacancyApplication.Id);
        }

        [Test]
        public void DraftVacancyApplicationTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Draft).Build();
            var candidate = new CandidateSummaryBuilder().WithCandidateId(vacancyApplication.CandidateId).Build();

            //Act
            var application = _applicationMappers.MapApplication(vacancyApplication, candidate.LegacyCandidateId, new Dictionary<Guid, int>(), new Dictionary<int, ApplicationSummary>(), new Dictionary<int, int>(), new Dictionary<int, SubVacancy>()).Application;

            //Assert
            application.ApplicationId.Should().Be(vacancyApplication.LegacyApplicationId);
            application.CandidateId.Should().Be(candidate.LegacyCandidateId);
            application.VacancyId.Should().Be(vacancyApplication.Vacancy.Id);
            application.ApplicationStatusTypeId.Should().Be(1);
            application.WithdrawnOrDeclinedReasonId.Should().Be(0);
            application.UnsuccessfulReasonId.Should().Be(0);
            application.OutcomeReasonOther.Should().Be(null);
            application.NextActionId.Should().Be(0);
            application.NextActionOther.Should().Be(null);
            application.AllocatedTo.Should().Be(null);
            application.CVAttachmentId.Should().Be(null);
            application.BeingSupportedBy.Should().Be(null);
            application.LockedForSupportUntil.Should().Be(null);
            application.WithdrawalAcknowledged.Should().Be(true);
            application.ApplicationGuid.Should().Be(vacancyApplication.Id);
        }

        [Test]
        public void SubmittingVacancyApplicationTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Submitting).Build();
            var candidate = new CandidateSummaryBuilder().WithCandidateId(vacancyApplication.CandidateId).Build();

            //Act
            var application = _applicationMappers.MapApplication(vacancyApplication, candidate.LegacyCandidateId, new Dictionary<Guid, int>(), new Dictionary<int, ApplicationSummary>(), new Dictionary<int, int>(), new Dictionary<int, SubVacancy>()).Application;

            //Assert
            application.ApplicationId.Should().Be(vacancyApplication.LegacyApplicationId);
            application.CandidateId.Should().Be(candidate.LegacyCandidateId);
            application.VacancyId.Should().Be(vacancyApplication.Vacancy.Id);
            application.ApplicationStatusTypeId.Should().Be(1);
            application.WithdrawnOrDeclinedReasonId.Should().Be(0);
            application.UnsuccessfulReasonId.Should().Be(0);
            application.OutcomeReasonOther.Should().Be(null);
            application.NextActionId.Should().Be(0);
            application.NextActionOther.Should().Be(null);
            application.AllocatedTo.Should().Be(null);
            application.CVAttachmentId.Should().Be(null);
            application.BeingSupportedBy.Should().Be(null);
            application.LockedForSupportUntil.Should().Be(null);
            application.WithdrawalAcknowledged.Should().Be(true);
            application.ApplicationGuid.Should().Be(vacancyApplication.Id);
        }

        [Test]
        public void SubmittedVacancyApplicationTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Submitted).Build();
            var candidate = new CandidateSummaryBuilder().WithCandidateId(vacancyApplication.CandidateId).Build();

            //Act
            var application = _applicationMappers.MapApplication(vacancyApplication, candidate.LegacyCandidateId, new Dictionary<Guid, int>(), new Dictionary<int, ApplicationSummary>(), new Dictionary<int, int>(), new Dictionary<int, SubVacancy>()).Application;

            //Assert
            application.ApplicationId.Should().Be(vacancyApplication.LegacyApplicationId);
            application.CandidateId.Should().Be(candidate.LegacyCandidateId);
            application.VacancyId.Should().Be(vacancyApplication.Vacancy.Id);
            application.ApplicationStatusTypeId.Should().Be(2);
            application.WithdrawnOrDeclinedReasonId.Should().Be(0);
            application.UnsuccessfulReasonId.Should().Be(0);
            application.OutcomeReasonOther.Should().Be(null);
            application.NextActionId.Should().Be(0);
            application.NextActionOther.Should().Be(null);
            application.AllocatedTo.Should().Be(null);
            application.CVAttachmentId.Should().Be(null);
            application.BeingSupportedBy.Should().Be(null);
            application.LockedForSupportUntil.Should().Be(null);
            application.WithdrawalAcknowledged.Should().Be(true);
            application.ApplicationGuid.Should().Be(vacancyApplication.Id);
        }

        [Test]
        public void InProgressVacancyApplicationTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.InProgress).Build();
            var candidate = new CandidateSummaryBuilder().WithCandidateId(vacancyApplication.CandidateId).Build();

            //Act
            var application = _applicationMappers.MapApplication(vacancyApplication, candidate.LegacyCandidateId, new Dictionary<Guid, int>(), new Dictionary<int, ApplicationSummary>(), new Dictionary<int, int>(), new Dictionary<int, SubVacancy>()).Application;

            //Assert
            application.ApplicationId.Should().Be(vacancyApplication.LegacyApplicationId);
            application.CandidateId.Should().Be(candidate.LegacyCandidateId);
            application.VacancyId.Should().Be(vacancyApplication.Vacancy.Id);
            application.ApplicationStatusTypeId.Should().Be(3);
            application.WithdrawnOrDeclinedReasonId.Should().Be(0);
            application.UnsuccessfulReasonId.Should().Be(0);
            application.OutcomeReasonOther.Should().Be(null);
            application.NextActionId.Should().Be(0);
            application.NextActionOther.Should().Be(null);
            application.AllocatedTo.Should().Be(null);
            application.CVAttachmentId.Should().Be(null);
            application.BeingSupportedBy.Should().Be(null);
            application.LockedForSupportUntil.Should().Be(null);
            application.WithdrawalAcknowledged.Should().Be(true);
            application.ApplicationGuid.Should().Be(vacancyApplication.Id);
        }

        [TestCase(null, 0)]
        [TestCase("", 0)]
        [TestCase("UNKNOWN", 0)]
        [TestCase("No longer interested", 1)]
        [TestCase("Accepted another Apprenticeship offer", 2)]
        [TestCase("Accepted an alternative job", 3)]
        [TestCase("Decided to go to college", 4)]
        [TestCase("Decided to stay on at 6th form", 5)]
        [TestCase("Want to be able to apply for other Apprenticeships", 6)]
        [TestCase("Personal reasons", 7)]
        [TestCase("Moving away", 8)]
        [TestCase("Pay or Conditions not acceptable", 9)]
        [TestCase("Other (please specify)", 10)]
        public void WithdrawnVacancyApplicationTest(string withdrawnOrDeclinedReason, int expectedWithdrawnOrDeclinedReasonId)
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.ExpiredOrWithdrawn).WithWithdrawnOrDeclinedReason(withdrawnOrDeclinedReason).Build();
            var candidate = new CandidateSummaryBuilder().WithCandidateId(vacancyApplication.CandidateId).Build();

            //Act
            var application = _applicationMappers.MapApplication(vacancyApplication, candidate.LegacyCandidateId, new Dictionary<Guid, int>(), new Dictionary<int, ApplicationSummary>(), new Dictionary<int, int>(), new Dictionary<int, SubVacancy>()).Application;

            //Assert
            application.ApplicationId.Should().Be(vacancyApplication.LegacyApplicationId);
            application.CandidateId.Should().Be(candidate.LegacyCandidateId);
            application.VacancyId.Should().Be(vacancyApplication.Vacancy.Id);
            application.ApplicationStatusTypeId.Should().Be(4);
            application.WithdrawnOrDeclinedReasonId.Should().Be(expectedWithdrawnOrDeclinedReasonId);
            application.UnsuccessfulReasonId.Should().Be(0);
            application.OutcomeReasonOther.Should().Be(null);
            application.NextActionId.Should().Be(0);
            application.NextActionOther.Should().Be(null);
            application.AllocatedTo.Should().Be(null);
            application.CVAttachmentId.Should().Be(null);
            application.BeingSupportedBy.Should().Be(null);
            application.LockedForSupportUntil.Should().Be(null);
            application.WithdrawalAcknowledged.Should().Be(true);
            application.ApplicationGuid.Should().Be(vacancyApplication.Id);
        }

        [TestCase(null, 0)]
        [TestCase("", 0)]
        [TestCase("UNKNOWN", 0)]
        [TestCase("Please Select...", 0)]
        [TestCase("You’re not eligible for an apprenticeship", 1)]
        [TestCase("You haven’t met the requirements", 2)]
        [TestCase("You met the employer’s/provider's requirements but have been unsuccessful", 3)]
        [TestCase("You didn’t attend the interview", 4)]
        [TestCase("The apprenticeship has been withdrawn", 5)]
        [TestCase("You've been unsuccessful - other", 6)]
        [TestCase("Not suitable for vacancy due to journey / distance involved", 7)]
        [TestCase("Failed initial assessment test", 8)]
        [TestCase("Employer withdrew vacancy", 9)]
        [TestCase("Accepted an alternative apprenticeship position", 10)]
        [TestCase("Have found other employment", 11)]
        [TestCase("Taken up other learning or education", 12)]
        [TestCase("Other reason for Withdrawing Application", 13)]
        [TestCase("Other", 14)]
        [TestCase("You’re not eligible for a traineeship", 15)]
        [TestCase("The training provider couldn’t contact you", 16)]
        [TestCase("Offered the position but turned it down", 17)]
        public void UnsuccessfulVacancyApplicationTest(string unsuccessfulReason, int expectedUnsuccessfulReasonId)
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Unsuccessful).WithUnsuccessfulReason(unsuccessfulReason).Build();
            var candidate = new CandidateSummaryBuilder().WithCandidateId(vacancyApplication.CandidateId).Build();

            //Act
            var application = _applicationMappers.MapApplication(vacancyApplication, candidate.LegacyCandidateId, new Dictionary<Guid, int>(), new Dictionary<int, ApplicationSummary>(), new Dictionary<int, int>(), new Dictionary<int, SubVacancy>()).Application;

            //Assert
            application.ApplicationId.Should().Be(vacancyApplication.LegacyApplicationId);
            application.CandidateId.Should().Be(candidate.LegacyCandidateId);
            application.VacancyId.Should().Be(vacancyApplication.Vacancy.Id);
            application.ApplicationStatusTypeId.Should().Be(5);
            application.WithdrawnOrDeclinedReasonId.Should().Be(0);
            application.UnsuccessfulReasonId.Should().Be(expectedUnsuccessfulReasonId);
            application.OutcomeReasonOther.Should().Be(expectedUnsuccessfulReasonId == 0 ? null : "");
            application.NextActionId.Should().Be(0);
            application.NextActionOther.Should().Be(null);
            application.AllocatedTo.Should().Be(expectedUnsuccessfulReasonId == 0 || expectedUnsuccessfulReasonId == 13 ? null : "");
            application.CVAttachmentId.Should().Be(null);
            application.BeingSupportedBy.Should().Be(null);
            application.LockedForSupportUntil.Should().Be(null);
            application.WithdrawalAcknowledged.Should().Be(expectedUnsuccessfulReasonId != 10 && expectedUnsuccessfulReasonId != 11 && expectedUnsuccessfulReasonId != 13);
            application.ApplicationGuid.Should().Be(vacancyApplication.Id);
        }

        [Test]
        public void SuccessfulVacancyApplicationTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Successful).Build();
            var candidate = new CandidateSummaryBuilder().WithCandidateId(vacancyApplication.CandidateId).Build();

            //Act
            var application = _applicationMappers.MapApplication(vacancyApplication, candidate.LegacyCandidateId, new Dictionary<Guid, int>(), new Dictionary<int, ApplicationSummary>(), new Dictionary<int, int>(), new Dictionary<int, SubVacancy>()).Application;

            //Assert
            application.ApplicationId.Should().Be(vacancyApplication.LegacyApplicationId);
            application.CandidateId.Should().Be(candidate.LegacyCandidateId);
            application.VacancyId.Should().Be(vacancyApplication.Vacancy.Id);
            application.ApplicationStatusTypeId.Should().Be(6);
            application.WithdrawnOrDeclinedReasonId.Should().Be(0);
            application.UnsuccessfulReasonId.Should().Be(0);
            application.OutcomeReasonOther.Should().Be(null);
            application.NextActionId.Should().Be(0);
            application.NextActionOther.Should().Be(null);
            application.AllocatedTo.Should().Be(null);
            application.CVAttachmentId.Should().Be(null);
            application.BeingSupportedBy.Should().Be(null);
            application.LockedForSupportUntil.Should().Be(null);
            application.WithdrawalAcknowledged.Should().Be(true);
            application.ApplicationGuid.Should().Be(vacancyApplication.Id);
        }

        [Test]
        public void SuccessfulApplicationWithHistoryTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Successful).Build();
            var candidate = new CandidateSummaryBuilder().WithCandidateId(vacancyApplication.CandidateId).Build();

            //Act
            var applicationWithHistory = _applicationMappers.MapApplicationWithHistory(vacancyApplication, candidate.LegacyCandidateId, new Dictionary<Guid, int>(), new Dictionary<int, ApplicationSummary>(), new Dictionary<int, int>(), new Dictionary<int, SubVacancy>(), new Dictionary<int, Dictionary<int, int>>(), new Dictionary<int, List<ApplicationHistorySummary>>());

            //Assert
            applicationWithHistory.ApplicationWithSubVacancy.Application.ApplicationId.Should().Be(vacancyApplication.LegacyApplicationId);
            applicationWithHistory.ApplicationWithSubVacancy.Application.CandidateId.Should().Be(candidate.LegacyCandidateId);
            applicationWithHistory.ApplicationWithSubVacancy.Application.VacancyId.Should().Be(vacancyApplication.Vacancy.Id);
            applicationWithHistory.ApplicationWithSubVacancy.Application.ApplicationStatusTypeId.Should().Be(6);
            applicationWithHistory.ApplicationWithSubVacancy.Application.WithdrawnOrDeclinedReasonId.Should().Be(0);
            applicationWithHistory.ApplicationWithSubVacancy.Application.UnsuccessfulReasonId.Should().Be(0);
            applicationWithHistory.ApplicationWithSubVacancy.Application.OutcomeReasonOther.Should().Be(null);
            applicationWithHistory.ApplicationWithSubVacancy.Application.NextActionId.Should().Be(0);
            applicationWithHistory.ApplicationWithSubVacancy.Application.NextActionOther.Should().Be(null);
            applicationWithHistory.ApplicationWithSubVacancy.Application.AllocatedTo.Should().Be(null);
            applicationWithHistory.ApplicationWithSubVacancy.Application.CVAttachmentId.Should().Be(null);
            applicationWithHistory.ApplicationWithSubVacancy.Application.BeingSupportedBy.Should().Be(null);
            applicationWithHistory.ApplicationWithSubVacancy.Application.LockedForSupportUntil.Should().Be(null);
            applicationWithHistory.ApplicationWithSubVacancy.Application.WithdrawalAcknowledged.Should().Be(true);
            applicationWithHistory.ApplicationWithSubVacancy.Application.ApplicationGuid.Should().Be(vacancyApplication.Id);
            applicationWithHistory.ApplicationHistory.Should().NotBeNullOrEmpty();
            applicationWithHistory.ApplicationHistory.Count.Should().Be(4);
            applicationWithHistory.ApplicationHistory.All(a => a.ApplicationId == applicationWithHistory.ApplicationWithSubVacancy.Application.ApplicationId).Should().BeTrue();
        }

        [Test]
        public void NoLegacyIdsVacancyApplicationTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Draft).WithLegacyApplicationId(0).Build();
            var candidate = new CandidateSummaryBuilder().WithCandidateId(vacancyApplication.CandidateId).WithLegacyCandidateId(0).Build();

            //Act
            var application = _applicationMappers.MapApplication(vacancyApplication, candidate.LegacyCandidateId, new Dictionary<Guid, int>(), new Dictionary<int, ApplicationSummary>(), new Dictionary<int, int>(), new Dictionary<int, SubVacancy>()).Application;

            //Assert
            application.ApplicationId.Should().Be(0);
            application.CandidateId.Should().Be(candidate.LegacyCandidateId);
        }

        [Test]
        public void MatchingIdVacancyApplicationTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Draft).WithLegacyApplicationId(0).Build();
            var candidate = new CandidateSummaryBuilder().WithCandidateId(vacancyApplication.CandidateId).WithLegacyCandidateId(0).Build();
            const int applicationId = 42;
            var applicationIds = new Dictionary<Guid, int>
            {
                {vacancyApplication.Id, applicationId}
            };

            //Act
            var application = _applicationMappers.MapApplication(vacancyApplication, candidate.LegacyCandidateId, applicationIds, new Dictionary<int, ApplicationSummary>(), new Dictionary<int, int>(), new Dictionary<int, SubVacancy>()).Application;

            //Assert
            application.ApplicationId.Should().Be(applicationId);
            application.CandidateId.Should().Be(candidate.LegacyCandidateId);
        }

        [Test]
        public void SubmittedVacancyApplicationDictionaryTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Submitted).Build();
            var candidate = new CandidateSummaryBuilder().WithCandidateId(vacancyApplication.CandidateId).Build();

            //Act
            var application = _applicationMappers.MapApplication(vacancyApplication, candidate.LegacyCandidateId, new Dictionary<Guid, int>(), new Dictionary<int, ApplicationSummary>(), new Dictionary<int, int>(), new Dictionary<int, SubVacancy>()).Application;
            var applicationDictionary = _applicationMappers.MapApplicationDictionary(application);

            //Assert
            applicationDictionary["ApplicationId"].Should().Be(vacancyApplication.LegacyApplicationId);
            applicationDictionary["CandidateId"].Should().Be(candidate.LegacyCandidateId);
            applicationDictionary["VacancyId"].Should().Be(vacancyApplication.Vacancy.Id);
            applicationDictionary["ApplicationStatusTypeId"].Should().Be(2);
            applicationDictionary["WithdrawnOrDeclinedReasonId"].Should().Be(0);
            applicationDictionary["UnsuccessfulReasonId"].Should().Be(0);
            applicationDictionary["OutcomeReasonOther"].Should().Be(null);
            applicationDictionary["NextActionId"].Should().Be(0);
            applicationDictionary["NextActionOther"].Should().Be(null);
            applicationDictionary["AllocatedTo"].Should().Be(null);
            applicationDictionary["CVAttachmentId"].Should().Be(null);
            applicationDictionary["BeingSupportedBy"].Should().Be(null);
            applicationDictionary["LockedForSupportUntil"].Should().Be(null);
            applicationDictionary["WithdrawalAcknowledged"].Should().Be(true);
            applicationDictionary["ApplicationGuid"].Should().Be(vacancyApplication.Id);
        }

        [Test]
        public void SubmittedApplicationWithHistoryDictionaryTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Submitted).Build();
            var candidate = new CandidateSummaryBuilder().WithCandidateId(vacancyApplication.CandidateId).Build();

            //Act
            var applicationWithHistory = _applicationMappers.MapApplicationWithHistory(vacancyApplication, candidate.LegacyCandidateId, new Dictionary<Guid, int>(), new Dictionary<int, ApplicationSummary>(), new Dictionary<int, int>(), new Dictionary<int, SubVacancy>(), new Dictionary<int, Dictionary<int, int>>(), new Dictionary<int, List<ApplicationHistorySummary>>());
            var applicationDictionary = _applicationMappers.MapApplicationDictionary(applicationWithHistory.ApplicationWithSubVacancy.Application);
            var applicationHistoryDictionary = applicationWithHistory.ApplicationHistory.MapApplicationHistoryDictionary();

            //Assert
            applicationDictionary["ApplicationId"].Should().Be(vacancyApplication.LegacyApplicationId);
            applicationDictionary["CandidateId"].Should().Be(candidate.LegacyCandidateId);
            applicationDictionary["VacancyId"].Should().Be(vacancyApplication.Vacancy.Id);
            applicationDictionary["ApplicationStatusTypeId"].Should().Be(2);
            applicationDictionary["WithdrawnOrDeclinedReasonId"].Should().Be(0);
            applicationDictionary["UnsuccessfulReasonId"].Should().Be(0);
            applicationDictionary["OutcomeReasonOther"].Should().Be(null);
            applicationDictionary["NextActionId"].Should().Be(0);
            applicationDictionary["NextActionOther"].Should().Be(null);
            applicationDictionary["AllocatedTo"].Should().Be(null);
            applicationDictionary["CVAttachmentId"].Should().Be(null);
            applicationDictionary["BeingSupportedBy"].Should().Be(null);
            applicationDictionary["LockedForSupportUntil"].Should().Be(null);
            applicationDictionary["WithdrawalAcknowledged"].Should().Be(true);
            applicationDictionary["ApplicationGuid"].Should().Be(vacancyApplication.Id);
            applicationHistoryDictionary.Should().NotBeNull();
            applicationHistoryDictionary.Count.Should().Be(2);
            applicationHistoryDictionary.All(a => (int)a["ApplicationId"] == (int)applicationDictionary["ApplicationId"]).Should().BeTrue();
        }

        [Test]
        public void SourceApplicationOutcomeReasonOtherTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Draft).WithLegacyApplicationId(0).Build();
            var candidate = new CandidateSummaryBuilder().WithCandidateId(vacancyApplication.CandidateId).WithLegacyCandidateId(0).Build();
            const int applicationId = 42;
            var applicationIds = new Dictionary<Guid, int>
            {
                {vacancyApplication.Id, applicationId}
            };
            const string outcomeReasonOther = "Failed to attend several first stage interviews";
            var sourceApplicationSummaries = new Dictionary<int, ApplicationSummary>
            {
                { applicationId, new ApplicationSummary {OutcomeReasonOther = outcomeReasonOther} }
            };

            //Act
            var application = _applicationMappers.MapApplication(vacancyApplication, candidate.LegacyCandidateId, applicationIds, sourceApplicationSummaries, new Dictionary<int, int>(), new Dictionary<int, SubVacancy>()).Application;

            //Assert
            application.ApplicationId.Should().Be(applicationId);
            application.CandidateId.Should().Be(candidate.LegacyCandidateId);
            application.OutcomeReasonOther.Should().Be(outcomeReasonOther);
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("Note from RAA")]
        public void AllocatedToTest(string notes)
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Draft).WithLegacyApplicationId(0).WithNotes(notes).Build();
            var candidate = new CandidateSummaryBuilder().WithCandidateId(vacancyApplication.CandidateId).WithLegacyCandidateId(0).Build();
            const int applicationId = 42;
            var applicationIds = new Dictionary<Guid, int>
            {
                {vacancyApplication.Id, applicationId}
            };
            const string allocatedTo = "registration completed. CV to be sent to employer ";
            var sourceApplicationSummaries = new Dictionary<int, ApplicationSummary>
            {
                { applicationId, new ApplicationSummary {AllocatedTo = allocatedTo} }
            };

            //Act
            var applicationWithSubVacancy = _applicationMappers.MapApplication(vacancyApplication, candidate.LegacyCandidateId, applicationIds, sourceApplicationSummaries, new Dictionary<int, int>(), new Dictionary<int, SubVacancy>());
            var application = applicationWithSubVacancy.Application;

            //Assert
            application.ApplicationId.Should().Be(applicationId);
            application.CandidateId.Should().Be(candidate.LegacyCandidateId);
            if (string.IsNullOrEmpty(notes))
            {
                application.AllocatedTo.Should().Be(allocatedTo);
                applicationWithSubVacancy.UpdateNotes.Should().BeTrue();
            }
            else
            {
                application.AllocatedTo.Should().Be(notes);
                applicationWithSubVacancy.UpdateNotes.Should().BeFalse();
            }
        }

        [Test]
        public void SourceApplicationStatusTypeIdInProgressTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Submitted).WithLegacyApplicationId(0).Build();
            var candidate = new CandidateSummaryBuilder().WithCandidateId(vacancyApplication.CandidateId).WithLegacyCandidateId(0).Build();
            const int applicationId = 42;
            var applicationIds = new Dictionary<Guid, int>
            {
                {vacancyApplication.Id, applicationId}
            };
            const int applicationStatusTypeIdInProgress = 3;
            var sourceApplicationSummaries = new Dictionary<int, ApplicationSummary>
            {
                { applicationId, new ApplicationSummary {ApplicationStatusTypeId = applicationStatusTypeIdInProgress} }
            };

            //Act
            var applicationWithSubVacancy = _applicationMappers.MapApplication(vacancyApplication, candidate.LegacyCandidateId, applicationIds, sourceApplicationSummaries, new Dictionary<int, int>(), new Dictionary<int, SubVacancy>());
            var application = applicationWithSubVacancy.Application;

            //Assert
            application.ApplicationId.Should().Be(applicationId);
            application.CandidateId.Should().Be(candidate.LegacyCandidateId);
            application.ApplicationStatusTypeId.Should().Be(applicationStatusTypeIdInProgress);
            applicationWithSubVacancy.UpdateStatusTo.Should().Be(ApplicationStatuses.InProgress);
        }

        [Test]
        public void SourceApplicationStatusTypeIdUnsuccessfulTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Submitted).WithLegacyApplicationId(0).Build();
            var candidate = new CandidateSummaryBuilder().WithCandidateId(vacancyApplication.CandidateId).WithLegacyCandidateId(0).Build();
            const int applicationId = 42;
            var applicationIds = new Dictionary<Guid, int>
            {
                {vacancyApplication.Id, applicationId}
            };
            const int applicationStatusTypeIdInProgress = 3;
            const int applicationStatusTypeIdUnsuccessful = 5;
            var sourceApplicationSummaries = new Dictionary<int, ApplicationSummary>
            {
                { applicationId, new ApplicationSummary {ApplicationStatusTypeId = applicationStatusTypeIdUnsuccessful} }
            };

            //Act
            var applicationWithSubVacancy = _applicationMappers.MapApplication(vacancyApplication, candidate.LegacyCandidateId, applicationIds, sourceApplicationSummaries, new Dictionary<int, int>(), new Dictionary<int, SubVacancy>());
            var application = applicationWithSubVacancy.Application;

            //Assert
            application.ApplicationId.Should().Be(applicationId);
            application.CandidateId.Should().Be(candidate.LegacyCandidateId);
            //We're going to set old applications with an incorrect outcome to in progress so as not to alert the candidates about older outcomes
            application.ApplicationStatusTypeId.Should().Be(applicationStatusTypeIdInProgress);
            applicationWithSubVacancy.UpdateStatusTo.Should().Be(ApplicationStatuses.InProgress);
            //application.ApplicationStatusTypeId.Should().Be(applicationStatusTypeIdUnsuccessful);
            //applicationWithSubVacancy.UpdateStatusTo.Should().Be(ApplicationStatuses.Unsuccessful);
        }

        [Test]
        public void SourceApplicationStatusTypeIdSuccessfulTest()
        {
            //Arrange
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Submitted).WithLegacyApplicationId(0).Build();
            var candidate = new CandidateSummaryBuilder().WithCandidateId(vacancyApplication.CandidateId).WithLegacyCandidateId(0).Build();
            const int applicationId = 42;
            var applicationIds = new Dictionary<Guid, int>
            {
                {vacancyApplication.Id, applicationId}
            };
            const int applicationStatusTypeIdInProgress = 3;
            const int applicationStatusTypeIdSuccessful = 6;
            var sourceApplicationSummaries = new Dictionary<int, ApplicationSummary>
            {
                { applicationId, new ApplicationSummary {ApplicationStatusTypeId = applicationStatusTypeIdSuccessful} }
            };

            //Act
            var applicationWithSubVacancy = _applicationMappers.MapApplication(vacancyApplication, candidate.LegacyCandidateId, applicationIds, sourceApplicationSummaries, new Dictionary<int, int>(), new Dictionary<int, SubVacancy>());
            var application = applicationWithSubVacancy.Application;

            //Assert
            application.ApplicationId.Should().Be(applicationId);
            application.CandidateId.Should().Be(candidate.LegacyCandidateId);
            application.ApplicationStatusTypeId.Should().Be(applicationStatusTypeIdInProgress);
            applicationWithSubVacancy.UpdateStatusTo.Should().Be(ApplicationStatuses.InProgress);
            //We're going to set old applications with an incorrect outcome to in progress so as not to alert the candidates about older outcomes
            //application.ApplicationStatusTypeId.Should().Be(applicationStatusTypeIdSuccessful);
            //applicationWithSubVacancy.UpdateStatusTo.Should().Be(ApplicationStatuses.Successful);
        }

        [Test]
        public void SourceSubVacancyTest()
        {
            //Arrange
            const int legacyApplicationId = 42;
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Unsuccessful).WithLegacyApplicationId(legacyApplicationId).Build();
            const int applicationId = -42;
            var applicationIds = new Dictionary<Guid, int>
            {
                {vacancyApplication.Id, applicationId}
            };
            var subVacancy = new SubVacancy {SubVacancyId = 1, VacancyId = 2, AllocatedApplicationId = legacyApplicationId, StartDate = DateTime.Now.AddDays(7)};
            var sourceSubVacancies = new Dictionary<int, SubVacancy>
            {
                { legacyApplicationId, subVacancy }
            };

            //Act
            var application = _applicationMappers.MapApplication(vacancyApplication, legacyApplicationId, applicationIds, new Dictionary<int, ApplicationSummary>(), new Dictionary<int, int>(), sourceSubVacancies);

            //Assert
            application.Application.ApplicationId.Should().Be(applicationId);
            application.SubVacancy.Should().NotBeNull();
            application.SubVacancy.Should().Be(subVacancy);
        }

        [Test]
        public void SourceSubVacancyDictionaryTest()
        {
            //Arrange
            const int legacyApplicationId = 42;
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Unsuccessful).WithLegacyApplicationId(legacyApplicationId).Build();
            const int applicationId = -42;
            var applicationIds = new Dictionary<Guid, int>
            {
                {vacancyApplication.Id, applicationId}
            };
            var subVacancy = new SubVacancy { SubVacancyId = 1, VacancyId = 2, AllocatedApplicationId = legacyApplicationId, StartDate = DateTime.Now.AddDays(7), ILRNumber = "123456"};
            var sourceSubVacancies = new Dictionary<int, SubVacancy>
            {
                { legacyApplicationId, subVacancy }
            };

            //Act
            var applicationWithHistory = _applicationMappers.MapApplicationWithHistory(vacancyApplication, legacyApplicationId, applicationIds, new Dictionary<int, ApplicationSummary>(), new Dictionary<int, int>(), sourceSubVacancies, new Dictionary<int, Dictionary<int, int>>(), new Dictionary<int, List<ApplicationHistorySummary>>());
            var subVacancyDictionary = _applicationMappers.MapSubVacancyDictionary(applicationWithHistory.ApplicationWithSubVacancy.SubVacancy);

            //Assert
            subVacancyDictionary["SubVacancyId"].Should().Be(subVacancy.SubVacancyId);
            subVacancyDictionary["VacancyId"].Should().Be(subVacancy.VacancyId);
            subVacancyDictionary["AllocatedApplicationId"].Should().Be(subVacancy.AllocatedApplicationId);
            subVacancyDictionary["StartDate"].Should().Be(subVacancy.StartDate);
            subVacancyDictionary["ILRNumber"].Should().Be(subVacancy.ILRNumber);
        }

        [Test]
        public void SchoolAttendedTest()
        {
            //Arrange
            var applicationTemplate = new ApplicationTemplate
            {
                EducationHistory = new Education
                {
                    Institution = "John Port School",
                    FromYear = 1990,
                    ToYear = 1997
                }
            };
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Submitted).WithApplicationTemplate(applicationTemplate).Build();
            var candidate = new CandidateSummaryBuilder().WithCandidateId(vacancyApplication.CandidateId).Build();

            //Act
            var applicationWithSubVacancy = _applicationMappers.MapApplication(vacancyApplication, candidate.LegacyCandidateId, new Dictionary<Guid, int>(), new Dictionary<int, ApplicationSummary>(), new Dictionary<int, int>(), new Dictionary<int, SubVacancy>());

            //Assert
            applicationWithSubVacancy.SchoolAttended.Should().NotBeNull();
            applicationWithSubVacancy.SchoolAttended.SchoolAttendedId.Should().Be(0);
            applicationWithSubVacancy.SchoolAttended.CandidateId.Should().Be(candidate.LegacyCandidateId);
            applicationWithSubVacancy.SchoolAttended.SchoolId.Should().Be(null);
            applicationWithSubVacancy.SchoolAttended.OtherSchoolName.Should().Be(applicationTemplate.EducationHistory.Institution);
            applicationWithSubVacancy.SchoolAttended.OtherSchoolTown.Should().BeNull();
            applicationWithSubVacancy.SchoolAttended.StartDate.Should().Be(new DateTime(applicationTemplate.EducationHistory.FromYear, 1, 1));
            applicationWithSubVacancy.SchoolAttended.EndDate.Should().Be(new DateTime(applicationTemplate.EducationHistory.ToYear, 1, 1));
            applicationWithSubVacancy.SchoolAttended.ApplicationId.Should().Be(vacancyApplication.LegacyApplicationId);
        }

        [Test]
        public void SchoolAttendedDictionaryTest()
        {
            //Arrange
            var applicationTemplate = new ApplicationTemplate
            {
                EducationHistory = new Education
                {
                    Institution = "John Port School",
                    FromYear = 1990,
                    ToYear = 1997
                }
            };
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Submitted).WithApplicationTemplate(applicationTemplate).Build();
            var candidate = new CandidateSummaryBuilder().WithCandidateId(vacancyApplication.CandidateId).Build();

            //Act
            var applicationWithSubVacancy = _applicationMappers.MapApplication(vacancyApplication, candidate.LegacyCandidateId, new Dictionary<Guid, int>(), new Dictionary<int, ApplicationSummary>(), new Dictionary<int, int>(), new Dictionary<int, SubVacancy>());
            var schoolAttendedDictionary = applicationWithSubVacancy.SchoolAttended.MapSchoolAttendedDictionary();

            //Assert
            schoolAttendedDictionary["SchoolAttendedId"].Should().Be(0);
            schoolAttendedDictionary["CandidateId"].Should().Be(candidate.LegacyCandidateId);
            schoolAttendedDictionary["SchoolId"].Should().Be(null);
            schoolAttendedDictionary["OtherSchoolName"].Should().Be(applicationTemplate.EducationHistory.Institution);
            schoolAttendedDictionary["OtherSchoolTown"].Should().BeNull();
            schoolAttendedDictionary["StartDate"].Should().Be(new DateTime(applicationTemplate.EducationHistory.FromYear, 1, 1));
            schoolAttendedDictionary["EndDate"].Should().Be(new DateTime(applicationTemplate.EducationHistory.ToYear, 1, 1));
            schoolAttendedDictionary["ApplicationId"].Should().Be(vacancyApplication.LegacyApplicationId);
        }

        [Test]
        public void SourceSchoolAttendedTest()
        {
            //Arrange
            const int legacyApplicationId = 42;
            const int legacyCandidateId = 43;
            var applicationTemplate = new ApplicationTemplate
            {
                EducationHistory = new Education
                {
                    Institution = "John Port School",
                    FromYear = 1990,
                    ToYear = 1997
                }
            };
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Submitted).WithLegacyApplicationId(legacyApplicationId).WithApplicationTemplate(applicationTemplate).Build();
            const int applicationId = -42;
            var applicationIds = new Dictionary<Guid, int>
            {
                {vacancyApplication.Id, applicationId}
            };
            const int schoolAttendedId = 44;
            var schoolAttendedIds = new Dictionary<int, int>
            {
                {applicationId, schoolAttendedId}
            };

            //Act
            var applicationWithSubVacancy = _applicationMappers.MapApplication(vacancyApplication, legacyCandidateId, applicationIds, new Dictionary<int, ApplicationSummary>(), schoolAttendedIds, new Dictionary<int, SubVacancy>());

            //Assert
            applicationWithSubVacancy.SchoolAttended.Should().NotBeNull();
            applicationWithSubVacancy.SchoolAttended.SchoolAttendedId.Should().Be(schoolAttendedId);
            applicationWithSubVacancy.SchoolAttended.CandidateId.Should().Be(legacyCandidateId);
            applicationWithSubVacancy.SchoolAttended.SchoolId.Should().Be(null);
            applicationWithSubVacancy.SchoolAttended.OtherSchoolName.Should().Be(applicationTemplate.EducationHistory.Institution);
            applicationWithSubVacancy.SchoolAttended.OtherSchoolTown.Should().BeNull();
            applicationWithSubVacancy.SchoolAttended.StartDate.Should().Be(new DateTime(applicationTemplate.EducationHistory.FromYear, 1, 1));
            applicationWithSubVacancy.SchoolAttended.EndDate.Should().Be(new DateTime(applicationTemplate.EducationHistory.ToYear, 1, 1));
            applicationWithSubVacancy.SchoolAttended.ApplicationId.Should().Be(applicationId);
        }

        [Test]
        public void EmptySchoolAttendedTest()
        {
            //Arrange
            var applicationTemplate = new ApplicationTemplate
            {
                EducationHistory = new Education()
            };
            var vacancyApplication = new VacancyApplicationBuilder().WithStatus(ApplicationStatuses.Submitted).WithApplicationTemplate(applicationTemplate).Build();
            var candidate = new CandidateSummaryBuilder().WithCandidateId(vacancyApplication.CandidateId).Build();

            //Act
            var applicationWithSubVacancy = _applicationMappers.MapApplication(vacancyApplication, candidate.LegacyCandidateId, new Dictionary<Guid, int>(), new Dictionary<int, ApplicationSummary>(), new Dictionary<int, int>(), new Dictionary<int, SubVacancy>());

            //Assert
            applicationWithSubVacancy.SchoolAttended.Should().BeNull();
        }
    }
}