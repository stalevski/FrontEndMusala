using NUnit.Framework;
using System.Collections.Generic;
using System.Threading;

namespace FrontEndMusala.Tests
{
    [TestFixture]
    public class Test : BaseTest
    {
        [Test]
        public static void FirstTest()
        {
            homePage
                .ClickContactUsButton()
                .EnterName("EKLhoemdEL")
                .EnterEmail("wrong@email")
                .EnterMobile("078333444")
                .EnterSubject("eoqmtKWjBL")
                .EnterYourMessage("XiXPsEpHdN")
                .ClickIAmNotARobotCheckbox()
                .ClickSendButtonInContactForm()
                .VerifyErrorMessage();
        }

        [Test]
        public static void SecondTest()
        {
            companyPage = homePage.GoToCompanyPage();
            companyPage.LeadershipSectionExists();
            facebookPage = companyPage.ClickFacebookButon();
            //Thread.Sleep(5000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            facebookPage
                .AssertDriverUrlIsCorrect()
                .AssertFacebookProfilePictureIsDisplayed();
        }
        [Test]
        public static void ThirdTest()
        {
            careersPage = homePage.GoToCareersPage();
            joinUsPage = careersPage.ClickCheckOpenPositionsButton();
            bool joinUsPageIsOpen = joinUsPage.VerifyJoinUsPageIsOpen();

            Assert.NotNull(joinUsPageIsOpen, "Join us page is not open");


        }
    }
}
