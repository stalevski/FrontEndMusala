using FrontEndMusala.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FrontEndMusala.Tests
{
    [TestFixture]
    public class Test
    {
        [Test]
        public static void FirstTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.musala.com/";

            HomePage homePage = new HomePage(driver);
            homePage
                .ClickContactUsButton()
                .EnterName("random")
                .EnterEmail("wrong@email")
                .EnterMobile("123123123")
                .EnterSubject("asdasdasdas")
                .EnterYourMessage("adasdasdad")
                .ClickIAmNotARobotCheckbox()
                .ClickSendButtonInContactForm();

            string error = homePage.GetErrorMessage();
        }
    }
}
