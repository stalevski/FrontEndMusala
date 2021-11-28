using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Configuration;


namespace FrontEndMusala.Tests
{
    public class BaseTest
    {
        public static IWebDriver driver;
        //public string MusalaUrl = ConfigurationManager.AppSettings["MusalaHomePageUrl"];

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.musala.com/";
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
