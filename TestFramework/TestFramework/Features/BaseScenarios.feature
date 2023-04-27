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
    And adds product to their basket
    Then the basket icon will change
    And the remove button will be displayed