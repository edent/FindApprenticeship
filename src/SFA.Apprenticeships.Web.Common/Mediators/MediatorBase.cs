﻿using FluentValidation.Results;
using SFA.Apprenticeships.Web.Common.Constants;

namespace SFA.Apprenticeships.Web.Common.Mediators
{
    using System.Collections.Generic;

    public abstract class MediatorBase
    {
        // TODO replace with one constructor : http://c2.com/cgi/wiki?HighlanderPrinciple
        protected static MediatorResponse GetMediatorResponse(string code, ValidationResult validationResult = null, object parameters = null)
        {
            var response = new MediatorResponse
            {
                Code = code,
                ValidationResult = validationResult,
                Parameters = parameters
            };

            return response;
        }

        protected static MediatorResponse GetMediatorResponse(string code, string message, UserMessageLevel level, object parameters = null)
        {
            var response = new MediatorResponse
            {
                Code = code,
                Message = new MediatorResponseMessage
                {
                    Text = message,
                    Level = level
                },
                Parameters = parameters
            };

            return response;
        }

        protected static MediatorResponse<T> GetMediatorResponse<T>(string code, T viewModel = default(T), ValidationResult validationResult = null, object parameters = null, MediatorResponseMessage message = null)
        {
            var response = new MediatorResponse<T>
            {
                Code = code,
                ViewModel = viewModel,
                ValidationResult = validationResult,
                Parameters = parameters,
                Message = message
            };

            return response;
        }

        protected static MediatorResponse<T> GetMediatorResponse<T>(string code, T viewModel, ValidationResult validationResult, string message, UserMessageLevel level, object parameters = null)
        {
            var response = new MediatorResponse<T>
            {
                Code = code,
                ViewModel = viewModel,
                Message = new MediatorResponseMessage
                {
                    Text = message,
                    Level = level
                },
                ValidationResult = validationResult,
                Parameters = parameters
            };

            return response;
        }

        protected static MediatorResponse<T> GetMediatorResponse<T>(string code, T viewModel, string message, UserMessageLevel level, object parameters = null)
        {
            var response = new MediatorResponse<T>
            {
                Code = code,
                ViewModel = viewModel,
                Message = new MediatorResponseMessage
                {
                    Text = message,
                    Level = level
                },
                Parameters = parameters
            };

            return response;
        }

        protected static MediatorResponse<T> GetMediatorResponse<T>(string code, T viewModel, List<string> messages, UserMessageLevel level, object parameters = null)
        {
            var response = new MediatorResponse<T>
            {
                Code = code,
                ViewModel = viewModel,
                Message = new MediatorResponseMessage
                {
                    Text = string.Join("<br/>", messages),
                    Level = level
                },
                Parameters = parameters
            };

            return response;
        }
    }
}