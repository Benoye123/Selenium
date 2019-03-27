using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumProject.Config;
using System.Collections.Generic;

namespace SeleniumProject.PageObjects
{
    class HoverPage:Base
    {
     
        public IWebElement imgUser1 => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/img"));

       
        public IWebElement imgUser2 => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/img"));

        
        public IWebElement imgUser3 => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[3]/img"));

        
        public IWebElement profileUser1 => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/h5"));

        
        public IWebElement profileUser2 => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/h5"));

        
        public IWebElement profileUser3 => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[3]/div/h5"));

    }


}
