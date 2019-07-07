Feature: SpecFlowLanguage
	In order to update my profile 
	As a skill trader
	I want to add, Update and Delete the languages that I know

@mytag
#Add languages
Scenario Outline: Check if the Seller is able to add a language
	Given I clicked on the Profile tab and the language tab appears
	When I add a new Language as <Language> Language Level as <Language Level>
	Then that language should be displayed on my listings

	Examples:
		| Language | Language Level |
		| English  | Conversational |
		| Hindi    | Native         |

#Update a language
Scenario Outline: Check if the seller is able to Update the Language
	Given Languages tab appears when clicked on Profile tab
	When I click on Edit button
	And  Change <Language Level> of <Language>
	Then The Updated result should be displayed on the list

	Examples:
		| Language | Language Level |
		| English  | Fluent         |

#Delete Language
Scenario Outline: Check if the seller is able to Delete the Language
	Given Languages tab appears when clicked on Profile tab
	When I select <Language> and <Language Level>
	And Click on "X"(Delete) button
	Then The deleted language should be not be displayed on the list

	Examples:
		| Language | Language Level |
		| Hindi    | Native         |

Scenario: Check if language can be added 
	Given Languages tab appears when clicked on Profile tab
	When I add the language leaving the language level blank
	Then Error Messege should be displayed 












