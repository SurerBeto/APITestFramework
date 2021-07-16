@NASAGETApiScenarios
Feature: NASAGETApiScenarios
	Scenarios for GET request of NASA Api's


Scenario: Get NASA Planetary API 
	Given The NASA API information is loaded
	When The NASA API 'Planetary' gets called
	Then The status code should be 'OK'
	And The Body Response is not empty

Scenario: Get NASA Techtransfer Patent API 
	Given The NASA API information is loaded
	When The NASA API 'Techtransfer Patent' gets called
	Then The status code should be 'OK'
	And The Body Response is not empty

Scenario: Get NASA Techtransfer Software API 
	Given The NASA API information is loaded
	When The NASA API 'Techtransfer Software' gets called
	Then The status code should be 'OK'
	And The Body Response is not empty