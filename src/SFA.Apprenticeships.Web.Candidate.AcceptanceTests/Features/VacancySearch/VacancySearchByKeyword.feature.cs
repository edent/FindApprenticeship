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
namespace SFA.Apprenticeships.Web.Candidate.AcceptanceTests.Features.VacancySearch
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("VacancySearchByKeyword")]
    public partial class VacancySearchByKeywordFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "VacancySearchByKeyword.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "VacancySearchByKeyword", "In order to quickly find a suitable apprenticeship vacancy\r\nAs a candidate\r\nI wan" +
                    "t to be able to find and refine vacancies by keyword", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("When searching by keyword the keyword is shown")]
        [NUnit.Framework.CategoryAttribute("US449")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void WhenSearchingByKeywordTheKeywordIsShown()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When searching by keyword the keyword is shown", new string[] {
                        "US449",
                        "SmokeTests"});
#line 13
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 14
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "Keywords",
                        "Mechanical"});
            table1.AddRow(new string[] {
                        "Location",
                        "Birmingham"});
            table1.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
#line 15
 testRunner.When("I enter data", ((string)(null)), table1, "When ");
#line 20
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table2.AddRow(new string[] {
                        "Keywords",
                        "Equals",
                        "Mechanical"});
#line 22
 testRunner.Then("I see", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When searching by keyword the results are ordered by best match")]
        [NUnit.Framework.CategoryAttribute("US449")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void WhenSearchingByKeywordTheResultsAreOrderedByBestMatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When searching by keyword the results are ordered by best match", new string[] {
                        "US449",
                        "SmokeTests"});
#line 27
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 28
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "Keywords",
                        "Mechanical"});
            table3.AddRow(new string[] {
                        "Location",
                        "Birmingham"});
            table3.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
#line 29
 testRunner.When("I enter data", ((string)(null)), table3, "When ");
#line 34
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table4.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Greater Than",
                        "0"});
            table4.AddRow(new string[] {
                        "SortOrderingDropDownItemsCount",
                        "Equals",
                        "3"});
            table4.AddRow(new string[] {
                        "SortOrderingDropDownItemsText",
                        "Equals",
                        "Best Match,Closing Date,Distance"});
            table4.AddRow(new string[] {
                        "SortOrderingDropDown",
                        "Equals",
                        "Best Match"});
#line 36
 testRunner.Then("I see", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When searching by keywords the results are ordered by best match")]
        [NUnit.Framework.CategoryAttribute("US449")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void WhenSearchingByKeywordsTheResultsAreOrderedByBestMatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When searching by keywords the results are ordered by best match", new string[] {
                        "US449",
                        "SmokeTests"});
#line 44
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 45
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "Keywords",
                        "Mechanical Engineering"});
            table5.AddRow(new string[] {
                        "Location",
                        "Birmingham"});
            table5.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
#line 46
 testRunner.When("I enter data", ((string)(null)), table5, "When ");
#line 51
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table6.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Greater Than",
                        "0"});
            table6.AddRow(new string[] {
                        "SortOrderingDropDownItemsCount",
                        "Equals",
                        "3"});
            table6.AddRow(new string[] {
                        "SortOrderingDropDownItemsText",
                        "Equals",
                        "Best Match,Closing Date,Distance"});
            table6.AddRow(new string[] {
                        "SortOrderingDropDown",
                        "Equals",
                        "Best Match"});
#line 53
 testRunner.Then("I see", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When searching by keyword then removing keyword and searching again the results a" +
            "re ordered by distance")]
        [NUnit.Framework.CategoryAttribute("US449")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void WhenSearchingByKeywordThenRemovingKeywordAndSearchingAgainTheResultsAreOrderedByDistance()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When searching by keyword then removing keyword and searching again the results a" +
                    "re ordered by distance", new string[] {
                        "US449",
                        "SmokeTests"});
#line 61
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 62
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "Keywords",
                        "Mechanical"});
            table7.AddRow(new string[] {
                        "Location",
                        "Birmingham"});
            table7.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
#line 63
 testRunner.When("I enter data", ((string)(null)), table7, "When ");
#line 68
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table8.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Greater Than",
                        "0"});
            table8.AddRow(new string[] {
                        "SortOrderingDropDown",
                        "Equals",
                        "Best Match"});
#line 70
 testRunner.Then("I see", ((string)(null)), table8, "Then ");
#line 74
 testRunner.When("I clear the Keywords field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table9.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Greater Than",
                        "0"});
            table9.AddRow(new string[] {
                        "SortOrderingDropDownItemsCount",
                        "Equals",
                        "2"});
            table9.AddRow(new string[] {
                        "SortOrderingDropDownItemsText",
                        "Equals",
                        "Closing Date,Distance"});
            table9.AddRow(new string[] {
                        "SortOrderingDropDown",
                        "Equals",
                        "Distance"});
#line 77
 testRunner.Then("I see", ((string)(null)), table9, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When searching by keyword then changing keyword and searching again the new keywo" +
            "rd is used")]
        [NUnit.Framework.CategoryAttribute("US449")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void WhenSearchingByKeywordThenChangingKeywordAndSearchingAgainTheNewKeywordIsUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When searching by keyword then changing keyword and searching again the new keywo" +
                    "rd is used", new string[] {
                        "US449",
                        "SmokeTests"});
#line 85
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 86
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "Keywords",
                        "Mechanical"});
            table10.AddRow(new string[] {
                        "Location",
                        "Birmingham"});
            table10.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
