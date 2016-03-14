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
namespace SFA.Apprenticeships.Web.Candidate.AcceptanceTests.Features.TraineeshipSearch
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Traineeship Search by Location")]
    [NUnit.Framework.CategoryAttribute("US583")]
    public partial class TraineeshipSearchByLocationFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TraineeshipSearchByLocation.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Traineeship Search by Location", "In order to find a georgraphically suitable traineeship vacancy\r\nAs a candidate\r\n" +
                    "I want to be able to find and refine traineeship vacancies by location", ProgrammingLanguage.CSharp, new string[] {
                        "US583"});
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
 testRunner.Given("I navigated to the TraineeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("I am logged out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("I navigated to the TraineeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.Then("I am on the TraineeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When searching by location the results are ordered by distance and order options " +
            "do not contain best match")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void WhenSearchingByLocationTheResultsAreOrderedByDistanceAndOrderOptionsDoNotContainBestMatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When searching by location the results are ordered by distance and order options " +
                    "do not contain best match", new string[] {
                        "SmokeTests"});
#line 14
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 15
 testRunner.Given("I navigated to the TraineeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "Location",
                        "Birmingham"});
#line 16
 testRunner.When("I enter data", ((string)(null)), table1, "When ");
#line 19
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("I am on the TraineeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
                        "3"});
            table2.AddRow(new string[] {
                        "SortOrderingDropDownItemsText",
                        "Equals",
                        "Closing date,Distance,Recently added"});
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
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void WhenSearchingByLocationTheResultsAreOrderedByDistanceAndDistanceIsShown()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When searching by location the results are ordered by distance and distance is sh" +
                    "own", new string[] {
                        "SmokeTests"});
#line 29
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 30
 testRunner.Given("I navigated to the TraineeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "Location",
                        "Birmingham"});
#line 31
 testRunner.When("I enter data", ((string)(null)), table3, "When ");
#line 34
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("I am on the TraineeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
#line 36
 testRunner.Then("I see SearchResults list contains", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User enters location manually and sees a list of suggested locations")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void UserEntersLocationManuallyAndSeesAListOfSuggestedLocations()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User enters location manually and sees a list of suggested locations", new string[] {
                        "SmokeTests"});
#line 42
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 43
 testRunner.Given("I navigated to the TraineeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "Location",
                        "Manchester"});
#line 44
 testRunner.When("I enter data", ((string)(null)), table5, "When ");
#line 47
 testRunner.Then("I wait for 5 seconds to see LocationAutoComplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User enters location manually and location defaults to first suggested location")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void UserEntersLocationManuallyAndLocationDefaultsToFirstSuggestedLocation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User enters location manually and location defaults to first suggested location", new string[] {
                        "SmokeTests"});
#line 51
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 52
 testRunner.Given("I navigated to the TraineeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "Location",
                        "Covent"});
#line 53
 testRunner.When("I enter data", ((string)(null)), table6, "When ");
#line 56
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.Then("I am on the TraineeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table7.AddRow(new string[] {
                        "Location",
                        "Equals",
                        "Coventry (West Midlands)"});
#line 58
 testRunner.And("I see", ((string)(null)), table7, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User enters location manually then changes location manually and sees a list of s" +
            "uggested locations")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void UserEntersLocationManuallyThenChangesLocationManuallyAndSeesAListOfSuggestedLocations()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User enters location manually then changes location manually and sees a list of s" +
                    "uggested locations", new string[] {
                        "SmokeTests"});
#line 63
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 64
 testRunner.Given("I navigated to the TraineeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table8.AddRow(new string[] {
                        "Location",
                        "Manchester"});
#line 65
 testRunner.When("I enter data", ((string)(null)), table8, "When ");
#line 68
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.Then("I am on the TraineeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 70
 testRunner.Then("I clear the Location field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "Location",
                        "Cov"});
#line 71
 testRunner.When("I enter data", ((string)(null)), table9, "When ");
#line 74
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.Then("I am on the TraineeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table10.AddRow(new string[] {
                        "Location",
                        "Equals",
                        "Coventry (West Midlands)"});
            table10.AddRow(new string[] {
                        "LocationSuggestionsCount",
                        "Greater Than",
                        "0"});
#line 76
 testRunner.And("I see", ((string)(null)), table10, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User enters location manually then selects from autocomplete and sees only their " +
            "chosen location")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void UserEntersLocationManuallyThenSelectsFromAutocompleteAndSeesOnlyTheirChosenLocation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User enters location manually then selects from autocomplete and sees only their " +
                    "chosen location", new string[] {
                        "SmokeTests"});
#line 82
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 83
 testRunner.Given("I navigated to the TraineeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "Location",
                        "Leeds"});
#line 84
 testRunner.When("I enter data", ((string)(null)), table11, "When ");
#line 87
 testRunner.Then("I wait for 5 seconds to see LocationAutoComplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table12.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Leeds (West Yorkshire)"});
