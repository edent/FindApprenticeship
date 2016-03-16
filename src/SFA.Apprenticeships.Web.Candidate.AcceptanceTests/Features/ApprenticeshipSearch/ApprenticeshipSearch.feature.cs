﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SFA.Apprenticeships.Web.Candidate.AcceptanceTests.Features.ApprenticeshipSearch
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Apprenticeship Search")]
    [NUnit.Framework.CategoryAttribute("US496")]
    [NUnit.Framework.CategoryAttribute("US449")]
    public partial class ApprenticeshipSearchFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ApprenticeshipSearch.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Apprenticeship Search", "In order to find a apprenticeship vacancy quickly\r\nAs a candidate\r\nI want to find" +
                    " a apprenticeship vacancy by location or keywords", ProgrammingLanguage.CSharp, new string[] {
                        "US496",
                        "US449"});
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
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Find apprenticeships and test ordering without keywords")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void FindApprenticeshipsAndTestOrderingWithoutKeywords()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find apprenticeships and test ordering without keywords", new string[] {
                        "SmokeTests"});
#line 14
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 15
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "Location",
                        "Coventry"});
            table1.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
            table1.AddRow(new string[] {
                        "ApprenticeshipLevel",
                        "All levels"});
#line 16
 testRunner.When("I enter data", ((string)(null)), table1, "When ");
#line 21
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table2.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Equals",
                        "5"});
            table2.AddRow(new string[] {
                        "ResultsAreInDistanceOrder",
                        "Equals",
                        "True"});
#line 23
 testRunner.Then("I see", ((string)(null)), table2, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "SortOrderingDropDown",
                        "Closing date"});
#line 30
 testRunner.And("I enter data", ((string)(null)), table3, "And ");
#line 33
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("I wait 3 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table4.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Equals",
                        "5"});
            table4.AddRow(new string[] {
                        "ResultsAreInClosingDateOrder",
                        "Equals",
                        "True"});
#line 35
 testRunner.And("I see", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Find apprenticeships and test ordering with keywords")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        [NUnit.Framework.CategoryAttribute("PrimaryTransaction")]
        public virtual void FindApprenticeshipsAndTestOrderingWithKeywords()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find apprenticeships and test ordering with keywords", new string[] {
                        "SmokeTests",
                        "PrimaryTransaction"});
#line 44
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 45
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "Keywords",
                        "Web"});
            table5.AddRow(new string[] {
                        "Location",
                        "Coventry"});
            table5.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
            table5.AddRow(new string[] {
                        "ApprenticeshipLevel",
                        "All levels"});
#line 46
 testRunner.When("I enter data", ((string)(null)), table5, "When ");
#line 52
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table6.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Equals",
                        "5"});
#line 54
 testRunner.Then("I see", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Find apprenticeships location must be two or more characters")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void FindApprenticeshipsLocationMustBeTwoOrMoreCharacters()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find apprenticeships location must be two or more characters", new string[] {
                        "SmokeTests"});
#line 62
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 63
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "Location",
                        "B"});
            table7.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
            table7.AddRow(new string[] {
                        "ApprenticeshipLevel",
                        "All levels"});
#line 64
 testRunner.When("I enter data", ((string)(null)), table7, "When ");
#line 69
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.Then("I am on the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table8.AddRow(new string[] {
                        "ValidationSummaryCount",
                        "Equals",
                        "1"});
#line 71
 testRunner.And("I see", ((string)(null)), table8, "And ");
#line 74
 testRunner.And("I am on the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table9.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Location must be 3 or more characters or a postcode"});
#line 75
 testRunner.And("I am on ValidationSummaryItems list item matching criteria", ((string)(null)), table9, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Find apprenticeships by partial postcode returns results")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void FindApprenticeshipsByPartialPostcodeReturnsResults()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find apprenticeships by partial postcode returns results", new string[] {
                        "SmokeTests"});
#line 80
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 81
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "Location",
                        "B1"});
            table10.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
            table10.AddRow(new string[] {
                        "ApprenticeshipLevel",
                        "All levels"});
#line 82
 testRunner.When("I enter data", ((string)(null)), table10, "When ");
#line 87
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table11.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Equals",
                        "5"});
