Feature: EditDeleteEmployeeInfoTest
	Simple calculator for adding two numbers

@editinfo
Scenario: Edit Employee Info
	Given Administrator is on employees page
	When User is searching for employee
	| employeename      |
	| Valicova Evghenia |
	And Employee details is opened
	And User can edit employee name 
	Then User will see the edited name


	@deleteeditedinfo
Scenario: Delete edited Employee profile info 
	Given Administrator is on employees page
	When User is searching for employee
	| employeename      |
	| Valicova Evghenia |
	And Employee details is opened
	And User can edit employee name 
	And User can delete previous changes
	Then The employee's name without recent changes should be displayed