#line 88
 testRunner.When("I am on LocationAutoCompletItems list item matching criteria", ((string)(null)), table12, "When ");
#line 91
 testRunner.And("I choose WrappedElement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("I am on the TraineeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.Then("I am on the TraineeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table13.AddRow(new string[] {
                        "Location",
                        "Equals",
                        "Leeds (West Yorkshire)"});
            table13.AddRow(new string[] {
                        "LocationSuggestionsContainer",
                        "Does Not Exist",
                        ""});
#line 95
 testRunner.And("I see", ((string)(null)), table13, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User enters location manually then selects from autocomplete then changes locatio" +
            "n manually and sees a list of suggested locations")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void UserEntersLocationManuallyThenSelectsFromAutocompleteThenChangesLocationManuallyAndSeesAListOfSuggestedLocations()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User enters location manually then selects from autocomplete then changes locatio" +
                    "n manually and sees a list of suggested locations", new string[] {
                        "SmokeTests"});
#line 101
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 102
 testRunner.Given("I navigated to the TraineeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table14.AddRow(new string[] {
                        "Location",
                        "Leeds"});
#line 103
 testRunner.When("I enter data", ((string)(null)), table14, "When ");
#line 106
 testRunner.Then("I wait for 5 seconds to see LocationAutoComplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table15.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Leeds (West Yorkshire)"});
#line 107
 testRunner.When("I am on LocationAutoCompletItems list item matching criteria", ((string)(null)), table15, "When ");
#line 110
 testRunner.And("I choose WrappedElement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
 testRunner.And("I am on the TraineeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.Then("I clear the Location field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table16.AddRow(new string[] {
                        "Location",
                        "Manchester"});
#line 113
 testRunner.When("I enter data", ((string)(null)), table16, "When ");
#line 116
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.Then("I am on the TraineeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table17.AddRow(new string[] {
                        "Location",
                        "Equals",
                        "Manchester (Greater Manchester)"});
            table17.AddRow(new string[] {
                        "LocationSuggestionsCount",
                        "Greater Than",
                        "0"});
#line 118
 testRunner.And("I see", ((string)(null)), table17, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User enters location manually then selects from autocomplete then refines twice a" +
            "nd sees a list of suggestions for the final location search")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void UserEntersLocationManuallyThenSelectsFromAutocompleteThenRefinesTwiceAndSeesAListOfSuggestionsForTheFinalLocationSearch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User enters location manually then selects from autocomplete then refines twice a" +
                    "nd sees a list of suggestions for the final location search", new string[] {
                        "SmokeTests"});
#line 124
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 125
 testRunner.Given("I navigated to the TraineeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table18.AddRow(new string[] {
                        "Location",
                        "Leeds"});
#line 126
 testRunner.When("I enter data", ((string)(null)), table18, "When ");
#line 129
 testRunner.Then("I wait for 5 seconds to see LocationAutoComplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table19.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Leeds (West Yorkshire)"});
#line 130
 testRunner.When("I am on LocationAutoCompletItems list item matching criteria", ((string)(null)), table19, "When ");
#line 133
 testRunner.And("I choose WrappedElement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
 testRunner.And("I am on the TraineeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
 testRunner.Then("I clear the Location field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table20.AddRow(new string[] {
                        "Location",
                        "Manchester"});
#line 136
 testRunner.When("I enter data", ((string)(null)), table20, "When ");
#line 139
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 140
 testRunner.Then("I am on the TraineeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table21.AddRow(new string[] {
                        "Location",
                        "Equals",
                        "Manchester (Greater Manchester)"});
            table21.AddRow(new string[] {
                        "LocationSuggestionsCount",
                        "Greater Than",
                        "0"});
#line 141
 testRunner.And("I see", ((string)(null)), table21, "And ");
#line 145
 testRunner.Then("I clear the Location field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table22.AddRow(new string[] {
                        "Location",
                        "Cov"});
#line 146
 testRunner.When("I enter data", ((string)(null)), table22, "When ");
#line 149
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 150
 testRunner.Then("I am on the TraineeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 151
 testRunner.And("I wait 3 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table23.AddRow(new string[] {
                        "Location",
                        "Equals",
                        "Coventry (West Midlands)"});
            table23.AddRow(new string[] {
                        "LocationSuggestionsCount",
                        "Greater Than",
                        "0"});
#line 152
 testRunner.And("I see", ((string)(null)), table23, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User enters location manually then selects from autocomplete then changes locatio" +
            "n manually then selects from autocomplete and sees a list of suggested locations" +
            "")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void UserEntersLocationManuallyThenSelectsFromAutocompleteThenChangesLocationManuallyThenSelectsFromAutocompleteAndSeesAListOfSuggestedLocations()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User enters location manually then selects from autocomplete then changes locatio" +
                    "n manually then selects from autocomplete and sees a list of suggested locations" +
                    "", new string[] {
                        "SmokeTests"});
