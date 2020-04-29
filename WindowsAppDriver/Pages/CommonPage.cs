using CalculatorUnitTests.Driver;
using OpenQA.Selenium;

namespace CalculatorUnitTests.Pages
{
    public class CommonPage
    {
        private readonly WinAppDriver _driver;

        public CommonPage(WinAppDriver driver)
        {
            _driver = driver;
        }

        private IWebElement Header => _driver.Current.FindElementByAccessibilityId("Header"); 

        public void EnterNumber(string number)
        {
            foreach (char c in number)
            {
                _driver.Current.FindElementByAccessibilityId("num" + c + "Button").Click();
            }
        }

        public void EnterSign(string sign)
        {
            _driver.Current.FindElementByAccessibilityId(sign + "Button").Click();
        }

        public void AppOpened()
        {
            GetTitle();
        }

        public string GetTitle()
        {
            return Header.Text.Trim();
        }

        public string GetResult()
        {
            return _driver.Current.FindElementByAccessibilityId("CalculatorResults").Text.Trim().Replace("Display is ", "");
        }
    }
}
