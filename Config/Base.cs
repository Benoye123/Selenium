using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace SeleniumProject.Config
{
    public abstract class Base: PageLocator
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;


        //Code refactor PageFactory obsolete
        #region constructor
        public Base() => driver = DriverContent.driverInstance;
        // PageFactory.InitElements(DriverContent.driverInstance, this);



        public Base(IWebDriver driver)
        {
            //PageFactory.InitElements(driver, this);

            this.driver = driver;
            wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
        }
        #endregion

        /// <summary>
        /// Accept list of type IWebElement
        /// and return string type
        /// </summary>
        /// <param name="listCollection">input parameter type Iwebelement</param>
        /// <returns>returns string type of list colleection</returns>
        protected List<string> GetTableList(IList<IWebElement> listCollection)
        {
            List<string> name = new List<string>();
            foreach (IWebElement item in listCollection)
            {
                name.Add(item.Text);
            }

            return name;
        }


        /// <summary>
        /// Accept a list and arrange in descending order
        /// </summary>
        /// <param name="listToOrder">List to order in decending order</param>
        /// <returns>return ordered list</returns>
        protected List<string> DescendingOrder(List<string> listToOrder)
        {
            List<string> descending = new List<string>();

            descending = listToOrder;
           /* descending.Sort();
            descending.Reverse();*/
            descending.Sort(new DescendingCompare());

            return descending;

        }


        /// <summary>
        /// Accept a list and arrange in ascending order
        /// </summary>
        /// <param name="listToOrder">List to order in ascending order</param>
        /// <returns>returns ordered list</returns>
        protected List<string> AscendingOrder(List<string> listToOrder)
        {
            List<string> ascendingName = new List<string>();
            ascendingName = listToOrder;
            ascendingName.Sort();

            return ascendingName;
        }

        public void ClickAndWait(IWebElement element)
        {
            wait.Until(d => element);
            element.Click();

        }


    }
}
