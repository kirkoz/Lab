using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverAdvanced.Page_Object
{
    class ProductPage
    {
        private protected IWebDriver driver;

        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private protected IWebElement ProductNameField => driver.FindElement(By.XPath("//input[@id=\"ProductName\"]"));

        private protected IWebElement UnitPriceField => driver.FindElement(By.Id("UnitPrice"));

        private protected IWebElement QuantityPerUnitField => driver.FindElement(By.Id("QuantityPerUnit"));

        private protected IWebElement UnitsInStockField => driver.FindElement(By.Id("UnitsInStock"));

        private protected IWebElement UnitsOnOrderField => driver.FindElement(By.Id("UnitsOnOrder"));

        private protected IWebElement ReorderLevelField => driver.FindElement(By.Id("ReorderLevel"));

        private protected IWebElement DiscontinuedField => driver.FindElement(By.XPath("//*[@type=\"checkbox\"]"));
    }
}
