using OpenQA.Selenium;
using TestFramework.Pages;
using TestFramework.Utilities;

namespace TestAutomationFrameworkSpecflow.Pages
{
    public class CheckoutComplete : BasePage
    {
        public IWebElement ThankYou => _driverHelper.driver.FindElement(By.XPath("//h2[contains(.,\"Thank you for your order!\")]"));
        public IWebElement BackHome => _driverHelper.driver.FindElement(By.Id("back-to-products"));

        public CheckoutComplete(DriverHelper _driverHelper) : base(_driverHelper) { }
    }
}
