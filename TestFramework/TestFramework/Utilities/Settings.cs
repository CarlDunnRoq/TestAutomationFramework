using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFrameworkSpecflow.Utilities
{
    public static class Settings
    {
        //Chrome, Firefox or Edge
        public static string Browser = "Chrome";
        //Headless or Headed Browser
        public static bool Headless = false;
        //Local or Docker
        public static string Environment = "Local";
    }
}
