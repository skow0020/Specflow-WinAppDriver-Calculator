using CalculatorUnitTests.Driver;

namespace CalculatorUnitTests.Pages
{
    public class NewPage : CommonPage
    {
        private readonly WinAppDriver _driver;

        public NewPage(WinAppDriver driver) : base(driver)
        {
            _driver = driver;
        }
    }
}
