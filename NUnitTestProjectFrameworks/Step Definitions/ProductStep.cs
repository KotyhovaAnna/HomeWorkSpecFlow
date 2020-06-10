using NUnit.Framework;
using NUnitTestProjectFrameworks.Business_Object;
using NUnitTestProjectSeleniumWebDriverAdvanced;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace NUnitTestProjectFrameworks.Step_Definitions
{
    [Binding]
    class ProductStep
    {
        protected IWebDriver driver;

        [Given(@"I open ""(.*)"" url")]
        public void GivenIopenUrl(string url)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = url;
            //driver.Navigate().GoToUrl(url);
        }
        [When(@"I type the word ""(.*)"" in the Name field")]
        public void WhenITypeInTheName(string Name)
        {
            new LoginPage(driver).LoginMetod(new Login(Name, null));

        }

        [When(@"I type the word ""(.*)"" in the Password field")]
        public void WhenITypeInThePassword(string Password)
        {
            new LoginPage(driver).LoginMetod(new Login(null, Password));
        }

        [When(@"I click the login button")]
        public void WhenIclickTheLogin()

        {
            new LoginPage(driver).LoginButton();
        }

        [When(@"I click the All products button in section Home page")]
        public void WhenIClickAllProducts()
        {
            new AddProductPage(driver).ButtonAllProducts();
        }

        [When(@"I click the create new button")]

        public void WhenIClickTheCreateNew()
        {
            new AddProductPage(driver).ButtonCreateNew();
        }

        [When(@"I type the word ""(.*)"" in the in section ProductName")]
        public void WhenITypeInProductName(string ProductName)
        {
            new AddProductPage(driver).AddNewProduct(new Product(ProductName, null, null, null, null, null, null, null));
        }

        [When(@"I select ""(.*)"" in the in section Category")]
        public void WhenITypeInCategory(string CategoryID)
        {
            new AddProductPage(driver).AddNewProduct(new Product(null, CategoryID, null, null, null, null, null, null));
        }

        [When(@"I select ""(.*)"" in the in section Supplier")]
        public void WhenITypeInSupplier(string SupplierId)
        {
            new AddProductPage(driver).AddNewProduct(new Product(null, null, SupplierId, null, null, null, null, null));
        }

        [When(@"I type the value ""(.*)"" in the in section UnitPrice")]
        public void WhenITypeInUnitPrice(string UnitPrice)
        {
            new AddProductPage(driver).AddNewProduct(new Product(null, null, null, UnitPrice, null, null, null, null));
        }

        [When(@"I type the value ""(.*)"" in the in section QuantityPerUnit")]
        public void WhenITypeInQuantityPerUnit(string QuantityPerUnit)
        {
            new AddProductPage(driver).AddNewProduct(new Product(null, null, null, null, QuantityPerUnit, null, null, null));
        }

        [When(@"I type the value ""(.*)"" in the in section UnitsInStock")]
        public void WhenITypeInUnitsInStock(string UnitsInStock)
        {
            new AddProductPage(driver).AddNewProduct(new Product(null, null, null, null, null, UnitsInStock, null, null));
        }

        [When(@"I type the value ""(.*)"" in the in section UnitsOnOrder")]
        public void WhenITypeInUnitsOnOrder(string UnitsOnOrder)
        {
            new AddProductPage(driver).AddNewProduct(new Product(null, null, null, null, null, null, UnitsOnOrder, null));
        }

        [When(@"I type the value ""(.*)"" in the in section ReorderLevel")]
        public void WhenITypeInReorderLevel(string ReorderLevel)
        {
            new AddProductPage(driver).AddNewProduct(new Product(null, null, null, null, null, null, null, ReorderLevel));
        }

        [When(@"I click the send button")]
        public void WhenIclickTheSendButton()
        {
            new AddProductPage(driver).SendButton();
        }

        [Then(@"I check that product ""(.*)"" has been created")]
        public void WhenICheckCreatProduct(string ProductName)
        {
            AddProductPage addProductPage = new AddProductPage(driver);
            Assert.AreEqual(ProductName, addProductPage.AssertAddNewProducts(new Product(ProductName, null, null, null, null, null, null, null)));

        }

    }
}

