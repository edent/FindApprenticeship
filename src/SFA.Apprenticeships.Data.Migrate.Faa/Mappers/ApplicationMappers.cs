﻿namespace SFA.Apprenticeships.Data.Migrate.Faa.Mappers
{
    using System;
    using System.Collections.Generic;
    using Entities;
    using Entities.Mongo;
    using Entities.Sql;
    using Repository.Sql;
    using SFA.Infrastructure.Interfaces;

    public class ApplicationMappers : IApplicationMappers
    {
        private readonly ILogService _logService;

        public ApplicationMappers(ILogService logService)
        {
            _logService = logService;
        }

        private static readonly IDictionary<string, int> WithdrawnOrDeclinedReasonIdMap = new Dictionary<string, int>
        {
            {"No longer interested", 1},
            {"Accepted another Apprenticeship offer", 2},
            {"Accepted an alternative job", 3},
            {"Decided to go to college", 4},
            {"Decided to stay on at 6th form", 5},
            {"Want to be able to apply for other Apprenticeships", 6},
            {"Personal reasons", 7},
            {"Moving away", 8},
            {"Pay or Conditions not acceptable", 9},
            {"Other (please specify)", 10}
        };

        private static readonly IDictionary<string, int> UnsuccessfulReasonIdMap = new Dictionary<string, int>
        {
            {"Please Select...", 0},
            {"You’re not eligible for an apprenticeship", 1},
            {"You haven’t met the requirements", 2},
            {"You met the employer’s/provider's requirements but have been unsuccessful", 3},
            {"You didn’t attend the interview", 4},
            {"The apprenticeship has been withdrawn", 5},
            {"You've been unsuccessful - other", 6},
            {"Not suitable for vacancy due to journey / distance involved", 7},
            {"Failed initial assessment test", 8},
            {"Employer withdrew vacancy", 9},
            {"Accepted an alternative apprenticeship position", 10},
            {"Have found other employment", 11},
            {"Taken up other learning or education", 12},
            {"Other reason for Withdrawing Application", 13},
            {"Other", 14},
            {"You’re not eligible for a traineeship", 15},
            {"The training provider couldn’t contact you", 16},
            {"Offered the position but turned it down", 17}
        };

        public IDictionary<Guid, int> GetApplicationIds(IDictionary<Guid, ApplicationIds> destinationApplicationIds, IDictionary<int, Dictionary<int, ApplicationIds>> candidateApplicationIds, IList<VacancyApplication> vacancyApplications, IDictionary<Guid, int> candidateIds)
        {
            var applicationIds = new Dictionary<Guid, int>(destinationApplicationIds.Count);

            foreach (var destinationApplicationId in destinationApplicationIds.Values)
            {
                applicationIds[destinationApplicationId.ApplicationGuid] = destinationApplicationId.ApplicationId;

                var candidateId = destinationApplicationId.CandidateId;
                var vacancyId = destinationApplicationId.VacancyId;

                if (candidateApplicationIds.ContainsKey(candidateId) && candidateApplicationIds[candidateId].ContainsKey(vacancyId))
                {
                    var candidateApplicationId = candidateApplicationIds[candidateId][vacancyId];
                    if (destinationApplicationId.ApplicationGuid != candidateApplicationId.ApplicationGuid)
                    {
                        _logService.Warn($"Application with Id {destinationApplicationId.ApplicationId}, {candidateApplicationId.ApplicationId} seems to have changed guid {destinationApplicationId.ApplicationGuid}, {candidateApplicationId.ApplicationGuid}");
                        applicationIds.Remove(destinationApplicationId.ApplicationGuid);
                        applicationIds[candidateApplicationId.ApplicationGuid] = candidateApplicationId.ApplicationId;
                    }
                }
            }

            foreach (var vacancyApplication in vacancyApplications)
            {
                if (candidateIds.ContainsKey(vacancyApplication.CandidateId))
                {
                    var candidateId = candidateIds[vacancyApplication.CandidateId];
                    var vacancyId = vacancyApplication.Vacancy.Id;
                    if (candidateApplicationIds.ContainsKey(candidateId) && candidateApplicationIds[candidateId].ContainsKey(vacancyId))
                    {
                        var candidateApplicationId = candidateApplicationIds[candidateId][vacancyId];
                        if (applicationIds.ContainsKey(vacancyApplication.Id))
                        {
                            if (applicationIds[vacancyApplication.Id] != candidateApplicationId.ApplicationId)
                            {
                                _logService.Warn($"Application id {candidateApplicationId.ApplicationId} for application guid {vacancyApplication.Id} does not match application id {applicationIds[vacancyApplication.Id]}. This suggests the id has changed post submission");
                            }
                        }
                        else
                        {
                            _logService.Warn($"Found application id {candidateApplicationId.ApplicationId} for application guid {vacancyApplication.Id} via candidate id {candidateId} and vacancy id {vacancyId} rather than via application guid {candidateApplicationId.ApplicationGuid}. This suggests the id has changed post submission");
                        }

                        applicationIds[vacancyApplication.Id] = candidateApplicationId.ApplicationId;
                    }
                }
            }

            return applicationIds;
        }

        public ApplicationWithSubVacancy MapApplication(VacancyApplication apprenticeshipApplication, int candidateId, IDictionary<Guid, int> applicationIds, IDictionary<int, ApplicationSummary> sourceApplicationSummaries, IDictionary<int, int> schoolAttendedIds, IDictionary<int, SubVacancy> subVacancies)
        {
            var applicationId = GetApplicationId(apprenticeshipApplication, applicationIds);
            var sourceApplicationId = GetSourceApplicationId(applicationId, apprenticeshipApplication.LegacyApplicationId);
            var unsuccessfulReasonId = GetUnsuccessfulReasonId(apprenticeshipApplication.UnsuccessfulReason);
            var sourceApplicationSummary = sourceApplicationSummaries.ContainsKey(sourceApplicationId) ? sourceApplicationSummaries[sourceApplicationId] : null;
            return new ApplicationWithSubVacancy
            {
                Application = new Application
                {
                    ApplicationId = applicationId,
                    CandidateId = candidateId,
                    VacancyId = apprenticeshipApplication.Vacancy.Id,
                    ApplicationStatusTypeId = GetApplicationStatusTypeId(apprenticeshipApplication.Status),
                    WithdrawnOrDeclinedReasonId = GetWithdrawnOrDeclinedReasonId(apprenticeshipApplication.WithdrawnOrDeclinedReason),
                    UnsuccessfulReasonId = unsuccessfulReasonId,
                    OutcomeReasonOther = GetOutcomeReasonOther(unsuccessfulReasonId, sourceApplicationSummary),
                    NextActionId = 0,
                    NextActionOther = null,
                    AllocatedTo = GetAllocatedTo(unsuccessfulReasonId),
                    CVAttachmentId = null,
                    BeingSupportedBy = null,
                    LockedForSupportUntil = null,
                    WithdrawalAcknowledged = GetWithdrawalAcknowledged(unsuccessfulReasonId),
                    ApplicationGuid = apprenticeshipApplication.Id,
                },
                SchoolAttended = MapSchoolAttended(apprenticeshipApplication, schoolAttendedIds, applicationId, candidateId),
                SubVacancy = GetSubVacancy(subVacancies, applicationId, sourceApplicationId)
            };
        }

        public ApplicationWithHistory MapApplicationWithHistory(VacancyApplication apprenticeshipApplication, int candidateId, IDictionary<Guid, int> applicationIds, IDictionary<int, ApplicationSummary> sourceApplicationSummaries, IDictionary<int, int> schoolAttendedIds, IDictionary<int, SubVacancy> subVacancies, IDictionary<int, Dictionary<int, int>> applicationHistoryIds, IDictionary<int, List<ApplicationHistorySummary>> sourceApplicationHistorySummaries)
        {
            var applicationWithSubVacancy = MapApplication(apprenticeshipApplication, candidateId, applicationIds, sourceApplicationSummaries, schoolAttendedIds, subVacancies);
            var applicationHistory = apprenticeshipApplication.MapApplicationHistory(applicationWithSubVacancy.Application.ApplicationId, applicationHistoryIds, sourceApplicationHistorySummaries);
            return new ApplicationWithHistory {ApplicationWithSubVacancy = applicationWithSubVacancy, ApplicationHistory = applicationHistory};
        }

        public IDictionary<string, object> MapApplicationDictionary(Application application)
        {
            return new Dictionary<string, object>
            {
                {"ApplicationId", application.ApplicationId},
                {"CandidateId", application.CandidateId},
                {"VacancyId", application.VacancyId},
                {"ApplicationStatusTypeId", application.ApplicationStatusTypeId},
                {"WithdrawnOrDeclinedReasonId", application.WithdrawnOrDeclinedReasonId},
                {"UnsuccessfulReasonId", application.UnsuccessfulReasonId},
                {"OutcomeReasonOther", application.OutcomeReasonOther},
                {"NextActionId", application.NextActionId},
                {"NextActionOther", application.NextActionOther},
                {"AllocatedTo", application.AllocatedTo},
                {"CVAttachmentId", application.CVAttachmentId},
                {"BeingSupportedBy", application.BeingSupportedBy},
                {"LockedForSupportUntil", application.LockedForSupportUntil},
                {"WithdrawalAcknowledged", application.WithdrawalAcknowledged},
                {"ApplicationGuid", application.ApplicationGuid}
            };
        }

        public IDictionary<string, object> MapSubVacancyDictionary(SubVacancy subVacancy)
        {
            return new Dictionary<string, object>
            {
                {"SubVacancyId", subVacancy.SubVacancyId},
                {"VacancyId", subVacancy.VacancyId},
                {"AllocatedApplicationId", subVacancy.AllocatedApplicationId},
                {"StartDate", subVacancy.StartDate},
                {"ILRNumber", subVacancy.ILRNumber}
            };
        }

        private int GetApplicationId(VacancyApplication apprenticeshipApplication, IDictionary<Guid, int> applicationIds)
        {
            if (applicationIds.ContainsKey(apprenticeshipApplication.Id))
            {
                var applicationId = applicationIds[apprenticeshipApplication.Id];
                if (applicationId > 0 && apprenticeshipApplication.LegacyApplicationId != 0 && apprenticeshipApplication.LegacyApplicationId != applicationId)
                {
                    _logService.Warn($"ApplicationId: {applicationId} does not match the LegacyApplicationId: {apprenticeshipApplication.LegacyApplicationId} for application with Id: {apprenticeshipApplication.Id}. This shouldn't change post submission");
                }
                return applicationId;
            }

            return apprenticeshipApplication.LegacyApplicationId;
        }

        private static int GetSourceApplicationId(int applicationId, int legacyApplicationId)
        {
            if (legacyApplicationId != 0 && legacyApplicationId != applicationId)
            {
                return legacyApplicationId;
            }
            return applicationId;
        }

        private static int GetApplicationStatusTypeId(int status)
        {
            switch (status)
            {
                case 5:
                    return 0;
                case 10:
                case 20:
                    return 1;
                case 15:
                    return 4;
                case 30:
                    return 2;
                case 40:
                    return 3;
                case 80:
                    return 6;
                case 90:
                    return 5;
                default: throw new ArgumentException($"Status value {status} was not recognised.");
            }
        }

        private static int GetWithdrawnOrDeclinedReasonId(string withdrawnOrDeclinedReason)
        {
            if (string.IsNullOrEmpty(withdrawnOrDeclinedReason))
            {
                return 0;
            }

            if (WithdrawnOrDeclinedReasonIdMap.ContainsKey(withdrawnOrDeclinedReason))
            {
                return WithdrawnOrDeclinedReasonIdMap[withdrawnOrDeclinedReason];
            }

            return 0;
        }

        private static int GetUnsuccessfulReasonId(string unsuccessfulReason)
        {
            if (string.IsNullOrEmpty(unsuccessfulReason))
            {
                return 0;
            }

            if (UnsuccessfulReasonIdMap.ContainsKey(unsuccessfulReason))
            {
                return UnsuccessfulReasonIdMap[unsuccessfulReason];
            }

            return 0;
        }

        private static string GetOutcomeReasonOther(int unsuccessfulReasonId, ApplicationSummary sourceApplicationSummary)
        {
            //We don't store any outcome reasons in RAA so copy over existing value from source if present
            if (sourceApplicationSummary != null) return sourceApplicationSummary.OutcomeReasonOther;
            return unsuccessfulReasonId == 0 ? null : "";
        }

        private static string GetAllocatedTo(int unsuccessfulReasonId)
        {
            return unsuccessfulReasonId == 0 || unsuccessfulReasonId == 13 ? null : "";
        }

        private static bool? GetWithdrawalAcknowledged(int unsuccessfulReasonId)
        {
            return unsuccessfulReasonId != 10 && unsuccessfulReasonId != 11 && unsuccessfulReasonId != 13;
        }

        private static SchoolAttended MapSchoolAttended(VacancyApplication apprenticeshipApplication, IDictionary<int, int> schoolAttendedIds, int applicationId, int candidateId)
        {
            if (apprenticeshipApplication.CandidateInformation?.EducationHistory == null)
                return null;

            var educationHistory = apprenticeshipApplication.CandidateInformation.EducationHistory;

            if (string.IsNullOrEmpty(educationHistory.Institution) || educationHistory.FromYear == 0 || educationHistory.ToYear == 0)
                return null;

            int schoolAttendedId;
            schoolAttendedIds.TryGetValue(applicationId, out schoolAttendedId);

            return new SchoolAttended
            {
                SchoolAttendedId = schoolAttendedId,
                CandidateId = candidateId,
                SchoolId = null,
                OtherSchoolName = educationHistory.Institution,
                OtherSchoolTown = null,
                StartDate = new DateTime(educationHistory.FromYear, 1, 1),
                EndDate = new DateTime(educationHistory.ToYear, 1, 1),
                ApplicationId = applicationId
            };
        }

        private static SubVacancy GetSubVacancy(IDictionary<int, SubVacancy> subVacancies, int applicationId, int sourceApplicationId)
        {
            var subVacancy = subVacancies.ContainsKey(sourceApplicationId) ? subVacancies[sourceApplicationId] : null;
            if (subVacancy != null)
            {
                subVacancy.AllocatedApplicationId = applicationId;
            }
            return subVacancy;
        }
    }
}
 