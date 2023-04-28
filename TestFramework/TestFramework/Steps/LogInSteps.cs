using TestFramework.Application;

namespace TestFramework.Steps
{
    [Binding]
    public class LogInSteps : WebApp
    {
        [Given(@"a user is on the (?:base|search) page")]
        public void GivenADuckDuckGoUserIsOnTheBasePage()
        {
            PageManager.BasePage.NavigateBaseUrl();
        }
        [Then(@"they see the page title contains ""(.*)""")]
        public void ThenTheySeeThePageTitleContains(string expectedTitle)
        {
            PageManager.LogIn.ValidatePageTitle(expectedTitle);
        }
        [Then(@"the page URL contains ""(.*)""")]
        public void ThenThePageURLContains(string expectedUrl)
        {
            PageManager.LogIn.ValidatePageUrl(expectedUrl);
        }
        [When(@"the user logs in correctly")]
        public void WhenTheUserLogsInCorrectly()
        {
            PageManager.LogIn.StandardUserLogIn();
        }


    }
}
