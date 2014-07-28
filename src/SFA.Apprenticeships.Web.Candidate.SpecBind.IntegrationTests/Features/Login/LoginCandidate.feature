﻿@ignore
@US415
@US458
Feature: Login Candidate
	As a candidate,
	I want to sign in so that I can access my profile,
	apply for apprenticeships etc.

Scenario: As a candidate all required fields are present
	Given I navigated to the LoginCandidatePage page
	When I am on the LoginCandidatePage page
	Then I wait to see EmailAddress
	And I wait to see Password
	And I see
		| Field             | Rule           | Value |
		| ValidationSummary | Does Not Exist |       |

Scenario: As a candidate I can login with a registered and activated email address and password
	Given I registered an account and activated it
	And I navigated to the LoginCandidatePage page
	When I am on the LoginCandidatePage page
	And I enter data
		| Field        | Value               |
		| EmailAddress | {EmailAddressToken} |
		| Password     | {PasswordToken}     |
	And I choose SignInButton
	Then I am on the VacancySearchPage page

Scenario: As a candidate I must provide an email address and password
	Given I navigated to the LoginCandidatePage page
	When I am on the LoginCandidatePage page
	And I choose SignInButton
	And I am on the LoginCandidatePage page
	Then I see
		| Field                  | Rule   | Value |
		| ValidationSummaryCount | Equals | 2     |

@ignore
Scenario: As a candidate I cannot login with an invalid password
	Given I navigated to the LoginCandidatePage page
	When I am on the LoginCandidatePage page
	And I enter data
		| Field        | Value               |
		| EmailAddress | {EmailAddressToken} |
		| Password     | {InvalidPassword}   |
	And I choose SignInButton
	And I wait to see ValidationSummary
	Then I see
		| Field                  | Rule   | Value |
		| ValidationSummaryCount | Equals | 1     |
	And I am on ValidationSummaryItems list item matching criteria
		| Field | Rule   | Value                                    |
		| Text  | Equals | 'Email address' or 'password' is invalid |
		| Href  | Equals | #emailaddress                            |

Scenario: As a candidate I can login with a registered but unactivated account and am redirected to my last viewed vacancy

	Given I registered an account but did not activate it
	And I navigated to the LoginCandidatePage page
	When I am on the LoginCandidatePage page
	And I enter data
		| Field        | Value               |
		| EmailAddress | {EmailAddressToken} |
		| Password     | {PasswordToken}     |
	And I choose SignInButton
	And I am on the ActivationPage page
	And I enter data
		| Field          | Value                 |
		| ActivationCode | {ActivationCodeToken} |
	And I choose ActivateButton
	Then I am on the VacancySearchPage page

Scenario: As a candidate I can login with a registered but unactivated account and am redirected to my last viewed page

	Given I registered an account but did not activate it
