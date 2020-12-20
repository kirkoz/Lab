using OpenQA.Selenium;
using SeleniumFramework.bussines_object;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverAdvanced.Page_Object;

namespace WebDriverFramework.service.ui
{
    class CreateNewTestProduct
    {
        public static string CreateProduct(Product testproduct, IWebDriver driver)
        {
            AllProductsPage allproductspage = new AllProductsPage(driver);
            NewProductPage newproductpage = new NewProductPage(driver);
            HomePage homepage = new HomePage(driver);
            homepage.GoToAllProducts();
            allproductspage.GoToNewProduct();
            newproductpage.CreateProduct(testproduct);
            return allproductspage.H2AllProductsText();
        }
    }
}
