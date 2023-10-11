using OpenQA.Selenium;
using TestAutomationFrameworkSpecflow.Pages;

namespace TestFramework.Steps
{
    [Binding]
    public class ProductsSteps
    {
        private readonly IWebDriver driver;
        Products Products;
        public ProductsSteps(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Then(@"I will be taken to the (.*) page")]
        public void ThenIWillBeTakenToTheDashboard(string page)
        {
            Products = new Products(driver);
            Products.ContentTitle(page);
        }
        [When(@"the user adds (.*) to their basket")]
        public void WhenAddsProductToTheirBasket(string product)
        {
            Products = new Products(driver);
            Products.AddToCart(product);
        }

        [Then(@"the basket icon will change to (.*)")]
        public void ThenTheBasketIconWillChange(int amount)
        {
            Products = new Products(driver);
            Products.ShoppingCartAmount(amount);
        }

        [Then(@"the remove button for (.*) is displayed")]
        public void ThenTheRemoveButtonWillBeDisplayed(string product)
        {
            Products = new Products(driver);
            Products.DeleteFromCart(product);
        }
        [Then(@"the user clicks on the basket icon")]
        public void WhenTheUserClicksOnTheBasketIcon()
        {
            Products = new Products(driver);
            Products.TakeMeToYourCart();
        }

        [Then(@"the (.*) will be (.*)")]
        public void ThenProductAndPriceWillMatch(string product, string price)
        {
            Products = new Products(driver);
            Products.ProductName(product);
            Products.ProductPrice(price);
        }
    }
}
