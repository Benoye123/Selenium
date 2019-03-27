using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace SeleniumProject.Config
{
    class BrowserFactory
    {
       static IWebDriver driver;

        public static IWebDriver browserSelection(string browserName, string url)
        {
            if (browserName.Equals("chrome", StringComparison.InvariantCultureIgnoreCase))
                driver = new ChromeDriver();
            else if (browserName.Equals("firefox", StringComparison.InvariantCultureIgnoreCase))
                driver = new FirefoxDriver();

            driver.Navigate().GoToUrl(url);            
            return driver;
        }
    }
}
