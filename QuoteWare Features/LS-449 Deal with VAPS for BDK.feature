Feature: LS-449 Deal with VAPS for BDK

Scenario: v3 endpoint returns same as v4 endpoint
	Given I have set the endpoint to quoteware/v3/quotes
	When I add a body a valid cash price and gross price
	Then I should receive a OK response code
	And I have retrieved the total charge value
	Given I have set the endpoint to quoteware/v4/quotes
	When I add a body with a cash price totalling cash price, gross price from V3
	Then I should receive a OK response code
	And I am displayed the same total charges on V3 and V4