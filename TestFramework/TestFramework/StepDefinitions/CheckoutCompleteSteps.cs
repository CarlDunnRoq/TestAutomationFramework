using NUnit.Framework;
using OpenQA.Selenium;
using TestAutomationFrameworkSpecflow.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Steps
{
    [Binding]
    public class CheckoutCompleteSteps
    {
        private readonly IWebDriver driver;
        CheckoutComplete CheckoutComplete;
        public CheckoutCompleteSteps(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"Thank you for your order! will be displayed")]
        public void ThenThankYouForYourOrderWillBeDisplayed()
        {
            CheckoutComplete = new CheckoutComplete(driver);
            Assert.True(CheckoutComplete.ThankYou.Displayed);
        }
        [Then(@"the user clicks Back Home")]
        public void ThenTheUserClicksBackHome()
        {
            CheckoutComplete = new CheckoutComplete(driver);
            CheckoutComplete.BackHome.Click();
        }

    }
}
