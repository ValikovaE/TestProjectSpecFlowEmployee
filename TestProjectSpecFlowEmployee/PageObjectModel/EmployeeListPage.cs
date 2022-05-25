using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;



namespace TestProjectSpecFlowEmployee.PageObjectModel
{
    public class EmployeeListPage : NavigationBar
    {
        private By employeesField = By.XPath(" //input[@type='text']");



        private By infoButton = By.CssSelector(" div.bottom-info");



        private By allProjectButton = By.Id("employeeProfileShowAllProjectsButton");



        private By filterButton = By.CssSelector("i.fa-filter");



        private By allDeliverySitesButton = By.Id("mat-select-0");



        private By noSuchEmployee = By.XPath("//div[contains(@class, 'not-found ng-star-inserted')]");






        public EmployeeListPage OpenEmployeeInfoByName(string name)
        {
            WaitAndSendKeys(employeesField, name);
            WaitAndClick(infoButton);
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



        public EmployeeListPage OpenEmployeeInfoByFilter()
        {



            WaitAndClick(filterButton);
            return this;
        }



        public void CheckFilterButtonText(string expectedResult)
        {
            string actualResult = WrappedWait.Until(ExpectedConditions.ElementIsVisible(allDeliverySitesButton)).Text;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}