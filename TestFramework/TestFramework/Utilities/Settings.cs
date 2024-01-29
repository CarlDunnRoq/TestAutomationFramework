using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Utilities
{
    public static class Settings
    {
        //Chrome, Firefox or Edge
        public static string Browser = "Chrome";
        //Headless or Headed Browser
        public static bool Headless = false;
        //Local or Remote
        public static bool Remote = false;
        //Starting URL
        public static string URL = "https://www.saucedemo.com/";
    }
}
