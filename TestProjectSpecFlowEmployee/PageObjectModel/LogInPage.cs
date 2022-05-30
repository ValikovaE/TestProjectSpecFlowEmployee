using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestProjectSpecFlowEmployee.Settings;

namespace TestProjectSpecFlowEmployee.PageObjectModel

{
    public class LogInPage : BasePage
    {

        private By logInButton = By.CssSelector("div.button");
        //private By logInButton = By.XPath("//button//span[contains(., 'LogIn')]");
        //By.XPath("//div//button//span[contains(., 'LogIn')]");
        private By emailField = By.XPath(" //input[@type='email']");

        public LogInPage(IWebDriver driver) : base(driver)
        {
        }
        public LogInPage() : base()
        {




        }
        public EmailPage ClickLogInButton()
        {
            
            WaitAndClick(logInButton);
            return new EmailPage();
        }

    }
}
