using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestFramework.Utils.Hooks;

namespace TestFramework.Steps
{
    [Binding]
    internal class LogInSteps : Hooks
    {
        [Given(@"the user is on the log in page")]
        public void GivenTheUserIsOnTheLogInPage()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            //driver.FindElement(By.Id("password")).Click();
        }

        [When(@"the user logs in correctly")]
        public void WhenTheUserLogsInCorrectly()
        {
            driver.FindElement(By.Id("user-name")).Click();
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();
        }

        [Then(@"the products page will be displayed")]
        public void ThenTheProductsPageWillBeDisplayed()
        {
            Assert.That(driver.FindElement(By.XPath("//*[@id=\"header_container\"]/div[2]/span")).Text == "Products");
        }

    }
}
