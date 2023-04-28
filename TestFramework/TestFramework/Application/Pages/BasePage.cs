using static TestFramework.Utils.Selenium.Settings;

namespace TestFramework.Pages
{
    public class BasePage
    {
        public IWebDriver driver = Driver.CurrentDriver;
        public string GetTitle => Driver.CurrentDriver.Title;
        public string GetUrl => Driver.CurrentDriver.Url;
        public string GetPageSource => Driver.CurrentDriver.PageSource;
        public By SearchField => By.Id("search_form_input_homepage");

        public void NavigateBaseUrl()
        {
            driver.Navigate().GoToUrl(baseUrl);
            driver.Manage().Window.Maximize();
            Console.WriteLine(" :: The base URL is navigated to");
        }

        public void ValidatePageTitle(string expectedTitle)
        {
            bool titleToValidate = GetTitle.Equals(expectedTitle);
            Assert.IsTrue(titleToValidate, " :: The actual page title is incorrect");
            Console.WriteLine(" :: The title of the site is " + GetTitle);
        }
        public void ValidatePageUrl(string expectedUrl)
        {
            var urlToValidate = GetUrl.Contains(expectedUrl);
            Assert.IsTrue(urlToValidate, " :: The actual page Url is different");
            Console.WriteLine(" :: The actual page URL is " + urlToValidate);
        }
        /*public void ValidatePageSource(string expectedSource)
        {
            var pageSourceTextToValidate = GetPageSource.Contains(expectedSource);
            Assert.IsTrue(pageSourceTextToValidate, " :: The expected string is not present in the page source");
            Console.WriteLine(" :: The page source does not contain " + expectedSource);
        }*/
        public void ContentTitle(string title)
        {
            Assert.That(driver.FindElement(By.XPath("//span[@class=\"title\"]")).Text == title);
        }
        public void ClickButton(string button)
        {
            string newButton = button.ToLower().Replace(" ", "-");
            driver.FindElement(By.Id(newButton)).Click();
        }
    }
}