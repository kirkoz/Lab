using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverAdvanced.Page_Object
{
    class NewProductPage
    {
        private IWebDriver driver;

        public NewProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement ProductNameField => driver.FindElement(By.Id("ProductName"));

        private IWebElement CategoryIdField => driver.FindElement(By.Id("CategoryId"));

        private IWebElement SupplierIdField => driver.FindElement(By.Id("SupplierId"));

        private IWebElement UnitPriceField => driver.FindElement(By.Id("UnitPrice"));

        private IWebElement QuantityPerUnitField => driver.FindElement(By.Id("QuantityPerUnit"));

        private IWebElement UnitsInStockField => driver.FindElement(By.Id("UnitsInStock"));

        private IWebElement UnitsOnOrderField => driver.FindElement(By.Id("UnitsOnOrder"));

        private IWebElement ReorderLevelField => driver.FindElement(By.Id("ReorderLevel"));

        private IWebElement DiscontinuedField => driver.FindElement(By.Id("Discontinued"));

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
