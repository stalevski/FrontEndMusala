using OpenQA.Selenium;

namespace FrontEndMusala.Pages
{
    public class CareersPage : BasePage
    {
        public CareersPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement CheckOpenPositionsButton => driver.FindElement(By.CssSelector("body > main > section.contacts > div > div > div > a.fancybox > button"));

        public void ClickCheckOpenPositionsButton()
        {
            CheckOpenPositionsButton.Click();
        }
    }
}
