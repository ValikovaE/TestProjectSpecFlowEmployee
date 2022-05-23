using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

using TestProjectSpecFlowEmployee.Settings;

namespace TestProjectSpecFlowEmployee.PageObjectModel
{
    public class NavigationBar : BasePage
    {
        private By clientsTab = By.Id("clients-tab");
        private By employees = By.Id("employees-tab");
        private By checkLogo = By.CssSelector("div.background");
        private By contacts = By.Id("contacts-tab");
        private By opportunities = By.Id("opportunities-tab");

        private By projects = By.Id("projects-tab");







        public EmployeeListPage GoToEmployeesFromMenu()
        {

            WaitAndClick(employees);
            return new EmployeeListPage();
        }










    }
}
