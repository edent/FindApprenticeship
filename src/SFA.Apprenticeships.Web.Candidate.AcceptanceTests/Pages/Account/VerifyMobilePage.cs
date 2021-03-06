﻿namespace SFA.Apprenticeships.Web.Candidate.AcceptanceTests.Pages.Account
{
    using OpenQA.Selenium;
    using SpecBind.Pages;

    [PageNavigation("/verifymobile")]
    [PageAlias("VerifyMobile")]
    public class VerifyMobilePage : BaseValidationPage
    {
        public VerifyMobilePage(ISearchContext context)
            : base(context)
        {
        }

        public string ClearAllSettings
        {
            get
            {
               VerifyMobileCode.Clear();
                return "Done";
            }
        }

        [ElementLocator(Id = "VerifyMobileCode")]
        public IWebElement VerifyMobileCode { get; set; }

        [ElementLocator(Id = "PhoneNumber")]
        public IWebElement Phonenumber { get; set; }

        [ElementLocator(Id = "verify-code-button")]
        public IWebElement VerifyNumberButton { get; set; }

        [ElementLocator(Id = "ResendMobileVerificationCodeLink")]
        public IWebElement ResendMobileVerificationCodeLink { get; set; }
        
        [ElementLocator(Id = "find-apprenticeship-link")]
        public IWebElement FindApprenticeshipLink { get; set; }

        [ElementLocator(Id = "find-traineeship-link")]
        public IWebElement FindTraineeshipLink { get; set; }
    }
}
