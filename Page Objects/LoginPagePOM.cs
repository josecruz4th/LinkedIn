using LinkedIn.Base_Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using NUnit;

namespace LinkedIn.Page_Objects
{
    class LoginPagePOM:BaseTest
    {
        /*DRIVER REFERENCE*/
        private static IWebDriver _objDriver;

        /*ELEMENT LOCATORS*/
        private static readonly string STR_USERNAME_TEXTFIELD = "username";
        private static readonly string STR_PASSWORD_TEXTFIELD = "password";
        private static readonly string STR_LOGIN_BUTTON = "//*[text()='Iniciar sesión' or text()='Sign in']";

        public LoginPagePOM(IWebDriver objDriver) 
        {
            _objDriver = objDriver;
        }

        /*PAGE ELEMENT OBJECTS*/

        private static IWebElement objUserName => _objDriver.FindElement(By.Id(STR_USERNAME_TEXTFIELD));
        private static IWebElement objPassword => _objDriver.FindElement(By.Id(STR_PASSWORD_TEXTFIELD));
        private static IWebElement objLoginButton => _objDriver.FindElement(By.XPath(STR_LOGIN_BUTTON));

        /*GET ELEMENT METHODS*/

        public IWebElement GetUserName()
        {
            return objUserName;
        }

        public IWebElement GetPassword()
        {
            return objPassword;
        }

        public IWebElement GetLoginButton()
        {
            return objLoginButton;
        }

        /*ACTION METHODS*/

        public void fnEnterUserName(string pstrUserName)
        {
            objUserName.Clear();
            objUserName.SendKeys(pstrUserName);
        }

        public void fnEnterPassword(string pstrPassword)
        {
            objPassword.Clear();
            objPassword.SendKeys(pstrPassword);
        }

        public void fnClickLogin()
        {
            objLoginButton.Click();
        }



    }
}
