Feature: Log in correctly

Ensuring the log in function works correctly

Scenario: Log In Correctly
	Given I am on the Swag Labs login page
	When I enter my username and password and click Login
	Then I will be taken to the Products page