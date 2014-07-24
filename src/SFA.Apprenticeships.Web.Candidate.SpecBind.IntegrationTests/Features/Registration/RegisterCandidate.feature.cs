﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18408
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SFA.Apprenticeships.Web.Candidate.SpecBind.IntegrationTests.Features.Registration
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.DeploymentItemAttribute("SpecBind.Selenium.dll")]
    public partial class RegisterCandidateFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RegisterCandidate.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Register Candidate", "In order to apply for a vacnacy\r\nAs an apprentice\r\nI want to be able to register " +
                    "for the service", ProgrammingLanguage.CSharp, new string[] {
                        "US413"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Register Candidate")))
            {
                SFA.Apprenticeships.Web.Candidate.SpecBind.IntegrationTests.Features.Registration.RegisterCandidateFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("As a candidate I am on the registration page and all required fields are present " +
            "and all validators show")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Register Candidate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("US413")]
        public virtual void AsACandidateIAmOnTheRegistrationPageAndAllRequiredFieldsArePresentAndAllValidatorsShow()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("As a candidate I am on the registration page and all required fields are present " +
                    "and all validators show", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I navigated to the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.And("I wait to see Firstname", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("I wait to see Lastname", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("I wait to see Day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And("I wait to see Month", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And("I wait to see Year", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("I wait to see EmailAddress", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And("I wait to see Password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("I wait to see HasAcceptedTermsAndConditions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("I choose CreateAccountButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("I wait to see ValidationSummary", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table1.AddRow(new string[] {
                        "ValidationSummaryCount",
                        "Equals",
                        "9"});
#line 20
 testRunner.Then("I see", ((string)(null)), table1, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table2.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "\'Firstname\' must be supplied"});
            table2.AddRow(new string[] {
                        "Href",
                        "Equals",
                        "#firstname"});
#line 23
 testRunner.And("I am on ValidationSummaryItems list item matching criteria", ((string)(null)), table2, "And ");
#line 27
 testRunner.And("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table3.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "\'Lastname\' must be supplied"});
            table3.AddRow(new string[] {
                        "Href",
                        "Equals",
                        "#lastname"});
#line 28
 testRunner.And("I am on ValidationSummaryItems list item matching criteria", ((string)(null)), table3, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("As a candidate on the registration page I want to be able to pick my address from" +
            " a list returned from the postcode search")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Register Candidate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("US413")]
        public virtual void AsACandidateOnTheRegistrationPageIWantToBeAbleToPickMyAddressFromAListReturnedFromThePostcodeSearch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("As a candidate on the registration page I want to be able to pick my address from" +
                    " a list returned from the postcode search", ((string[])(null)));
#line 33
this.ScenarioSetup(scenarioInfo);
#line 34
 testRunner.Given("I navigated to the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 35
 testRunner.When("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "PostcodeSearch",
                        "N7 8LS"});
#line 36
 testRunner.And("I enter data", ((string)(null)), table4, "And ");
#line 39
 testRunner.And("I choose FindAddresses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table5.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Flat A, 6 Furlong Road"});
            table5.AddRow(new string[] {
                        "AddressLine1",
                        "Equals",
                        "Flat A"});
            table5.AddRow(new string[] {
                        "AddressLine2",
                        "Equals",
                        "6 Furlong Road"});
            table5.AddRow(new string[] {
                        "AddressLine3",
                        "Equals",
                        "London"});
            table5.AddRow(new string[] {
                        "AddressLine4",
                        "Equals",
                        "Islington"});
            table5.AddRow(new string[] {
                        "Postcode",
                        "Equals",
                        "N7 8LS"});
            table5.AddRow(new string[] {
                        "Uprn",
                        "Equals",
                        "5300034721"});
            table5.AddRow(new string[] {
                        "Latitude",
                        "Equals",
                        "51.54751633697479"});
            table5.AddRow(new string[] {
                        "Longitude",
                        "Equals",
                        "-0.10660693737952387"});
#line 40
 testRunner.And("I am on AddressDropdown list item matching criteria", ((string)(null)), table5, "And ");
#line 51
 testRunner.And("I choose WrappedElement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table6.AddRow(new string[] {
                        "AddressLine1",
                        "Equals",
                        "Flat A"});
            table6.AddRow(new string[] {
                        "AddressLine2",
                        "Equals",
                        "6 Furlong Road"});
            table6.AddRow(new string[] {
                        "AddressLine3",
                        "Equals",
                        "London"});
            table6.AddRow(new string[] {
                        "AddressLine4",
                        "Equals",
                        "Islington"});
            table6.AddRow(new string[] {
                        "Postcode",
                        "Equals",
                        "N7 8LS"});
            table6.AddRow(new string[] {
                        "Uprn",
                        "Equals",
                        "5300034721"});
            table6.AddRow(new string[] {
                        "Latitude",
                        "Equals",
                        "51.54751633697479"});
            table6.AddRow(new string[] {
                        "Longitude",
                        "Equals",
                        "-0.10660693737952387"});
#line 53
 testRunner.Then("I see", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("As a candidate I want to be told quickly that my email/username is available")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Register Candidate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("US413")]
        public virtual void AsACandidateIWantToBeToldQuicklyThatMyEmailUsernameIsAvailable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("As a candidate I want to be told quickly that my email/username is available", ((string[])(null)));
#line 65
this.ScenarioSetup(scenarioInfo);
#line 66
 testRunner.Given("I navigated to the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 67
 testRunner.And("I have created a new email address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.When("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "EmailAddress",
                        "{EmailToken}"});
#line 69
 testRunner.And("I enter data", ((string)(null)), table7, "And ");
#line 72
 testRunner.And("I choose Phonenumber", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.And("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.And("I wait to see EmailAddressAvailableMessage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.And("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table8.AddRow(new string[] {
                        "EmailAddressAvailableMessage",
                        "Equals",
                        "Username is available: true"});
#line 76
 testRunner.Then("I see", ((string)(null)), table8, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("As a candidate I want to be told quickly that my email/username is not available " +
            "if I have already registered")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Register Candidate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("US413")]
        public virtual void AsACandidateIWantToBeToldQuicklyThatMyEmailUsernameIsNotAvailableIfIHaveAlreadyRegistered()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("As a candidate I want to be told quickly that my email/username is not available " +
                    "if I have already registered", ((string[])(null)));
#line 81
this.ScenarioSetup(scenarioInfo);
#line 82
 testRunner.Given("I navigated to the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 83
 testRunner.When("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "EmailAddress",
                        "valtechnas@gmail.com"});
#line 84
 testRunner.And("I enter data", ((string)(null)), table9, "And ");
#line 87
 testRunner.And("I choose Phonenumber", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.And("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.And("I wait to see EmailAddressAvailableMessage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.And("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table10.AddRow(new string[] {
                        "EmailAddressAvailableMessage",
                        "Equals",
                        "Username is available: false"});
#line 91
 testRunner.Then("I see", ((string)(null)), table10, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("As a candidate I want to be submit my registration details so that I can apply fo" +
            "r vacancies")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Register Candidate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("US413")]
        public virtual void AsACandidateIWantToBeSubmitMyRegistrationDetailsSoThatICanApplyForVacancies()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("As a candidate I want to be submit my registration details so that I can apply fo" +
                    "r vacancies", ((string[])(null)));
#line 96
this.ScenarioSetup(scenarioInfo);
#line 97
 testRunner.Given("I navigated to the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 98
 testRunner.And("I have created a new email address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.When("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "PostcodeSearch",
                        "N7 8LS"});
#line 100
 testRunner.And("I enter data", ((string)(null)), table11, "And ");
#line 103
 testRunner.And("I choose FindAddresses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table12.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Flat A, 6 Furlong Road"});
#line 104
 testRunner.And("I am on AddressDropdown list item matching criteria", ((string)(null)), table12, "And ");
#line 107
 testRunner.And("I choose WrappedElement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
 testRunner.And("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table13.AddRow(new string[] {
                        "Firstname",
                        "FirstnameTest"});
            table13.AddRow(new string[] {
                        "Lastname",
                        "LastnameTest"});
            table13.AddRow(new string[] {
                        "Day",
                        "01"});
            table13.AddRow(new string[] {
                        "Month",
                        "01"});
            table13.AddRow(new string[] {
                        "Year",
                        "1999"});
            table13.AddRow(new string[] {
                        "EmailAddress",
                        "{EmailToken}"});
            table13.AddRow(new string[] {
                        "Phonenumber",
                        "07999999999"});
            table13.AddRow(new string[] {
                        "Password",
                        "?Password01!"});
#line 109
 testRunner.And("I enter data", ((string)(null)), table13, "And ");
#line 119
 testRunner.And("I choose HasAcceptedTermsAndConditions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.And("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.And("I choose CreateAccountButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
 testRunner.And("I wait 70 second for the ActivationPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
 testRunner.And("I get the token for my newly created account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.And("I am on the ActivationPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
 testRunner.And("I wait to see EmailAddress", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
 testRunner.And("I am on the ActivationPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table14.AddRow(new string[] {
                        "ActivationCode",
                        "{ActivationToken}"});
#line 127
 testRunner.And("I enter data", ((string)(null)), table14, "And ");
#line 130
 testRunner.And("I am on the ActivationPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
 testRunner.And("I choose ActivateButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
 testRunner.Then("I am on the VacancySearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
