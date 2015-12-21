﻿namespace SFA.Apprenticeships.Web.Recruit.Validators
{
    using Constants.ViewModels;
    using FluentValidation;
    using ViewModels.Application.Apprenticeship;

    public class ApprenticeshipApplicationViewModelClientValidator : AbstractValidator<ApprenticeshipApplicationViewModel>
    {
        public ApprenticeshipApplicationViewModelClientValidator()
        {
            this.AddCommonRules();
            this.AddClientRules();
        }
    }

    public class ApprenticeshipApplicationViewModelServerValidator : AbstractValidator<ApprenticeshipApplicationViewModel>
    {
        public ApprenticeshipApplicationViewModelServerValidator()
        {
            this.AddCommonRules();
            this.AddServerRules();
        }
    }

    internal static class ApprenticeshipApplicationViewModelValidatorRules
    {
        internal static void AddCommonRules(this AbstractValidator<ApprenticeshipApplicationViewModel> validator)
        {
            validator.RuleFor(x => x.Notes)
                .Matches(ApplicationViewModelMessages.Notes.WhiteListRegularExpression)
                .WithMessage(ApplicationViewModelMessages.Notes.WhiteListErrorText);
        }

        internal static void AddClientRules(this AbstractValidator<ApprenticeshipApplicationViewModel> validator)
        {

        }

        internal static void AddServerRules(this AbstractValidator<ApprenticeshipApplicationViewModel> validator)
        {

        }
    }
}