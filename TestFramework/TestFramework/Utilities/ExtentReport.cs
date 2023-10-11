using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Config;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFrameworkSpecflow.Utilities
{
    public class ExtentReport
    {
        public static ExtentReports _extentReports;
        public static ExtentTest _feature;
        public static ExtentTest _scenario;

        public static string dir = AppDomain.CurrentDomain.BaseDirectory;
        public static string testResultPath = dir.Replace("bin\\Debug\\net7.0", "TestResults");

        public static void TestPrint()
        {
            Console.WriteLine(dir);
            Console.WriteLine(testResultPath);
        }

        public static void ExtentReportInit()
        {
                
                var htmlReporter = new ExtentSparkReporter(testResultPath + "report.html");
                htmlReporter.Config.ReportName = "Automation Status Report";
                htmlReporter.Config.DocumentTitle = "Automation Status Report";
                htmlReporter.Config.Theme = Theme.Standard;
                //htmlReporter.Start();

                _extentReports = new ExtentReports();
                _extentReports.AttachReporter(htmlReporter);
                _extentReports.AddSystemInfo("Application", "Swag Labs");
                _extentReports.AddSystemInfo("Browser", "Chrome");
                _extentReports.AddSystemInfo("OS", "Windows");
        }

        public static void ExtentReportTearDown() 
        {
            _extentReports.Flush();
        }

        public string addScreenshot(IWebDriver driver, ScenarioContext scenarioContext)
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot) driver;
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            string screenshotLocation = Path.Combine(testResultPath, scenarioContext.ScenarioInfo.Title+".png");
            screenshot.SaveAsFile(screenshotLocation);
            return screenshotLocation;
        }
    }
}
