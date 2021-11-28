using OpenQA.Selenium;

namespace FrontEndMusala.Pages
{
    public class CareersPage : BasePage
    {
        public CareersPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement CheckOpenPositionsButton => driver.FindElement(By.CssSelector("#content > div.entry-header > div > div.image-overlay > div > section > div > a > button"));

        public JoinUsPage ClickCheckOpenPositionsButton()
        {
            CheckOpenPositionsButton.Click();
            return new JoinUsPage(driver);
        }
    }
}
