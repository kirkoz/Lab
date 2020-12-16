using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverAdvanced.Page_Object
{
    class NewProductPage : ProductPage
    {

        public NewProductPage(IWebDriver driver) : base (driver)
        {
            this.driver = driver;
        }

        private IWebElement CategoryIdField => driver.FindElement(By.XPath("//*[@id=\"CategoryId\"]"));

        private IWebElement SupplierIdField => driver.FindElement(By.XPath("//*[@id=\"SupplierId\"]"));

        private IWebElement SendButton => driver.FindElement(By.CssSelector(".btn"));

        public void CreateProduct(string product_name, string categoryid, string supplierid, string unitprice, string quantityperunit, string unitsinstock, string unitsonoder, string reorderlevel)
        {
            new Actions(driver).SendKeys(ProductNameField, product_name).Build().Perform();
            new Actions(driver).SendKeys(CategoryIdField, categoryid).Build().Perform();
            new Actions(driver).SendKeys(SupplierIdField, supplierid).Build().Perform();
            new Actions(driver).SendKeys(UnitPriceField, unitprice).Build().Perform();
            new Actions(driver).SendKeys(QuantityPerUnitField, quantityperunit).Build().Perform();
            new Actions(driver).SendKeys(UnitsInStockField, unitsinstock).Build().Perform();
            new Actions(driver).SendKeys(UnitsOnOrderField, unitsonoder).Build().Perform();
            new Actions(driver).SendKeys(ReorderLevelField, reorderlevel).Build().Perform();
            new Actions(driver).Click(DiscontinuedField).Build().Perform();
            new Actions(driver).Click(SendButton).Build().Perform();
        }      
    }
}
