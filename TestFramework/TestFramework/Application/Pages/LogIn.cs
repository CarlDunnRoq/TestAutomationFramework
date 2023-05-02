namespace TestFramework.Application.Pages
{
    public class LogIn : BasePage
    {
        public void StandardUserLogIn()
        {
            driver.FindElement(By.Id("user-name")).Click();
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();
        }

        public void IncorrectUserLogIn()
        {
            driver.FindElement(By.Id("user-name")).Click();
            driver.FindElement(By.Id("user-name")).SendKeys("incorrect_user");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("wrong_password");
            driver.FindElement(By.Id("login-button")).Click();
        }

        public IWebElement ErrorMessage => driver.FindElement(By.XPath("//button[@class='error-button']"));
    }
}
