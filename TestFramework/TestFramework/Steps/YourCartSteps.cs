namespace TestFramework.Steps
{
    [Binding]
    internal class YourCartSteps : WebApp
    {
        [Then(@"the user will be taken to the (.*) page")]
        public void ThenTheUserWillBeTakenToThePage(string title)
        {
            PageManager.YourCart.ContentTitle(title);
            Sleep(3);
        }
        [When(@"the user sees (.*) in their cart")]
        public void WhenTheUserSeesItemInTheirCart(string product)
        {
            PageManager.YourCart.CartConfirmation(product);
        }
        [When(@"the user clicks (.*)")]
        public void WhenTheUserClicksButton(string button)
        {
            PageManager.YourCart.ClickButton(button);
        }
        [Then(@"the result will be (.*)")]
        public void ThenTheResultWillBe(string price)
        {
            PageManager.YourCart.ConfirmPrice(price);
        }

    }
}
