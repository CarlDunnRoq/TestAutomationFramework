namespace TestFramework.Steps
{
    [Binding]
    public class CheckoutInfoSteps : WebApp
    {
        [When(@"the user enters their information")]
        public void WhenTheUserEntersTheirInformation()
        {
            PageManager.CheckoutInfo.FillDetails();
        }

    }
}
