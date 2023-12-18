using OpenQA.Selenium;
using TestAutomationFrameworkSpecflow.Pages;
using TestFramework.Pages;
using TestFramework.Utilities;

namespace TestFramework.Steps
{
    [Binding]
    public class CheckoutInfoSteps
    {
        private DriverHelper _driverHelper;
        private WebApp _webApp;

        public CheckoutInfoSteps(DriverHelper driverHelper, WebApp webApp)
        {
            _driverHelper = driverHelper;
            _webApp = webApp;
        }

        [When(@"the user enters their information")]
        public void WhenTheUserEntersTheirInformation()
        {
            _webApp.CheckoutInfo.FillDetails();
        }

    }
}
