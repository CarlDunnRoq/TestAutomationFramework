using OpenQA.Selenium;

namespace TestAutomationFrameworkSpecflow.Pages
{
    public class CheckoutComplete
    {
        private IWebDriver driver;
        public CheckoutComplete(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement ThankYou => driver.FindElement(By.XPath("//h2[contains(.,\"Thank you for your order!\")]"));
        public IWebElement BackHome => driver.FindElement(By.Id("back-to-products"));
    }
}
