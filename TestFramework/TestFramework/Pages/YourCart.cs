using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFrameworkSpecflow.Pages
{
    public class YourCart
    {
        private IWebDriver driver;
        public YourCart(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void CartConfirmation(string product)
        {
            Assert.IsNotNull(driver.FindElement(By.XPath($"//a//div[contains(.,'{product}')]")));
        }
        public void ConfirmPrice(string price)
        {
            Assert.IsNotNull(driver.FindElement(By.XPath($"//div[(text()={price})]")));
        }
        public void ContentTitle(string title)
        {
            Assert.That(driver.FindElement(By.XPath("//span[@class=\"title\"]")).Text == title);
        }
        public void ClickButton(string button)
        {
            string newButton = button.ToLower().Replace(" ", "-");
            driver.FindElement(By.Id(newButton)).Click();
        }
    }
}
