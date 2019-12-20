using LinkedIn.Base_Files;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn.Page_Objects
{
    class SearchPagePOM:BaseTest
    {
        /*DRIVER REFERENCE*/
        private static IWebDriver _objDriver;

        /*ELEMENT LOCATORS*/
        private static readonly string STR_SEARCH_TEXTFIELD = "search-global-typeahead__input";
        private static readonly string STR_SEARCH_BUTTON = "search-global-typeahead__controls";
        private static readonly string STR_PEOPLE_BUTTON = "//button[span[text()='Gente' or text()='People']]";
        //private static readonly string STR_LOGIN_BUTTON = "//*[text()='Iniciar sesión' or text()='Sign in']";

        public SearchPagePOM(IWebDriver objDriver)
        {
            _objDriver = objDriver;
        }

        /*PAGE ELEMENT OBJECTS*/

        private static IWebElement objSearchField => _objDriver.FindElement(By.ClassName(STR_SEARCH_TEXTFIELD));
        private static IWebElement objSearchButton => _objDriver.FindElement(By.ClassName(STR_SEARCH_BUTTON));
        private static IWebElement objPeopleButton => _objDriver.FindElement(By.XPath(STR_PEOPLE_BUTTON));
        //private static IWebElement objLoginButton => _objDriver.FindElement(By.XPath(STR_LOGIN_BUTTON));

        /*GET ELEMENT METHODS*/

        public IWebElement GetSearchField()
        {
            return objSearchField;
        }

        public IWebElement GetobjSearchButton()
        {
            return objSearchButton;
        }

        public IWebElement GetobjPeopleButton()
        {
            return objPeopleButton;
        }

        /*ACTION METHODS*/

        public void fnSearchField(string pstrSearchText)
        {
            objSearchField.Clear();
            objSearchField.SendKeys(pstrSearchText);
            //objSearchField.SendKeys(Keys.Enter);
        }

        public void fnSearchButton()
        {
            objSearchButton.Click();
            
        }

        public void fnPeopleButton() {
            objPeopleButton.Click();
        }

        //public void fnClickLogin()
        //{
        //    objLoginButton.Click();
        //}
    }
}
