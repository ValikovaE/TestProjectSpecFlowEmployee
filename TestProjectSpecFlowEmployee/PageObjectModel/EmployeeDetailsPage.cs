using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Threading;



namespace TestProjectSpecFlowEmployee.PageObjectModel
{
    public class EmployeeDetailsPage : EmployeeListPage
    {



        private By profileButton = By.Id("employeeProfiledownload");



        private By pdfFileCheckbox = By.XPath("//div//mat-dialog-container//span[contains(., 'PDF')]");
        private By wordFileCheckbox = By.XPath("//div//mat-dialog-container//span[contains(., 'Word')]");
        private By downloadButton = By.XPath("//button//span[contains(., 'Download')]");

        private By downloadProfilePopup = By.CssSelector("div.cdk-overlay-container:empty");



        private By editButton = By.XPath("//div//span[contains(.,'Edit')]");
        private By editPersonalDataButton = By.XPath("//div//span[contains(.,'Edit Personal Data')]");



        private By temporaryUnavailableEmployeeText = By.XPath("//span[contains(.,'Is temporary unavailable')]");
        private By availableEmployeeText = By.XPath("//div//span[contains(.,'Available')]");



        //edit personal data
        private By temporaryUnavailableEmployeeCheckbox = By.XPath("//div//span[contains(.,'Temporary Unavailable')]");
        private By saveButton = By.XPath("//button[@type='submit']");

        //edit firstname
        private By firstname = By.Name("firstName");
        private By firstnameText=By.XPath("//div//span[contains(.,'First Name * ')]");


        public EmployeeDetailsPage ClickOnProfileButton()
        {
            WaitAndClick(profileButton);
            return this;
        }



        public EmployeeDetailsPage TickPdfFileCheckbox()
        {
            WaitAndClick(pdfFileCheckbox);
            return this;
        }



        public EmployeeDetailsPage TickWordFileCheckbox()
        {
            WaitAndClick(wordFileCheckbox);
            return this;
        }



        public EmployeeDetailsPage ClickDownloadButton()
        {
            WaitAndClick(downloadButton);
            return this;
        }



        public EmployeeDetailsPage TickTemporaryUnavailableCheckbox()
        {
            Thread.Sleep(2000);
            WaitAndClick(temporaryUnavailableEmployeeCheckbox);
            return this;
        }



        public EmployeeDetailsPage ClickSaveButton()
        {
            WaitAndClick(saveButton);
            return this;
        }



        public EmployeeDetailsPage ClickEditButton()
        {
            WaitAndClick(editButton);
            return this;
        }



        public EmployeeDetailsPage ClickEditPersonalDataButton()
        {
            WaitAndClick(editPersonalDataButton);
            return this;
        }



        public void CheckTemporaryUnavailableEmployeeText(string expectedResult)
        {
            string actualResult = WrappedWait.Until(ExpectedConditions.ElementIsVisible(temporaryUnavailableEmployeeText)).Text;
            Assert.AreEqual(expectedResult, actualResult);
        }



        public void CheckAvailableEmployeeText(string expectedResult)
        {
            string actualResult = WrappedWait.Until(ExpectedConditions.ElementIsVisible(availableEmployeeText)).Text;
            Assert.AreEqual(expectedResult, actualResult);
        }



        public bool IsDownloadPopupPresent()
        {
            try
            {
                Thread.Sleep(2000);
                return WrappedDriver.FindElement(downloadProfilePopup) == null;
            }
            catch (NoSuchElementException e)
            {
                //displayed
                return true;
            }
        }
        public EmployeeDetailsPage SetNewFirstname(string name)
        {
            WaitAndSendKeys(firstname, name);
            
            return this;
        }
        public void CheckEmoloyeeFirstname(string expectedResult)
        {
            string actualResult = WrappedWait.Until(ExpectedConditions.ElementIsVisible(firstnameText)).Text;
            Assert.AreEqual(expectedResult, actualResult);
        }

    }

}