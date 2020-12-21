using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumFramework.bussines_object;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WebDriverAdvanced.Page_Object
{
    class AllProductsPage
    {
        private IWebDriver driver;

        public AllProductsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement H2FieldAllProducts => driver.FindElement(By.XPath("//h2"));

        private IWebElement CreateNewButton => driver.FindElement(By.LinkText("Create new"));

        private IWebElement LogOutButton => driver.FindElement(By.LinkText("Logout"));

        public void GoToNewProduct()
        {
            new Actions(driver).Click(CreateNewButton).Build().Perform();
        }

        public string H2AllProductsText()
        {
            return H2FieldAllProducts.Text;
        }

        public void GoToProduct(Product product)
        {
            driver.FindElement(By.LinkText(product.ProductName)).Click();
        }

        public void DeleteProduct(Product product)
        {
            driver.FindElement(By.XPath(String.Format("//*[a[text()=\"{0}\"]]/following-sibling::*[10]/a[text()=\"Remove\"]", product.ProductName))).Click();
            driver.SwitchTo().Alert().Accept();
        }

        public void LogOut()
        {
            new Actions(driver).Click(LogOutButton).Build().Perform();
        }

        public Boolean FindProduct(Product product)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.LinkText(product.ProductName)));
                return driver.FindElement(By.LinkText(product.ProductName)).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        public Boolean isElementPresent(string product_name)
        {
            return driver.FindElements(By.LinkText(product_name)).Count != 0;
        }
        
    }
}
