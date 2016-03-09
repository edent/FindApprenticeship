﻿namespace SFA.Apprenticeships.Web.Raa.Common.Mappers.Resolvers
{
    using System;
    using AutoMapper;
    using Domain.Entities.Raa.Locations;
    using Domain.Entities.Raa.Vacancies;
    using Infrastructure.Presentation;
    using ViewModels.Vacancy;
    using Web.Common.ViewModels;
    using Web.Common.ViewModels.Locations;

    /// <summary>
    /// This is meant to replace
    /// SFA.Apprenticeships.Web.Raa.Common.Converters.ApprenticeshipVacancyConverter.ConvertToVacancyViewModel
    /// 
    /// TODO: DI for automapper within Raa websites (manage and recruit), then replace usage of converter (above) with this mapping class
    /// </summary>
    internal sealed class VacancyToVacancySummaryViewModelConverter : ITypeConverter<Vacancy, VacancySummaryViewModel>
    {
        public VacancySummaryViewModel Convert(ResolutionContext context)
        {
            var source = (Vacancy)context.SourceValue;

            var destination = new VacancySummaryViewModel
            {
                VacancyId = source.VacancyId,
                VacancyReferenceNumber = source.VacancyReferenceNumber,
                VacancyType = source.VacancyType,
                Status = source.Status,
                Title = source.Title,
                OwnerPartyId = source.OwnerPartyId,
                //ProviderName = source.ProviderName,
                //EmployerName = source.EmployerName,
                Location = context.Engine.Map<PostalAddress, AddressViewModel>(source.Address),
                OfflineVacancy = source.OfflineVacancy,
                //ApplicationCount = source.ApplicationCount,
                OfflineApplicationClickThroughCount = source.OfflineApplicationClickThroughCount,
                ClosingDate = context.Engine.Map<DateTime?, DateViewModel>(source.ClosingDate),
                DateSubmitted = source.DateSubmitted,
                SubmissionCount = source.SubmissionCount,
                IsEmployerLocationMainApprenticeshipLocation = source.IsEmployerLocationMainApprenticeshipLocation,
                ParentVacancyId = source.ParentVacancyId
            };

            return destination;
        }
    }
}