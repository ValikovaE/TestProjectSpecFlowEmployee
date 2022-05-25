Feature: EmployeeSearchCheck
By name



@employeeSearchByName
Scenario: Search an employee by name
Given Administrator is on employees page
When User is searching for employee
| employeename |
| Evghenia |
Then Employee is found and user can see all projects in which this employee is involved




@employeeSearchByFamilly
Scenario: Search an employee by family
Given Administrator is on employees page
When User is searching for employee
| employeename |
| Valicova |
Then Employee is found and user can see all projects in which this employee is involved




@employeeSearchByFullname
Scenario: Search an employee by full name
Given Administrator is on employees page
When User is searching for employee
| employeename |
| Evghenia Valicova |
Then Employee is found and user can see all projects in which this employee is involved




@employeeSearchByname
Scenario Outline: Search employee by name
Given Administrator is on employees page
When User is searching for employee
| employeename |
| <name> |
Then Employee is found and user can see all projects in which this employee is involved

Examples:
| name |
| Evghenia Valicova |
| Valicova |
| Evghenia |




@invalidEmployeeSearch
Scenario: Search an invalid employee
Given Administrator is on employees page
When User is searching for employee
| employeename |
| test123456 |
Then Employee is not found