using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationFrameworkSpecflow.Pages;

namespace TestAutomationFrameworkSpecflow.StepDefinitions
{
    [Binding]
    public class LogInSteps
    {
        private readonly IWebDriver driver;
        Login Login;

        public LogInSteps(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"I am on the Swag Labs login page")]
        public void GivenIAmOnTheSwagLabsLoginPage()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");            
        }

        [When(@"I enter my username and password and click Login")]
        public void WhenIEnterMyUsernameAndPassword()
        {
            Login = new Login(driver);
            Login.LogIn("standard_user", "secret_sauce");
        }
        [When(@"the user logs in incorrectly")]
        public void WhenTheUserLogsInIncorrectly()
        {
            Login = new Login(driver);
            Login.IncorrectUserLogIn();
        }
        [Then(@"an error message will be displayed")]
        public void ThenAnErrorMessageWillBeDisplayed()
        {
            Login = new Login(driver);
            Assert.True(Login.ErrorMessage.Displayed);
        }
    }
}
