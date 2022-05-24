using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectSpecFlowEmployee.Settings;

namespace TestProjectSpecFlowEmployee.PageObjectModel
{
    public class EmployeeListPage : NavigationBar
    {

        private By employeesField = By.XPath(" //input[@type='text']");

        private By infoButton = By.CssSelector(" div.bottom-info");

        private By downloadEmployeeInfoButton = By.Id("employeeProfiledownload");

        private By filterButton = By.CssSelector("i.fa-filter");

        private By downloadButton = By.XPath("//button//span[contains(., 'Download')]");

        private By noSuchEmployee = By.XPath("//div[contains(@class, 'not-found ng-star-inserted')]");

        public EmployeeListPage OpenEmployeeInfoByName(string name)
        {
            WaitAndSendKeys(employeesField, name);
            WaitAndClick(infoButton);
            return this;
        }

        /*public void CheckShowAllProjectsButtonText(string expectedResult)
        {

            string actualResult = WrappedWait.Until(ExpectedConditions.ElementIsVisible(allProjectButton)).Text;
            Assert.AreEqual(expectedResult, actualResult);
        }*/
        public EmployeeListPage OpenEmployeeInfoByFilter()
        {
            WaitAndClick(filterButton);
            return this;
        }
        public void CheckEmployeeInfo(string expectedResult)
        {

            string actualResult = WrappedWait.Until(ExpectedConditions.ElementIsVisible(downloadEmployeeInfoButton)).Text;
            Assert.AreEqual(expectedResult, actualResult);
        }
        public void CheckNoSuchEmployeeText(string expectedResult)
        {
            string actualResult = WrappedWait.Until(ExpectedConditions.ElementIsVisible(noSuchEmployee)).Text;
            Assert.AreEqual(expectedResult, actualResult);
        }
        
    }
}
