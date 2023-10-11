using OpenQA.Selenium;
using TestAutomationFrameworkSpecflow.Pages;

namespace TestFramework.Steps
{
    [Binding]
    public class CheckoutInfoSteps
    {
        private readonly IWebDriver driver;
        CheckoutInfo CheckoutInfo;
        public CheckoutInfoSteps(IWebDriver driver)
        {
            this.driver = driver;
        }
        [When(@"the user enters their information")]
        public void WhenTheUserEntersTheirInformation()
        {
            CheckoutInfo = new CheckoutInfo(driver);
            CheckoutInfo.FillDetails();
        }

    }
}
