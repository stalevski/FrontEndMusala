using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEndMusala.Pages
{
    public class JoinUsPage : BasePage
    {
        public JoinUsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement LocationDropdownMenu => driver.FindElement(By.XPath("/html/body/main/div/div/section/div[1]/select"));
        private IWebElement FindJobByName => driver.FindElement(By.XPath("/html/body/main/div/div/section")).FindElement(By.XPath("//*[contains(., 'Experienced Automation QA Engineer')]"));
        private IWebElement Mobile => driver.FindElement(By.XPath("/html/body/div[8]/div/div[9]/div/div/div/form/p[3]/span/input"));
        private IWebElement Subject => driver.FindElement(By.XPath("/html/body/div[8]/div/div[9]/div/div/div/form/p[4]/span/input"));


        public bool VerifyJoinUsPageIsOpen()
        {
            if (driver.Url.Equals("https://www.musala.com/careers/join-us/"))
            {
                return true;
            }
            else return false;
        }
        public void SelectLocation(string Location)
        {
            var selectLocation = new OpenQA.Selenium.Support.UI.SelectElement(LocationDropdownMenu);
            selectLocation.SelectByText(Location);
        }
        public void ClickJobByName()
        {
            FindJobByName.Click();
        }
    }
}
