﻿namespace SFA.Apprenticeships.Web.Raa.Common.ViewModels.Api
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using Constants.ViewModels;
    using Domain.Entities.Raa.Api;

    public class ApiUserViewModel
    {
        public ApiUserViewModel()
        {
            ApiEndpoints = new List<ApiEndpointViewModel>
            {
                new ApiEndpointViewModel { Endpoint = ApiEndpoint.VacancySummary },
                new ApiEndpointViewModel { Endpoint = ApiEndpoint.VacancyDetail },
                new ApiEndpointViewModel { Endpoint = ApiEndpoint.ReferenceData },
                new ApiEndpointViewModel { Endpoint = ApiEndpoint.BulkVacancyUpload },
                new ApiEndpointViewModel { Endpoint = ApiEndpoint.ApplicationTracking }
            };
        }

        [Display(Name = ApiUserViewModelMessages.ExternalSystemId.LabelText)]
        public Guid ExternalSystemId { get; set; }
        [Display(Name = ApiUserViewModelMessages.Password.LabelText)]
        public string Password { get; set; }
        [Display(Name = ApiUserViewModelMessages.CompanyId.LabelText)]
        public string CompanyId { get; set; }
        public ApiBusinessCategory BusinessCategory { get; set; }
        public ApiEmployeeType EmployeeType { get; set; }
        public IList<ApiEndpointViewModel> ApiEndpoints { get; set; }
        public string FullName { get; set; }
        public string TradingName { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNumber { get; set; }

        public string CompanyName
        {
            get
            {
                if(FullName == TradingName)
                {
                    return FullName;
                }
                return $"{TradingName} ({FullName})";
            }
        }

        public string AuthorisedApiEndpoints
        {
            get
            {
                return string.Join(", ", ApiEndpoints.Where(ae => ae.Authorised).Select(ae => ae.Endpoint));
            }
        }
    }
}