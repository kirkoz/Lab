using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumFramework.bussines_object;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverAdvanced.Page_Object
{
    class EditProductPage : ProductPage
    {

        public EditProductPage(IWebDriver driver) : base(driver)
        {
        }
       
        private IWebElement CategoryIdField => driver.FindElement(By.XPath("//*[@id=\"CategoryId\"]/option[9]"));

        private IWebElement SupplierIdField => driver.FindElement(By.XPath("//*[@id=\"SupplierId\"]/option[7]"));
        
        private IWebElement ProductsButton => driver.FindElement(By.XPath("//*[@href=\"/Product\"]"));

        private IWebElement H2EditProductPage => driver.FindElement(By.XPath("//h2"));

        public Product ReadProduct()
        {
            string editproductname = ProductNameField.GetAttribute("value");
            string editcategoryid = CategoryIdField.Text;
            string editsupplierid = SupplierIdField.Text;
            string editunitprice = Math.Truncate(Convert.ToDouble(UnitPriceField.GetAttribute("value"))).ToString();
            string editquantityqerunit = QuantityPerUnitField.GetAttribute("value");
            string editunitsinstock = UnitsInStockField.GetAttribute("value");
            string editunitsonorder = UnitsOnOrderField.GetAttribute("value");
            string editreorderlevel = ReorderLevelField.GetAttribute("value");
            return new Product(editproductname, editcategoryid, editsupplierid, editunitprice, editquantityqerunit, editunitsinstock, editunitsonorder, editreorderlevel);
        }

        public string H2EditProductPageText()
        {
            return H2EditProductPage.Text;
        }

        public void GoToProducts()
        {
            new Actions(driver).Click(ProductsButton).Build().Perform();
        }
    }
}
