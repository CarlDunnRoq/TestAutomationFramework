using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestFramework.Utils.Selenium;

namespace TestFramework.Utils.Hooks
{
    internal static class TestRunHooks
    {
        [AfterTestRun]
        internal static void AfterTestRun()
        {
            Driver.CurrentDriver.Quit();
        }
    }
}
