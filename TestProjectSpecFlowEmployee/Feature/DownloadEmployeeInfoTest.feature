Feature: DownloadEmployeeInfo
	

@downloadinfo
Scenario: Download Employee Info
	Given Administrator is on employees page
	When User is searching for employee
	| employeename      |
	| Valicova Evghenia |
	And Employee details is opened
	Then User can download employee info