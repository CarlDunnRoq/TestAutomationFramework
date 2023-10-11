Feature: CSV file feature

This feature will import an external CSV file to compare the prices of products
@DataSource:Products.csv
Scenario: Testing product prices using an external .csv file
    Given I am on the Swag Labs login page
    When I enter my username and password and click Login
    Then the <product> will be <price>
