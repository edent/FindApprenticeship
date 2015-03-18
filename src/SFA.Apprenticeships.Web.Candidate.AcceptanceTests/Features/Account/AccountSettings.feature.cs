﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34209
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("As a candidate I can change my personal settings")]
        [NUnit.Framework.CategoryAttribute("US532")]
        public virtual void AsACandidateICanChangeMyPersonalSettings()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("As a candidate I can change my personal settings", new string[] {
                        "US532"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 10
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.And("I am logged out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.Then("I am on the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
 testRunner.Given("I registered an account and activated it", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
 testRunner.And("I navigated to the LoginPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.When("I am on the LoginPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "EmailAddress",
                        "{EmailToken}"});
            table1.AddRow(new string[] {
                        "Password",
                        "{PasswordToken}"});
#line 18
 testRunner.And("I enter data", ((string)(null)), table1, "And ");
#line 22
 testRunner.And("I choose SignInButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.Then("I am on the MyApplicationsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.Given("I navigated to the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
 testRunner.When("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.And("I wait to see Firstname", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("I wait to see Lastname", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("I wait to see Day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("I wait to see Month", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("I wait to see Year", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("I wait to see PhoneNumber", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("I wait to see PostcodeSearch", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("I wait to see AddressLine1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("I wait to see AddressLine2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("I wait to see AddressLine3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("I wait to see AddressLine4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("I wait to see Postcode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.And("I wait to see AllowEmailComms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("I wait to see AllowSmsComms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.And("I wait to see SendApplicationSubmitted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.And("I wait to see SendApplicationStatusChanges", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("I wait to see SendApprenticeshipApplicationsExpiring", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.And("I wait to see SendMarketingCommunications", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
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
#line 55
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
#line 59
 testRunner.When("I enter data", ((string)(null)), table3, "When ");
#line 73
 testRunner.And("I choose AllowEmailComms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.And("I choose UpdateDetailsButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
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
#line 78
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
#line 82
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
#line 98
 testRunner.And("I see", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("As a candidate I cannot save invalid personal settings")]
        public virtual void AsACandidateICannotSaveInvalidPersonalSettings()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("As a candidate I cannot save invalid personal settings", ((string[])(null)));
#line 102
this.ScenarioSetup(scenarioInfo);
#line 104
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 105
 testRunner.And("I am logged out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
 testRunner.And("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.Then("I am on the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 109
 testRunner.Given("I registered an account and activated it", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 110
 testRunner.And("I navigated to the LoginPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
 testRunner.When("I am on the LoginPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "EmailAddress",
                        "{EmailToken}"});
            table7.AddRow(new string[] {
                        "Password",
                        "{PasswordToken}"});
#line 112
 testRunner.And("I enter data", ((string)(null)), table7, "And ");
#line 116
 testRunner.And("I choose SignInButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.Then("I am on the MyApplicationsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 119
 testRunner.Given("I navigated to the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 120
 testRunner.When("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 122
 testRunner.And("I wait to see UpdateDetailsButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table8.AddRow(new string[] {
                        "ClearAllSettings",
                        "Equals",
                        "Done"});
#line 124
 testRunner.Then("I see", ((string)(null)), table8, "Then ");
#line 128
 testRunner.When("I choose UpdateDetailsButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 129
 testRunner.Then("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table9.AddRow(new string[] {
                        "ValidationSummaryCount",
                        "Equals",
                        "8"});
#line 131
 testRunner.And("I see", ((string)(null)), table9, "And ");
#line 135
 testRunner.And("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table10.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Please enter first name"});
            table10.AddRow(new string[] {
                        "Href",
                        "Equals",
                        "#FirstName"});
#line 136
 testRunner.And("I am on ValidationSummaryItems list item matching criteria", ((string)(null)), table10, "And ");
#line 141
 testRunner.And("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table11.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Please enter last name"});
            table11.AddRow(new string[] {
                        "Href",
                        "Equals",
                        "#LastName"});
#line 142
 testRunner.And("I am on ValidationSummaryItems list item matching criteria", ((string)(null)), table11, "And ");
#line 147
 testRunner.And("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table12.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Please enter the day"});
            table12.AddRow(new string[] {
                        "Href",
                        "Equals",
                        "#DateOfBirth_Day"});
#line 148
 testRunner.And("I am on ValidationSummaryItems list item matching criteria", ((string)(null)), table12, "And ");
#line 153
 testRunner.And("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table13.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Please enter the month"});
            table13.AddRow(new string[] {
                        "Href",
                        "Equals",
                        "#DateOfBirth_Month"});
#line 154
 testRunner.And("I am on ValidationSummaryItems list item matching criteria", ((string)(null)), table13, "And ");
#line 159
 testRunner.And("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table14.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Please enter the year"});
            table14.AddRow(new string[] {
                        "Href",
                        "Equals",
                        "#DateOfBirth_Year"});
#line 160
 testRunner.And("I am on ValidationSummaryItems list item matching criteria", ((string)(null)), table14, "And ");
#line 165
 testRunner.And("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table15.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Please enter your first line of address"});
            table15.AddRow(new string[] {
                        "Href",
                        "Equals",
                        "#Address_AddressLine1"});
#line 166
 testRunner.And("I am on ValidationSummaryItems list item matching criteria", ((string)(null)), table15, "And ");
#line 171
 testRunner.And("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table16.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Please enter your postcode"});
            table16.AddRow(new string[] {
                        "Href",
                        "Equals",
                        "#Address_Postcode"});
#line 172
 testRunner.And("I am on ValidationSummaryItems list item matching criteria", ((string)(null)), table16, "And ");
#line 177
 testRunner.And("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table17.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Please enter phone number"});
            table17.AddRow(new string[] {
                        "Href",
                        "Equals",
                        "#PhoneNumber"});
#line 178
 testRunner.And("I am on ValidationSummaryItems list item matching criteria", ((string)(null)), table17, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("As a candidate I can verify my mobile number")]
        [NUnit.Framework.CategoryAttribute("US616")]
        public virtual void AsACandidateICanVerifyMyMobileNumber()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("As a candidate I can verify my mobile number", new string[] {
                        "US616"});
#line 184
this.ScenarioSetup(scenarioInfo);
#line 185
 testRunner.Given("I have registered a new candidate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 186
 testRunner.Given("I navigated to the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 187
 testRunner.Then("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table18.AddRow(new string[] {
                        "VerifyContainer",
                        "Does Not Exist",
                        ""});
            table18.AddRow(new string[] {
                        "IsAllowSmsComms",
                        "Equals",
                        "False"});
#line 188
 testRunner.And("I see", ((string)(null)), table18, "And ");
#line 192
 testRunner.And("I wait to see AllowSmsComms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 193
 testRunner.When("I choose AllowSmsComms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 194
 testRunner.And("I choose UpdateDetailsButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 195
 testRunner.Then("I am on the VerifyMobile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 196
 testRunner.When("I get my mobile verification code", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table19.AddRow(new string[] {
                        "VerifyMobileCode",
                        "{MobileVerificationCodeToken}"});
#line 197
 testRunner.And("I enter data", ((string)(null)), table19, "And ");
#line 200
 testRunner.And("I choose VerifyNumberButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 201
 testRunner.Then("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table20.AddRow(new string[] {
                        "VerifyContainer",
                        "Exists",
                        ""});
            table20.AddRow(new string[] {
                        "IsAllowSmsComms",
                        "Equals",
                        "True"});
#line 202
 testRunner.And("I see", ((string)(null)), table20, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("As a candidate I can opt into marketing messages")]
        [NUnit.Framework.CategoryAttribute("US519")]
        public virtual void AsACandidateICanOptIntoMarketingMessages()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("As a candidate I can opt into marketing messages", new string[] {
                        "US519"});
#line 208
this.ScenarioSetup(scenarioInfo);
#line 209
 testRunner.Given("I have registered a new candidate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 210
 testRunner.Given("I navigated to the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 211
 testRunner.Then("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table21.AddRow(new string[] {
                        "VerifyContainer",
                        "Does Not Exist",
                        ""});
            table21.AddRow(new string[] {
                        "IsAllowSmsComms",
                        "Equals",
                        "False"});
            table21.AddRow(new string[] {
                        "IsSendApplicationSubmitted",
                        "Equals",
                        "True"});
            table21.AddRow(new string[] {
                        "IsSendApplicationStatusChanges",
                        "Equals",
                        "True"});
            table21.AddRow(new string[] {
                        "IsSendApprenticeshipApplicationsExpiring",
                        "Equals",
                        "True"});
            table21.AddRow(new string[] {
                        "IsSendMarketingCommunications",
                        "Equals",
                        "True"});
#line 212
 testRunner.And("I see", ((string)(null)), table21, "And ");
#line 220
 testRunner.When("I choose AllowSmsComms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 221
 testRunner.And("I choose SendApplicationSubmitted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 222
 testRunner.And("I choose SendApplicationStatusChanges", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 223
 testRunner.And("I choose SendApprenticeshipApplicationsExpiring", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 224
 testRunner.And("I choose SendMarketingCommunications", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 225
 testRunner.And("I choose UpdateDetailsButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 226
 testRunner.Then("I am on the VerifyMobile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 227
 testRunner.When("I get my mobile verification code", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table22.AddRow(new string[] {
                        "VerifyMobileCode",
                        "{MobileVerificationCodeToken}"});
#line 228
 testRunner.And("I enter data", ((string)(null)), table22, "And ");
#line 231
 testRunner.And("I choose VerifyNumberButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 232
 testRunner.Then("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table23.AddRow(new string[] {
                        "VerifyContainer",
                        "Exists",
                        ""});
            table23.AddRow(new string[] {
                        "IsSendApplicationSubmitted",
                        "Equals",
                        "False"});
            table23.AddRow(new string[] {
                        "IsSendApprenticeshipApplicationsExpiring",
                        "Equals",
                        "False"});
            table23.AddRow(new string[] {
                        "IsSendMarketingCommunications",
                        "Equals",
                        "False"});
#line 233
 testRunner.And("I see", ((string)(null)), table23, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
