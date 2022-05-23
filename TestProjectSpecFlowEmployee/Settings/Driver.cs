using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectSpecFlowEmployee.Settings

{
    public static class Driver
    {
        private static WebDriverWait _browserWait;
        private static IWebDriver _browser;
        public static IWebDriver GetBrowser()
        {
            if (_browser == null)
            {
               // StartBrowser();
                throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method Start.");
            }
            return _browser;
        }
        private static void SetBrowser(IWebDriver value)
        {
            _browser = value;
        }
        public static WebDriverWait GetBrowserWait()
        {
            if (_browserWait == null || _browser == null)
            {
                throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Start.");
            }
            return _browserWait;
        }
        private static void SetBrowserWait(WebDriverWait value)
        {
            _browserWait = value;
        }
        public static void StartBrowser(int defaultTimeOut = 30)
        {
            Console.WriteLine("Start browser se executa");
            ChromeOptions options = new ChromeOptions();
            //SetBrowser(new ChromeDriver(options));
            _browser = new ChromeDriver(options);
            _browser.Navigate().GoToUrl(@"https://projectplanappweb-stage.azurewebsites.net/login");

            SetBrowserWait(new WebDriverWait(GetBrowser(), TimeSpan.FromSeconds(defaultTimeOut)));
        }
        public static void StopBrowser()
        {
            GetBrowser().Quit();
            SetBrowser(null);
            SetBrowserWait(null);
        }
    }
}
