using NUnit.Framework;
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
        private IWebElement FacebookButton => driver.FindElement(By.XPath("/html/body/footer/div/div/a[4]/span"));


        public CompanyPage LeadershipSectionExists()
        {
            Assert.NotNull(LeadershipSection.Displayed);
            return this;
        }
        public FacebookPage ClickFacebookButon()
        {
            FacebookButton.Click();
            return new FacebookPage(driver);
        }
    }
}
