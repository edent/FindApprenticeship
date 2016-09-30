﻿namespace SFA.Apprenticeships.Domain.Raa.Interfaces.Repositories
{
    using System.Collections.Generic;
    using Entities.Raa.Api;
    using Models;

    public interface IApiUserRepository
    {
        IEnumerable<ApiUser> SearchApiUsers(ApiUserSearchParameters searchParameters);
    }
}