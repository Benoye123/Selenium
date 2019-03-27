
using NUnit.Framework;
using SeleniumProject.Config;
using SeleniumProject.PageObjects;

namespace SeleniumProject.TestCases
{

    public class LoginTestCases : TestInitialization
    {

        
        /* [OneTimeSetUp]
         public void setUpMethod()
         {
             startAut();

         }*
        /*
         * Basic user test cases
         */

        [Test,Explicit]
        public void correctCredentials()
        {
            loginpage = new LoginPage();
            BeforeMethods("correctCredentials");
            securepage = loginpage.userLogin("tomsmith", "SuperSecretPassword!");
            Assert.False(DriverContent.driverInstance.PageSource.Contains(correctLoginMessage));


            //string ActualMessage = securepage.getSecureMessage();
            //Assert.AreEqual(correctLoginMessage, ActualMessage.Substring(0, 30));
        }
        [Test, Description("Login Function"), Category("Smoke Test")]
        public void wrongUserName()
        {
            BeforeMethods("wrongUserName");
            securepage = loginpage.userLogin("tomsmiths", "SuperSecretPassword!");
            Assert.True(loginpage.pageSource().Contains(wrongUsername));
           


            //string ActualMessage = loginpage.getMessage();
            //Console.WriteLine(ActualMessage);
            //Assert.AreEqual(wrongUsername, ActualMessage.Substring(0,25));
        }
        [Test, Description("Login Function"), Category("Smoke Test")]
         public void wrongPassWord()
        {
            BeforeMethods("wrongPassWord");
            securepage = loginpage.userLogin("tomsmith", "tomsmiths");
            Assert.True(loginpage.pageSource().Contains(wrongPassword));

            //string ActualMessage = loginpage.getMessage();
            //Console.WriteLine(ActualMessage);
            //Assert.AreEqual(wrongPassword, ActualMessage.Substring(0, 25));
        }

       /* [TearDown]
        public void closeDriver()
        {
            GetResult();
            //DriverContent.driverInstance.Quit();
            //instance.Quit();
        }*/
    }
}
