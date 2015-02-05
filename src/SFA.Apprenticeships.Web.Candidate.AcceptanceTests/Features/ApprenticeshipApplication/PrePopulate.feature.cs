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
namespace SFA.Apprenticeships.Web.Candidate.AcceptanceTests.Features.ApprenticeshipApplication
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Apprenticeship Application Pre Populate")]
    public partial class ApprenticeshipApplicationPrePopulateFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PrePopulate.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Apprenticeship Application Pre Populate", "In order to speed up the application process\r\nAs a candidate\r\nI want valid data I" +
                    " have previously entered to pre populate the application form", ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 6
#line 7
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("I am logged out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.And("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.Then("I am on the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Pre-populate my Education Qualifications Work Experience About You details")]
        [NUnit.Framework.CategoryAttribute("US461")]
        public virtual void Pre_PopulateMyEducationQualificationsWorkExperienceAboutYouDetails()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pre-populate my Education Qualifications Work Experience About You details", new string[] {
                        "US461"});
#line 13
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 14
 testRunner.Given("I have registered a new candidate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.When("I select the \"first\" apprenticeship vacancy in location \"N7 8LS\" that can apply b" +
                    "y this website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("I am on the ApprenticeshipDetailsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.When("I choose ApplyButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("I am on the ApprenticeshipApplicationPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table1.AddRow(new string[] {
                        "FullnameReadOnly",
                        "Equals",
                        "Firstname Lastname"});
            table1.AddRow(new string[] {
                        "EmailReadOnly",
                        "Equals",
                        "{EmailToken}"});
            table1.AddRow(new string[] {
                        "DobReadOnly",
                        "Equals",
                        "01/01/2000"});
            table1.AddRow(new string[] {
                        "PhoneReadOnly",
                        "Equals",
                        "07970523193"});
            table1.AddRow(new string[] {
                        "AddressLine1ReadOnly",
                        "Equals",
                        "Flat A"});
            table1.AddRow(new string[] {
                        "AddressLine2ReadOnly",
                        "Equals",
                        "6 Furlong Road"});
            table1.AddRow(new string[] {
                        "AddressLine3ReadOnly",
                        "Equals",
                        "London"});
            table1.AddRow(new string[] {
                        "AddressLine4ReadOnly",
                        "Equals",
                        "Islington"});
            table1.AddRow(new string[] {
                        "AddressPostcodeReadOnly",
                        "Equals",
                        "N7 8LS"});
            table1.AddRow(new string[] {
                        "EducationNameOfSchool",
                        "Equals",
                        ""});
            table1.AddRow(new string[] {
                        "EducationFromYear",
                        "Equals",
                        ""});
            table1.AddRow(new string[] {
                        "EducationToYear",
                        "Equals",
                        ""});
            table1.AddRow(new string[] {
                        "WhatAreYourStrengths",
                        "Equals",
                        ""});
            table1.AddRow(new string[] {
                        "WhatCanYouImprove",
                        "Equals",
                        ""});
#line 19
 testRunner.And("I see", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "EducationNameOfSchool",
                        "SchoolName"});
            table2.AddRow(new string[] {
                        "EducationFromYear",
                        "2010"});
            table2.AddRow(new string[] {
                        "EducationToYear",
                        "2012"});
            table2.AddRow(new string[] {
                        "WhatAreYourStrengths",
                        "My strengths"});
            table2.AddRow(new string[] {
                        "WhatCanYouImprove",
                        "What can I improve"});
            table2.AddRow(new string[] {
                        "HobbiesAndInterests",
                        "Hobbies and interests"});
#line 37
 testRunner.When("I enter data", ((string)(null)), table2, "When ");
#line 45
 testRunner.And("I choose SaveButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.Then("I wait to see ApplicationSavedMessage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table3.AddRow(new string[] {
                        "ApplicationSavedMessage",
                        "Ends With",
                        "my applications"});
#line 47
 testRunner.And("I see", ((string)(null)), table3, "And ");
#line 50
 testRunner.When("I select the \"second\" apprenticeship vacancy in location \"N7 8LS\" that can apply " +
                    "by this website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.Then("I am on the ApprenticeshipDetailsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.When("I choose ApplyButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.Then("I am on the ApprenticeshipApplicationPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table4.AddRow(new string[] {
                        "EducationNameOfSchool",
                        "Equals",
                        "SchoolName"});
            table4.AddRow(new string[] {
                        "EducationFromYear",
                        "Equals",
                        "2010"});
            table4.AddRow(new string[] {
                        "EducationToYear",
                        "Equals",
                        "2012"});
            table4.AddRow(new string[] {
                        "WhatAreYourStrengths",
                        "Equals",
                        "My strengths"});
            table4.AddRow(new string[] {
                        "WhatCanYouImprove",
                        "Equals",
                        "What can I improve"});
            table4.AddRow(new string[] {
                        "HobbiesAndInterests",
                        "Equals",
                        "Hobbies and interests"});
#line 54
 testRunner.And("I see", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
