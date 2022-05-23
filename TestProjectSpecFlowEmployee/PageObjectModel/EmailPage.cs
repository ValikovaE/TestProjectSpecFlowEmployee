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
    public class EmailPage : BasePage
    {

        private By emailField = By.XPath(" //input[@type='email']");
        private By nextButton = By.XPath(" //input[@type='submit']");
        private By errorMessage = By.Id("usernameError");
        

        
         public PasswordPage SetEmailAndContinue(string email)
         {
             WaitAndSendKeys(emailField, email);
             WaitAndClick(nextButton);
             return new PasswordPage();
         }

        public void WriteEmail(string email)
        {
            WaitAndSendKeys(emailField, email);
        }

        internal void WaitAndSendKeys(string email)
        {
            throw new NotImplementedException();
        }

        public void ClickNextButton()

        {
            WaitAndClick(nextButton);
            // return new PasswordPage();
        }



    }
}

