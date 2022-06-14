using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Threading;

namespace TestProjectSpecFlowEmployee.PageObjectModel
{
    public class EmployeeListPage : NavigationBar
    {
        private By employeesField = By.XPath(" //input[@type='text']");
        // private By infoButton = By.Id("sidebar-employee-item-273");
        private By profileButton = By.Id("employeeProfiledownload");
        private By allProjectButton = By.Id("employeeProfileShowAllProjectsButton");
        private By noSuchEmployee = By.XPath("//div[contains(@class, 'not-found ng-star-inserted')]");
        private By infoButton = By.CssSelector("div.item-container");


        public EmployeeListPage OpenEmployeeInfoByName(string name)
        {
            WaitAndSendKeys(employeesField, name);
            
            return this;
        }



        public void CheckShowAllProjectsButtonText(string expectedResult)
        {
            string actualResult = WrappedWait.Until(ExpectedConditions.ElementIsVisible(allProjectButton)).Text;
            Assert.AreEqual(expectedResult, actualResult);
        }



        public void CheckNoSuchEmployeeText(string expectedResult)
        {
            string actualResult = WrappedWait.Until(ExpectedConditions.ElementIsVisible(noSuchEmployee)).Text;
            Assert.AreEqual(expectedResult, actualResult);
        }


        public EmployeeListPage OpenEmployeeInfo()
        {



            WaitAndClick(infoButton);
            return this;
        }
    } 

}