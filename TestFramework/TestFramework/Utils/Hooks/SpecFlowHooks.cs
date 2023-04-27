using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestFramework.Utils.Selenium;

namespace TestFramework.Utils.Hooks
{
    [Binding]
    internal static class SpecFlowHooks
    {
        [Before]
        [Scope(Tag = "Chrome")]
        internal static void StartChromeDriver()
        {
            Driver.InitChrome();
        }

        [Before]
        [Scope(Tag = "Firefox")]
        internal static void StartFirefoxDriver()
        {
            Driver.InitFirefox();
        }

        [After]
        internal static void StopWebDriver()
        {
            Driver.CurrentDriver.Quit();
        }
    }
}
