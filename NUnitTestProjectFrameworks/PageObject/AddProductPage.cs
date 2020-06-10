using NUnitTestProjectFrameworks.Business_Object;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;



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
        private IWebElement clicksearchCategoryId => driver.FindElement(By.XPath("//select[@id= 'CategoryId']"));
        private IWebElement searchCategoryId => driver.FindElement(By.XPath("//select[@id= 'CategoryId']/child::option[@value = '7']"));
        private IWebElement clicksearchSupplierId => driver.FindElement(By.XPath("//select[@id= 'SupplierId']"));
        private IWebElement searchSupplierId => driver.FindElement(By.XPath("//select[@id= 'SupplierId']/child::option[@value = '6']"));
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

        public void SendName(Product product)
        {
            new Actions(driver).Click(searchProductName).SendKeys(product.searchProductName).Build().Perform();

        }
        public void Category()
        {
            new Actions(driver).Click(clicksearchCategoryId).Build().Perform();
            searchCategoryId.Click();
        }
        public void Supplier()
        {
            new Actions(driver).Click(clicksearchSupplierId).Build().Perform();
            searchSupplierId.Click();
        }
        public void UnitPrice(Product product)
        {
            searchUnitPrice.SendKeys(product.searchUnitPrice);

        }
        public void QuantityPerUnit(Product product)
        {
            searchQuantityPerUnit.SendKeys(product.searchQuantityPerUnit);

        }
        public void UnitsInStock(Product product)
        {
            searchUnitsInStock.SendKeys(product.searchUnitsInStock);

        }
        public void UnitsOnOrder(Product product)
        {
            searchUnitsOnOrder.SendKeys(product.searchUnitsOnOrder);

        }
        public void ReorderLevel(Product product)
        {
            searchReorderLevel.SendKeys(product.searchReorderLevel);

        }
        public void SendButton()
        {
            searchsubmit.Click();
        }

        public string AssertAddNewProducts(Product product)
        {
            IWebElement assertAddNewProducts = driver.FindElement(By.XPath($"//a[contains(text(), '{product.searchProductName}')]"));
            return assertAddNewProducts.Text;
        }

    }
}
