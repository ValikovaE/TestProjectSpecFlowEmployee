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
    class EmployeeSearch:Base
    {
        LogInPage loginPage;
        EmployeeListPage employeePage;

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

        [Then(@"Employee is found and user can see all projects in which this employee is involved ")]
        public void ThenEmployeeIsFound()
        {
            employeePage.CheckShowAllProjectsButtonText("Show all Projects");
        }
        
    }
}
