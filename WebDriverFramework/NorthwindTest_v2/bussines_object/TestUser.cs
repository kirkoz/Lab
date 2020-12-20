using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverFramework.bussines_object
{
    class TestUser
    {
        public TestUser(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public string Login { get; set; }
        public string Password { get; set; }
    }
}
