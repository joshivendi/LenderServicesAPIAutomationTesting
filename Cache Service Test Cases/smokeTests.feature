Feature: smokeTests

Scenario: cache/dealerships
Given I have set the endpoint to baseURL/cache/dealerships
And I have created a GET request
When I get a response back
Then I should receive a OK response code

#Scenario: cache/deaershipByList
#Given I have set the endpoint to baseURL/cache/dealershipByList
#And I have added a body with a DealershipId
#When I create a POST request
#When I get a response back
#Then I should receive a OK response code