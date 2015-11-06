﻿namespace SFA.Apprenticeships.Web.Recruit.Converters
{
    using Domain.Entities.Organisations;
    using Raa.Common.ViewModels.Vacancy;
    using ViewModels.VacancyPosting;

    public static class EmployerViewModelConverter
    {
        public static EmployerResultViewModel ConvertToResult(this EmployerViewModel employer)
        {
            var viewModel = new EmployerResultViewModel
            {
                Ern = employer.Ern,
                //EmployerId = 
                EmployerName = employer.Name,
                Address = employer.Address
            };

            return viewModel;
        }

        public static EmployerResultViewModel ConvertToResult(this Employer employer)
        {
            var viewModel = new EmployerResultViewModel
            {
                Ern = employer.Ern,
                //EmployerId = 
                EmployerName = employer.Name,
                Address = employer.Address.Convert()
            };

            return viewModel;
        }

        public static EmployerViewModel Convert(this Employer employer)
        {
            var viewModel = new EmployerViewModel
            {
                Ern = employer.Ern,
                Name = employer.Name,
                Address = employer.Address.Convert()
            };

            return viewModel;
        }
    }
}