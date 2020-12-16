using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverAdvanced.Page_Object
{
    class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement NameField => driver.FindElement(By.Id("Name"));

        private IWebElement PasswordField => driver.FindElement(By.Id("Password"));

        private IWebElement SendButton => driver.FindElement(By.CssSelector(".btn"));

        private IWebElement H2FieldLoginPage => driver.FindElement(By.XPath("//h2"));

        public void Login(string name, string password)
        {
            new Actions(driver).SendKeys(NameField, name).Build().Perform();
            new Actions(driver).SendKeys(PasswordField, password).Build().Perform();
            new Actions(driver).MoveToElement(SendButton).Click(SendButton).Build().Perform();
        }

        public string H2LoginPageText()
        {
            return H2FieldLoginPage.Text;
        }
    }
}
