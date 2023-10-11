using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFrameworkSpecflow.Pages
{
    public class Login
    {
        private IWebDriver driver;
        public Login(IWebDriver driver) 
        {
            this.driver = driver;
        }

        public IWebElement Username => driver.FindElement(By.Id("user-name"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement logInButton => driver.FindElement(By.Id("login-button"));
        public IWebElement ErrorMessage => driver.FindElement(By.XPath("//button[@class='error-button']"));
        

        public string GetURL => driver.Url;

        //By usernameinput = By.Id("user-name");
        public void LogIn(string username, string password)
        {
            Username.SendKeys(username);
            Password.SendKeys(password);
            logInButton.Click();
        }
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
    }
}
