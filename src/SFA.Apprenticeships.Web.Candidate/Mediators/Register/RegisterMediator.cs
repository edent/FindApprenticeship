﻿namespace SFA.Apprenticeships.Web.Candidate.Mediators.Register
{
    using System;
    using Common.Constants;
    using Common.Services;
    using Constants.Pages;
    using Domain.Entities.Users;
    using Providers;
    using Validators;
    using ViewModels;
    using ViewModels.Register;

    public class RegisterMediator : MediatorBase, IRegisterMediator
    {
        private readonly ICandidateServiceProvider _candidateServiceProvider;
        private readonly IAuthenticationTicketService _authenticationTicketService;

        private readonly ActivationViewModelServerValidator _activationViewModelServerValidator;
        private readonly ForgottenPasswordViewModelServerValidator _forgottenPasswordViewModelServerValidator;
        private readonly PasswordResetViewModelServerValidator _passwordResetViewModelServerValidator;
        private readonly RegisterViewModelServerValidator _registerViewModelServerValidator;

        public RegisterMediator(ICandidateServiceProvider candidateServiceProvider,
            IAuthenticationTicketService authenticationTicketService,
            RegisterViewModelServerValidator registerViewModelServerValidator,
            ActivationViewModelServerValidator activationViewModelServerValidator,
            ForgottenPasswordViewModelServerValidator forgottenPasswordViewModelServerValidator,
            PasswordResetViewModelServerValidator passwordResetViewModelServerValidator)
        {
            _candidateServiceProvider = candidateServiceProvider;
            _authenticationTicketService = authenticationTicketService;
            _registerViewModelServerValidator = registerViewModelServerValidator;
            _activationViewModelServerValidator = activationViewModelServerValidator;
            _forgottenPasswordViewModelServerValidator = forgottenPasswordViewModelServerValidator;
            _passwordResetViewModelServerValidator = passwordResetViewModelServerValidator;
        }

        public MediatorResponse<RegisterViewModel> Register(RegisterViewModel registerViewModel)
        {
            var emailAddress = string.IsNullOrWhiteSpace(registerViewModel.EmailAddress)
                ? string.Empty
                : registerViewModel.EmailAddress.Trim();

            UserNameAvailability userNameAvailable;

            if (string.IsNullOrWhiteSpace(emailAddress))
            {
                userNameAvailable = new UserNameAvailability
                {
                    HasError = false,
                    IsUserNameAvailable = false
                };
            }
            else
            {
                userNameAvailable = _candidateServiceProvider.IsUsernameAvailable(emailAddress);    
            }

            if (!userNameAvailable.HasError)
            {
                registerViewModel.IsUsernameAvailable = userNameAvailable.IsUserNameAvailable;
                var validationResult = _registerViewModelServerValidator.Validate(registerViewModel);

                if (!validationResult.IsValid)
                {
                    return GetMediatorResponse(RegisterMediatorCodes.Register.ValidationFailed, registerViewModel, validationResult);
                }

                var registered = _candidateServiceProvider.Register(registerViewModel);
                if (registered)
                {
                    return GetMediatorResponse(RegisterMediatorCodes.Register.SuccessfullyRegistered, registerViewModel);
                }
            }

            return GetMediatorResponse(RegisterMediatorCodes.Register.RegistrationFailed, registerViewModel, RegisterPageMessages.RegistrationFailed, UserMessageLevel.Warning);
        }

        public MediatorResponse<ActivationViewModel> Activate(Guid candidateId, ActivationViewModel activationViewModel)
        {
            var activatedResult = _activationViewModelServerValidator.Validate(activationViewModel);

            if (!activatedResult.IsValid)
            {
                return GetMediatorResponse(RegisterMediatorCodes.Activate.FailedValidation, activationViewModel, activatedResult);
            }

            activationViewModel = _candidateServiceProvider.Activate(activationViewModel, candidateId);

            switch (activationViewModel.State)
            {
                case ActivateUserState.Activated:
                    return GetMediatorResponse(RegisterMediatorCodes.Activate.SuccessfullyActivated, activationViewModel, ActivationPageMessages.AccountActivated, UserMessageLevel.Success);
                case ActivateUserState.Error:
                    return GetMediatorResponse(RegisterMediatorCodes.Activate.SuccessfullyActivated, activationViewModel, activationViewModel.ViewModelMessage, UserMessageLevel.Success);
                case ActivateUserState.InvalidCode:
                    activatedResult = _activationViewModelServerValidator.Validate(activationViewModel);
                    return GetMediatorResponse(RegisterMediatorCodes.Activate.InvalidActivationCode, activationViewModel, activatedResult);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public MediatorResponse<ForgottenCredentialsViewModel> ForgottenPassword(ForgottenCredentialsViewModel forgottenCredentialsViewModel)
        {
            var forgottenPasswordViewModel = forgottenCredentialsViewModel.ForgottenPasswordViewModel;
            var validationResult = _forgottenPasswordViewModelServerValidator.Validate(forgottenPasswordViewModel);

            if (!validationResult.IsValid)
            {
                return GetMediatorResponse(RegisterMediatorCodes.ForgottenPassword.FailedValidation, forgottenCredentialsViewModel, validationResult);
            }

            if (_candidateServiceProvider.RequestForgottenPasswordResetCode(forgottenPasswordViewModel))
            {
                return GetMediatorResponse(RegisterMediatorCodes.ForgottenPassword.PasswordSent, forgottenCredentialsViewModel);
            }

            return GetMediatorResponse(RegisterMediatorCodes.ForgottenPassword.FailedToSendResetCode, forgottenCredentialsViewModel, PasswordResetPageMessages.FailedToSendPasswordResetCode, UserMessageLevel.Warning);
        }

        public MediatorResponse<ForgottenCredentialsViewModel> ForgottenEmail(ForgottenCredentialsViewModel forgottenCredentialsViewModel)
        {
            return GetMediatorResponse(RegisterMediatorCodes.ForgottenEmail.EmailSent, forgottenCredentialsViewModel);
        }

        public MediatorResponse<PasswordResetViewModel> ResetPassword(PasswordResetViewModel resetViewModel)
        {
            //Password Reset Code is verified in VerifyPasswordReset. 
            //Initially assume the reset code is valid as a full check requires hitting the repo.
            resetViewModel.IsPasswordResetCodeValid = true;

            var validationResult = _passwordResetViewModelServerValidator.Validate(resetViewModel);

            if (!validationResult.IsValid)
            {
                return GetMediatorResponse(RegisterMediatorCodes.ResetPassword.FailedValidation, resetViewModel, validationResult);
            }
            
            resetViewModel = _candidateServiceProvider.VerifyPasswordReset(resetViewModel);

            if (resetViewModel.HasError())
            {
                return GetMediatorResponse(RegisterMediatorCodes.ResetPassword.FailedToResetPassword, resetViewModel, resetViewModel.ViewModelMessage, UserMessageLevel.Warning);
            }

            if (resetViewModel.UserStatus == UserStatuses.Locked)
            {
                return GetMediatorResponse(RegisterMediatorCodes.ResetPassword.UserAccountLocked, resetViewModel);
            }

            if (!resetViewModel.IsPasswordResetCodeValid)
            {
                validationResult = _passwordResetViewModelServerValidator.Validate(resetViewModel);
                return GetMediatorResponse(RegisterMediatorCodes.ResetPassword.InvalidResetCode, resetViewModel, validationResult);
            }

            var candidate = _candidateServiceProvider.GetCandidate(resetViewModel.EmailAddress);
            _authenticationTicketService.SetAuthenticationCookie(candidate.EntityId.ToString(), UserRoleNames.Activated);

            return GetMediatorResponse(RegisterMediatorCodes.ResetPassword.SuccessfullyResetPassword, resetViewModel, PasswordResetPageMessages.SuccessfulPasswordReset, UserMessageLevel.Success);
        }
    }
}