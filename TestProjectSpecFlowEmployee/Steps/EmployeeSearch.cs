using TestProjectSpecFlowEmployee.PageObjectModel;
using TestProjectSpecFlowEmployee.Settings;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace TestProjectSpecFlowEmployee.Steps
{
    [Binding]
    class EmployeeSearch : Base
    {
        LogInPage loginPage;
        EmployeeListPage employeePage;
        EmployeeDetailsPage employeeDetailsPage;
        

        [Given(@"Administrator is on employees page")]
        public void GivenAdministratorIsLoggedIn()
        {
            loginPage = new LogInPage();
            loginPage.ClickLogInButton()
                .SetEmailAndContinue("automation.pp@amdaris.com")
                .SetPasswordAndSubmit("10704-observe-MODERN-products-STRAIGHT-69112")
                .ClickSubmitButton()
                .GoToEmployeesFromMenu();

        }

        [When(@"User is searching for employee")]
        public void WhenUserIsSearchingForEmployee(Table table)
        {

            employeePage = new EmployeeListPage();
            dynamic data = table.CreateDynamicInstance();
            employeePage.OpenEmployeeInfoByName((string)data.employeename);

             

        }

        [Then(@"Employee is found and user can see his profile")]
        public void ThenEmployeeIsFound()
        {
            employeePage.CheckEmployeeInfo("Profile");
        }

        [Then(@"Employee is not found")]
        public void ThenEmployeeIsNotFound()
        {
            employeePage.CheckNoSuchEmployeeText("No such employees");
        }

        [When(@"Employee details is opened")]
        public void WhenEmployeeDetailsIsOpened()
        {
            employeeDetailsPage = new EmployeeDetailsPage();
            employeeDetailsPage.OpenEmployeeInfoDownload();
        }

        [Then(@"User can download employee info")]
        public void ThenUserCanDownloadEmployeeInfo()
        {
            employeeDetailsPage.CheckDownloadEmployeeText("Download");
        }
        [When(@"User open projects tab")]
        public void WhenUserOpenProjectsTab()
        {
            employeeDetailsPage.OpenEmployeeProjects();
        }


        [Then(@"User can see all completed work orders")]
        public void ThenUserCanSeeAllCompletedWorkOrders()
        {
            employeeDetailsPage.CheckEmployeeProjects("Hide all Projects");
        }
        











    }
}
