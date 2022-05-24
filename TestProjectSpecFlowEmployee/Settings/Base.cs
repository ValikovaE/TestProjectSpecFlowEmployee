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

        [BeforeFeature]
        public static void Setup()
        {
            Driver.StartBrowser();
        }
        [AfterFeature]
        public static void TearDown()
        {
            Driver.StopBrowser();
        }
    }
}