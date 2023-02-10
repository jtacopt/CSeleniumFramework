using CSeleniumFramework.GUI.POM;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace CSeleniumFramework.test_cases
{
    internal class TestCase1
    {
        [Test]
        public void Test()
        {
            Console.WriteLine("Cenas");
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
