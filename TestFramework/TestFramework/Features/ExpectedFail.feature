Feature: An expected fail

A test expected to fail (invalid username/password)

Scenario: A test expected to fail invalid username or password
    Given I am on the Swag Labs login page
    When the user logs in incorrectly
    Then I will be taken to the Products page