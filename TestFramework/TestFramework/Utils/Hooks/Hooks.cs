using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace TestFramework.Utils.Hooks
{

    [Binding]
    public class Hooks
    {
        public IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
