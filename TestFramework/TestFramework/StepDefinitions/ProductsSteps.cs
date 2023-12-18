using OpenQA.Selenium;
using TestAutomationFrameworkSpecflow.Pages;
using TestFramework.Pages;
using TestFramework.Utilities;

namespace TestFramework.Steps
{
    [Binding]
    public class ProductsSteps
    {
        private DriverHelper _driverHelper;
        private WebApp _webApp;

        public ProductsSteps(DriverHelper driverHelper, WebApp webApp)
        {
            _driverHelper = driverHelper;
            _webApp = webApp;
        }

        [Then(@"I will be taken to the (.*) page")]
        public void ThenIWillBeTakenToTheDashboard(string page)
        {
            _webApp.Products.ContentTitle(page);
        }
        [When(@"the user adds (.*) to their basket")]
        public void WhenAddsProductToTheirBasket(string product)
        {
            _webApp.Products.AddToCart(product);
        }

        [Then(@"the basket icon will change to (.*)")]
        public void ThenTheBasketIconWillChange(int amount)
        {
            _webApp.Products.ShoppingCartAmount(amount);
        }

        [Then(@"the remove button for (.*) is displayed")]
        public void ThenTheRemoveButtonWillBeDisplayed(string product)
        {
            _webApp.Products.DeleteFromCart(product);
        }
        [Then(@"the user clicks on the basket icon")]
        public void WhenTheUserClicksOnTheBasketIcon()
        {
            _webApp.Products.TakeMeToYourCart();
        }

        [Then(@"the (.*) will be (.*)")]
        public void ThenProductAndPriceWillMatch(string product, string price)
        {
            _webApp.Products.ProductName(product);
            _webApp.Products.ProductPrice(price);
        }
    }
}
