using NuGet.Frameworks;
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
        public void Sleep(int seconds) => Thread.Sleep(TimeSpan.FromSeconds(seconds));

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
            Sleep(3);
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
            Sleep(3);
            Assert.True(ProductItem.Displayed);
        }
        [When(@"the user clicks the cart icon")]
        public void WhenTheUserClicksTheCartIcon()
        {
            driver.FindElement(By.XPath("//*[@id='shopping_cart_container']/a")).Click();
            Sleep(3);
            Assert.True(driver.FindElement(By.Id("checkout")).Displayed);
        }

        [When(@"the user continues to checkout")]
        public void WhenTheUserContinuesToCheckout()
        {
            driver.FindElement(By.Id("checkout")).Click();
            Sleep(3);
            Assert.True(driver.FindElement(By.XPath("//*[@id='header_container']/div[2]/span")).Displayed);
        }

        [When(@"enters their information")]
        public void WhenEntersTheirInformation()
        {
            driver.FindElement(By.Id("first-name")).Click();
            driver.FindElement(By.Id("first-name")).SendKeys("Test First Name");
            Sleep(3);
            driver.FindElement(By.Id("last-name")).Click();
            driver.FindElement(By.Id("last-name")).SendKeys("Test Last Name");
            Sleep(3);
            driver.FindElement(By.Id("postal-code")).Click();
            driver.FindElement(By.Id("postal-code")).SendKeys("P0stC0d3");
            Sleep(3);
            driver.FindElement(By.Id("continue")).Click();
            Assert.True(driver.FindElement(By.XPath("//*[@id=\'header_container\']/div[2]/span")).Displayed);
            Sleep(3);
        }

        [When(@"finishes their order on the overview")]
        public void WhenFinishesTheirOrderOnTheOverview()
        {
            driver.FindElement(By.Id("finish")).Click();
        }

        [Then(@"the checkout will be complete")]
        public void ThenTheCheckoutWillBeComplete()
        {
            Assert.True(driver.FindElement(By.XPath("//*[@id=\'checkout_complete_container\']/h2")).Displayed);
        }

        [Then(@"the user can click Back Home")]
        public void ThenTheUsrCanClickBackHome()
        {
            driver.FindElement(By.Id("back-to-products")).Click();
            Assert.That(driver.Url == "https://www.saucedemo.com/inventory.html");
        }

    }
}