#line 158
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 159
 testRunner.Given("I navigated to the TraineeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table24.AddRow(new string[] {
                        "Location",
                        "Cov"});
#line 160
 testRunner.When("I enter data", ((string)(null)), table24, "When ");
#line 163
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 164
 testRunner.Then("I am on the TraineeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table25.AddRow(new string[] {
                        "Location",
                        "Contains",
                        "Cove"});
            table25.AddRow(new string[] {
                        "LocationSuggestionsCount",
                        "Greater Than",
                        "0"});
#line 165
 testRunner.And("I see", ((string)(null)), table25, "And ");
#line 172
 testRunner.Then("I clear the Location field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table26.AddRow(new string[] {
                        "Location",
                        "Covent"});
#line 173
 testRunner.When("I enter data", ((string)(null)), table26, "When ");
#line 176
 testRunner.Then("I wait for 5 seconds to see LocationAutoComplete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table27.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Coventry (West Midlands)"});
#line 177
 testRunner.When("I am on LocationAutoCompletItems list item matching criteria", ((string)(null)), table27, "When ");
#line 180
 testRunner.And("I choose WrappedElement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 181
 testRunner.And("I am on the TraineeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 182
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 183
 testRunner.Then("I am on the TraineeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 184
 testRunner.And("I wait 3 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table28.AddRow(new string[] {
                        "Location",
                        "Equals",
                        "Coventry (West Midlands)"});
            table28.AddRow(new string[] {
                        "LocationSuggestionsContainer",
                        "Does Not Exist",
                        ""});
#line 185
 testRunner.And("I see", ((string)(null)), table28, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Find traineeships by location and change ordering to closing date")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void FindTraineeshipsByLocationAndChangeOrderingToClosingDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find traineeships by location and change ordering to closing date", new string[] {
                        "SmokeTests"});
#line 191
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 192
 testRunner.Given("I navigated to the TraineeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table29.AddRow(new string[] {
                        "Location",
                        "Coventry"});
#line 193
 testRunner.When("I enter data", ((string)(null)), table29, "When ");
#line 196
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 197
 testRunner.And("I am on the TraineeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table30.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Equals",
                        "5"});
            table30.AddRow(new string[] {
                        "ResultsAreInDistanceOrder",
                        "Equals",
                        "True"});
#line 198
 testRunner.Then("I see", ((string)(null)), table30, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table31.AddRow(new string[] {
                        "SortOrderingDropDown",
                        "Closing date"});
#line 202
 testRunner.And("I enter data", ((string)(null)), table31, "And ");
#line 205
 testRunner.And("I am on the TraineeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 206
 testRunner.And("I wait 3 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table32.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Equals",
                        "5"});
            table32.AddRow(new string[] {
                        "ResultsAreInClosingDateOrder",
                        "Equals",
                        "True"});
#line 207
 testRunner.And("I see", ((string)(null)), table32, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Find traineeships by location and change ordering to closing date and back again")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void FindTraineeshipsByLocationAndChangeOrderingToClosingDateAndBackAgain()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find traineeships by location and change ordering to closing date and back again", new string[] {
                        "SmokeTests"});
#line 213
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 214
 testRunner.Given("I navigated to the TraineeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table33.AddRow(new string[] {
                        "Location",
                        "Coventry"});
#line 215
 testRunner.When("I enter data", ((string)(null)), table33, "When ");
#line 218
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 219
 testRunner.And("I am on the TraineeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table34 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table34.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Equals",
                        "5"});
            table34.AddRow(new string[] {
                        "ResultsAreInDistanceOrder",
                        "Equals",
                        "True"});
#line 220
 testRunner.Then("I see", ((string)(null)), table34, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table35 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table35.AddRow(new string[] {
                        "SortOrderingDropDown",
                        "Closing date"});
#line 224
 testRunner.And("I enter data", ((string)(null)), table35, "And ");
#line 227
 testRunner.And("I am on the TraineeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 228
 testRunner.And("I wait 3 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table36 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table36.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Equals",
                        "5"});
            table36.AddRow(new string[] {
                        "ResultsAreInClosingDateOrder",
                        "Equals",
                        "True"});
#line 229
 testRunner.And("I see", ((string)(null)), table36, "And ");
#line hidden
            TechTalk.SpecFlow.Table table37 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table37.AddRow(new string[] {
                        "SortOrderingDropDown",
                        "Distance"});
#line 233
 testRunner.And("I enter data", ((string)(null)), table37, "And ");
#line 236
 testRunner.And("I am on the TraineeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 237
 testRunner.And("I wait 3 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table38 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table38.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Equals",
                        "5"});
            table38.AddRow(new string[] {
                        "ResultsAreInDistanceOrder",
                        "Equals",
                        "True"});
#line 238
 testRunner.And("I see", ((string)(null)), table38, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
