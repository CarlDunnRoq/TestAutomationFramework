Feature: The user checks out basket

This an end-to-end test of a full transaction

Scenario: The user checks out basket
    Given I am on the Swag Labs login page
    When I enter my username and password and click Login
    And the user adds Sauce Labs Backpack to their basket
    Then the basket icon will change to 1
    And the remove button for Sauce Labs Backpack is displayed
    And the user clicks on the basket icon
    And the user is taken to the Your Cart page
    When the user sees Sauce Labs Backpack in their cart
    And the user clicks Checkout
    Then the user is taken to the Checkout: Your Information page
    When the user enters their information
    And the user clicks Continue
    Then the user is taken to the Checkout: Overview page
    When the user clicks Finish
    Then the user is taken to the Checkout: Complete! page
    And Thank you for your order! will be displayed
    Then the user clicks Back Home
    And the user is taken to the Products page
