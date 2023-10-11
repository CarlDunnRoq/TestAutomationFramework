using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using TechTalk.SpecFlow;
using TestAutomationFrameworkSpecflow.Utilities;

namespace TestAutomationFrameworkSpecflow.Hooks
{
    [Binding]
    public sealed class Hooks : ExtentReport
    {
       private readonly IObjectContainer _container;

       public Hooks(IObjectContainer container) 
        {
            _container = container;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("Running before test run...");
            ExtentReportInit();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("Running after test run...");
            ExtentReportTearDown();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            Console.WriteLine("Running before feature...");
            _feature = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("Running after feature...");
        }

        [BeforeScenario("@tag2")]
        public void BeforeScenarioWithTag()
        {
            Console.WriteLine("Running tagged tests...");
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario(ScenarioContext scenarioContext)
        {
            Console.WriteLine("Running before scenario...");
            TestPrint();

            if (Settings.Environment == "Local")
            {
                if (Settings.Browser == "Chrome")
                {
                    if (Settings.Headless == true)
                    {
                        var options = new ChromeOptions();
                        options.AddArgument("--headless=new");
                        IWebDriver driver = new ChromeDriver(options);

                        _container.RegisterInstanceAs<IWebDriver>(driver);
                        _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
                    }
                    else
                    {
                        IWebDriver driver = new ChromeDriver();
                        driver.Manage().Window.Maximize();

                        _container.RegisterInstanceAs<IWebDriver>(driver);
                        _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
                    }
                }
                else if (Settings.Browser == "Firefox")
                {
                    if (Settings.Headless == true)
                    {
                        var options = new FirefoxOptions();
                        options.AddArgument("--headless=new");
                        IWebDriver driver = new FirefoxDriver(options);

                        _container.RegisterInstanceAs<IWebDriver>(driver);
                        _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
                    }
                    else
                    {
                        IWebDriver driver = new FirefoxDriver();
                        driver.Manage().Window.Maximize();
                        _container.RegisterInstanceAs<IWebDriver>(driver);
                        _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
                    }
                }
                else if (Settings.Browser == "Edge")
                {
                    if (Settings.Headless == true)
                    {
                        var options = new EdgeOptions();
                        options.AddArgument("--headless=new");
                        IWebDriver driver = new EdgeDriver(options);

                        _container.RegisterInstanceAs<IWebDriver>(driver);
                        _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
                    }
                    else
                    {
                        IWebDriver driver = new EdgeDriver();
                        driver.Manage().Window.Maximize();
                        _container.RegisterInstanceAs<IWebDriver>(driver);
                        _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
                    }

                }
            }
            else if(Settings.Environment == "Docker")
            {
                if (Settings.Browser == "Chrome")
                {
                        var options = new ChromeOptions();
                        IWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4445/ui"), options);

                        _container.RegisterInstanceAs<IWebDriver>(driver);
                        _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
                }
                else if (Settings.Browser == "Firefox")
                {
                        var options = new FirefoxOptions();
                        IWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4446/ui"), options);

                        _container.RegisterInstanceAs<IWebDriver>(driver);
                        _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
                }
                else if (Settings.Browser == "Edge")
                {
                        var options = new EdgeOptions();
                        IWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/ui"), options);

                        _container.RegisterInstanceAs<IWebDriver>(driver);
                        _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
                }           
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
           var driver = _container.Resolve<IWebDriver>();

           if(driver != null)
           {
                driver.Quit();
           }
        }

        [AfterStep]
        public void AfterStep(ScenarioContext scenarioContext)
        {
            Console.WriteLine("Running after step...");
            string stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            string stepName = scenarioContext.StepContext.StepInfo.Text;
            var driver = _container.Resolve<IWebDriver>();

            //When the scenario passes
            if (scenarioContext.TestError == null)
            {
                if (stepType == "Given")
                {
                    _scenario.CreateNode<Given>(stepName);
                }
                else if (stepType == "When")
                {
                    _scenario.CreateNode<When>(stepName);
                }
                else if (stepType == "Then")
                {
                    _scenario.CreateNode<Then>(stepName);
                }
                else if (stepType == "And")
                {
                    _scenario.CreateNode<And>(stepName);
                }
            }  
            //When the scenario fails
            if (scenarioContext.TestError != null)
            {
                

                if (stepType == "Given")
                {
                    _scenario.CreateNode<Given>(stepName).Fail(scenarioContext.TestError.Message, 
                        MediaEntityBuilder.CreateScreenCaptureFromPath(addScreenshot(driver, scenarioContext)).Build());
                }
                else if (stepType == "When")
                {
                    _scenario.CreateNode<When>(stepName).Fail(scenarioContext.TestError.Message,
                        MediaEntityBuilder.CreateScreenCaptureFromPath(addScreenshot(driver, scenarioContext)).Build());
                }
                else if (stepType == "Then")
                {
                    _scenario.CreateNode<Then>(stepName).Fail(scenarioContext.TestError.Message,
                        MediaEntityBuilder.CreateScreenCaptureFromPath(addScreenshot(driver, scenarioContext)).Build());
                }
                else if (stepType == "And")
                {
                    _scenario.CreateNode<And>(stepName).Fail(scenarioContext.TestError.Message, 
                        MediaEntityBuilder.CreateScreenCaptureFromPath(addScreenshot(driver, scenarioContext)).Build());
                }
            }
        }
    }
}