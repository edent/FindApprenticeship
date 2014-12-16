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
    [NUnit.Framework.DescriptionAttribute("Vacancy Search by Location")]
    public partial class VacancySearchByLocationFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "VacancySearchByLocation.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Vacancy Search by Location", "In order to find a georgraphically suitable vacancy\r\nAs a candidate\r\nI want to be" +
                    " able to find and refine vacancies by location", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("When searching by location the results are ordered by distance and order options " +
            "do not contain best match")]
        [NUnit.Framework.CategoryAttribute("US449")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void WhenSearchingByLocationTheResultsAreOrderedByDistanceAndOrderOptionsDoNotContainBestMatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When searching by location the results are ordered by distance and order options " +
                    "do not contain best match", new string[] {
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
                        "Location",
                        "Birmingham"});
            table1.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
#line 15
 testRunner.When("I enter data", ((string)(null)), table1, "When ");
#line 19
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table2.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Greater Than",
                        "0"});
            table2.AddRow(new string[] {
                        "SortOrderingDropDownItemsCount",
                        "Equals",
                        "2"});
            table2.AddRow(new string[] {
                        "SortOrderingDropDownItemsText",
                        "Equals",
                        "Closing Date,Distance"});
            table2.AddRow(new string[] {
                        "SortOrderingDropDown",
                        "Equals",
                        "Distance"});
#line 21
 testRunner.Then("I see", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When searching by location the results are ordered by distance and distance is sh" +
            "own")]
        [NUnit.Framework.CategoryAttribute("US449")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void WhenSearchingByLocationTheResultsAreOrderedByDistanceAndDistanceIsShown()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When searching by location the results are ordered by distance and distance is sh" +
                    "own", new string[] {
                        "US449",
                        "SmokeTests"});
#line 29
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 30
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "Location",
                        "Birmingham"});
            table3.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
#line 31
 testRunner.When("I enter data", ((string)(null)), table3, "When ");
#line 35
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table4.AddRow(new string[] {
                        "DistanceDisplayed",
                        "Equals",
                        "True"});
            table4.AddRow(new string[] {
                        "ClosingDateDisplayed",
                        "Equals",
                        "True"});
            table4.AddRow(new string[] {
                        "NationwideDisplayed",
                        "Equals",
                        "False"});
#line 37
 testRunner.Then("I see SearchResults list contains", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User enters location manually and sees a list of suggested locations")]
        [NUnit.Framework.CategoryAttribute("USXXX")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void UserEntersLocationManuallyAndSeesAListOfSuggestedLocations()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User enters location manually and sees a list of suggested locations", new string[] {
                        "USXXX",
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
                        "Location",
                        "Manchester"});
#line 46
 testRunner.When("I enter data", ((string)(null)), table5, "When ");
#line 49
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table6.AddRow(new string[] {
                        "LocationSuggestionsCount",
                        "Greater Than",
                        "0"});
#line 51
 testRunner.And("I see", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User enters location manually and location defaults to first suggested location")]
        [NUnit.Framework.CategoryAttribute("USXXX")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void UserEntersLocationManuallyAndLocationDefaultsToFirstSuggestedLocation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User enters location manually and location defaults to first suggested location", new string[] {
                        "USXXX",
                        "SmokeTests"});
#line 56
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 57
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "Location",
                        "Covent"});
#line 58
 testRunner.When("I enter data", ((string)(null)), table7, "When ");
#line 61
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table8.AddRow(new string[] {
                        "Location",
                        "Equals",
                        "Coventry (West Midlands)"});
#line 63
 testRunner.And("I see", ((string)(null)), table8, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User enters location manually then changes location manually and sees a list of s" +
            "uggested locations")]
        [NUnit.Framework.CategoryAttribute("USXXX")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void UserEntersLocationManuallyThenChangesLocationManuallyAndSeesAListOfSuggestedLocations()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User enters location manually then changes location manually and sees a list of s" +
                    "uggested locations", new string[] {
                        "USXXX",
                        "SmokeTests"});
#line 68
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 69
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "Location",
                        "Manchester"});
#line 70
 testRunner.When("I enter data", ((string)(null)), table9, "When ");
#line 73
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 75
 testRunner.Then("I clear the Location field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "Location",
                        "Birm"});
#line 76
 testRunner.When("I enter data", ((string)(null)), table10, "When ");
#line 79
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table11.AddRow(new string[] {
                        "Location",
                        "Equals",
                        "Birmingham (West Midlands)"});
            table11.AddRow(new string[] {
                        "LocationSuggestionsCount",
                        "Greater Than",
                        "0"});
#line 81
 testRunner.And("I see", ((string)(null)), table11, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User enters location manually then selects from autocomplete and sees only their " +
            "chosen location")]
        [NUnit.Framework.CategoryAttribute("USXXX")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void UserEntersLocationManuallyThenSelectsFromAutocompleteAndSeesOnlyTheirChosenLocation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User enters location manually then selects from autocomplete and sees only their " +
                    "chosen location", new string[] {
                        "USXXX",
                        "SmokeTests"});
