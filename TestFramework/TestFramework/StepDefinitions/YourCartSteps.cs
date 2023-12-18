using OpenQA.Selenium;
using TestAutomationFrameworkSpecflow.Pages;
using TestFramework.Pages;
using TestFramework.Utilities;

namespace TestFramework.Steps
{
    [Binding]
    public class YourCartSteps
    {
        private DriverHelper _driverHelper;
        private WebApp _webApp;

        public YourCartSteps(DriverHelper driverHelper, WebApp webApp)
        {
            _driverHelper = driverHelper;
            _webApp = webApp;
        }

        [Then(@"the user is taken to the (.*) page")]
        public void ThenTheUserWillBeTakenToThePage(string title)
        {
            _webApp.YourCart.ContentTitle(title);
        }
        [When(@"the user sees (.*) in their cart")]
        public void WhenTheUserSeesItemInTheirCart(string product)
        {
            _webApp.YourCart.CartConfirmation(product);
        }
        [When(@"the user clicks (.*)")]
        public void WhenTheUserClicksButton(string button)
        {
            _webApp.YourCart.ClickButton(button);
        }
        [Then(@"the result is going to be (.*)")]
        public void ThenTheResultWillBe(string price)
        {
            _webApp.YourCart.ConfirmPrice(price);
        }

    }
}
