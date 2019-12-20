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
    class LoginTest:BaseTest
    {
        [Test]

        public void fnLogin() {
            LoginPagePOM loginpage = new LoginPagePOM(driver);
            //LogoutPage logoutpage = new LogoutPage(driver);

            loginpage.fnEnterUserName(Environment.GetEnvironmentVariable("usernameLinkedin", EnvironmentVariableTarget.User));// ConfigurationManager.AppSettings.Get("user")) ;
            loginpage.fnEnterPassword(Environment.GetEnvironmentVariable("passwordLinkedin", EnvironmentVariableTarget.User));// ConfigurationManager.AppSettings.Get("password"));
            loginpage.fnClickLogin();

            Assert.AreEqual("LinkedIn", driver.Title);

            Thread.Sleep(1000);

            //logoutpage.fnObjMyAccountButton();
            //logoutpage.fnObjLogOutButton();

            //Thread.Sleep(1000);

            //Assert.AreEqual("LinkedIn: Log In or Sign Up", driver.Title);

        }

    }
}