#line 87
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 88
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "Location",
                        "Leeds"});
#line 89
 testRunner.When("I enter data", ((string)(null)), table12, "When ");
#line 92
 testRunner.Then("I wait for 5 seconds to see LocationAutoComplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table13.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Leeds (West Yorkshire)"});
#line 93
 testRunner.When("I am on LocationAutoCompletItems list item matching criteria", ((string)(null)), table13, "When ");
#line 96
 testRunner.And("I choose WrappedElement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.And("I am on the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table14.AddRow(new string[] {
                        "Location",
                        "Equals",
                        "Leeds (West Yorkshire)"});
            table14.AddRow(new string[] {
                        "LocationSuggestionsContainer",
                        "Does Not Exist",
                        ""});
#line 100
 testRunner.And("I see", ((string)(null)), table14, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User enters location manually then selects from autocomplete then changes locatio" +
            "n manually and sees a list of suggested locations")]
        [NUnit.Framework.CategoryAttribute("USXXX")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void UserEntersLocationManuallyThenSelectsFromAutocompleteThenChangesLocationManuallyAndSeesAListOfSuggestedLocations()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User enters location manually then selects from autocomplete then changes locatio" +
                    "n manually and sees a list of suggested locations", new string[] {
                        "USXXX",
                        "SmokeTests"});
#line 106
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 107
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table15.AddRow(new string[] {
                        "Location",
                        "Leeds"});
#line 108
 testRunner.When("I enter data", ((string)(null)), table15, "When ");
#line 111
 testRunner.Then("I wait for 5 seconds to see LocationAutoComplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table16.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Leeds (West Yorkshire)"});
#line 112
 testRunner.When("I am on LocationAutoCompletItems list item matching criteria", ((string)(null)), table16, "When ");
#line 115
 testRunner.And("I choose WrappedElement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
 testRunner.And("I am on the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.Then("I clear the Location field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table17.AddRow(new string[] {
                        "Location",
                        "Manchester"});
#line 118
 testRunner.When("I enter data", ((string)(null)), table17, "When ");
#line 121
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table18.AddRow(new string[] {
                        "Location",
                        "Equals",
                        "Manchester (Greater Manchester)"});
            table18.AddRow(new string[] {
                        "LocationSuggestionsCount",
                        "Greater Than",
                        "0"});
#line 123
 testRunner.And("I see", ((string)(null)), table18, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User enters location manually then selects from autocomplete then refines twice a" +
            "nd sees a list of suggestions for the final location search")]
        [NUnit.Framework.CategoryAttribute("USXXX")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void UserEntersLocationManuallyThenSelectsFromAutocompleteThenRefinesTwiceAndSeesAListOfSuggestionsForTheFinalLocationSearch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User enters location manually then selects from autocomplete then refines twice a" +
                    "nd sees a list of suggestions for the final location search", new string[] {
                        "USXXX",
                        "SmokeTests"});
#line 129
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 130
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table19.AddRow(new string[] {
                        "Location",
                        "Leeds"});
#line 131
 testRunner.When("I enter data", ((string)(null)), table19, "When ");
#line 134
 testRunner.Then("I wait for 5 seconds to see LocationAutoComplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table20.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Leeds (West Yorkshire)"});
#line 135
 testRunner.When("I am on LocationAutoCompletItems list item matching criteria", ((string)(null)), table20, "When ");
#line 138
 testRunner.And("I choose WrappedElement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
 testRunner.And("I am on the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 140
 testRunner.Then("I clear the Location field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table21.AddRow(new string[] {
                        "Location",
                        "Manchester"});
#line 141
 testRunner.When("I enter data", ((string)(null)), table21, "When ");
#line 144
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table22.AddRow(new string[] {
                        "Location",
                        "Equals",
                        "Manchester (Greater Manchester)"});
            table22.AddRow(new string[] {
                        "LocationSuggestionsCount",
                        "Greater Than",
                        "0"});
#line 146
 testRunner.And("I see", ((string)(null)), table22, "And ");
#line 150
 testRunner.Then("I clear the Location field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table23.AddRow(new string[] {
                        "Location",
                        "Birm"});
#line 151
 testRunner.When("I enter data", ((string)(null)), table23, "When ");
#line 154
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 155
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table24.AddRow(new string[] {
                        "Location",
                        "Equals",
                        "Birmingham (West Midlands)"});
            table24.AddRow(new string[] {
                        "LocationSuggestionsCount",
                        "Greater Than",
                        "0"});
