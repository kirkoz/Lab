using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace NorthwindTest
{

    [TestFixture]
    public class NorthwindTests
    {
        private IWebDriver driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000");
            driver.Manage().Window.Maximize();
        }

        [Test, Order(1)]
        public void TestLogin()
        {
            driver.FindElement(By.Id("Name")).SendKeys("user");
            driver.FindElement(By.Id("Password")).SendKeys("user");
            driver.FindElement(By.CssSelector(".btn")).Click();
            string H2homepage = driver.FindElement(By.XPath("//h2")).Text;
            Assert.AreNotEqual("Login", H2homepage);
        }

        [Test, Order(2)]
        public void TestCreateProduct()
        {
            driver.FindElement(By.LinkText("All Products")).Click();
            driver.FindElement(By.LinkText("Create new")).Click();
            driver.FindElement(By.Id("ProductName")).SendKeys("Salmon");
            driver.FindElement(By.Id("CategoryId")).SendKeys("Seafood");
            driver.FindElement(By.Id("SupplierId")).SendKeys("Mayumi's");
            driver.FindElement(By.Id("UnitPrice")).SendKeys("100");
            driver.FindElement(By.Id("QuantityPerUnit")).SendKeys("2");
            driver.FindElement(By.Id("UnitsInStock")).SendKeys("3");
            driver.FindElement(By.Id("UnitsOnOrder")).SendKeys("4");
            driver.FindElement(By.Id("ReorderLevel")).SendKeys("5");
            driver.FindElement(By.Id("Discontinued")).Click();
            driver.FindElement(By.CssSelector(".btn")).Click();
            string H2allproducts = driver.FindElement(By.XPath("//h2")).Text;
            Assert.AreNotEqual("Product editing", H2allproducts);
        }

        [Test, Order(3)]
        public void CheckFieldsProduct()
        {
            driver.FindElement(By.LinkText("Salmon")).Click();
            var ProductName = driver.FindElement(By.XPath("//input[@id=\"ProductName\"]")).GetAttribute("value");
            string Category = driver.FindElement(By.XPath("//*[@id=\"CategoryId\"]/option[9]")).Text;
            string Supplier = driver.FindElement(By.XPath("//*[@id=\"SupplierId\"]/option[7]")).Text;
            string UnitPrice = driver.FindElement(By.Id("UnitPrice")).GetAttribute("value");
            string QuantityPerUnit = driver.FindElement(By.Id("QuantityPerUnit")).GetAttribute("value");
            string UnitsInStock = driver.FindElement(By.Id("UnitsInStock")).GetAttribute("value");
            string UnitsOnOrder = driver.FindElement(By.Id("UnitsOnOrder")).GetAttribute("value");
            string ReorderLevel = driver.FindElement(By.Id("ReorderLevel")).GetAttribute("value");
            string Discontinued = driver.FindElement(By.XPath("//*[@type=\"checkbox\"]")).GetAttribute("checked");
            Assert.AreEqual("Salmon", ProductName);
            Assert.AreEqual("Seafood", Category);
            Assert.AreEqual("Mayumi's", Supplier);
            Assert.AreEqual("100,0000", UnitPrice);
            Assert.AreEqual("2", QuantityPerUnit);
            Assert.AreEqual("3", UnitsInStock);
            Assert.AreEqual("4", UnitsOnOrder);
            Assert.AreEqual("5", ReorderLevel);
            Assert.AreEqual("true", Discontinued);
        }
        [Test, Order(4)]
        public void RemoveProduct()
        {
            driver.FindElement(By.XPath("//*[@href=\"/Product\"]")).Click();
            driver.FindElement(By.XPath("//*[a[text()=\"Salmon\"]]/following-sibling::*[10]/a[text()=\"Remove\"]")).Click();
            driver.SwitchTo().Alert().Accept();
            Assert.Throws<OpenQA.Selenium.InvalidSelectorException>(() => driver.FindElement(By.XPath("=//td/a[text()=\"Salmon\"]")));
        }
        
        [Test, Order(5)]
        public void LogOut()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
            string H2login = driver.FindElement(By.XPath("//h2")).Text;
            Assert.AreEqual("Login", H2login);
        }
        
        [OneTimeTearDown]
        public void CloseDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}