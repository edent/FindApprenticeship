﻿namespace SFA.Apprenticeships.Application.Employer.Strategies
{
    using Domain.Entities.Raa.Parties;

    public interface ISaveEmployerStrategy
    {
        Employer Save(Employer employer);
    }
}