﻿namespace SFA.Apprenticeships.Domain.Entities.Raa.Vacancies
{
    using Entities.Vacancies;
    using Locations;
    using Reference;
    using System;

    public class VacancySummary
    {
        public int VacancyId { get; set; }
        public int VacancyOwnerRelationshipId { get; set; }
        public int VacancyReferenceNumber { get; set; }
        public Guid VacancyGuid { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string WorkingWeek { get; set; }
        public string ExpectedDuration { get; set; }
        public DurationType DurationType { get; set; }
        public int? Duration { get; set; }
        public DateTime? ClosingDate { get; set; }
        public DateTime? PossibleStartDate { get; set; }
        public bool? OfflineVacancy { get; set; }
        public int NoOfOfflineApplicants { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public DateTime? DateFirstSubmitted { get; set; }
        public DateTime? DateStartedToQA { get; set; }
        public string QAUserName { get; set; }
        public DateTime? DateQAApproved { get; set; }
        public int SubmissionCount { get; set; }
        public int? VacancyManagerId { get; set; }
        public int? DeliveryOrganisationId { get; set; }
        public int? ParentVacancyId { get; set; }
        public TrainingType TrainingType { get; set; }
        public ApprenticeshipLevel ApprenticeshipLevel { get; set; }
        //TODO: Use Id rather than code name
        public string FrameworkCodeName { get; set; }
        public int? StandardId { get; set; }
        public string SectorCodeName { get; set; }
        public VacancyStatus Status { get; set; }
        public bool? IsEmployerLocationMainApprenticeshipLocation { get; set; }
        public string EmployerAnonymousName { get; set; }
        public string EmployerAnonymousReason { get; set; }
        public bool? IsAnonymousEmployer { get; set; }
        public string AnonymousAboutTheEmployer { get; set; }
        public int? NumberOfPositions { get; set; }
        public VacancyType VacancyType { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public PostalAddress Address { get; set; }
        public int ContractOwnerId { get; set; }
        public int OriginalContractOwnerId { get; set; }
        public RegionalTeam RegionalTeam { get; set; }
        public VacancyLocationType VacancyLocationType { get; set; }
        public int EmployerId { get; set; }

        public DateTime LiveClosingDate
        {
            get
            {
                if (Status != VacancyStatus.Live && Status != VacancyStatus.Closed && Status != VacancyStatus.Completed)
                    throw new InvalidOperationException(Status.ToString());
                if (ClosingDate == null)
                    throw new InvalidOperationException($"Null closing date found for live vacancy {VacancyId}");
                return ClosingDate.Value;
            }
        }

        public DateTime SyntheticUpdatedDateTime
        {
            get
            {
                return UpdatedDateTime ?? new DateTime(2016, 6, 30, 0, 0, 0, DateTimeKind.Utc);
            }
        }

        public string EmployerName { get; set; }
        public string EmployerLocation { get; set; }

        public int NewApplicationCount { get; set; }
        public int ApplicantCount { get; set; }

        public string ProviderTradingName { get; set; }
        public DateTime CreatedDate { get; set; }

        public Wage Wage { get; set; }
    }
}
