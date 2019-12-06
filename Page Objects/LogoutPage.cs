using LinkedIn.Base_Files;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn.Page_Objects
{
    class LogoutPage:BaseTest
    {
        /*DRIVER REFERENCE*/
        private static IWebDriver _objDriver;

        /*ELEMENT LOCATORS*/

        private static readonly string STR_MY_ACCOUNT_BUTTON = "//*[@id='nav-settings__dropdown-trigger']";
        private static readonly string STR_LOGOUT_BUTTON = "//*[text()='Cerrar sesión']";

        public LogoutPage(IWebDriver objDriver)
        {
            _objDriver = objDriver;
        }

        /*PAGE ELEMENT OBJECTS*/

        private static IWebElement objMyAccountButton => _objDriver.FindElement(By.XPath(STR_MY_ACCOUNT_BUTTON));
        private static IWebElement objLogOutButton => _objDriver.FindElement(By.XPath(STR_LOGOUT_BUTTON));

        /*GET ELEMENT METHODS*/

        public IWebElement mtMyAccountButton()
        {
            return objMyAccountButton;
        }

        public IWebElement mtLogOutButton()
        {
            return objLogOutButton;
        }

        /*ACTION METHODS*/

        public void fnObjMyAccountButton()
        {
            objMyAccountButton.Click();
        }

        public void fnObjLogOutButton()
        {
            objLogOutButton.Click();
        }
    }
}
