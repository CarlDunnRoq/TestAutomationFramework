using NUnit.Framework;
using OpenQA.Selenium;
using TestAutomationFrameworkSpecflow.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Utilities;
using NUnit.Framework.Legacy;
using TestFramework.Pages;

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
