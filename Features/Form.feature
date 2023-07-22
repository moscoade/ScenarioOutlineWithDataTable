Feature: Form

As a user, i want to input my details on the form


Scenario Outline: Form with Example
	Given I navigate to the website 
	And I enter "<username>" as name
	And I enter the "<lastname>" 
	And I enter field for my "<email>"
	And I enter my "<Height>"
	And I select No for vegetarian
	And I enteet my location
	When I select career change
	And I enter my favorite hobbies "<sport>"
	And I Select my choice course
	And I select three career progression
	And I select all work days best for me
	And I select time best for me
	And I select favourite music
	#When I click on submit 
	#Then My form should be submited
	Then "<message>" is displayed

Examples: 
| username | lastname | email                    | Height | sport   | message |
| Molly    | Jerry    | molly_jerry@camplvad.com | 170    | Reading |         |
| Boot     | Mike     | boot_mike@camplvad.com   | 180    | Music   |         |
| Kelly    | Rose     | kelly_rose@camplvad.com  | 190    | Cooking |         |