#line 87
 testRunner.When("I enter data", ((string)(null)), table10, "When ");
#line 92
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table11.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Greater Than",
                        "0"});
            table11.AddRow(new string[] {
                        "Keywords",
                        "Equals",
                        "Mechanical"});
#line 94
 testRunner.Then("I see", ((string)(null)), table11, "Then ");
#line 98
 testRunner.When("I clear the Keywords field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "Keywords",
                        "bricklaying"});
#line 99
 testRunner.And("I enter data", ((string)(null)), table12, "And ");
#line 102
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table13.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Greater Than",
                        "0"});
            table13.AddRow(new string[] {
                        "Keywords",
                        "Equals",
                        "bricklaying"});
#line 104
 testRunner.Then("I see", ((string)(null)), table13, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When searching by location then adding keyword and searching again the results ar" +
            "e ordered by best match")]
        [NUnit.Framework.CategoryAttribute("US449")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void WhenSearchingByLocationThenAddingKeywordAndSearchingAgainTheResultsAreOrderedByBestMatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When searching by location then adding keyword and searching again the results ar" +
                    "e ordered by best match", new string[] {
                        "US449",
                        "SmokeTests"});
#line 110
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 111
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table14.AddRow(new string[] {
                        "Location",
                        "Birmingham"});
            table14.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
#line 112
 testRunner.When("I enter data", ((string)(null)), table14, "When ");
#line 116
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table15.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Greater Than",
                        "0"});
            table15.AddRow(new string[] {
                        "SortOrderingDropDown",
                        "Equals",
                        "Distance"});
#line 118
 testRunner.Then("I see", ((string)(null)), table15, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table16.AddRow(new string[] {
                        "Keywords",
                        "Mechanical"});
#line 122
 testRunner.When("I enter data", ((string)(null)), table16, "When ");
#line 125
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table17.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Greater Than",
                        "0"});
            table17.AddRow(new string[] {
                        "SortOrderingDropDownItemsCount",
                        "Equals",
                        "3"});
            table17.AddRow(new string[] {
                        "SortOrderingDropDownItemsText",
                        "Equals",
                        "Best Match,Closing Date,Distance"});
            table17.AddRow(new string[] {
                        "SortOrderingDropDown",
                        "Equals",
                        "Distance"});
#line 127
 testRunner.Then("I see", ((string)(null)), table17, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Nationwide apprenticeships are included in keyword search results")]
        [NUnit.Framework.CategoryAttribute("US449")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void NationwideApprenticeshipsAreIncludedInKeywordSearchResults()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Nationwide apprenticeships are included in keyword search results", new string[] {
                        "US449",
                        "SmokeTests"});
#line 136
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 137
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table18.AddRow(new string[] {
                        "Keywords",
                        "it"});
            table18.AddRow(new string[] {
                        "Location",
                        "London"});
            table18.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
#line 138
 testRunner.When("I enter data", ((string)(null)), table18, "When ");
#line 143
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 144
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table19.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Greater Than",
                        "0"});
            table19.AddRow(new string[] {
                        "SortOrderingDropDown",
                        "Equals",
                        "Best Match"});
            table19.AddRow(new string[] {
                        "NationwideLocationTypeLink",
                        "Exists",
                        ""});
#line 145
 testRunner.Then("I see", ((string)(null)), table19, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Find apprenticeships by keyword and change ordering to distance")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void FindApprenticeshipsByKeywordAndChangeOrderingToDistance()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find apprenticeships by keyword and change ordering to distance", new string[] {
                        "SmokeTests"});
#line 152
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 153
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table20.AddRow(new string[] {
                        "Keywords",
                        "Admin"});
            table20.AddRow(new string[] {
                        "Location",
                        "Coventry"});
            table20.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
#line 154
 testRunner.When("I enter data", ((string)(null)), table20, "When ");
#line 159
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 160
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table21.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Equals",
                        "5"});
#line 161
 testRunner.Then("I see", ((string)(null)), table21, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table22.AddRow(new string[] {
                        "SortOrderingDropDown",
                        "Distance"});
#line 167
 testRunner.And("I enter data", ((string)(null)), table22, "And ");
#line 170
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table23.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Equals",
                        "5"});
            table23.AddRow(new string[] {
                        "ResultsAreInDistanceOrder",
                        "Equals",
                        "True"});
#line 171
 testRunner.And("I see", ((string)(null)), table23, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Find apprenticeships by keyword and change ordering to closing date")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void FindApprenticeshipsByKeywordAndChangeOrderingToClosingDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find apprenticeships by keyword and change ordering to closing date", new string[] {
                        "SmokeTests"});
#line 179
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 180
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table24.AddRow(new string[] {
                        "Keywords",
                        "Admin"});
            table24.AddRow(new string[] {
                        "Location",
                        "Coventry"});
            table24.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
#line 181
 testRunner.When("I enter data", ((string)(null)), table24, "When ");
#line 186
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 187
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table25.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Equals",
                        "5"});
#line 188
 testRunner.Then("I see", ((string)(null)), table25, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table26.AddRow(new string[] {
                        "SortOrderingDropDown",
                        "Closing Date"});
#line 194
 testRunner.And("I enter data", ((string)(null)), table26, "And ");
#line 197
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table27.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Equals",
                        "5"});
            table27.AddRow(new string[] {
                        "ResultsAreInClosingDateOrder",
                        "Equals",
                        "True"});
#line 198
 testRunner.And("I see", ((string)(null)), table27, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
