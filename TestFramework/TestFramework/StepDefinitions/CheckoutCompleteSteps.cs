namespace TestFramework.Steps
{
    [Binding]
    public class CheckoutCompleteSteps
    {
        private DriverHelper _driverHelper;
        private WebApp _webApp;

        public CheckoutCompleteSteps(DriverHelper driverHelper, WebApp webApp)
        {
            _driverHelper = driverHelper;
            _webApp = webApp;
        }

        [Then(@"Thank you for your order! will be displayed")]
        public void ThenThankYouForYourOrderWillBeDisplayed()
        {
            ClassicAssert.True(_webApp.CheckoutComplete.ThankYou.Displayed);
        }
        [Then(@"the user clicks Back Home")]
        public void ThenTheUserClicksBackHome()
        {
            _webApp.CheckoutComplete.BackHome.Click();
        }

    }
}
