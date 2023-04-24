using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
        //Products Page
        [When(@"the user adds (.*) to cart")]
        public void WhenTheUserAddsToCart(string product)
        {
            string newProduct = product.ToLower().Replace(" ", "-");
            //Console.WriteLine(newProduct);
            IWebElement productItem = driver.FindElement(By.XPath($"//button[@id=\"add-to-cart-{newProduct}\"]"));
            productItem.Click();
        }
        
        [Then(@"the products page will be displayed")]
        public void ThenTheProductsPageWillBeDisplayed()
        {
            Assert.That(driver.FindElement(By.XPath("//span[@class=\"title\"]")).Text == "Products");
            //string proof = driver.FindElement(By.XPath("//span[@class=\"title\"]")).Text;
            //Console.WriteLine("This is what is printed: " + proof);
        }

        [Then(@"the remove button will be displayed for the (.*)")]
        public void ThenTheRemoveButtonWillBeDisplayedforthe(string product)
        {
            string newProduct = product.ToLower().Replace(" ", "-");
            //Console.WriteLine(newProduct);
            IWebElement ProductItem = driver.FindElement(By.XPath($"//button[@id=\"remove-{newProduct}\"]"));
            Assert.True(ProductItem.Displayed);
        }
    }
}
