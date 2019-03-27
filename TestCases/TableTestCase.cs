using System;
using System.Collections.Generic;
using NUnit.Framework;
using SeleniumProject.Config;
using SeleniumProject.PageObjects;

namespace SeleniumProject.TestCases
{
    [TestFixture]
    public class TableTestCase
    {
        TablePage tablepage;
        List<string> ActualName = new List<string>();

        [SetUp]
        public void Setup()
        {
            DriverContent.driverInstance = BrowserFactory.browserSelection("firefox", "website");
            tablepage = new TablePage();
            DriverContent.driverInstance.Manage().Window.Maximize();
        }

        [Test]
        public void AscendingTest()
        {
            ActualName = tablepage.GetTableLastNames();
            ActualName.ForEach(Console.WriteLine);
            Console.WriteLine("--------------Ascending--------------------");
            tablepage.GetAscendingOrder().ForEach(Console.WriteLine);
           Assert.AreEqual(tablepage.GetAscendingOrder(), ActualName);

        }

        [Test]
        public void DescendingTest()
        {
            ActualName = tablepage.GetTableLastNames();
            ActualName.ForEach(Console.WriteLine);
            Console.WriteLine("--------------Descending--------------------");
            tablepage.GetdescendingOrder().ForEach(Console.WriteLine);
           Assert.AreEqual(tablepage.GetdescendingOrder(), ActualName);

        }

        [TearDown]
        public void quitDriver()
        {
            DriverContent.driverInstance.Quit();
        }
    }
}
