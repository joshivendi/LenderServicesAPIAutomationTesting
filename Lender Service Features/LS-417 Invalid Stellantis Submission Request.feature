Feature: LS-417 Invalid Stellantis Submission Request

As a caller of the API
When I submit a Request for Stellantis that is invalid
I expect to get a failed result

#Vehicles
Scenario: valid submission
	Given I have set the endpoint to lenderservicev3api/api/consumersubmission/send
	When I have set the api key in the header
	And I have added a body with a valid submission
	Then I should receive a Bad request response code

##Vehicles
#Scenario: error message displayed, vechile milage over 60000
#	Given I have set the endpoint to lenderservicev3api/api/consumersubmission/send
#	When I have set the api key in the header
#	And I have added a body with a invalid milage over 6000
#	Then I should receive a Bad request response code
#	And I am displayed the correct error message for incorrect vechile input

##Applicant
#Scenario: error message displayed, first name field null
#	Given I have set the endpoint to lenderservicev3api/api/consumersubmission/send
#	When I have set the api key in the header
#	And I have added a body without a first name
#	Then I should receive a Bad request response code
#	And I am displayed the correct error message for null first name field

Scenario: error message displayed, first name character limit reached
	Given I have set the endpoint to lenderservicev3api/api/consumersubmission/send
	When I have set the api key in the header
	And I have added a body with a first name over the 30 character limit
	Then I should receive a Bad request response code
	And I am displayed the correct error message for first name character limit being reached

Scenario: error message displayed, incorrect value entered for first name, number
	Given I have set the endpoint to <template>
	And I have added a body with a first name with a number 
	When I create a POST request
	When I get a response back
	Then I should receive a Bad request response code
	And I am displayed the correct error message for first name incorrect values for number

Scenario: error message displayed, incorrect value entered for first name, special character
	Given I have set the endpoint to <template>
	And I have added a body with a first name with a special character 
	When I create a POST request
	When I get a response back
	Then I should receive a Bad request response code
	And I am displayed the correct error message for first name incorrect values for special character

Scenario: error message displayed, surname field null
	Given I have set the endpoint to lenderservicev3api/api/consumersubmission/send
	When I have set the api key in the header
	And I have added a body without a surname
	Then I should receive a Bad request response code
	And I am displayed the correct error message for null surname field

Scenario: error message displayed, surname character limit reached
	Given I have set the endpoint to <template>
	And I have added a body with a surname over the 30 character limit
	When I create a POST request
	When I get a response back
	Then I should receive a Bad request response code
	And I am displayed the correct error message for surname character limit being reached

Scenario: error message displayed, incorrect value entered for surname, number
	Given I have set the endpoint to <template>
	And I have added a body with a surname with a number 
	When I create a POST request
	When I get a response back
	Then I should receive a Bad request response code
	And I am displayed the correct error message for surname incorrect values for number

Scenario: error message displayed, incorrect value entered for surname, special character
	Given I have set the endpoint to <template>
	And I have added a body with a surname with a special character 
	When I create a POST request
	When I get a response back
	Then I should receive a Bad request response code
	And I am displayed the correct error message for surname incorrect values for special character

Scenario: valid submission, correct surname values entered
	Given I have set the endpoint to <template>
	And I have added a body with a valid surname
	When I create a POST request
	When I get a response back
	Then I should receive a OK response code

Scenario: error message, incorrect date formatting for DOB
	Given I have set the endpoint to <template>
	And I have added a body with a DOB incorrectly formatted
	When I create a POST request
	When I get a response back
	Then I should receive a Bad request response code
	And I am displayed the correct error message for DOB incorrectly formatted

Scenario: valid submission, correct DOB values entered
	Given I have set the endpoint to <template>
	And I have added a body with a valid DOB, formatted correctly
	When I create a POST request
	When I get a response back
	Then I should receive a OK response code

#Address
Scenario: error message, incorrect date formatting for date at address
	Given I have set the endpoint to <template>
	And I have added a body with a date at address incorrectly formatted
	When I create a POST request
	When I get a response back
	Then I should receive a Bad request response code
	And I am displayed the correct error message for date at address incorrectly formatted

Scenario: error message, valid date is less than three years, previous address is mandatory
	Given I have set the endpoint to <template>
	And I have added a body with a valid date at address, less than three years
	When I create a POST request
	When I get a response back
	Then I should receive a Bad request response code
	And I am displayed a error message saying previous address must be entered

Scenario: valid submission, date entered minimum of three years at the property
	Given I have set the endpoint to <template>
	And I have added a body with a date within a minimum of 3 years
	When I create a POST request
	When I get a response back
	Then I should receive a OK response code

Scenario: error message displayed, locality name character limit reached
	Given I have set the endpoint to <template>
	And I have added a body with a locality name over the 20 character limit
	When I create a POST request
	When I get a response back
	Then I should receive a Bad request response code
	And I am displayed the correct error message for locality name character limit being reached

Scenario: valid submission, correct locality name values entered
	Given I have set the endpoint to <template>
	And I have added a body with a locality name within the character character limits
	When I create a POST request
	When I get a response back
	Then I should receive a OK response code

Scenario: valid submission, locality name field is null
	Given I have set the endpoint to <template>
	And I have added a body with a locality name field null
	When I create a POST request
	When I get a response back
	Then I should receive a OK response code

Scenario: error message displayed, postTown field character limit reached
	Given I have set the endpoint to <template>
	And I have added a body with postTown over the 30 character limit
	When I create a POST request
	When I get a response back
	Then I should receive a Bad request response code
	And I am displayed the correct error message for postTown character limit being reached

Scenario: valid submission, correct postTown values entered
	Given I have set the endpoint to <template>
	And I have added a body with postTown within the character character limits
	When I create a POST request
	When I get a response back
	Then I should receive a OK response code

