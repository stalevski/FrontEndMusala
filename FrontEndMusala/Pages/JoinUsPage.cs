﻿using OpenQA.Selenium;
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
        private IWebElement FindJobByNameExperiencedQAEngineer => driver.FindElement(By.XPath("/html/body/main/div/div/section")).FindElement(By.XPath("//*[contains(., 'Experienced Automation QA Engineer')]"));


        public bool VerifyJoinUsPageIsOpen()
        {
            if (driver.Url.Equals("https://www.musala.com/careers/join-us/"))
            {
                return true;
            }
            else return false;
        }
        public void SelectLocation(string location)
        {
            var selectLocation = new OpenQA.Selenium.Support.UI.SelectElement(LocationDropdownMenu);
            selectLocation.SelectByText(location);
        }
        public void ClickJobByName()
        {
            FindJobByNameExperiencedQAEngineer.Click();
        }
        public void GetAllJobsInListByLocation(string location)
        {
            var selectLocation = new OpenQA.Selenium.Support.UI.SelectElement(LocationDropdownMenu);
            selectLocation.SelectByText(location);

        }
    }
}
