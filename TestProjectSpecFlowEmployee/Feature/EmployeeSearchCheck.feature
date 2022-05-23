Feature: EmployeeSearchCheck
By name

	@employeeSearchByName
Scenario: Search an employee by name 
	Given Administrator is on employees page
	When User is searching for employee
	| employeename   |
	| Alexandru Micu |
	Then Employee is found and user can see all projects in which this employee is involved . 

