using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Pages;
using TestFramework.Utilities;

namespace TestAutomationFrameworkSpecflow.Pages
{
    public class CheckoutInfo : BasePage
    {
        public void FillDetails()
        {
            _driverHelper.driver.FindElement(By.Id("first-name")).Click();
            _driverHelper.driver.FindElement(By.Id("first-name")).SendKeys("Test First Name");
            _driverHelper.driver.FindElement(By.Id("last-name")).Click();
            _driverHelper.driver.FindElement(By.Id("last-name")).SendKeys("Test Last Name");
            _driverHelper.driver.FindElement(By.Id("postal-code")).Click();
            _driverHelper.driver.FindElement(By.Id("postal-code")).SendKeys("P0stC0d3");
        }

        public CheckoutInfo(DriverHelper _driverHelper) : base(_driverHelper) { }
    }
}