#line 89
 testRunner.Then("I see", ((string)(null)), table11, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Find apprenticeships and test paging")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void FindApprenticeshipsAndTestPaging()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find apprenticeships and test paging", new string[] {
                        "SmokeTests"});
#line 94
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 95
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "Location",
                        "Coventry"});
            table12.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
            table12.AddRow(new string[] {
                        "ApprenticeshipLevel",
                        "All levels"});
#line 96
 testRunner.When("I enter data", ((string)(null)), table12, "When ");
#line 101
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
 testRunner.And("I wait 3 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
 testRunner.And("I choose NextPage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
 testRunner.And("I wait 3 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table13.AddRow(new string[] {
                        "NextPage",
                        "Contains",
                        "3 of"});
            table13.AddRow(new string[] {
                        "PreviousPage",
                        "Contains",
                        "1 of"});
#line 107
 testRunner.Then("I see", ((string)(null)), table13, "Then ");
#line 111
 testRunner.When("I choose NextPage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 112
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
 testRunner.And("I wait 3 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table14.AddRow(new string[] {
                        "NextPage",
                        "Contains",
                        "4 of"});
            table14.AddRow(new string[] {
                        "PreviousPage",
                        "Contains",
                        "2 of"});
#line 114
 testRunner.Then("I see", ((string)(null)), table14, "Then ");
#line 118
 testRunner.When("I choose PreviousPage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 119
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.And("I wait 3 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table15.AddRow(new string[] {
                        "NextPage",
                        "Contains",
                        "3 of"});
            table15.AddRow(new string[] {
                        "PreviousPage",
                        "Contains",
                        "1 of"});
#line 121
 testRunner.Then("I see", ((string)(null)), table15, "Then ");
#line 125
 testRunner.When("I choose PreviousPage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 126
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
 testRunner.And("I wait 3 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.And("I wait to not see PreviousPage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table16.AddRow(new string[] {
                        "NextPage",
                        "Contains",
                        "2 of"});
#line 129
 testRunner.Then("I see", ((string)(null)), table16, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search doesn\'t error when location doesn\'t exist")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void SearchDoesnTErrorWhenLocationDoesnTExist()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search doesn\'t error when location doesn\'t exist", new string[] {
                        "SmokeTests"});
#line 134
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 135
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table17.AddRow(new string[] {
                        "Location",
                        "KJHNSAKDFJHA"});
#line 136
 testRunner.When("I enter data", ((string)(null)), table17, "When ");
#line 139
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 140
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table18.AddRow(new string[] {
                        "SortOrderingDropDown",
                        "Does Not Exist",
                        ""});
            table18.AddRow(new string[] {
                        "NoResultsTitle",
                        "Exists",
                        ""});
#line 141
 testRunner.Then("I see", ((string)(null)), table18, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search location autocomplete appears on both initial search page and search resul" +
            "ts page")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void SearchLocationAutocompleteAppearsOnBothInitialSearchPageAndSearchResultsPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search location autocomplete appears on both initial search page and search resul" +
                    "ts page", new string[] {
                        "SmokeTests"});
#line 147
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 148
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table19.AddRow(new string[] {
                        "Location",
                        "Coventry"});
#line 149
 testRunner.When("I enter data", ((string)(null)), table19, "When ");
#line 152
 testRunner.Then("I wait for 5 seconds to see LocationAutoComplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table20.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Coventry (West Midlands)"});
#line 153
 testRunner.When("I am on LocationAutoCompletItems list item matching criteria", ((string)(null)), table20, "When ");
#line 156
 testRunner.And("I choose WrappedElement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 157
 testRunner.And("I am on the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 158
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 159
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table21.AddRow(new string[] {
                        "ClearLocation",
                        "Equals",
                        "True"});
#line 160
 testRunner.Then("I see", ((string)(null)), table21, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table22.AddRow(new string[] {
                        "Location",
                        "London"});
#line 163
 testRunner.When("I enter data", ((string)(null)), table22, "When ");
#line 166
 testRunner.Then("I wait for 5 seconds to see LocationAutoComplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Different results per page")]
        [NUnit.Framework.CategoryAttribute("US517")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void DifferentResultsPerPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Different results per page", new string[] {
                        "US517",
                        "SmokeTests"});
#line 169
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 170
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table23.AddRow(new string[] {
                        "Location",
                        "London"});
            table23.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
            table23.AddRow(new string[] {
                        "ApprenticeshipLevel",
                        "All levels"});
#line 171
 testRunner.When("I enter data", ((string)(null)), table23, "When ");
#line 176
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 177
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table24.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Equals",
                        "5"});
