using OpenQA.Selenium;
using TestAutomationFrameworkSpecflow.Pages;

namespace TestFramework.Steps
{
    [Binding]
    public class YourCartSteps
    {
        private readonly IWebDriver driver;
        YourCart YourCart;
        public YourCartSteps(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"the user is taken to the (.*) page")]
        public void ThenTheUserWillBeTakenToThePage(string title)
        {
            YourCart = new YourCart(driver);
            YourCart.ContentTitle(title);
        }
        [When(@"the user sees (.*) in their cart")]
        public void WhenTheUserSeesItemInTheirCart(string product)
        {
            YourCart = new YourCart(driver);
            YourCart.CartConfirmation(product);
        }
        [When(@"the user clicks (.*)")]
        public void WhenTheUserClicksButton(string button)
        {
            YourCart = new YourCart(driver);
            YourCart.ClickButton(button);
        }
        [Then(@"the result is going to be (.*)")]
        public void ThenTheResultWillBe(string price)
        {
            YourCart = new YourCart(driver);
            YourCart.ConfirmPrice(price);
        }

    }
}
