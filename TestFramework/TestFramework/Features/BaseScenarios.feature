Feature: Succesful Customer Journey
A happy-path scenario of a customer journey to purchase a single item.

@LogIn
Scenario: Successful Log On
	Given the user is on the log in page
	When the user logs in correctly
	Then the products page will be displayed
