
using NUnit.Framework;
using SeleniumProject.Config;
using SeleniumProject.PageObjects;
using System.Collections.Generic;
using System.Threading;

namespace SeleniumProject.TestCases
{

    public class HoverTestCases : TestInitialization
    {
        HoverPage hoverpage;
        // IList<bool> result = new List<bool>();

        [SetUp]
        public void Setup()
        {
            DriverContent.driverInstance = BrowserFactory.browserSelection("firefox", "website");
            hoverpage = GetInstance<HoverPage>();
            DriverContent.driverInstance.Manage().Window.Maximize();

        }

        [Test]
        public void HoverTest()
        {


            Assert.Multiple(() =>
            {
                CurrentPage = GetInstance<HoverPage>();
                CurrentPage.Is<HoverPage>().imgUser1.MoveTo();
                bool imageDisplay = CurrentPage.Is<HoverPage>().profileUser1.Displayed;                                        
                Assert.True(imageDisplay);

                CurrentPage.Is<HoverPage>().imgUser2.MoveTo();
                bool imageDisplay2 = CurrentPage.Is<HoverPage>().profileUser2.Displayed;
                Assert.True(imageDisplay2);

                CurrentPage.Is<HoverPage>().imgUser3.MoveTo();
                bool imageDisplay3 = CurrentPage.Is<HoverPage>().profileUser3.Displayed;
                Assert.True(imageDisplay3);

            });


        }

        [TearDown]
        public void quitDriver()
        {
            DriverContent.driverInstance.Quit();
        }


    }
}
