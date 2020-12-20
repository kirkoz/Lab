using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumFramework.bussines_object;
using WebDriverAdvanced.Page_Object;
using WebDriverFramework.bussines_object;
using WebDriverFramework.service.ui;
using WebDriverFramework.tests;

namespace NorthwindTest
{

    [TestFixture]
    public class NorthwindTest : BaseTest
    {
        
        private LoginPage loginpage;
        private AllProductsPage allproductspage;
        private EditProductPage editproductpage;
        private readonly Product testproduct = new Product("Salmon", "Seafood", "Mayumi's", "100", "2", "3", "4", "5");
        private readonly TestUser testuser = new TestUser("user", "user");

        [Test, Order(1)]
        public void TestLogin()
        {
            Assert.AreNotEqual("Login", LoginToSite.UserLogin(testuser, driver));
        }

        [Test, Order(2)]
        public void TestCreateProduct()
        {
            Assert.AreNotEqual("Product editing", CreateNewTestProduct.CreateProduct(testproduct, driver));
        }

        [Test, Order(3)]
        public void CheckFieldsProduct()
        {
            editproductpage = new EditProductPage(driver);
            allproductspage = new AllProductsPage(driver);
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
            Assert.IsFalse(allproductspage.FindProduct("Salmon"));
        }
        
        [Test, Order(5)]
        public void LogOut()
        {
            loginpage = new LoginPage(driver);
            allproductspage.LogOut();
            Assert.AreEqual("Login", loginpage.H2LoginPageText());
        }
        
    }
}