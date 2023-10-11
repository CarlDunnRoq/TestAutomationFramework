using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFrameworkSpecflow.Pages
{
    [Binding]
    public class Products
    {
        private IWebDriver driver;
        public Products(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement Title => driver.FindElement(By.XPath("//*[@id=\"header_container\"]/div[2]/span"));       
        
        public void ProductPrice(string price)
        {
            driver.FindElement(By.XPath($"//div[contains(@class, 'inventory_item_price') and contains(., {price})]"));
        }

        public void ProductName(string product)
        {
            driver.FindElement(By.XPath($"//div[contains(@class, 'inventory_item_name') and contains(., '{product}')]"));
        }
        public void ContentTitle(string title)
        {
            Console.WriteLine(driver.FindElement(By.XPath("//span[@class=\"title\"]")).Text);
            Assert.That(driver.FindElement(By.XPath("//span[@class=\"title\"]")).Text == title);
        }
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
