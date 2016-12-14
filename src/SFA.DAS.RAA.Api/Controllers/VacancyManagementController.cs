﻿namespace SFA.DAS.RAA.Api.Controllers
{
    using System;
    using System.Web.Http;
    using Apprenticeships.Domain.Entities.Raa;
    using Apprenticeships.Domain.Entities.Raa.Vacancies;
    using Models;
    using Providers;
    using Swashbuckle.Swagger.Annotations;

    [Authorize(Roles = Roles.Provider)]
    [RoutePrefix("vacancy")]
    public class VacancyManagementController : ApiController
    {
        private readonly IVacancyProvider _vacancyProvider;

        public VacancyManagementController(IVacancyProvider vacancyProvider)
        {
            _vacancyProvider = vacancyProvider;
        }

        [Route("wage")]
        [SwaggerOperation("EditVacancyWage")]
        [HttpPut]
        public Vacancy EditWage(WageUpdate wage, int? vacancyId = null, int? vacancyReferenceNumber = null, Guid? vacancyGuid = null)
        {
            var vacancy = _vacancyProvider.Get(vacancyId, vacancyReferenceNumber, vacancyGuid);
            //TODO: Loads of validation
            vacancy.Wage.Amount = wage.Amount;
            vacancy.Wage.Unit = wage.Unit;
            return vacancy;
        }
    }
}