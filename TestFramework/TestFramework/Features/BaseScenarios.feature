Feature: Succesful Customer Journey
A happy-path scenario of a customer journey to purchase a single item.

@LogIn
Scenario: Successful Log On
	Given the user is on the log in page
	When the user logs in correctly
	Then the products page will be displayed

@AddToCart
Scenario: Adding a product to the cart
	Given the user is on the log in page
	When the user logs in correctly
	And the user adds Sauce Labs Bike Light to cart
	Then the remove button will be displayed for the Sauce Labs Bike Light

@FullJourney
Scenario: The user will go from the log in page to successfully purchasing an item
	Given the user is on the log in page
	When the user logs in correctly
	And the user adds Sauce Labs Bike Light to cart
	And the user clicks the cart icon
	And the user continues to checkout
	And enters their information
	And finishes their order on the overview
	Then the checkout will be complete
	And the user can click Back Home
