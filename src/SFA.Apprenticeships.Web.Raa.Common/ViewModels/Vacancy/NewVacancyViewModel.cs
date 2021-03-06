namespace SFA.Apprenticeships.Web.Raa.Common.ViewModels.Vacancy
{
    using Constants.ViewModels;
    using Domain.Entities.Raa.Vacancies;
    using FluentValidation.Attributes;
    using Provider;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using VacancyPosting;
    using Validators.Vacancy;

    [Validator(typeof(NewVacancyViewModelClientValidator))]
    public class NewVacancyViewModel : IPartialVacancyViewModel
    {
        public const string PartialView = "Vacancy/BasicVacancyDetails";

        public int? VacancyReferenceNumber { get; set; }

        //TODO: probably removegit 
        public string Ukprn { get; set; }

        [Display(Name = VacancyViewModelMessages.Title.LabelText)]
        public string Title { get; set; }

        [Display(Name = VacancyViewModelMessages.TitleComment.LabelText)]
        public string TitleComment { get; set; }

        [Display(Name = VacancyViewModelMessages.ShortDescription.LabelText)]
        public string ShortDescription { get; set; }

        [Display(Name = VacancyViewModelMessages.ShortDescriptionComment.LabelText)]
        public string ShortDescriptionComment { get; set; }

        public VacancyOwnerRelationshipViewModel VacancyOwnerRelationship { get; set; }

        public bool? OfflineVacancy { get; set; }

        public OfflineVacancyType? OfflineVacancyType { get; set; }

        [Display(Name = VacancyViewModelMessages.OfflineApplicationUrl.LabelText)]
        public string OfflineApplicationUrl { get; set; }

        [Display(Name = VacancyViewModelMessages.OfflineApplicationUrlComment.LabelText)]
        public string OfflineApplicationUrlComment { get; set; }

        [Display(Name = VacancyViewModelMessages.OfflineApplicationInstructions.LabelText)]
        public string OfflineApplicationInstructions { get; set; }

        [Display(Name = VacancyViewModelMessages.OfflineApplicationInstructionsComment.LabelText)]
        public string OfflineApplicationInstructionsComment { get; set; }

        public Guid VacancyGuid { get; set; }

        public VacancyStatus Status { get; set; }

        public bool? IsEmployerLocationMainApprenticeshipLocation { get; set; }

        public int? NumberOfPositions { get; set; }

        public List<VacancyLocationAddressViewModel> LocationAddresses { get; set; }
        public string AdditionalLocationInformation { get; set; }
        public bool ComeFromPreview { get; set; }
        public string EmployerDescription { get; set; }
        public string EmployerDescriptionComment { get; set; }
        public string EmployerWebsiteUrlComment { get; set; }
        public string LocationAddressesComment { get; set; }
        public string NumberOfPositionsComment { get; set; }
        public string AdditionalLocationInformationComment { get; set; }
        public VacancyType VacancyType { get; set; }
        public int AutoSaveTimeoutInSeconds { get; set; }
        public VacancySource VacancySource { get; set; }
        public string AnonymousEmployerDescription { get; set; }
        public string AnonymousEmployerDescriptionComment { get; set; }
        public string AnonymousEmployerReason { get; set; }
        public string AnonymousEmployerReasonComment { get; set; }
        public string AnonymousAboutTheEmployer { get; set; }
        public string AnonymousAboutTheEmployerComment { get; set; }
        public bool? IsAnonymousEmployer { get; set; }
    }
}