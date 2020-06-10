using NUnit.Framework;
using NUnitTestProjectSeleniumWebDriverAdvanced;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProjectFrameworks.Test
{
    public class BaseTest
    {
        protected IWebDriver driver;
        

        [OneTimeSetUp]

        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();

        }


        [OneTimeTearDown]

        public void CleanUp()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
