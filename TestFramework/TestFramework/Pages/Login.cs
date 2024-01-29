namespace TestFramework.Pages
{
    public class Login : BasePage
    {

        public IWebElement Username => _driverHelper.driver.FindElement(By.Id("user-name"));
        public IWebElement Password => _driverHelper.driver.FindElement(By.Id("password"));
        public IWebElement logInButton => _driverHelper.driver.FindElement(By.Id("login-button"));
        public IWebElement ErrorMessage => _driverHelper.driver.FindElement(By.XPath("//button[@class='error-button']"));
        

        public string GetURL => _driverHelper.driver.Url;

        //By usernameinput = By.Id("user-name");
        public void LogIn(string username, string password)
        {
            Username.SendKeys(username);
            Password.SendKeys(password);
            logInButton.Click();
        }
        public void StandardUserLogIn()
        {
            _driverHelper.driver.FindElement(By.Id("user-name")).Click();
            _driverHelper.driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            _driverHelper.driver.FindElement(By.Id("password")).Click();
            _driverHelper.driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            _driverHelper.driver.FindElement(By.Id("login-button")).Click();
        }
        public void IncorrectUserLogIn()
        {
            _driverHelper.driver.FindElement(By.Id("user-name")).Click();
            _driverHelper.driver.FindElement(By.Id("user-name")).SendKeys("incorrect_user");
            _driverHelper.driver.FindElement(By.Id("password")).Click();
            _driverHelper.driver.FindElement(By.Id("password")).SendKeys("wrong_password");
            _driverHelper.driver.FindElement(By.Id("login-button")).Click();
        }
        public Login(DriverHelper _driverHelper) : base(_driverHelper) { }
    }   
}
