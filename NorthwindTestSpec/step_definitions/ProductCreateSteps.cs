using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumFramework.bussines_object;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using WebDriverAdvanced.Page_Object;
using WebDriverFramework.bussines_object;


namespace NorthWindTestSpec.step_definitions
{
    [Binding]
    class ProductCreateSteps
    {
        private IWebDriver driver;
        private readonly TestUser testuser = new TestUser("user", "user");
        private LoginPage loginpage;
        private AllProductsPage allproductspage;
        private HomePage homepage;


        [Given(@"I login to ""(.+)""")]
        public void GivenILoginToSite(string url)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            loginpage = new LoginPage(driver);
            loginpage.Login(testuser);
        }

        [When(@"I click on All Products button")]
        public void WhenIClickOnAllProductButton()
        {
            homepage = new HomePage(driver);
            homepage.GoToAllProducts();
        }

        [When(@"I click on Create New button")]
        public void WhenIClickOnCreateNewButton()
        {
            allproductspage = new AllProductsPage(driver);
            allproductspage.GoToNewProduct();
        }

        [When(@"I enter values ""(.+)"", ""(.+)"", ""(.+)"", ""(.+)"", ""(.+)"", ""(.+)"", ""(.+)"", ""(.+)""")]
        public void WhenIEnterValues(string productName, string categoryId, string supplierId, string unitPrice, string quantityPerUnit, string unitsInStock, string unitsOnOrder, string reorderLevel)
        {
            Product testproduct = new Product(productName, categoryId, supplierId, unitPrice, quantityPerUnit, unitsInStock, unitsOnOrder, reorderLevel);
            NewProductPage newproductpage = new NewProductPage(driver);
            newproductpage.CreateProduct(testproduct);
        }
        [When(@"I click on Send button")]
        public void WhenIClickSendButton()
        {
            NewProductPage newproductpage = new NewProductPage(driver);
            newproductpage.ClickSendButton();
        }

        [Then(@"A product named ""(.+)"" should appear on the product page")]
        public void ThenAProductNamedShouldAppearOnTheProductPage(string product_name)
        {
            Assert.IsTrue(allproductspage.isElementPresent(product_name));
        }

        [AfterScenario]
        public void CloseDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
