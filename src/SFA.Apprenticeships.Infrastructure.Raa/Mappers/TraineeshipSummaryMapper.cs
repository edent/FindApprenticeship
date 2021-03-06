﻿namespace SFA.Apprenticeships.Infrastructure.Raa.Mappers
{
    using Domain.Entities.Extensions;
    using Domain.Entities.Locations;
    using Domain.Entities.Raa.Parties;
    using Domain.Entities.Raa.Vacancies;
    using Domain.Entities.ReferenceData;
    using Domain.Entities.Vacancies.Traineeships;
    using Extensions;
    using SFA.Apprenticeships.Application.Interfaces;
    using System;
    using System.Collections.Generic;

    public class TraineeshipSummaryMapper
    {
        public static TraineeshipSummary GetTraineeshipSummary(VacancySummary vacancy, Employer employer, Provider provider, IList<Category> categories, ILogService logService)
        {
            try
            {
                //Manually mapping rather than using automapper as the two enties are significantly different

                var location = GetGeoPoint(vacancy);

                var category = vacancy.GetCategory(categories);
                var subcategory = vacancy.GetSubCategory(categories);

                LogCategory(vacancy, logService, category);

                var summary = new TraineeshipSummary
                {
                    Id = vacancy.VacancyId,
                    //Goes into elastic unformatted for searching
                    VacancyReference = vacancy.VacancyReferenceNumber.ToString(),
                    Title = vacancy.Title,
                    // ReSharper disable PossibleInvalidOperationException
                    PostedDate = vacancy.DateQAApproved.Value,
                    StartDate = vacancy.PossibleStartDate.Value,
                    ClosingDate = vacancy.ClosingDate.Value,
                    // ReSharper restore PossibleInvalidOperationException
                    Description = vacancy.ShortDescription,
                    NumberOfPositions = vacancy.NumberOfPositions,
                    EmployerName = string.IsNullOrWhiteSpace(vacancy.EmployerAnonymousName) ? employer.FullName : vacancy.EmployerAnonymousName,
                    IsEmployerAnonymous = !string.IsNullOrEmpty(vacancy.EmployerAnonymousName),
                    ProviderName = provider.TradingName,
                    IsPositiveAboutDisability = employer.IsPositiveAboutDisability,
                    Location = location,
                    CategoryCode = category.CodeName,
                    Category = category.FullName,
                    SubCategoryCode = subcategory.CodeName,
                    SubCategory = subcategory.FullName,
                    AnonymousEmployerName = vacancy.EmployerAnonymousName
                };

                return summary;
            }
            catch (Exception ex)
            {
                logService.Error($"Failed to map traineeship with Id: {vacancy?.VacancyId ?? 0}", ex);
                return null;
            }
        }

        private static GeoPoint GetGeoPoint(VacancySummary vacancy)
        {
            if (vacancy.Address?.GeoPoint == null)
            {
                return new GeoPoint();
            }

            return new GeoPoint
            {
                Latitude = vacancy.Address.GeoPoint.Latitude,
                Longitude = vacancy.Address.GeoPoint.Longitude
            };
        }

        private static void LogCategory(VacancySummary vacancy, ILogService logService, Category category)
        {
            if (vacancy.SectorCodeName != null && !category.IsValid())
            {
                logService.Warn("Cannot find a category for the traineeship with Id {0}", vacancy.VacancyId);
            }
        }
    }
}