#line 156
 testRunner.And("I see", ((string)(null)), table24, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User enters location manually then selects from autocomplete then changes locatio" +
            "n manually then selects from autocomplete and sees a list of suggested locations" +
            "")]
        [NUnit.Framework.CategoryAttribute("USXXX")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void UserEntersLocationManuallyThenSelectsFromAutocompleteThenChangesLocationManuallyThenSelectsFromAutocompleteAndSeesAListOfSuggestedLocations()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User enters location manually then selects from autocomplete then changes locatio" +
                    "n manually then selects from autocomplete and sees a list of suggested locations" +
                    "", new string[] {
                        "USXXX",
                        "SmokeTests"});
#line 162
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 163
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table25.AddRow(new string[] {
                        "Location",
                        "Cov"});
#line 164
 testRunner.When("I enter data", ((string)(null)), table25, "When ");
#line 167
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 168
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table26.AddRow(new string[] {
                        "Location",
                        "Contains",
                        "Cove"});
            table26.AddRow(new string[] {
                        "LocationSuggestionsCount",
                        "Greater Than",
                        "0"});
#line 169
 testRunner.And("I see", ((string)(null)), table26, "And ");
#line 176
 testRunner.Then("I clear the Location field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table27.AddRow(new string[] {
                        "Location",
                        "Covent"});
#line 177
 testRunner.When("I enter data", ((string)(null)), table27, "When ");
#line 180
 testRunner.Then("I wait for 5 seconds to see LocationAutoComplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table28.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Coventry (West Midlands)"});
#line 181
 testRunner.When("I am on LocationAutoCompletItems list item matching criteria", ((string)(null)), table28, "When ");
#line 184
 testRunner.And("I choose WrappedElement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 185
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 186
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 187
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table29.AddRow(new string[] {
                        "Location",
                        "Equals",
                        "Coventry (West Midlands)"});
            table29.AddRow(new string[] {
                        "LocationSuggestionsContainer",
                        "Does Not Exist",
                        ""});
#line 188
 testRunner.And("I see", ((string)(null)), table29, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Find apprenticeships by location and change ordering to closing date")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void FindApprenticeshipsByLocationAndChangeOrderingToClosingDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find apprenticeships by location and change ordering to closing date", new string[] {
                        "SmokeTests"});
#line 194
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 195
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table30.AddRow(new string[] {
                        "Location",
                        "Coventry"});
            table30.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
#line 196
 testRunner.When("I enter data", ((string)(null)), table30, "When ");
#line 200
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 201
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table31.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Equals",
                        "5"});
            table31.AddRow(new string[] {
                        "ResultsAreInDistanceOrder",
                        "Equals",
                        "True"});
#line 202
 testRunner.Then("I see", ((string)(null)), table31, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table32.AddRow(new string[] {
                        "SortOrderingDropDown",
                        "Closing Date"});
#line 208
 testRunner.And("I enter data", ((string)(null)), table32, "And ");
#line 211
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table33.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Equals",
                        "5"});
            table33.AddRow(new string[] {
                        "ResultsAreInClosingDateOrder",
                        "Equals",
                        "True"});
#line 212
 testRunner.And("I see", ((string)(null)), table33, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Find apprenticeships by location and change ordering to closing date and back aga" +
            "in")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void FindApprenticeshipsByLocationAndChangeOrderingToClosingDateAndBackAgain()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find apprenticeships by location and change ordering to closing date and back aga" +
                    "in", new string[] {
                        "SmokeTests"});
#line 220
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 221
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table34 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table34.AddRow(new string[] {
                        "Location",
                        "Coventry"});
            table34.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
#line 222
 testRunner.When("I enter data", ((string)(null)), table34, "When ");
#line 226
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 227
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table35 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table35.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Equals",
                        "5"});
            table35.AddRow(new string[] {
                        "ResultsAreInDistanceOrder",
                        "Equals",
                        "True"});
#line 228
 testRunner.Then("I see", ((string)(null)), table35, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table36 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table36.AddRow(new string[] {
                        "SortOrderingDropDown",
                        "Closing Date"});
#line 234
 testRunner.And("I enter data", ((string)(null)), table36, "And ");
#line 237
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table37 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table37.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Equals",
                        "5"});
            table37.AddRow(new string[] {
                        "ResultsAreInClosingDateOrder",
                        "Equals",
                        "True"});
#line 238
 testRunner.And("I see", ((string)(null)), table37, "And ");
#line hidden
            TechTalk.SpecFlow.Table table38 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table38.AddRow(new string[] {
                        "SortOrderingDropDown",
                        "Distance"});
#line 244
 testRunner.And("I enter data", ((string)(null)), table38, "And ");
#line 247
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table39 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table39.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Equals",
                        "5"});
            table39.AddRow(new string[] {
                        "ResultsAreInDistanceOrder",
                        "Equals",
                        "True"});
#line 248
 testRunner.And("I see", ((string)(null)), table39, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
