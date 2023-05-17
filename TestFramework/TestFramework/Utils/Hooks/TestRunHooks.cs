using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestFramework.Utils.Selenium;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Gherkin.Model;

namespace TestFramework.Utils.Hooks
{
    [Binding]
    public sealed class TestRunHooks : ExtentReports
    {
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;

        [BeforeTestRun]
        public static void InitReport()
        {
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(@"C:\Users\carl.dunn\OneDrive - ROQ IT\Documents\TestAutomationRepo\TestAutomationFramework\TestAutomationFramework\TestFramework\TestFramework\TestResults\TestResults.html");
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            Console.WriteLine("html report created");
        }
        

        [AfterTestRun]
        public static void AfterTestRun()
        {
            extent.Flush();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            featureName = extent.CreateTest<Feature>(featureContext.FeatureInfo.Title);           
        }

        [BeforeScenario]
        public void Init(ScenarioContext scenarioContext)
        {
            scenario = featureName.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
        }
        [AfterScenario]
        public static void TearDown()
        {
            Driver.CurrentDriver.Quit();
        }
        [AfterStep]
        public void InsertReportingSteps(ScenarioContext scenarioContext
            )
        {
            var stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();

            if (scenarioContext.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if(scenarioContext.TestError != null) 
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.InnerException);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.InnerException);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);
            }
        }
    }
}