Scenario: valid submission, postTown field is null
	Given I have set the endpoint to <template>
	And I have added a body with postTown field null
	When I create a POST request
	When I get a response back
	Then I should receive a OK response code

Scenario: error message, postcode field left null
	Given I have set the endpoint to <template>
	And I have added a body without a postcode
	When I create a POST request
	When I get a response back
	Then I should receive a Bad request response code
	And I am displayed the correct error message for null postcode field

Scenario: error message displayed, postcode field character limit reached
	Given I have set the endpoint to <template>
	And I have added a body with postcode over the 8 character limit
	When I create a POST request
	When I get a response back
	Then I should receive a Bad request response code
	And I am displayed the correct error message for postcode character limit being reached

Scenario: valid submission, correct postcode values entered
	Given I have set the endpoint to <template>
	And I have added a body with postcode within the character character limits
	When I create a POST request
	When I get a response back
	Then I should receive a OK response code

Scenario: error message displayed, county field character limit reached
	Given I have set the endpoint to <template>
	And I have added a body with county over the 20 character limit
	When I create a POST request
	When I get a response back
	Then I should receive a Bad request response code
	And I am displayed the correct error message for county character limit being reached

Scenario: valid submission, correct county values entered
	Given I have set the endpoint to <template>
	And I have added a body with county within the character character limits
	When I create a POST request
	When I get a response back
	Then I should receive a OK response code

Scenario: valid submission, county field is null
	Given I have set the endpoint to <template>
	And I have added a body with county field null
	When I create a POST request
	When I get a response back
	Then I should receive a OK response code

#contact details
Scenario: error message displayed, phone number field character limit reached
	Given I have set the endpoint to <template>
	And I have added a body with a phone number over the 20 character limit
	When I create a POST request
	When I get a response back
	Then I should receive a Bad request response code
	And I am displayed the correct error message for a phone number character limit being reached

Scenario: valid submission, correct phone number values entered
	Given I have set the endpoint to <template>
	And I have added a body with a phone number within the character character limits
	When I create a POST request
	When I get a response back
	Then I should receive a OK response code

Scenario: valid submission, phone number field is null
	Given I have set the endpoint to <template>
	And I have added a body with the phone number field null
	When I create a POST request
	When I get a response back
	Then I should receive a OK response code

Scenario: error message displayed, email field character limit reached
	Given I have set the endpoint to <template>
	And I have added a body with a phone number over the 100 character limit
	When I create a POST request
	When I get a response back
	Then I should receive a Bad request response code
	And I am displayed the correct error message for a email character limit being reached

Scenario: valid submission, correct email values entered
	Given I have set the endpoint to <template>
	And I have added a body with a email within the character character limits
	When I create a POST request
	When I get a response back
	Then I should receive a OK response code

Scenario: valid submission, email field is null
	Given I have set the endpoint to <template>
	And I have added a body with the email field null
	When I create a POST request
	When I get a response back
	Then I should receive a OK response code

Scenario: error message displayed, mobile number field character limit reached
	Given I have set the endpoint to <template>
	And I have added a body with a mobile number over the 20 character limit
	When I create a POST request
	When I get a response back
	Then I should receive a Bad request response code
	And I am displayed the correct error message for a mobile number character limit being reached

Scenario: valid submission, correct mobile number values entered
	Given I have set the endpoint to <template>
	And I have added a body with a mobile number within the character character limits
	When I create a POST request
	When I get a response back
	Then I should receive a OK response code

Scenario: valid submission, mobile number field is null
	Given I have set the endpoint to <template>
	And I have added a body with the mobile number field null
	When I create a POST request
	When I get a response back
	Then I should receive a OK response code

#Occupation
Scenario: error message displayed, occupation postion field character limit reached
	Given I have set the endpoint to <template>
	And I have added a body with a occupation postion over the 30 character limit
	When I create a POST request
	When I get a response back
	Then I should receive a Bad request response code
	And I am displayed the correct error message for a occupation postion character limit being reached

Scenario: valid submission, correct occupation postion values entered
	Given I have set the endpoint to <template>
	And I have added a body with a occupation postion within the character character limits
	When I create a POST request
	When I get a response back
	Then I should receive a OK response code

Scenario: valid submission, occupation postion field is null
	Given I have set the endpoint to <template>
	And I have added a body with the occupation postion field null
	When I create a POST request
	When I get a response back
	Then I should receive a OK response code

Scenario: error message displayed, occupation employer name field character limit reached
	Given I have set the endpoint to <template>
	And I have added a body with a occupation employer name over the 30 character limit
	When I create a POST request
	When I get a response back
	Then I should receive a Bad request response code
	And I am displayed the correct error message for a occupation employer name character limit being reached

Scenario: valid submission, correct occupation employer name values entered
	Given I have set the endpoint to <template>
	And I have added a body with a occupation employer name within the character character limits
	When I create a POST request
	When I get a response back
	Then I should receive a OK response code

Scenario: error message, occupation employer name field is null
	Given I have set the endpoint to <template>
	And I have added a body with the occupation employer name field null
	When I create a POST request
	When I get a response back
	Then I should receive a Bad request response code
	And I am displayed the correct error message for a occupation employer name field being null

Scenario: error message, incorrect date formatting for bank date from
	Given I have set the endpoint to <template>
	And I have added a body with bank date from incorrectly formatted
	When I create a POST request
	When I get a response back
	Then I should receive a Bad request response code
	And I am displayed the correct error message for bank date from incorrectly formatted

Scenario: valid submission, correct bank date from values entered
	Given I have set the endpoint to <template>
	And I have added a body with valid bank date from formatted correctly
	When I create a POST request
	When I get a response back
	Then I should receive a OK response code