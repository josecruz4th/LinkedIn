using LinkedIn.Page_Objects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedIn.Test_Cases;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium;

namespace LinkedIn.Test_Cases
{
    class SearchPageTest:LoginTest
    {
        WebDriverWait wait;

        [Test]

        public void fnSearchText() {

            fnLogin();

            SearchPagePOM objSearchPage = new SearchPagePOM(driver);
            objSearchPage.fnSearchField("test");

            wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("ember8")));
            //wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("ember8")));
            //Thread.Sleep(1000);
            objSearchPage.fnSearchButton();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[span[text()='Gente' or text()='People']]")));
            objSearchPage.fnPeopleButton();
            
        }
    }
}
