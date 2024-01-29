namespace TestFramework.Pages
{
    public class WebApp : BasePage
    {
        public Login Login => new(_driverHelper);
        public Products Products => new(_driverHelper);
        public YourCart YourCart => new(_driverHelper);
        public CheckoutInfo CheckoutInfo => new(_driverHelper);
        public CheckoutComplete CheckoutComplete => new(_driverHelper);
        public WebApp(DriverHelper _driverHelper) : base(_driverHelper) { }
    }
}
