using CSeleniumFramework.gui.pom;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace CSeleniumFramework.test_cases
{
    internal class TestCase1
    {
        private IWebDriver driver;

        [SetUp]
        public void setUp()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test()
        {
            driver.Navigate().GoToUrl(Config.BaseUrl);
            CookiePom cookie = new CookiePom(driver);
            cookie.AcceptAll();

        }

        [TearDown]
        public void TearDown()
        {
            if(driver != null)
            {
                driver.Quit();
            }
        }
    }

}
