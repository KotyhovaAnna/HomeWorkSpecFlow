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
        }

        [When(@"I type the word ""(.*)"" in the Name field and ""(.*)"" in the Password field")]
        public void WhenITypeMyValueNameAndPussword(string name, string password)
        {
            new LoginPage(driver).LoginMetod(new Login(name, password));
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
            new AddProductPage(driver).SendName(new Product(ProductName, null, null, null, null, null, null, null));
        }

        [When(@"I select Product in the in section Category")]
        public void ISelectCategory()
        {
            new AddProductPage(driver).Category();
        }

        [When(@"I select Product in the in section Supplier")]
        public void ISelectSupplier()
        {
            new AddProductPage(driver).Supplier();
        }


        [When(@"I type the value ""(.*)"" in the in section UnitPrice")]
        public void WhenITypeInUnitPrice(string UnitPrice)
        {
            new AddProductPage(driver).UnitPrice(new Product(null, null, null, UnitPrice, null, null, null, null));
        }

        [When(@"I type the value ""(.*)"" in the in section QuantityPerUnit")]
        public void WhenITypeInQuantityPerUnit(string QuantityPerUnit)
        {
            new AddProductPage(driver).QuantityPerUnit(new Product(null, null, null, null, QuantityPerUnit, null, null, null));
        }

        [When(@"I type the value ""(.*)"" in the in section UnitsInStock")]
        public void WhenITypeInUnitsInStock(string UnitsInStock)
        {
            new AddProductPage(driver).UnitsInStock(new Product(null, null, null, null, null, UnitsInStock, null, null));
        }

        [When(@"I type the value ""(.*)"" in the in section UnitsOnOrder")]
        public void WhenITypeInUnitsOnOrder(string UnitsOnOrder)
        {
            new AddProductPage(driver).UnitsOnOrder(new Product(null, null, null, null, null, null, UnitsOnOrder, null));
        }

        [When(@"I type the value ""(.*)"" in the in section ReorderLevel")]
        public void WhenITypeInReorderLevel(string ReorderLevel)
        {
            new AddProductPage(driver).ReorderLevel(new Product(null, null, null, null, null, null, null, ReorderLevel));
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

