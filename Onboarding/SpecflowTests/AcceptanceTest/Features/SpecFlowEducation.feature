Feature: SpecFlowEducation
		In order to update my profile 
		As a skill trader 
		I want to add my Education details

@mytag
Scenario: Check if Seller is able to add Education details
	Given I have logged in and clicked on Education tab under Profile tab
	When I Add my education details
	Then those details should be displayed on the list

Scenario: Check if seller is able to add details without giving any one field
	Given I have logged in and clicked on Education tab under Profile tab
	When I have enter all feilds under education tab except one
	Then that eduaction detail should not apppear on the list

Scenario: Check if the seller is able to update the education details 
	Given I have logged in and clicked on Education tab under Profile tab
	When I click on the edit button
	And make changes in the any of the field 
	Then the updated detail should be replaced in the list

Scenario: Check if the seller can delete any eduation detail that is added
	Given I have logged in and clicked on Education tab under Profile tab
	When I click on delete(X) button of the selected education detail
	Then I that eduaction detail should not appear on the list

Scenario: Check if seller can add education details without entering one field
	Given I have logged in and clicked on Education tab under Profile tab
	When I enter all the fields except Year of education field
	Then that education detail should not be added in the list



