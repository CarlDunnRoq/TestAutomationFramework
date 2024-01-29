using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;

namespace TestFramework.Utilities
{
    public class DriverHelper : ITakesScreenshot
    {
        public IWebDriver driver;
        public void InitBrowser(string browserName, bool isRemote)
        {
            if (browserName.ToLower().Equals("chrome"))
            {
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                ChromeOptions options = new();
                options.AddArguments("start-maximised");
                if (isRemote == false)
                {
                    driver = new ChromeDriver(options);
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                }
                else
                {
                    driver = new RemoteWebDriver(new Uri("http://localhost:4444"), options);
                }
            }
            else if (browserName.ToLower().Equals("firefox"))
            {
                new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                FirefoxOptions options = new();
                options.AddArguments("start-maximised");
                if (isRemote == false)
                {
                    driver = new FirefoxDriver(options);
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                }
                else
                {
                    driver = new RemoteWebDriver(new Uri("http://localhost:4444"), options);
                }
            }
            else if (browserName.ToLower().Equals("edge"))
            {
                new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                EdgeOptions options = new();
                options.AddArguments("start-maximised");
                if (isRemote == false)
                {
                    driver = new EdgeDriver(options);
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                }
                else
                {
                    driver = new RemoteWebDriver(new Uri("http://localhost:4444"), options);
                };
            }
        }
        public void KillDriver()
        {
            driver.Quit();
        }
        public Screenshot GetScreenshot()
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            return screenshot;
        }
    }
}

