﻿namespace SFA.Apprenticeships.Web.Candidate.Mappers.Resolvers
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using Application.Interfaces.Search;
    using Application.Interfaces.Vacancies;
    using Domain.Entities.Vacancies.Apprenticeships;
    using ViewModels.VacancySearch;

    internal class ApprenticeshipSearchResultsResolver : ITypeConverter<SearchResults<ApprenticeshipSearchResponse, ApprenticeshipSearchParameters>, ApprenticeshipSearchResponseViewModel>
    {
        public ApprenticeshipSearchResponseViewModel Convert(ResolutionContext context)
        {
            var source = (SearchResults<ApprenticeshipSearchResponse, ApprenticeshipSearchParameters>)context.SourceValue;

            var viewModel = new ApprenticeshipSearchResponseViewModel
            {
                Vacancies = context.Engine.Map<IEnumerable<ApprenticeshipSearchResponse>, IEnumerable<ApprenticeshipVacancySummaryViewModel>>(source.Results.OrderBy(v=>v.Id))
            };

            return viewModel;
        }
    }
}