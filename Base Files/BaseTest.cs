using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using NUnit.Framework;

namespace LinkedIn.Base_Files
{
    class BaseTest
    {
        public static IWebDriver driver;
        public static string strBrowserUrl = ConfigurationManager.AppSettings.Get("url");

        [SetUp]

        public static void SetUp()
        {
            driver = new ChromeDriver();
            driver.Url = strBrowserUrl;
        }
        
        [TearDown]
        public static void AfterTest()
        {
            //driver.Close();
            //driver.Quit();
        }
    }
}
