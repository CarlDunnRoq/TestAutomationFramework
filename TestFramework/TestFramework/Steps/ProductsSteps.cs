using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestFramework.Utils.Hooks;
using TestFramework.Utils.Selenium;

namespace TestFramework.Steps
{
    [Binding]
    internal class ProductsSteps : LogInSteps
    {
        [Then(@"the products page will be displayed")]
        public void ThenTheProductsPageWillBeDisplayed()
        {
            Assert.That(driver.FindElement(By.XPath("//span[@class=\"title\"]")).Text == "Products");
            //string proof = driver.FindElement(By.XPath("//span[@class=\"title\"]")).Text;
            //Console.WriteLine("This is what is printed: " + proof);
        }
        [When(@"adds product to their basket")]
        public void WhenAddsProductToTheirBasket()
        {
            throw new PendingStepException();
        }

        [Then(@"the basket icon will change")]
        public void ThenTheBasketIconWillChange()
        {
            throw new PendingStepException();
        }

        [Then(@"the remove button will be displayed")]
        public void ThenTheRemoveButtonWillBeDisplayed()
        {
            throw new PendingStepException();
        }

    }
}
