using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CSeleniumFramework
{
    public class Runner
    {

        public static void main()
        {
            IWebDriver driver = new ChromeDriver();
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
