using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.Config
{
    public static class WebElementExtentionMethod
    {

        public static void MoveTo(this IWebElement element)
        {
            Actions action = new Actions(DriverContent.driverInstance);
            action.MoveToElement(element).Build().Perform();
        }

        public static void Select(IWebElement element, int d)
        {
            SelectElement sel = new SelectElement(element);
            sel.SelectByIndex(d);
        }

    }


    public static class IntExtentionMethod
    {
        static int a = 5;

        public static bool isBetween(this int d, int Min, int Max)
        {
            return d >= Min && d <= Max;
        }

        

        
    }

}
