using FrontEndMusala.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace FrontEndMusala.Tests
{
    public class BaseTest
    {
        public static IWebDriver driver;
        public static CareersPage careersPage;
        public static CompanyPage companyPage;
        public static ExperiencedQAPage experianceQaPage;
        public static FacebookPage facebookPage;
        public static HomePage homePage;
        public static JoinUsPage joinUsPage;
        //public string MusalaUrl = ConfigurationManager.AppSettings["MusalaHomePageUrl"];

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver
            {
                Url = "https://www.musala.com/"
            };
            homePage = new HomePage(driver);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }
    }
}
