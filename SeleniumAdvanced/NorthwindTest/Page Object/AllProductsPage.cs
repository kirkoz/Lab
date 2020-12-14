using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

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

        private IWebElement SalmonObjectButton => driver.FindElement(By.LinkText("Salmon"));

        private IWebElement SalmonObjectDeleteButton => driver.FindElement(By.XPath("//*[a[text()=\"Salmon\"]]/following-sibling::*[10]/a[text()=\"Remove\"]"));

        private IWebElement LogOutButton => driver.FindElement(By.LinkText("Logout"));

        public void GoToNewProduct()
        {
            new Actions(driver).Click(CreateNewButton).Build().Perform();
        }

        public string H2AllProductsText()
        {
            return H2FieldAllProducts.Text;
        }

        public void GoToSalmon()
        {
            new Actions(driver).Click(SalmonObjectButton).Build().Perform();
        }

        public void DeleteProduct()
        {
            new Actions(driver).Click(SalmonObjectDeleteButton).Build().Perform();
            driver.SwitchTo().Alert().Accept();
        }

        public void LogOut()
        { 
            new Actions(driver).Click(LogOutButton).Build().Perform();
        }
    }
}
