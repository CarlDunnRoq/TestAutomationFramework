using NUnit.Framework;
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
    public class YourCart : BasePage
    {
        public void CartConfirmation(string product)
        {
            ClassicAssert.IsNotNull(_driverHelper.driver.FindElement(By.XPath($"//a//div[contains(.,'{product}')]")));
        }
        public void ConfirmPrice(string price)
        {
            ClassicAssert.IsNotNull(_driverHelper.driver.FindElement(By.XPath($"//div[(text()={price})]")));
        }
        public void ContentTitle(string title)
        {
            Assert.That(_driverHelper.driver.FindElement(By.XPath("//span[@class=\"title\"]")).Text == title);
        }
        public void ClickButton(string button)
        {
            string newButton = button.ToLower().Replace(" ", "-");
            _driverHelper.driver.FindElement(By.Id(newButton)).Click();
        }
        public YourCart(DriverHelper _driverHelper) : base(_driverHelper) { }
    }
}
