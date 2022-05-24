Feature: EmployeeSearchCheck
By name

	@employeeSearchByName
Scenario: Search an employee by name and firstname
	Given Administrator is on employees page
	When User is searching for employee
	| employeename      |
	| Valicova Evghenia |
	Then Employee is found and user can see his profile 



@employeeSearchByFamily
Scenario: Search an employee by name
	Given Administrator is on employees page
	When User is searching for employee
	| employeename |
	| Valicova     |
	Then Employee is found and user can see his profile 


	@employeeSearchByFamily
Scenario: Search an employee by firstname
	Given Administrator is on employees page
	When User is searching for employee
	| employeename |
	| Evghenia     |
	Then Employee is found and user can see his profile 


@invalidEmployeeSearch
Scenario: Search an invalid employee
Given Administrator is on employees page
When User is searching for employee
| employeename |
| test123456   |
Then Employee is not found	
	

	
@downloadinfo
Scenario: Download Employee profile info 
	Given Administrator is on employees page
	When User is searching for employee
	| employeename      |
	| Valicova Evghenia |
	And Employee details is opened
	Then User can download employee info