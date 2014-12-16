﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34014
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SFA.Apprenticeships.Web.Candidate.AcceptanceTests.Features.Account
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Account Settings - Personal Details")]
    [NUnit.Framework.CategoryAttribute("US483")]
    public partial class AccountSettings_PersonalDetailsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AccountSettings.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Account Settings - Personal Details", "As a candidate \r\nI want to be able to make amendments to my first name, last name" +
                    ", date of birth, address and mobile phone number\r\nand communication preferences " +
                    "so that I can manage my personal details and make sure they are correct", ProgrammingLanguage.CSharp, new string[] {
                        "US483"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
        
        public virtual void FeatureBackground()
        {
#line 7
#line 8
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("I am logged out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.Then("I am on the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.Given("I registered an account and activated it", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
 testRunner.And("I navigated to the LoginPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.When("I am on the LoginPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "EmailAddress",
                        "{EmailAddressToken}"});
            table1.AddRow(new string[] {
                        "Password",
                        "{PasswordToken}"});
#line 16
 testRunner.And("I enter data", ((string)(null)), table1, "And ");
#line 20
 testRunner.And("I choose SignInButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.Then("I am on the MyApplicationsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("As a candidate I can change my personal settings")]
        [NUnit.Framework.CategoryAttribute("US532")]
        public virtual void AsACandidateICanChangeMyPersonalSettings()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("As a candidate I can change my personal settings", new string[] {
                        "US532"});
#line 24
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 26
 testRunner.Given("I navigated to the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
 testRunner.When("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.And("I wait to see Firstname", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("I wait to see Lastname", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("I wait to see Day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("I wait to see Month", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("I wait to see Year", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("I wait to see PhoneNumber", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("I wait to see PostcodeSearch", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("I wait to see AddressLine1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("I wait to see AddressLine2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("I wait to see AddressLine3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("I wait to see AddressLine4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.And("I wait to see Postcode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("I wait to see AllowEmailCommsYes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.And("I wait to see AllowEmailCommsNo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.And("I wait to see UpdateDetailsButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table2.AddRow(new string[] {
                        "ClearAllSettings",
                        "Equals",
                        "Done"});
#line 51
 testRunner.Then("I see", ((string)(null)), table2, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "Firstname",
                        "Jane"});
            table3.AddRow(new string[] {
                        "Lastname",
                        "Dovedale"});
            table3.AddRow(new string[] {
                        "Day",
                        "31"});
            table3.AddRow(new string[] {
                        "Month",
                        "1"});
            table3.AddRow(new string[] {
                        "Year",
                        "1994"});
            table3.AddRow(new string[] {
                        "Phonenumber",
                        "07123000099"});
            table3.AddRow(new string[] {
                        "AddressLine1",
                        "10 Downing Street"});
            table3.AddRow(new string[] {
                        "AddressLine2",
                        "City of Westminster"});
            table3.AddRow(new string[] {
                        "AddressLine3",
                        "London"});
            table3.AddRow(new string[] {
                        "AddressLine4",
                        "England"});
            table3.AddRow(new string[] {
                        "Postcode",
                        "SW1A 2AA"});
#line 55
 testRunner.When("I enter data", ((string)(null)), table3, "When ");
#line 69
 testRunner.And("I choose AllowEmailCommsNo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.And("I choose UpdateDetailsButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.Then("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table4.AddRow(new string[] {
                        "ValidationSummary",
                        "Does Not Exist",
                        ""});
#line 74
 testRunner.And("I see", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table5.AddRow(new string[] {
                        "Firstname",
                        "Equals",
                        "Jane"});
            table5.AddRow(new string[] {
                        "Lastname",
                        "Equals",
                        "Dovedale"});
            table5.AddRow(new string[] {
                        "Day",
                        "Equals",
                        "31"});
            table5.AddRow(new string[] {
                        "Month",
                        "Equals",
                        "1"});
            table5.AddRow(new string[] {
                        "Year",
                        "Equals",
                        "1994"});
            table5.AddRow(new string[] {
                        "Phonenumber",
                        "Equals",
                        "07123000099"});
            table5.AddRow(new string[] {
                        "AddressLine1",
                        "Equals",
                        "10 Downing Street"});
            table5.AddRow(new string[] {
                        "AddressLine2",
                        "Equals",
                        "City of Westminster"});
            table5.AddRow(new string[] {
                        "AddressLine3",
                        "Equals",
                        "London"});
            table5.AddRow(new string[] {
                        "AddressLine4",
                        "Equals",
                        "England"});
            table5.AddRow(new string[] {
                        "Postcode",
                        "Equals",
                        "SW1A 2AA"});
            table5.AddRow(new string[] {
                        "BannerUserName",
                        "Equals",
                        "Jane Dovedale"});
            table5.AddRow(new string[] {
                        "IsAllowEmailComms",
                        "Equals",
                        "False"});
#line 78
 testRunner.And("I see", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table6.AddRow(new string[] {
                        "SuccessMessageText",
                        "Equals",
                        "You\'ve successfully updated your settings"});
#line 94
 testRunner.And("I see", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("As a candidate I cannot save invalid personal settings")]
        public virtual void AsACandidateICannotSaveInvalidPersonalSettings()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("As a candidate I cannot save invalid personal settings", ((string[])(null)));
#line 98
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 100
 testRunner.Given("I navigated to the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 101
 testRunner.When("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
 testRunner.And("I wait to see UpdateDetailsButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table7.AddRow(new string[] {
                        "ClearAllSettings",
                        "Equals",
                        "Done"});
#line 105
 testRunner.Then("I see", ((string)(null)), table7, "Then ");
#line 109
 testRunner.When("I choose UpdateDetailsButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 110
 testRunner.Then("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table8.AddRow(new string[] {
                        "ValidationSummaryCount",
                        "Equals",
                        "8"});
#line 112
 testRunner.And("I see", ((string)(null)), table8, "And ");
#line 116
 testRunner.And("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table9.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Please enter first name"});
            table9.AddRow(new string[] {
                        "Href",
                        "Equals",
                        "#FirstName"});
#line 117
 testRunner.And("I am on ValidationSummaryItems list item matching criteria", ((string)(null)), table9, "And ");
#line 122
 testRunner.And("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table10.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Please enter last name"});
            table10.AddRow(new string[] {
                        "Href",
                        "Equals",
                        "#LastName"});
#line 123
 testRunner.And("I am on ValidationSummaryItems list item matching criteria", ((string)(null)), table10, "And ");
#line 128
 testRunner.And("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table11.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Please enter the day"});
            table11.AddRow(new string[] {
                        "Href",
                        "Equals",
                        "#DateOfBirth_Day"});
#line 129
 testRunner.And("I am on ValidationSummaryItems list item matching criteria", ((string)(null)), table11, "And ");
#line 134
 testRunner.And("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table12.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Please enter the month"});
            table12.AddRow(new string[] {
                        "Href",
                        "Equals",
                        "#DateOfBirth_Month"});
#line 135
 testRunner.And("I am on ValidationSummaryItems list item matching criteria", ((string)(null)), table12, "And ");
#line 140
 testRunner.And("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table13.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Please enter the year"});
            table13.AddRow(new string[] {
                        "Href",
                        "Equals",
                        "#DateOfBirth_Year"});
#line 141
 testRunner.And("I am on ValidationSummaryItems list item matching criteria", ((string)(null)), table13, "And ");
#line 146
 testRunner.And("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table14.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Please enter your first line of address"});
            table14.AddRow(new string[] {
                        "Href",
                        "Equals",
                        "#Address_AddressLine1"});
#line 147
 testRunner.And("I am on ValidationSummaryItems list item matching criteria", ((string)(null)), table14, "And ");
#line 152
 testRunner.And("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table15.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Please enter your postcode"});
            table15.AddRow(new string[] {
                        "Href",
                        "Equals",
                        "#Address_Postcode"});
#line 153
 testRunner.And("I am on ValidationSummaryItems list item matching criteria", ((string)(null)), table15, "And ");
#line 158
 testRunner.And("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table16.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Please enter phone number"});
            table16.AddRow(new string[] {
                        "Href",
                        "Equals",
                        "#PhoneNumber"});
#line 159
 testRunner.And("I am on ValidationSummaryItems list item matching criteria", ((string)(null)), table16, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
