using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Configuration;
using LinkedIn.Base_Files;
using LinkedIn.Page_Objects;
using System.Threading;

namespace LinkedIn.Test_Cases
{
    class ValidateLogin:BaseTest
    {
        [Test]

        public void fnLogin() {
            LoginPage loginpage = new LoginPage(driver);
            LogoutPage logoutpage = new LogoutPage(driver);

            loginpage.fnEnterUserName(ConfigurationManager.AppSettings.Get("user"));
            loginpage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            loginpage.fnClickLogin();

            Assert.AreEqual("LinkedIn", driver.Title);

            Thread.Sleep(10000);

            logoutpage.fnObjMyAccountButton();
            logoutpage.fnObjLogOutButton();

        }

    }
}
