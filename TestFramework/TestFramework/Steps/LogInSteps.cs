using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestFramework.Application.Pages;
using TestFramework.Pages;

namespace TestFramework.Steps
{
    public class LogInSteps : LogIn
    {
        [Given(@"a user is on the (?:base|search) page")]
        public void GivenADuckDuckGoUserIsOnTheBasePage()
        {
            NavigateBaseUrl();
        }
        [Then(@"they see the page title contains ""(.*)""")]
        public void ThenTheySeeThePageTitleContains(string expectedTitle)
        {
            ValidatePageTitle(expectedTitle);
        }
        [Then(@"the page URL contains ""(.*)""")]
        public void ThenThePageURLContains(string expectedUrl)
        {
            ValidatePageUrl(expectedUrl);
        }
        [When(@"the user logs in correctly")]
        public void WhenTheUserLogsInCorrectly()
        {
            StandardUserLogIn();
        }


    }
}
