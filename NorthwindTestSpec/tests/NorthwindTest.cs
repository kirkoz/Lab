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
        
    //    private LoginPage loginpage;
    //    private AllProductsPage allproductspage;
    //    private EditProductPage editproductpage;
    //    private readonly Product testproduct = new Product("Salmon", "Seafood", "Mayumi's", "32", "2", "3", "4", "5");
    //    private readonly TestUser testuser = new TestUser("user", "user");

    //    [Test, Order(1)]
    //    public void TestLogin()
    //    {
    //        loginpage = new LoginPage(driver);
    //        Assert.AreNotEqual(loginpage.H2LoginPageText(), LoginToSite.UserLogin(testuser, driver));
    //    }

    //    [Test, Order(2)]
    //    public void TestCreateProduct()
    //    {
    //        editproductpage = new EditProductPage(driver);
    //        Assert.AreNotEqual(editproductpage.H2EditProductPageText(), CreateNewTestProduct.CreateProduct(testproduct, driver));
    //    }

    //    [Test, Order(3)]
    //    public void CheckFieldsProduct()
    //    {
    //        allproductspage = new AllProductsPage(driver);
    //        allproductspage.GoToProduct(testproduct);
    //        Assert.AreEqual(testproduct, editproductpage.ReadProduct());
    //    }
    //    [Test, Order(4)]
    //    public void RemoveProduct()
    //    {
    //        editproductpage.GoToProducts();
    //        allproductspage.DeleteProduct(testproduct);
    //        Assert.IsFalse(allproductspage.FindProduct(testproduct));
    //    }
        
    //    [Test, Order(5)]
    //    public void LogOut()
    //    {
    //        loginpage = new LoginPage(driver);
    //        allproductspage.LogOut();
    //        Assert.AreEqual("Login", loginpage.H2LoginPageText());
    //    }
    }
}