using NUnitTestProjectFrameworks.Test;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
namespace NUnitTestProjectSeleniumWebDriverAdvanced
{
    class HomePage 
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement SearchALL_Product => driver.FindElement(By.XPath("//a[@href='/Product']"));
        private IWebElement SearchLogout => driver.FindElement(By.XPath("//a[@href= '/Account/Logout']"));
        private IWebElement assertHome_page => driver.FindElement(By.XPath("//a[contains(text(),'Home')]"));


        public void Logout()
        {
            new Actions(driver).Click(SearchALL_Product).Build().Perform();
            new Actions(driver).Click(SearchLogout).Build().Perform();
        }

        public string AssertLogout()
        {
            return assertHome_page.Text;
        }
    }
}
