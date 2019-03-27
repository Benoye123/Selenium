using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumProject.Config;

namespace SeleniumProject.PageObjects
{
    public class SecurePage:Base
    {
        IWebDriver driver;

        public SecurePage()
        {

        }
        public SecurePage(IWebDriver driver):base(driver)
        {
            this.driver = driver;
        }
        //Code refactor PageFactory obsolete

        //[FindsBy(How = How.Id, Using = ("flash"))]
        IWebElement msgSecureMessage => driver.FindElement(By.Id("flash"));

        public string getSecureMessage()
        {
            return msgSecureMessage.Text.Trim();
        }
    }
}
