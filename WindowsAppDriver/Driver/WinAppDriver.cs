using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Configuration;

namespace CalculatorUnitTests.Driver
{
    public class WinAppDriver : IDisposable
    {
        private WindowsDriver<WindowsElement> _driver;

        public WindowsDriver<WindowsElement> Current
        {
            get
            {
                if (_driver == null)
                {
                    var options = new AppiumOptions
                    {
                        PlatformName = "Windows"
                    };
                    options.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");

                    _driver = new WindowsDriver<WindowsElement>(new Uri(ConfigurationManager.AppSettings["winAppUri"]), options);
                }

                return _driver;
            }
        }

        public void Dispose()
        {
            _driver?.Dispose();
        }
    }
}
