﻿namespace SFA.Apprenticeships.Web.Manage.ViewModels
{
    using System.ComponentModel.DataAnnotations;
    using Constants.ViewModels;

    public class CandidateSearchViewModel
    {
        [Display(Name = CandidateSearchViewModelMessages.FirstName.LabelText)]
        public string FirstName { get; set; }
        [Display(Name = CandidateSearchViewModelMessages.LastName.LabelText)]
        public string LastName { get; set; }
        [Display(Name = CandidateSearchViewModelMessages.DateOfBirth.LabelText, Description = CandidateSearchViewModelMessages.DateOfBirth.HintText)]
        public string DateOfBirth { get; set; }
        [Display(Name = CandidateSearchViewModelMessages.Postcode.LabelText, Description = CandidateSearchViewModelMessages.Postcode.HintText)]
        public string Postcode { get; set; }
    }
}