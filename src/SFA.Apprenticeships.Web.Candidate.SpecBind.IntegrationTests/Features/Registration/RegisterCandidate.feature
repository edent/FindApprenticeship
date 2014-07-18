﻿@US413
Feature: Register Candidate
	In order to apply for a vacnacy
	As an apprentice
	I want to be able to register for the service

Scenario: As a candidate I am on the registration page and all required fields are present and all validators show
	Given I navigated to the RegisterCandidatePage page
	When I am on the RegisterCandidatePage page
	And I wait to see Firstname
	And I wait to see Lastname
	And I wait to see Day
	And I wait to see Month
	And I wait to see Year
	And I wait to see EmailAddress
	And I wait to see Password
	And I wait to see HasAcceptedTermsAndConditions
	And I choose CreateAccountButton
	And I wait to see ValidationSummary
	Then I see
         | Field                  | Rule   | Value |
         | ValidationSummaryCount | Equals | 9     |
	And I am on ValidationSummaryItems list item matching criteria
		    | Field | Rule   | Value                        |
		    | Text  | Equals | 'Firstname' must be supplied |
		    | Href  | Equals | #firstname                   |
	And I am on the RegisterCandidatePage page
	And I am on ValidationSummaryItems list item matching criteria
		    | Field | Rule   | Value                        |
		    | Text  | Equals | 'Lastname' must be supplied  |
		    | Href  | Equals | #lastname                    |

	

Scenario: As a candidate on the registration page I want to be able to pick my address from a list returned from the postcode search
	Given I navigated to the RegisterCandidatePage page
	When I am on the RegisterCandidatePage page
	And I enter data
		 | Field          | Value  |
		 | PostcodeSearch | N7 8LS |
	And I choose FindAddresses
	And I am on AddressDropdown list item matching criteria
		    | Field        | Rule   | Value                  |
		    | Text         | Equals | Flat A, 6 Furlong Road |
		    | AddressLine1 | Equals | Flat A                 |
		    | AddressLine2 | Equals | 6 Furlong Road         |
		    | AddressLine3 | Equals | London                 |
		    | AddressLine4 | Equals | Islington              |
		    | Postcode     | Equals | N7 8LS                 |
		    | Uprn         | Equals | 5300034721             |
		    | Latitude     | Equals | 51.54751633697479      |
		    | Longitude    | Equals | -0.10660693737952387   |
	And I choose WrappedElement
	And I am on the RegisterCandidatePage page
	Then I see
			    | Field        | Rule   | Value                |
			    | AddressLine1 | Equals | Flat A               |
			    | AddressLine2 | Equals | 6 Furlong Road       |
			    | AddressLine3 | Equals | London               |
			    | AddressLine4 | Equals | Islington            |
			    | Postcode     | Equals | N7 8LS               |
			    | Uprn         | Equals | 5300034721           |
			    | Latitude     | Equals | 51.54751633697479    |
			    | Longitude    | Equals | -0.10660693737952387 |


