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

        [Test]
        public static void SecondTest()
        {
            HomePage homePage = new HomePage(driver);
            CompanyPage companyPage;
            FacebookPage facebookPage;

            homePage.GoToCompanyPage();
            companyPage = new CompanyPage(driver);

            bool exists = companyPage.LeadershipSectionExists();

            companyPage.ClickFacebookButon();
            facebookPage = new FacebookPage(driver);
            bool facebookLink = facebookPage.VerifyFacebookLink();
            bool facebookPicture = facebookPage.VerifyFacebookProfilePictureIsDisplayed();

            Assert.Multiple(() =>
            {
                Assert.IsNotNull(exists, "Leadership section does not exist");
                Assert.NotNull(facebookLink);
                Assert.NotNull(facebookPicture);
            });
            
        }
        [Test]
        public static void ThirdTest()
        {
            HomePage homePage = new HomePage(driver);
            CareersPage careersPage;
            JoinUsPage joinUsPage;
            homePage.GoToCareersPage();
            careersPage = new CareersPage(driver);
            careersPage.ClickCheckOpenPositionsButton();
            joinUsPage = new JoinUsPage(driver);
            joinUsPage.VerifyJoinUsPageIsOpen();
        }
    }
}
