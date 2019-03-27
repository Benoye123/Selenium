using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.Config
{
    public class ExtentReportImplementation : PageLocator
    {
        static ExtentTest TestClassName;
        static ExtentTest TestCaseName;
        static ExtentTest Test;
        public static ExtentHtmlReporter htmlreporter;
        static ExtentReports extent;


        public static void ExtentTestInitialization()
        {
            //call in onetime setup before suite.
            htmlreporter = new ExtentHtmlReporter(@"C:\Users\Benjamin\Documents\report.html");
            htmlreporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent = new ExtentReports();
            extent.AttachReporter(htmlreporter);
        }


        public static void Flush()
        {
            // call in onetime teardown after suite
            extent.Flush();
        }

        public static void BeforeMethods(string TestMethod)
        {
            TestClassName = extent.CreateTest(TestMethod);
        }

        public static void GetResult()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            if (status == TestStatus.Failed)
            {
                Test.Log(Status.Fail, "Fail");
            }


        }

    }
}
