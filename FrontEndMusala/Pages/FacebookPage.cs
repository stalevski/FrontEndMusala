using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEndMusala.Pages
{
    public class FacebookPage : BasePage
    {
        public FacebookPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement FacebookProfilePicutre => driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div[1]/div[2]/div/div/div/div[1]/div/div/a/div/div"));
        public bool VerifyFacebookLink()
        {
            if (driver.Url.Equals("https://www.facebook.com/MUFFINconference/"))
            {
                return true;
            }
            else return false;
        }
        public bool VerifyFacebookProfilePictureIsDisplayed()
        {
            string pictureHref = FacebookProfilePicutre.GetAttribute("a href");
            if (pictureHref.Equals("https://scontent.fskp4-2.fna.fbcdn.net/v/t1.6435-1/p148x148/158325737_3926723744014946_1132226306152824042_n.jpg?_nc_cat=100&ccb=1-5&_nc_sid=1eb0c7&_nc_ohc=0TdqA97hwbAAX_4jXlf&_nc_ht=scontent.fskp4-2.fna&oh=1643bbf42f134d334272fdfaf4aa12c8&oe=61C60344"))
            {
                return true;
            }
            else return false;
        }

    }
}
