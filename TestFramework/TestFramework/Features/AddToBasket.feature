Feature: Add to basket

The user adds a product to the basket

Scenario: The user adds a product to the basket
    Given I am on the Swag Labs login page
    When I enter my username and password and click Login
    And the user adds Sauce Labs Backpack to their basket
    Then the basket icon will change to 1
    And the remove button for Sauce Labs Backpack is displayed
