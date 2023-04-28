using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Application.Pages
{
    public class CheckoutComplete : BasePage
    {
        public IWebElement ThankYou => driver.FindElement(By.XPath("//h2[contains(.,\"Thank you for your order!\")]"));

        public IWebElement BackHome => driver.FindElement(By.Id("back-to-products"));
    }
}
