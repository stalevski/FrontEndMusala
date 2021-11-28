using FrontEndMusala.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FrontEndMusala.Tests
{
    [TestFixture]
    public class Test : BaseTest
    {
        IWebDriver driver;
        //public string MusalaUrl = ConfigurationManager.AppSettings["MusalaHomePageUrl"];

        [SetUp]
        public void Init()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.musala.com/";
        }

        [Test]
        public static void FirstTest()
        {
            //HomePage homePage = new HomePage(driver);
            
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
