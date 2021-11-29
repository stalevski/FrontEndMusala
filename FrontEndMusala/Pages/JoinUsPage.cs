using OpenQA.Selenium;
using System.Collections.Generic;

namespace FrontEndMusala.Pages
{
    public class JoinUsPage : BasePage
    {
        public JoinUsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement LocationDropdownMenu => driver.FindElement(By.XPath("/html/body/main/div/div/section/div[1]/select"));
        private IList<IWebElement> FindJobByNameExperiencedQAEngineer => driver.FindElements(By.LinkText("Experienced Automation QA Engineer"));


        public bool CheckJoinUsPageIsOpen()
        {
            if (driver.Url.Contains("www.musala.com/careers/join-us/"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SelectLocation(string location)
        {
            OpenQA.Selenium.Support.UI.SelectElement selectLocation = new OpenQA.Selenium.Support.UI.SelectElement(LocationDropdownMenu);
            selectLocation.SelectByText(location);
        }
        public void ClickJobByName()
        {
            var net = FindJobByNameExperiencedQAEngineer;
        }
        public void GetAllJobsInListByLocation(string location)
        {
            OpenQA.Selenium.Support.UI.SelectElement selectLocation = new OpenQA.Selenium.Support.UI.SelectElement(LocationDropdownMenu);
            selectLocation.SelectByText(location);
        }
    }
}
