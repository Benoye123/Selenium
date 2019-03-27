using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumProject.Config;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumProject.PageObjects
{
    public class TablePage : Base
    {
        //Code refactor PageFactory obsolete

        // [FindsBy(How = How.CssSelector, Using = ("td[class = 'last-name']"))]

        public IList<IWebElement> tblLastName => driver.FindElements(By.CssSelector("td[class = 'last-name']"));


        public List<string> GetdescendingOrder()
        {
            return DescendingOrder(GetTableLastNames());
        }

        public List<string> GetTableLastNames()
        {
            return GetTableList(tblLastName);
        }

        public List<string> GetAscendingOrder()
        {
            
            return AscendingOrder(GetTableLastNames());

        }

  
    }
}
