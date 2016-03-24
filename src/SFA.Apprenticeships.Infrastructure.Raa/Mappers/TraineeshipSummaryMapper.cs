﻿namespace SFA.Apprenticeships.Infrastructure.Raa.Mappers
{
    using System;
    using System.Collections.Generic;
    using SFA.Infrastructure.Interfaces;
    using Domain.Entities.Locations;
    using Domain.Entities.Raa.Parties;
    using Domain.Entities.Raa.Vacancies;
    using Domain.Entities.ReferenceData;
    using Domain.Entities.Vacancies.Traineeships;
    using Extensions;

    public class TraineeshipSummaryMapper
    {
        public static TraineeshipSummary GetTraineeshipSummary(VacancySummary vacancy, Employer employer, Provider provider, IList<Category> categories, ILogService logService)
        {
            try
            {
                //Manually mapping rather than using automapper as the two enties are significantly different

                //TODO: Geocode new vacancies
                var location = new GeoPoint();
                if (vacancy.Address.GeoPoint != null && vacancy.Address.GeoPoint.Latitude != 0 &&
                    vacancy.Address.GeoPoint.Longitude != 0)
                {
                    location.Latitude = vacancy.Address.GeoPoint.Latitude;
                    location.Longitude = vacancy.Address.GeoPoint.Longitude;
                }
                else
                {
                    //Coventry
                    location.Latitude = 52.4009991288043;
                    location.Longitude = -1.50812239495425;
                }

                var category = vacancy.GetCategory(categories);
                var subcategory = vacancy.GetSubCategory(categories);

                LogCategory(vacancy, logService, category);

                var summary = new TraineeshipSummary
                {
                    Id = (int)vacancy.VacancyReferenceNumber,
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
                    EmployerName = employer.Name,
                    ProviderName = provider.Name,
                    //TODO: Are we going to add this to RAA?
                    //IsPositiveAboutDisability = vacancy.,
                    Location = location,
                    CategoryCode = category.CodeName,
                    Category = category.FullName,
                    SubCategoryCode = subcategory.CodeName,
                    SubCategory = subcategory.FullName
                };

                return summary;
            }
            catch (Exception ex)
            {
                logService.Error($"Failed to map traineeship with Id: {vacancy.VacancyId}", ex);
                return null;
            }
        }

        private static void LogCategory(VacancySummary vacancy, ILogService logService, Category category)
        {
            if (category == Category.UnknownSectorSubjectAreaTier1 ||
                category == Category.InvalidSectorSubjectAreaTier1)
            {
                logService.Warn("Cannot find a category for the traineeship with Id {0}", vacancy.VacancyId);
            }
        }
    }
}