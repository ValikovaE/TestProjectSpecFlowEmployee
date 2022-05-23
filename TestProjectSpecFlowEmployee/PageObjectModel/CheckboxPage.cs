using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectSpecFlowEmployee.Settings;

namespace TestProjectSpecFlowEmployee.PageObjectModel
{
    public class CheckboxPage : BasePage
    {


        private By checkButton = By.XPath(" //input[@type='checkbox']");
        private By submitButton = By.XPath(" //input[@type='submit']");


        public HomePage ClickSubmitButton()
        {
            WaitAndClick(checkButton);
            WaitAndClick(submitButton);
            return new HomePage();
        }
    }
}
