using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Steps
{
    [Binding]
    public class CheckoutCompleteSteps : WebApp
    {
        [Then(@"Thank you for your order! will be displayed")]
        public void ThenThankYouForYourOrderWillBeDisplayed()
        {
            Assert.True(PageManager.CheckoutComplete.ThankYou.Displayed);
        }
        [Then(@"the user clicks Back Home")]
        public void ThenTheUserClicksBackHome()
        {
            PageManager.CheckoutComplete.BackHome.Click();
        }

    }
}
