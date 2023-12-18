using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationFrameworkSpecflow.Pages;
using TestFramework.Pages;
using TestFramework.Utilities;

namespace TestAutomationFrameworkSpecflow.StepDefinitions
{
    [Binding]
    public class LogInSteps
    {
        private DriverHelper _driverHelper;
        private WebApp _webApp;

        public LogInSteps(DriverHelper driverHelper, WebApp webApp)
        {
            _driverHelper = driverHelper;
            _webApp = webApp;
        }

        [Given(@"I am on the Swag Labs login page")]
        public void GivenIAmOnTheSwagLabsLoginPage()
        {
            _driverHelper.driver.Navigate().GoToUrl("https://www.saucedemo.com/");            
        }

        [When(@"I enter my username and password and click Login")]
        public void WhenIEnterMyUsernameAndPassword()
        {
            _webApp.Login.LogIn("standard_user", "secret_sauce");
        }
        [When(@"the user logs in incorrectly")]
        public void WhenTheUserLogsInIncorrectly()
        {
            _webApp.Login.IncorrectUserLogIn();
        }
        [Then(@"an error message will be displayed")]
        public void ThenAnErrorMessageWillBeDisplayed()
        {
            ClassicAssert.True(_webApp.Login.ErrorMessage.Displayed);
        }
    }
}
