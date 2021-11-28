using OpenQA.Selenium;

namespace FrontEndMusala.Pages
{
    public class CompanyPage : BasePage
    {
        public CompanyPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement LeadershipSection => driver.FindElement(By.CssSelector("#content > div.entry-content > section.company-members"));
        private IWebElement FacebookButton => driver.FindElement(By.CssSelector("body > footer > div > div > a:nth-child(5)"));


        public bool LeadershipSectionExists()
        {
            return LeadershipSection.Displayed;
        }
        public FacebookPage ClickFacebookButon()
        {
            FacebookButton.Click();
            return new FacebookPage(driver);
        }
    }
}
