using TestFramework.Application;

namespace TestFramework.Steps
{
    [Binding]
    internal class ProductsSteps : WebApp
    {
        [Then(@"the products page will be displayed")]
        public void ThenTheProductsPageWillBeDisplayed()
        {
            PageManager.Products.ContentTitle("Products");
        }
        [When(@"the user adds (.*) to their basket")]
        public void WhenAddsProductToTheirBasket(string product)
        {
            PageManager.Products.AddToCart(product);
        }

        [Then(@"the basket icon will change to (.*)")]
        public void ThenTheBasketIconWillChange(int amount)
        {
            PageManager.Products.ShoppingCartAmount(amount);
        }

        [Then(@"the remove button for (.*) will be displayed")]
        public void ThenTheRemoveButtonWillBeDisplayed(string product)
        {
            PageManager.Products.DeleteFromCart(product);
        }
        [Then(@"the user clicks on the basket icon")]
        public void WhenTheUserClicksOnTheBasketIcon()
        {
            PageManager.Products.TakeMeToYourCart();
        }


    }
}
