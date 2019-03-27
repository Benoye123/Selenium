using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumProject.PageObjects;

namespace SeleniumProject.Config
{
    [TestFixture]
    public class TestInitialization : ExtentReportImplementation
    {
        public LoginPage loginpage;
        public SecurePage securepage;
        public const string correctLoginMessage = "You logged into a secure area!";
        public const string wrongUsername = "Your username is invalid!";
        public const string wrongPassword = "Your password is invalid!";

        public IWebDriver instance;


        [OneTimeSetUp]
        public void startAut()
        {
            DriverContent.driverInstance = BrowserFactory.browserSelection("firefox", "website");
            DriverContent.driverInstance.Manage().Window.Maximize();
            CurrentPage = GetInstance<LoginPage>();

            ExtentTestInitialization();

        }

        [OneTimeTearDown]
        public void TearDown()
        {
            GetResult();
            Flush();
            DriverContent.driverInstance.Quit();
        }

    }
}
