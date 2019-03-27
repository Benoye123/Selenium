using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.Config
{
   public static class DriverContent
    {
        private static IWebDriver driver;

        public static IWebDriver driverInstance
        {
            get
            {
                return driver;
            }
            set
            {
                driver = value;
            }
        }
    }
}
