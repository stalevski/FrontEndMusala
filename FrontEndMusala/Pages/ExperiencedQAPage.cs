using OpenQA.Selenium;

namespace FrontEndMusala.Pages
{
    public class ExperiencedQAPage : BasePage
    {
        public ExperiencedQAPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement GeneralDescription => driver.FindElement(By.XPath("/html/body/main/div/div/section/article/div/div[2]/div[1]/div[1]/div[1]"));
        private IWebElement Requirements => driver.FindElement(By.XPath("/html/body/main/div/div/section/article/div/div[2]/div[1]/div[1]/div[2]"));
        private IWebElement Responsibilities => driver.FindElement(By.XPath("/html/body/main/div/div/section/article/div/div[2]/div[1]/div[2]/div[1]"));
        private IWebElement WhatWeOffer => driver.FindElement(By.XPath("/html/body/main/div/div/section/article/div/div[2]/div[1]/div[2]/div[2]"));
        private IWebElement ApplyButton => driver.FindElement(By.XPath("/html/body/main/div/div/section/article/div/div[2]/div[1]/div[2]/div[2]"));

        private IWebElement Name => driver.FindElement(By.XPath("/html/body/div[8]/div/div[9]/div/div/div/form/p[2]/span/input"));
        private IWebElement Email => driver.FindElement(By.XPath("/html/body/div[8]/div/div[9]/div/div/div/form/p[3]/span/input"));
        private IWebElement Mobile => driver.FindElement(By.XPath("/html/body/div[8]/div/div[9]/div/div/div/form/p[4]/span/input"));
        private IWebElement UploadYourCv => driver.FindElement(By.XPath("/html/body/div[8]/div/div[9]/div/div/div/form/div[2]/span[2]/input"));
        private IWebElement LinkedInProfileLink => driver.FindElement(By.XPath("/html/body/div[8]/div/div[9]/div/div/div/form/p[5]/span/input"));
        private IWebElement YourMessage => driver.FindElement(By.XPath("/html/body/div[8]/div/div[9]/div/div/div/form/p[6]/span/textarea"));
        private IWebElement ImNotARobotCheckbox => driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div[2]/div/label"));
        private IWebElement SendButton => driver.FindElement(By.XPath("/html/body/div[8]/div/div[9]/div/div/div/form/div[3]/p/input"));
        private IWebElement ErrorMessage => driver.FindElement(By.XPath("/html/body/div[8]/div/div[9]/div/div/div/form/div[4]/div/div"));
        private IWebElement ErrorCloseButton => driver.FindElement(By.XPath("/html/body/div[8]/div/div[9]/div/div/div/form/div[4]/div/button"));
        private IWebElement EmailErrorMessage => driver.FindElement(By.XPath("/html/body/div[8]/div/div[9]/div/div/div/form/p[3]/span/span"));


        public bool VerifyMainSectionsExist()
        {
            if (GeneralDescription.Displayed && Requirements.Displayed && Responsibilities.Displayed && WhatWeOffer.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ClickApplyButton()
        {
            ApplyButton.Click();
        }
        public void EnterName(string name)
        {
            Name.Click();
            Name.SendKeys(name);
        }
        public void EnterEmail(string email)
        {
            Email.Click();
            Email.SendKeys(email);

        }
        public void EnterEmail()
        {
            Email.Click();
            Email.SendKeys("incorrect@email");

        }
        public void EnterMobile(string mobile)
        {
            Mobile.Click();
            Mobile.SendKeys(mobile);
        }
        public void EnterCVLocation()
        {
            UploadYourCv.Click();
            UploadYourCv.SendKeys("C: // DoesNotExist ");
        }
        public void EnterLinkedInLink()
        {
            LinkedInProfileLink.Click();
            LinkedInProfileLink.SendKeys("https://www.linkedin.com/in/stefan-talevski/");
        }
        public void EnterYourMessage(string yourMessage)
        {
            YourMessage.Click();
            YourMessage.SendKeys(yourMessage);
        }
        public void ClickIAmNotARobotCheckbox()
        {
            ImNotARobotCheckbox.Click();
        }
        public void ClickSendButtonInApplyForm()
        {
            SendButton.Click();
        }
        public bool CheckErrorIsDisplayed()
        {
            if (ErrorMessage.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ClickErrorCloseButtonInApplyForm()
        {
            ErrorCloseButton.Click();
        }
        public bool CheckEmailErrorIsDisplayed()
        {
            if (EmailErrorMessage.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
