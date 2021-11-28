using NUnit.Framework;
using OpenQA.Selenium;

namespace FrontEndMusala.Pages
{
    public class FacebookPage : BasePage
    {
        public FacebookPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement FacebookProfilePicture => driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div/div[1]/div/div/div[1]/div/div/div/a/div/img"));
        public FacebookPage AssertDriverUrlIsCorrect()
        {
            Assert.True(driver.Url.Contains("facebook.com/MusalaSoft"), "Driver did not open facebook page");
            return this;
        }
        public FacebookPage AssertFacebookProfilePictureIsDisplayed()
        {
            Assert.True(FacebookProfilePicture.Displayed, "Facebook profile picture is not displayed");
            return this;
        }

    }
}
