namespace TestFramework.Application.Pages
{
    public class Products : BasePage
    {
        public void AddToCart(string product)
        {
            string newProduct = product.ToLower().Replace(" ", "-");
            driver.FindElement(By.XPath($"//button[@id=\"add-to-cart-{newProduct}\"]")).Click();
        }
        public void DeleteFromCart(string product)
        {
            string newProduct = product.ToLower().Replace(" ", "-");
            IWebElement ProductItem = driver.FindElement(By.XPath($"//button[@id=\"remove-{newProduct}\"]"));
            Assert.True(ProductItem.Displayed);
        }
        public void ShoppingCartAmount(int amount)
        {
            driver.FindElement(By.XPath($"//span[contains(.,{amount})]"));
        }
        public void TakeMeToYourCart()
        {
            driver.FindElement(By.XPath("//a[@class=\"shopping_cart_link\"]")).Click();
        }
        }
    }

 
