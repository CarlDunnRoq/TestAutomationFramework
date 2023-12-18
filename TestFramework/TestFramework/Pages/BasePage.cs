using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Utilities;

namespace TestFramework.Pages
{
    public abstract class BasePage
    {
        protected DriverHelper _driverHelper;

        protected BasePage(DriverHelper driverHelper) 
        {
            _driverHelper = driverHelper;
        }
    }
}
