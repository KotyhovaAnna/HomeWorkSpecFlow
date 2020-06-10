using NUnitTestProjectFrameworks.Business_Object;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProjectSeleniumWebDriverAdvanced
{
    public class AddProductPage
    {
        private IWebDriver driver;


        public AddProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement searchAll_Products => driver.FindElement(By.XPath("//a[contains(text(), 'All Products')]"));
        private IWebElement SearchCreateNew => driver.FindElement(By.XPath("//a[contains(text(),'Create new')]"));
        private IWebElement searchProductName => driver.FindElement(By.XPath("//input[@name='ProductName'] "));
        private IWebElement searchCategoryId => driver.FindElement(By.XPath("//*[@id=\"CategoryId\"]/*[@value][text()=\"Produce\"]"));
        private IWebElement SearchSupplierId => driver.FindElement(By.XPath("//*[@id=\"SupplierId\"]/*[@value][text()=\"Mayumi's\"]"));
        private IWebElement searchUnitPrice => driver.FindElement(By.XPath("//input[@id = 'UnitPrice']"));
        private IWebElement searchQuantityPerUnit => driver.FindElement(By.XPath("//input[@id = 'QuantityPerUnit']"));
        private IWebElement searchUnitsInStock => driver.FindElement(By.XPath("//input[@id = 'UnitsInStock']"));
        private IWebElement searchUnitsOnOrder => driver.FindElement(By.XPath("//input[@id = 'UnitsOnOrder']"));
        private IWebElement searchReorderLevel => driver.FindElement(By.XPath("//input[@id = 'ReorderLevel']"));
        private IWebElement searchsubmit => driver.FindElement(By.XPath("//*[@type='submit']"));

        private string NewProductName;
       private IWebElement nameNewProduct => driver.FindElement(By.XPath($"//a[contains(text(),'{NewProductName}')]"));


        public void ButtonAllProducts()
        {
            searchAll_Products.Click();
        }
        public void ButtonCreateNew()
        {
            SearchCreateNew.Click();
        }


        public AddProductPage AddNewProduct(Product product)
        {
            //new Actions(driver).Click(searchAll_Products).Build().Perform();
            //new Actions(driver).Click(SearchCreateNew).Build().Perform();
            new Actions(driver).Click(searchProductName).SendKeys(product.searchProductName).Build().Perform();
            driver.FindElement(By.XPath($"//*[@id=\"CategoryId\"]/*[@value][text()=\"{product.searchCategoryId}\"]")).Click();
            driver.FindElement(By.XPath($"//*[@id=\"SupplierId\"]/*[@value][text()=\"{product.SearchSupplierId}\"]")).Click();
            new Actions(driver).Click(searchUnitPrice).SendKeys(product.searchUnitPrice).Build().Perform();
            new Actions(driver).Click(searchQuantityPerUnit).SendKeys(product.searchQuantityPerUnit).Build().Perform();
            new Actions(driver).Click(searchUnitsInStock).SendKeys(product.searchUnitsInStock).Build().Perform();
            new Actions(driver).Click(searchUnitsOnOrder).SendKeys(product.searchUnitsOnOrder).Build().Perform();
            new Actions(driver).Click(searchReorderLevel).SendKeys(product.searchReorderLevel).Build().Perform();
            new Actions(driver).Click(searchsubmit).Build().Perform();


            return this;
        }
        public void SendButton()
        {
            searchsubmit.Click();
        }

        public string AssertAddNewProducts(Product product)
        {
            return nameNewProduct.Text;
        }

    }
}
