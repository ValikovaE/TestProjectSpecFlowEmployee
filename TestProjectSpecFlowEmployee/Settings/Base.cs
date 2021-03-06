using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace TestProjectSpecFlowEmployee.Settings
{ 
    [Binding]
    public class Base
    {

        [BeforeScenario]
        public static void BeforeScenario()
        {
            Driver.StartBrowser();
        }
        [AfterScenario]
        public static void AfterScenario()
        {
            Driver.StopBrowser();
        }
    }
}