#line 178
 testRunner.And("I see", ((string)(null)), table24, "And ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table25.AddRow(new string[] {
                        "ResultsPerPageDropDown",
                        "10 per page"});
#line 181
 testRunner.When("I enter data", ((string)(null)), table25, "When ");
#line 184
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table26.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Equals",
                        "10"});
#line 185
 testRunner.And("I see", ((string)(null)), table26, "And ");
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table27.AddRow(new string[] {
                        "ResultsPerPageDropDown",
                        "25 per page"});
#line 188
 testRunner.When("I enter data", ((string)(null)), table27, "When ");
#line 191
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table28.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Equals",
                        "25"});
#line 192
 testRunner.And("I see", ((string)(null)), table28, "And ");
#line hidden
            TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table29.AddRow(new string[] {
                        "ResultsPerPageDropDown",
                        "50 per page"});
#line 195
 testRunner.When("I enter data", ((string)(null)), table29, "When ");
#line 198
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table30.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Equals",
                        "50"});
#line 199
 testRunner.And("I see", ((string)(null)), table30, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Return to search results link appears if arriving from search results page")]
        [NUnit.Framework.CategoryAttribute("US528")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void ReturnToSearchResultsLinkAppearsIfArrivingFromSearchResultsPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return to search results link appears if arriving from search results page", new string[] {
                        "US528",
                        "SmokeTests"});
#line 204
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 205
 testRunner.Given("I select the \"first\" apprenticeship vacancy in location \"N7 8LS\" that can apply b" +
                    "y this website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 206
 testRunner.When("I am on the ApprenticeshipDetailsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table31.AddRow(new string[] {
                        "ReturnToSearchResultsLink",
                        "Exists",
                        ""});
#line 207
 testRunner.Then("I see", ((string)(null)), table31, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Return to find apprenticeship link appears if not arriving from search results pa" +
            "ge")]
        [NUnit.Framework.CategoryAttribute("US528")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void ReturnToFindApprenticeshipLinkAppearsIfNotArrivingFromSearchResultsPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return to find apprenticeship link appears if not arriving from search results pa" +
                    "ge", new string[] {
                        "US528",
                        "SmokeTests"});
#line 212
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 213
 testRunner.When("I navigate to the details of the apprenticeship vacancy 779161", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 214
 testRunner.And("I am on the ApprenticeshipDetailsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table32.AddRow(new string[] {
                        "FindApprenticeshipLink",
                        "Exists",
                        ""});
#line 215
 testRunner.Then("I see", ((string)(null)), table32, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Reset search options")]
        [NUnit.Framework.CategoryAttribute("US726")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void ResetSearchOptions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Reset search options", new string[] {
                        "US726",
                        "SmokeTests"});
#line 221
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 222
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table33.AddRow(new string[] {
                        "Keywords",
                        "Admin"});
            table33.AddRow(new string[] {
                        "Location",
                        "Coventry"});
            table33.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
            table33.AddRow(new string[] {
                        "ApprenticeshipLevel",
                        "Advanced"});
#line 223
 testRunner.When("I enter data", ((string)(null)), table33, "When ");
#line 229
 testRunner.And("I choose Reset Search Options Link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 230
 testRunner.And("I am on the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table34 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table34.AddRow(new string[] {
                        "Keywords",
                        "Empty",
                        ""});
            table34.AddRow(new string[] {
                        "Location",
                        "Empty",
                        ""});
            table34.AddRow(new string[] {
                        "WithInDistance",
                        "Empty",
                        "5 miles"});
            table34.AddRow(new string[] {
                        "ApprenticeshipLevel",
                        "Equals",
                        "All levels"});
#line 231
 testRunner.Then("I see", ((string)(null)), table34, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
