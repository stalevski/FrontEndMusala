using FrontEndMusala.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FrontEndMusala.Tests
{
    [TestFixture]
    public class Test : BaseTest
    {
        [Test]
        public static void FirstTest()
        {
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

            string errorMessage = homePage.GetErrorMessage();

            Assert.AreEqual("The e-mail address entered is invalid.", errorMessage, "Error message for email is not displayed");
        }
    }
}
