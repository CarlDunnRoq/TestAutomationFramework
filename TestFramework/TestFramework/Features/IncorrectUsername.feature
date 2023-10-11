Feature: Incorrect Username/Password

An Un-happy path with incorrect username/password

Scenario: An Un-happy path with incorrect username/password
    Given I am on the Swag Labs login page
    When the user logs in incorrectly
    Then an error message will be displayed