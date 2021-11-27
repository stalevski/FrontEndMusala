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
        private IWebElement ImNotARobotCheckbox => driver.FindElement(By.CssSelector("#rc-anchor-container > div.rc-anchor-content > div:nth-child(1) > div"));
        private IWebElement ContactUsSendButton => driver.FindElement(By.CssSelector("#wpcf7-f875-o1 > form > div.btn-cf-wrapper > p > input"));
        private IWebElement ErrorMessage => driver.FindElement(By.CssSelector("/html/body/div[8]/div/div[9]/div/div/div/form/p[2]/span/span"));

        public void ClickContactUsButton()
        {
            ContactUsButton.Click();
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
        public void EnterMobile(string mobile)
        {
            Mobile.Click();
            Mobile.SendKeys(mobile);
        }
        public void EnterSubject(string subject)
        {
            Subject.Click();
            Subject.SendKeys(subject);
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
        public void ClickSendButtonInContactForm()
        {
            ContactUsSendButton.Click();
        }
        public string GetErrorMessage()
        {
            return ErrorMessage.Text;
        }
    }
}
