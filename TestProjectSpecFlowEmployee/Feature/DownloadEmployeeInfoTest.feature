Feature: DownloadEmployeeInfo
	

@downloadProfileOfEmployee
Scenario: Download profile of employee
Given Administrator is on employees page
When User is searching for employee
| employeename |
| Evghenia Valicova |
Then Employee is found and user can see all projects in which this employee is involved
When User clicks on Profile icon
Then Download Employee Profile Popup is present
When User ticks PDF file checkbox
And User ticks Word file checkbox
And User clicks Download button
Then Download Employee Profile Popup is not present