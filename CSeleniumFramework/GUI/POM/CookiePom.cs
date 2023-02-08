using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace CSeleniumFramework.GUI.POM
{
    public class CookiePom
    {
        private static By CookieBannerBy = By.CssSelector("cmm-cookie-banner");

        private static By AccpetAllBy = By.CssSelector("button[class$=accept-all]");

        private IWebDriver driver;

        public CookiePom(IWebDriver driverP)
        {
            driver = driverP;
        }

        public void AcceptAll()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement CookieBannerElement = wait.Until(ExpectedConditions.ElementExists(CookieBannerBy));
            Thread.Sleep(1000);
            var context = CookieBannerElement.GetShadowRoot();
            DefaultWait<ISearchContext> fluentWait = new(context)
            {
                Timeout = TimeSpan.FromSeconds(5),
                PollingInterval = TimeSpan.FromMilliseconds(250)
            };
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            var element = fluentWait.Until(shadowDom => shadowDom.FindElement(AccpetAllBy));
            element.Click();
        }
    }
}
