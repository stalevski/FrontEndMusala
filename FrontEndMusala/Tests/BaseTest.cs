using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FrontEndMusala.Tests
{
    public class BaseTest
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}
