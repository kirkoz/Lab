using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverAdvanced.Page_Object;
using WebDriverFramework.bussines_object;

namespace WebDriverFramework.service.ui
{
    class LoginToSite
    {

        public static string UserLogin(TestUser testuser, IWebDriver driver)
        {
           LoginPage loginpage = new LoginPage(driver);
           HomePage homepage = new HomePage(driver);
           loginpage.Login(testuser);
           return homepage.H2HomePageText();
        }



    }
}
