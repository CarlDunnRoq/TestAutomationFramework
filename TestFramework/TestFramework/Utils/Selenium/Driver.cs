using System;
using System.Diagnostics;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace TestFramework.Utils.Selenium
{
    public static class Driver
    {
        [ThreadStatic]
        public static IWebDriver CurrentDriver;

        public static void InitChrome()
        {
            CurrentDriver = new ChromeDriver(Path.GetFullPath(@"C:\Users\carl.dunn\OneDrive - ROQ IT\Documents\TestAutomationRepo\TestAutomationFramework\TestAutomationFramework\TestFramework\TestFramework\" + "_drivers"));
        }


        public static void InitFirefox()
        {
            CurrentDriver = new FirefoxDriver(Path.GetFullPath(@"C:\Users\carl.dunn\OneDrive - ROQ IT\Documents\TestAutomationRepo\TestAutomationFramework\TestAutomationFramework\TestFramework\TestFramework\" + "_drivers"));
        }
    }
}