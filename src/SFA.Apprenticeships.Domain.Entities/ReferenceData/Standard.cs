﻿namespace SFA.Apprenticeships.Domain.Entities.ReferenceData
{
    using Vacancies.ProviderVacancies.Apprenticeship;

    public class Standard
    {
        public int Id { get; set; }

        public int ApprenticeshipSectorId { get; set; }

        public string Name { get; set; }

        public ApprenticeshipLevel ApprenticeshipLevel { get; set; }
    }
}