Feature: InValid

As a user, i want to input valid and invalid details


Scenario: InValid Form
	Given I navigate to the website 
	And I enter First Mame
	And I enter Lastname
	And I enter incurrect Email Adress
	When I click on submit 
	Then I see a Message "Please enter a valid email address."


