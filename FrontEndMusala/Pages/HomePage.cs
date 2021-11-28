using NUnit.Framework;
using OpenQA.Selenium;

namespace FrontEndMusala.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement ContactUsButton => driver.FindElement(By.CssSelector("body > main > section.contacts > div > div > div > a.fancybox > button"));
        private IWebElement Name => driver.FindElement(By.XPath("/html/body/div[8]/div/div[9]/div/div/div/form/p[1]/span/input"));
        private IWebElement Email => driver.FindElement(By.XPath("/html/body/div[8]/div/div[9]/div/div/div/form/p[2]/span/input"));
        private IWebElement Mobile => driver.FindElement(By.XPath("/html/body/div[8]/div/div[9]/div/div/div/form/p[3]/span/input"));
        private IWebElement Subject => driver.FindElement(By.XPath("/html/body/div[8]/div/div[9]/div/div/div/form/p[4]/span/input"));
        private IWebElement YourMessage => driver.FindElement(By.XPath("/html/body/div[8]/div/div[9]/div/div/div/form/p[5]/span/textarea"));
        private IWebElement ImNotARobotCheckbox => driver.FindElement(By.CssSelector("#recaptcha-anchor > div.recaptcha-checkbox-checkmark"));
        private IWebElement ContactUsSendButton => driver.FindElement(By.CssSelector("#wpcf7-f875-o1 > form > div.btn-cf-wrapper > p > input"));
        private IWebElement ErrorMessage => driver.FindElement(By.CssSelector("/html/body/div[8]/div/div[9]/div/div/div/form/p[2]/span/span"));
        private IWebElement CompanyPageButton => driver.FindElement(By.CssSelector("#menu-main-nav-1 > li.menu-item.menu-item-type-post_type.menu-item-object-page.menu-item-887 > a"));
        private IWebElement CareersPageButton => driver.FindElement(By.CssSelector("#menu-main-nav-1 > li.menu-item.menu-item-type-post_type.menu-item-object-page.menu-item-478 > a"));

        public HomePage ClickContactUsButton()
        {
            ContactUsButton.Click();
            return this;
        }
        public HomePage EnterName(string name)
        {
            Name.Click();
            Name.SendKeys(name);
            return this;
        }
        public HomePage EnterEmail(string email)
        {
            Email.Click();
            Email.SendKeys(email);
            return this;

        }
        public HomePage EnterEmail()
        {
            Email.Click();
            Email.SendKeys("incorrect@email");
            return this;

        }
        public HomePage EnterMobile(string mobile)
        {
            Mobile.Click();
            Mobile.SendKeys(mobile);
            return this;
        }
        public HomePage EnterSubject(string subject)
        {
            Subject.Click();
            Subject.SendKeys(subject);
            return this;
        }
        public HomePage EnterYourMessage(string yourMessage)
        {
            YourMessage.Click();
            YourMessage.SendKeys(yourMessage);
            return this;
        }
        public HomePage ClickIAmNotARobotCheckbox()
        {
            ImNotARobotCheckbox.Click();
            return this;
        }
        public HomePage ClickSendButtonInContactForm()
        {
            ContactUsSendButton.Click();
            return this;
        }
        public HomePage VerifyErrorMessage()
        {
            Assert.AreEqual("The e-mail address entered is invalid.", ErrorMessage.Text, "Error message for email is not displayed");
            return this;
        }
        public CompanyPage GoToCompanyPage()
        {
            CompanyPageButton.Click();
            return new CompanyPage(driver);
        }
        public CareersPage GoToCareersPage()
        {
            CareersPageButton.Click();
            return new CareersPage(driver);
        }
    }
}
