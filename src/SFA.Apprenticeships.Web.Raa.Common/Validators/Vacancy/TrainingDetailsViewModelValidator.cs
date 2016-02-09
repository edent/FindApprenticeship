﻿namespace SFA.Apprenticeships.Web.Raa.Common.Validators.Vacancy
{
    using Domain.Entities.Vacancies.ProviderVacancies;
    using Domain.Entities.Vacancies.ProviderVacancies.Apprenticeship;
    using FluentValidation;
    using Constants.ViewModels;
    using ViewModels.Vacancy;
    using Web.Common.Validators;

    public class TrainingDetailsViewModelClientValidator : AbstractValidator<TrainingDetailsViewModel>
    {
        public TrainingDetailsViewModelClientValidator()
        {
            this.AddCommonRules();
            this.AddClientRules();
        }
    }

    public class TrainingDetailsViewModelServerValidator : AbstractValidator<TrainingDetailsViewModel>
    {
        public TrainingDetailsViewModelServerValidator()
        {
            this.AddCommonRules();
            this.AddServerRules();
            RuleSet(RuleSets.Errors, this.AddCommonRules);
            RuleSet(RuleSets.Errors, this.AddServerRules);
        }
    }

    internal static class TrainingDetailsViewModelValidatorRules
    {
        internal static void AddCommonRules(this AbstractValidator<TrainingDetailsViewModel> validator)
        {
            validator.RuleFor(m => m.StandardIdComment)
                .Matches(VacancyViewModelMessages.Comment.WhiteListRegularExpression)
                .WithMessage(VacancyViewModelMessages.Comment.WhiteListErrorText);

            validator.RuleFor(m => m.ApprenticeshipLevelComment)
                .Matches(VacancyViewModelMessages.Comment.WhiteListRegularExpression)
                .WithMessage(VacancyViewModelMessages.Comment.WhiteListErrorText);

            validator.RuleFor(m => m.FrameworkCodeNameComment)
                .Matches(VacancyViewModelMessages.Comment.WhiteListRegularExpression)
                .WithMessage(VacancyViewModelMessages.Comment.WhiteListErrorText);

            validator.RuleFor(m => m.TrainingProvided)
                .Matches(VacancyViewModelMessages.TrainingProvidedMessages.WhiteListRegularExpression)
                .WithMessage(VacancyViewModelMessages.TrainingProvidedMessages.WhiteListErrorText);

            validator.RuleFor(m => m.TrainingProvidedComment)
                .Matches(VacancyViewModelMessages.Comment.WhiteListRegularExpression)
                .WithMessage(VacancyViewModelMessages.Comment.WhiteListErrorText);

            validator.RuleFor(m => m.ContactName)
                .Length(0, 100)
                .WithMessage(VacancyViewModelMessages.ContactNameMessages.TooLongErrorText)
                .Matches(VacancyViewModelMessages.ContactNameMessages.WhiteListRegularExpression)
                .WithMessage(VacancyViewModelMessages.ContactNameMessages.WhiteListErrorText);

            validator.RuleFor(x => x.ContactNumber)
                .Length(8, 16)
                .WithMessage(VacancyViewModelMessages.ContactNumberMessages.LengthErrorText)
                .Matches(VacancyViewModelMessages.ContactNumberMessages.WhiteListRegularExpression)
                .WithMessage(VacancyViewModelMessages.ContactNumberMessages.WhiteListErrorText);

            validator.RuleFor(m => m.ContactEmail)
                .Length(0, 100)
                .WithMessage(VacancyViewModelMessages.ContactEmailMessages.TooLongErrorText)
                .Matches(VacancyViewModelMessages.ContactEmailMessages.WhiteListRegularExpression)
                .WithMessage(VacancyViewModelMessages.ContactEmailMessages.WhiteListErrorText);

            validator.RuleFor(m => m.ContactDetailsComment)
                .Matches(VacancyViewModelMessages.Comment.WhiteListRegularExpression)
                .WithMessage(VacancyViewModelMessages.Comment.WhiteListErrorText);
        }

        internal static void AddClientRules(this AbstractValidator<TrainingDetailsViewModel> validator)
        {
            
        }

        internal static void AddServerRules(this AbstractValidator<TrainingDetailsViewModel> validator)
        {
            validator.RuleFor(viewModel => (int)viewModel.TrainingType)
                .InclusiveBetween((int)TrainingType.Frameworks, (int)TrainingType.Standards)
                .WithMessage(NewVacancyViewModelMessages.TrainingType.RequiredErrorText);

            validator.RuleFor(m => m.FrameworkCodeName)
                .NotEmpty()
                .WithMessage(VacancyViewModelMessages.FrameworkCodeName.RequiredErrorText)
                .When(m => m.TrainingType == TrainingType.Frameworks);

            validator.RuleFor(m => m.StandardId)
                .NotEmpty()
                .WithMessage(VacancyViewModelMessages.StandardId.RequiredErrorText)
                .When(m => m.TrainingType == TrainingType.Standards);

            validator.RuleFor(viewModel => (int)viewModel.ApprenticeshipLevel)
                .InclusiveBetween((int)ApprenticeshipLevel.Intermediate, (int)ApprenticeshipLevel.Degree)
                .WithMessage(NewVacancyViewModelMessages.ApprenticeshipLevel.RequiredErrorText)
                .When(m => m.TrainingType == TrainingType.Frameworks)
                .NotEqual((int)ApprenticeshipLevel.FoundationDegree)
                .WithMessage(NewVacancyViewModelMessages.ApprenticeshipLevel.RequiredErrorText)
                .When(m => m.TrainingType == TrainingType.Frameworks);

            validator.RuleFor(x => x.TrainingProvided)
                .NotEmpty()
                .WithMessage(VacancyViewModelMessages.TrainingProvidedMessages.RequiredErrorText);
        }
    }
}