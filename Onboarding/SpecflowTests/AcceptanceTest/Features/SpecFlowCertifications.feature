Feature: SpecFlowCertifications
	In order to update my profile 
	As a skill trader
	I want to add, Update and Delete the Certifications
@mytag
Scenario Outline: Check if seller can add certifications 
	Given I have logged in and clicked on cerfications tab under Profile tab
	When I enter <Certificate> <From> <Year>
	And click on ADD button
	Then the entered data should appear in the list

Examples: 
		| Certificate      | From         | Year |
		| ISTQB Foundation | ISTQB        | 2018 |
		| Yoga             | Yoga Academy | 2016 |
	
Scenario: Check if the seller is able to update a certificate
	Given I have logged in and clicked on cerfications tab under Profile tab
	When I click on edit button of Yoga
	And change 'certified from' field and click on update
	Then the updated data should appear on the list

Scenario: Check if the seller is able to delete a certificate 
	Given I have logged in and clicked on cerfications tab under Profile tab
	When I click on delete button(X) of ISTQB
	Then that record should not appear on the list

Scenario: Check if the seller is able to add certicates leaving fields blank
	Given I have logged in and clicked on cerfications tab under Profile tab
	When I enter only certicate field and leave the other fields blank
	Then that record should not appear on the list



	

		
	
