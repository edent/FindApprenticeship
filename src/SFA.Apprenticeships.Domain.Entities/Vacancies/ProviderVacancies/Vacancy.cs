﻿namespace SFA.Apprenticeships.Domain.Entities.Vacancies.ProviderVacancies
{
    using System;
    using Organisations;

    public abstract class Vacancy : BaseEntity
    {
        public long VacancyReferenceNumber { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string WorkingWeek { get; set; }
        public decimal? WeeklyWage { get; set; }
        public int? Duration { get; set; }
        public DateTime? PublishDate { get; set; }
        public DateTime? ClosingDate { get; set; }
        public DateTime? PossibleStartDate { get; set; }
        public string LongDescription { get; set; }
        public string DesiredSkills { get; set; }
        public string FutureProspects { get; set; }
        public string PersonalQualities { get; set; }
        public string ThingsToConsider { get; set; }
        public string DesiredQualifications { get; set; }
        public string FirstQuestion { get; set; }
        public string SecondQuestion { get; set; }
        public Employer Employer { get; set; }
    }
}
