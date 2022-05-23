using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectSpecFlowEmployee.Settings;

namespace TestProjectSpecFlowEmployee.PageObjectModel

{
    public class LogInPage : BasePage
    {



        private By logInButton = By.CssSelector("div.button>span");
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
