using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Pages;

namespace TestFramework.Application.Pages
{
    public class Products : BasePage
    {
        public void AddToCart(string product)
        {
            string newProduct = product.ToLower().Replace(" ", "-");
            driver.FindElement(By.XPath($"//button[@id=\"add-to-cart-{newProduct}\"]")).Click();
        }
    }
}
