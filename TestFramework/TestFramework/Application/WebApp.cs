using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Application.Pages;
using TestFramework.Utils.Selenium;

namespace TestFramework.Application
{
    public class WebApp
    {
        public static PageManager PageManager = new PageManager();
        
        public void Sleep(int seconds) => Thread.Sleep(TimeSpan.FromSeconds(seconds));
    }
}
