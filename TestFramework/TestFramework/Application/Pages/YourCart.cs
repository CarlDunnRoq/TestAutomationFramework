using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Application.Pages
{
    public class YourCart : BasePage
    {
        //public IWebElement CheckoutButton => driver.FindElement(By.Id("checkout"));
        //public IWebElement ContinueButton => driver.FindElement(By.Id("continue-shopping"));

        public void CartConfirmation(string product)
        {
            Assert.IsNotNull(driver.FindElement(By.XPath($"//a//div[contains(.,'{product}')]")));
        }
    }
}
