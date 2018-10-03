using CalculatorUnitTests.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
