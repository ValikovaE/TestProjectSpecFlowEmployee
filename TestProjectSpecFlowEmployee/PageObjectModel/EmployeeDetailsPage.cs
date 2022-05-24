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
    public class EmployeeDetailsPage : NavigationBar
    {
        private By filterButton = By.CssSelector("i.fa-filter");

        private By downloadButton = By.XPath("//button//span[contains(., 'Download')]");
        private By downloadEmployeeInfoButton = By.Id("employeeProfiledownload");
        private By allProjectButton = By.Id("employeeProfileShowAllProjectsButton");
        private By hideProjectButton = By.Id("employeeProfileShowAllProjectsButton");

        public EmployeeDetailsPage OpenEmployeeInfoDownload()
        {

            WaitAndClick(downloadEmployeeInfoButton);
            return this;
        }
        public void CheckDownloadEmployeeText(string expectedResult)
        {
            string actualResult = WrappedWait.Until(ExpectedConditions.ElementIsVisible(downloadButton)).Text;
            Assert.AreEqual(expectedResult, actualResult);
        }
        public EmployeeDetailsPage OpenEmployeeProjects()
        {
            WaitAndClick(allProjectButton);
            return this;
        }
        public void CheckEmployeeProjects(string expectedResult)
        {
            
            string actualResult = WrappedWait.Until(ExpectedConditions.ElementIsVisible(hideProjectButton)).Text;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
