@TubularPostApiScenarios
Feature: TubularPOSTApiScenarios
	Simple calculator for adding two numbers

@Post1
Scenario: Tubular Post - Post - Page #1,  #5 Rows per Page, Order by ID Asc
	Given The Tubular API information is loaded
	When The Tubular Post Request Is Sent
	Then The status code should be 'OK'
	And The Body Response is not empty
@Post2
Scenario: Tubular Post - Post - Page #2,  #10 Rows per Page, Order by Customer Name
	Given The Tubular API information is loaded
	When The Tubular Post Request Is Sent
	Then The status code should be 'OK'
	And The Body Response is not empty

