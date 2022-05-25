Feature: EditDeleteEmployeeInfoTest
	Simple calculator for adding two numbers

@temporaryUnavailableEmployee
Scenario: Sets Temporary Unavailable employee
Given Administrator is on employees page
When User is searching for employee
| employeename |
| Alexandru Micu |
Then Employee is found and user can see all projects in which this employee is involved
When User clicks Edit button
And User clicks Edit Personal Data
And User sets Temporary Unavailable employee
Then Employee is temporary unavailable
When User clicks Edit button
And User clicks Edit Personal Data
And User sets Available employee
Then Employee is available