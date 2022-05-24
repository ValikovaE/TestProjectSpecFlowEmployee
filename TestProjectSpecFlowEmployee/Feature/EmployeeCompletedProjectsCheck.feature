Feature: EmployeeCompletedProjectsCheck
	

@showallemployeprojects
Scenario: Show completed work orders
	Given Administrator is on employees page
	When User is searching for employee
	| employeename      |
	| Valicova Evghenia |
	And User open projects tab
	Then User can see all completed work orders
	
	