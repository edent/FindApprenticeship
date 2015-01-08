﻿Feature: ApprenticeshipSearchByLevel
	In order to quickly find a suitable apprenticeship vacancy
	As a candidate
	I want to be able to find and refine apprenticeship vacancies by their level

Background: 
	Given I navigated to the ApprenticeshipSearchPage page
	And I am logged out
	And I navigated to the ApprenticeshipSearchPage page
	Then I am on the ApprenticeshipSearchPage page

@US621 @SmokeTests
Scenario: When searching by apprenticeship level the level is shown
	Given I navigated to the ApprenticeshipSearchPage page
	When I enter data
		 | Field               | Value      |
		 | Location            | Birmingham |
		 | WithInDistance      | 40 miles   |
		 | ApprenticeshipLevel | Higher     |
	And I choose Search
	And I am on the ApprenticeshipSearchResultPage page
	Then I see 
        | Field               | Rule   | Value  |
        | ApprenticeshipLevel | Equals | Higher |

@US621 @SmokeTests
Scenario: When searching by apprenticeship level and finding no results I am advised to specify all apprenticeship levels
	Given I navigated to the ApprenticeshipSearchPage page
	When I enter data
		 | Field               | Value   |
		 | Location            | Stanton |
		 | WithInDistance      | 2 miles |
		 | ApprenticeshipLevel | Higher  |
	And I choose Search
	And I am on the ApprenticeshipSearchResultPage page
	Then I see 
        | Field                     | Rule   | Value |
        | ApprenticeshipLevelAdvice | Exists |       |

@US621 @SmokeTests
Scenario: When searching normally and finding no results I am not advised to specify all apprenticeship levels
	Given I navigated to the ApprenticeshipSearchPage page
	When I enter data
		 | Field               | Value          |
		 | Keywords            | askjdhaskjdhjk |
		 | Location            | Stanton        |
		 | WithInDistance      | 2 miles        |
		 | ApprenticeshipLevel | All levels     |
	And I choose Search
	And I am on the ApprenticeshipSearchResultPage page
	Then I see 
        | Field                     | Rule           | Value |
        | ApprenticeshipLevelAdvice | Does Not Exist |       |
