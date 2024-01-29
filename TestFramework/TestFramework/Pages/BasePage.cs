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
