﻿Feature: SpecFlowEducation
		In order to update my profile 
		As a skill trader 
		I want to add my Education details

@mytag
Scenario Outline: Check if Seller is able to add Education details
	Given I have logged in and clicked on Education tab under Profile tab
	When I Add my education details <Country>,<University>,<Title>,<Degree>,<Graduation Year>
	Then those details should be displayed on the list

	Examples: 
		| Country   | University | Title  | Degree | Graduation Year |
		| India     |    VTU     | B.Tech |   IT   |	2016         |
		| Australia |   Monash   | M.B.A  |   CS   |	2018         |

@mytag
Scenario: Check if the seller is able to update the education details  
	Given I have logged in and clicked on Education tab under Profile tab
	When I edit education details and click in update button
	Then the updated detail should be replaced in the list

@mytag
Scenario: Check if the seller can delete any eduation detail that is added
	Given I have logged in and clicked on Education tab under Profile tab
	When I click on delete button of the selected education detail
	Then I that eduaction detail should not appear on the list

	@ignore
Scenario: Check if seller can add education details without entering one field
	Given I have logged in and clicked on Education tab under Profile tab
	When I enter all the fields except Year of education field
	Then that education detail should not be added in the list

