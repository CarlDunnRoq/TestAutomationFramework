using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using OpenQA.Selenium.Edge;

namespace TestFramework.Utils.Selenium
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void Test()
        {
            _webDriver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Assert.True(_webDriver.Title.Contains("Swag Labs"));
        }

        [Test]
        public void NegTest()
        {
            _webDriver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Assert.False(_webDriver.Title.Contains("Google"));

        }
    }
}
