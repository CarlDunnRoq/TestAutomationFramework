using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Pages;
using TestFramework.Utilities;

namespace TestAutomationFrameworkSpecflow.Pages
{
    [Binding]
    public class Products : BasePage
    {
        public IWebElement Title => _driverHelper.driver.FindElement(By.XPath("//*[@id=\"header_container\"]/div[2]/span"));       
        
        public void ProductPrice(string price)
        {
            _driverHelper.driver.FindElement(By.XPath($"//div[contains(@class, 'inventory_item_price') and contains(., {price})]"));
        }

        public void ProductName(string product)
        {
            _driverHelper.driver.FindElement(By.XPath($"//div[contains(@class, 'inventory_item_name') and contains(., '{product}')]"));
        }
        public void ContentTitle(string title)
        {
            Console.WriteLine(_driverHelper.driver.FindElement(By.XPath("//span[@class=\"title\"]")).Text);
            Assert.That(_driverHelper.driver.FindElement(By.XPath("//span[@class=\"title\"]")).Text == title);
        }
        public void AddToCart(string product)
        {
            string newProduct = product.ToLower().Replace(" ", "-");
            _driverHelper.driver.FindElement(By.XPath($"//button[@id=\"add-to-cart-{newProduct}\"]")).Click();
        }
        public void DeleteFromCart(string product)
        {
            string newProduct = product.ToLower().Replace(" ", "-");
            IWebElement ProductItem = _driverHelper.driver.FindElement(By.XPath($"//button[@id=\"remove-{newProduct}\"]"));
            ClassicAssert.True(ProductItem.Displayed);
        }
        public void ShoppingCartAmount(int amount)
        {
            _driverHelper.driver.FindElement(By.XPath($"//span[contains(.,{amount})]"));
        }
        public void TakeMeToYourCart()
        {
            _driverHelper.driver.FindElement(By.XPath("//a[@class=\"shopping_cart_link\"]")).Click();
        }

        public Products(DriverHelper _driverHelper) : base(_driverHelper) { }
    }
}
