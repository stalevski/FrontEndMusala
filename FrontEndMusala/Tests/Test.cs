using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;
using System.Threading;

namespace FrontEndMusala.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)] 
    // tests run in parallel but flaky
    // didn't find a way to make it run in multiple browsers
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
                //.ClickIAmNotARobotCheckbox() // I got stuck here and couldn't find a solution
                .ClickSendButtonInContactForm() // Same here, I assumed it is something related to aria-hidden="true"
                .VerifyErrorMessage();
        }

        [Test]
        public static void SecondTest()
        {
            companyPage = homePage.GoToCompanyPage();
            companyPage.LeadershipSectionExists();
            facebookPage = companyPage.ClickFacebookButon();
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
            bool joinUsPageIsOpen = joinUsPage.CheckJoinUsPageIsOpen();

            Assert.IsTrue(joinUsPageIsOpen, "Join us page is not open");

            joinUsPage.SelectLocation("Anywhere"); // couldn't figure out a way to select jobs after this
        }
    }
}
