﻿namespace SFA.Apprenticeship.Api.AvService.Repositories
{
    using System;
    using Domain;

    public interface IWebServiceConsumerReadRepository
    {
        WebServiceConsumer Get(Guid externalSystemId);
    }
}