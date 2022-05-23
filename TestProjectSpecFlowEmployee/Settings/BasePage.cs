using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectSpecFlowEmployee.Settings
{
    public class BasePage
    {
        protected readonly IWebDriver WrappedDriver;
        protected readonly WebDriverWait WrappedWait;
        public BasePage()
        {
            WrappedDriver = Driver.GetBrowser() ?? throw new ArgumentNullException("The wrapped IWebDriver instance is not initialized.");
            WrappedWait = Driver.GetBrowserWait();
        }
        public BasePage(IWebDriver driver)
        {

        }
        private readonly string _url = @"https://projectplanappweb-stage.azurewebsites.net/login";

        public void Navigate()

        {

            WrappedDriver.Navigate().GoToUrl(_url);

        }
        public void WaitAndClick(By locator)
        {
            WrappedWait.Until(ExpectedConditions.ElementIsVisible(locator));
            WrappedWait.Until(ExpectedConditions.ElementToBeClickable(WrappedDriver.FindElement(locator))).Click();
        }

        public void WaitAndSendKeys(By locator, string text)
        {
            WrappedWait.Until(ExpectedConditions.ElementIsVisible(locator)).SendKeys(text);
        }
    }
}
