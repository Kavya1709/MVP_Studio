Feature: SpecFlowSkills
		In order to update my profile 
		As a skill trader 
		I want to add the skills I know

#Add Skills
Scenario Outline: Check if the seller is able to add skills
	Given I have logged in and clicked on Skills tab under Profile tab
	When I add New <skill> and <Level> in my profile
	Then those skills should be displayed on my skills tab

	Examples:
		| Skill       | Level        |
		| Yoga        | Beginner     |
		| Calligraphy | Intermediate |

#Update Skill
Scenario: Check if seller can update the existing skill 
	Given I have logged in and clicked on Skills tab under Profile tab
	When I click on Edit button of the skill 'calligraphy'
	And Change Level to Expert
	Then the updated skill must be displayed on the list

#Delete Skill
Scenario: Check if seller can delete the existing skill
	Given I have logged in and clicked on Skills tab under Profile tab
	When I click on Delete(X) button of Yoga
	Then Yoga skill should not appear on the list

Scenario: Check if seller can add a skill without entering the skill level
	Given I have logged in and clicked on Skills tab under Profile tab
	When I enter the skill and not the skill level
	Then that skill should not be added to the list 

Scenario: Check if seller can add a skill with the fields blank
	Given I have logged and clicked on Skills tab under Profile tab
	When I dont enter any fields 
	And click on ADD button
	Then Pop-up should appear saying 'Enter all the fields'
	






