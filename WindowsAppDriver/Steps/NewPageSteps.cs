using CalculatorUnitTests.Pages;
using TechTalk.SpecFlow;

namespace CalculatorUnitTests.Steps
{
    [Binding]
    class NewPageSteps
    {
        private readonly NewPage _newPage;

        public NewPageSteps(NewPage page)
        {
            _newPage = page;
        }
    }
}
