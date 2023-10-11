using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFrameworkSpecflow.Pages
{
    public class CheckoutInfo
    {
        private IWebDriver driver;
        public CheckoutInfo(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void FillDetails()
        {
            driver.FindElement(By.Id("first-name")).Click();
            driver.FindElement(By.Id("first-name")).SendKeys("Test First Name");
            driver.FindElement(By.Id("last-name")).Click();
            driver.FindElement(By.Id("last-name")).SendKeys("Test Last Name");
            driver.FindElement(By.Id("postal-code")).Click();
            driver.FindElement(By.Id("postal-code")).SendKeys("P0stC0d3");
        }
    }
}
