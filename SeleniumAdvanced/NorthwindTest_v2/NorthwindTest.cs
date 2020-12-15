using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverAdvanced.Page_Object;

namespace NorthwindTest
{

    [TestFixture]
    public class NorthwindTests
    {
        private IWebDriver driver;
        private LoginPage loginpage;
        private HomePage homepage;
        private AllProductsPage allproductspage;
        private NewProductPage newproductpage;
        private EditProductPage editproductpage;

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
            loginpage = new LoginPage(driver);
            homepage = new HomePage(driver);
            loginpage.Login("user", "user");
            Assert.AreNotEqual("Login", homepage.H2HomePageText());
        }

        [Test, Order(2)]
        public void TestCreateProduct()
        {
            allproductspage = new AllProductsPage(driver);
            newproductpage = new NewProductPage(driver);
            homepage.GoToAllProducts();
            allproductspage.GoToNewProduct();
            newproductpage.CreateProduct("Salmon", "Seafood", "Mayumi's", "100", "2", "3", "4", "5");
            Assert.AreNotEqual("Product editing", allproductspage.H2AllProductsText());
        }

        [Test, Order(3)]
        public void CheckFieldsProduct()
        {
            editproductpage = new EditProductPage(driver);
            allproductspage.GoToProduct("Salmon");
            Assert.AreEqual("Salmon", editproductpage.ProductName());
            Assert.AreEqual("Seafood", editproductpage.CategoryID());
            Assert.AreEqual("Mayumi's", editproductpage.SupplierID());
            Assert.AreEqual("100,0000", editproductpage.UnitPrice());
            Assert.AreEqual("2", editproductpage.QuantityPerUnit());
            Assert.AreEqual("3", editproductpage.UnitsInStock());
            Assert.AreEqual("4", editproductpage.UnitsOnOrder());
            Assert.AreEqual("5", editproductpage.ReorderLevel());
            Assert.AreEqual("true", editproductpage.Discontinued());
        }
        [Test, Order(4)]
        public void RemoveProduct()
        {
            editproductpage.GoToProducts();
            allproductspage.DeleteProduct();
            Assert.Throws<OpenQA.Selenium.InvalidSelectorException>(() => driver.FindElement(By.XPath("=//td/a[text()=\"Salmon\"]")));
        }
        
        [Test, Order(5)]
        public void LogOut()
        {
            allproductspage.LogOut();
            Assert.AreEqual("Login", loginpage.H2LoginPageText());
        }
        
        [OneTimeTearDown]
        public void CloseDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}