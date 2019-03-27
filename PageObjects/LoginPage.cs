using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumProject.Config;

namespace SeleniumProject.PageObjects
{
    public class LoginPage:Base
    {
        IWebDriver driver;
       
        public LoginPage(IWebDriver driver):base(driver)
        {
            this.driver = driver;
        }
        public LoginPage()
        {
                
        }
        //Code refactor PageFactory obsolete

        //[FindsBy(How = How.Id, Using = ("username"))]

        IWebElement txtUserName => base.driver.FindElement(By.Id("username"));

        //[FindsBy(How = How.Id, Using = ("password"))]

        IWebElement txtPassword => base.driver.FindElement(By.Id("password"));

        //[FindsBy(How = How.CssSelector, Using = ("button[type = 'submit']"))]

        IWebElement btnLogin => base.driver.FindElement(By.CssSelector("button[type = 'submit']"));

        //[FindsBy(How = How.Id, Using = ("flash"))]

        IWebElement msgErrorMessage => base.driver.FindElement(By.Id("flash"));

       
        public SecurePage userLogin(string userName, string passWord)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(passWord);
            btnLogin.Click();
            return new SecurePage();
        }

        public string getMessage()
        {
            return msgErrorMessage.Text.Trim();
        }

        public string pageSource()
        {
            return DriverContent.driverInstance.PageSource;
        }
    }
}
