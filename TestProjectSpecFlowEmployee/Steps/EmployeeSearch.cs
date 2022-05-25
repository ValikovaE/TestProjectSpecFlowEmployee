using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestProjectSpecFlowEmployee.PageObjectModel;
using TestProjectSpecFlowEmployee.Settings;




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



        [When(@"User clicks on Profile icon")]
        public void WhenUserClicksOnProfileIcon()
        {
            employeeDetailsPage = new EmployeeDetailsPage();
            employeeDetailsPage.ClickOnProfileButton();
        }



        [When(@"User ticks PDF file checkbox")]
        public void WhenUserTicksPDFFileCheckbox()
        {
            employeeDetailsPage = new EmployeeDetailsPage();
            employeeDetailsPage.TickPdfFileCheckbox();
        }



        [When(@"User ticks Word file checkbox")]
        public void WhenUserTicksWordFileCheckbox()
        {
            employeeDetailsPage = new EmployeeDetailsPage();
            employeeDetailsPage.TickWordFileCheckbox();
        }



        [When(@"User clicks Download button")]
        public void WhenUserClicksDownloadButton()
        {
            employeeDetailsPage = new EmployeeDetailsPage();
            employeeDetailsPage.ClickDownloadButton();
        }



        [When(@"User clicks Edit Personal Data")]
        public void WhenUserClicksEditPersonalData()
        {
            employeeDetailsPage = new EmployeeDetailsPage();
            employeeDetailsPage.ClickEditPersonalDataButton();
        }



        [When(@"User clicks Edit button")]
        public void WhenUserClicksEdit()
        {
            employeeDetailsPage = new EmployeeDetailsPage();
            employeeDetailsPage.ClickEditButton();
        }



        [When(@"User sets Available employee")]
        [When(@"User sets Temporary Unavailable employee")]
        public void WhenUserTicksTemporaryUnavailableCheckbox()
        {
            employeeDetailsPage = new EmployeeDetailsPage();
            employeeDetailsPage.TickTemporaryUnavailableCheckbox();
            employeeDetailsPage.ClickSaveButton();
        }




        [Then(@"Employee is found and user can see all projects in which this employee is involved")]
        public void ThenEmployeeIsFound()
        {
            employeePage.CheckShowAllProjectsButtonText("Show all Projects");
        }



        [Then(@"Employee is not found")]
        public void ThenEmployeeIsNotFound()
        {
            employeePage.CheckNoSuchEmployeeText("No such employees");
        }



        [Then(@"Employee is temporary unavailable")]
        public void ThenEmployeeIsTemporaryUnavailable()
        {
            employeeDetailsPage.CheckTemporaryUnavailableEmployeeText("Is temporary unavailable");
        }



        [Then(@"Employee is available")]
        public void ThenEmployeeIsAvailable()
        {
            employeeDetailsPage.CheckAvailableEmployeeText("Available");
        }



        [Then(@"Download Employee Profile Popup (is|is not) present")]
        public void ThenPopupAppeared(string action)
        {
            if (employeeDetailsPage.IsDownloadPopupPresent())
            {
                if (action.Equals("is not"))
                {
                    throw new System.Exception("Pop-up present");
                }
            }
            else
            {
                if (action.Equals("is"))
                {
                    throw new System.Exception("Pop-up not present");
                }
            }
        }
    }
}