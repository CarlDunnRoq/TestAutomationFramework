@Chrome
Feature: Succesful Customer Journey
A happy-path scenario of a customer journey to purchase a single item.

Scenario: 01. Validate the title of a website
   Given a user is on the base page
   Then they see the page title contains "Swag Labs"

Scenario: 02. Validate the Url of a webpage
    Given a user is on the base page
    Then the page URL contains "https://www.saucedemo.com/"

Scenario: 03. The user logs in correctly
    Given a user is on the base page
    When the user logs in correctly
    Then the products page will be displayed

Scenario: 04. The user adds a product to the basket
    Given a user is on the base page
    When the user logs in correctly
    And the user adds Sauce Labs Backpack to their basket
    Then the basket icon will change to 1
    And the remove button for Sauce Labs Backpack will be displayed

Scenario: 05. The user checks out basket
    Given a user is on the base page
    When the user logs in correctly
    And the user adds Sauce Labs Backpack to their basket
    Then the basket icon will change to 1
    And the remove button for Sauce Labs Backpack will be displayed
    And the user clicks on the basket icon
    And the user will be taken to the Your Cart page
    When the user sees Sauce Labs Backpack in their cart
    And the user clicks Checkout
    Then the user will be taken to the Checkout: Your Information page
    When the user enters their information
    And the user clicks Continue
    Then the user will be taken to the Checkout: Overview page
    When the user clicks Finish
    Then the user will be taken to the Checkout: Complete! page
    And Thank you for your order! will be displayed
    Then the user clicks Back Home
    And the user will be taken to the Products page