using CSeleniumFramework.GUI.POM;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSeleniumFramework
{
     class Runner
    {

        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            try
            {
                driver.Navigate().GoToUrl(Config.BaseUrl);
                CookiePom cookie = new CookiePom(driver);
                cookie.AcceptAll();
                
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
