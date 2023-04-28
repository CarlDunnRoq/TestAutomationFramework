namespace TestFramework.Application.Pages
{
    public class CheckoutInfo : BasePage
    {
        public void FillDetails()
        {
            driver.FindElement(By.Id("first-name")).Click();
            driver.FindElement(By.Id("first-name")).SendKeys("Test First Name");
            driver.FindElement(By.Id("last-name")).Click();
            driver.FindElement(By.Id("last-name")).SendKeys("Test Last Name");
            driver.FindElement(By.Id("postal-code")).Click();
            driver.FindElement(By.Id("postal-code")).SendKeys("P0stC0d3");
        }
    }
}
