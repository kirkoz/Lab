using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverAdvanced.Page_Object
{
    class EditProductPage
    {
        private IWebDriver driver;

        public EditProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement ProductNameField => driver.FindElement(By.XPath("//input[@id=\"ProductName\"]"));

        private IWebElement CategoryIdField => driver.FindElement(By.XPath("//*[@id=\"CategoryId\"]/option[9]"));

        private IWebElement SupplierIdField => driver.FindElement(By.XPath("//*[@id=\"SupplierId\"]/option[7]"));

        private IWebElement UnitPriceField => driver.FindElement(By.Id("UnitPrice"));

        private IWebElement QuantityPerUnitField => driver.FindElement(By.Id("QuantityPerUnit"));

        private IWebElement UnitsInStockField => driver.FindElement(By.Id("UnitsInStock"));

        private IWebElement UnitsOnOrderField => driver.FindElement(By.Id("UnitsOnOrder"));

        private IWebElement ReorderLevelField => driver.FindElement(By.Id("ReorderLevel"));

        private IWebElement DiscontinuedField => driver.FindElement(By.XPath("//*[@type=\"checkbox\"]"));

        private IWebElement ProductsButton => driver.FindElement(By.XPath("//*[@href=\"/Product\"]"));

        public string ProductName()
        {
            return ProductNameField.GetAttribute("value"); 
        }

        public string CategoryID()
        {
            return CategoryIdField.Text;
        }
        
        public string SupplierID()
        {
            return SupplierIdField.Text;
        }

        public string UnitPrice()
        {
            return UnitPriceField.GetAttribute("value");
        }

        public string QuantityPerUnit()
        {
            return QuantityPerUnitField.GetAttribute("value"); 
        }

        public string UnitsInStock()
        {
            return UnitsInStockField.GetAttribute("value");
        }

        public string UnitsOnOrder()
        {
            return UnitsOnOrderField.GetAttribute("value");
        }

        public string ReorderLevel()
        {
            return ReorderLevelField.GetAttribute("value");
        }

        public string Discontinued()
        {
            return DiscontinuedField.GetAttribute("checked");
        }

        public void GoToProducts()
        {
            new Actions(driver).Click(ProductsButton).Build().Perform();
        }
    }
}
