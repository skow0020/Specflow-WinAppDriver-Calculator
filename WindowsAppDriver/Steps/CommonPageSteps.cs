using CalculatorUnitTests.Pages;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace CalculatorUnitTests.Steps
{
    [Binding]
    public class CommonPageSteps
    {
        private readonly CommonPage _commonPage;

        public CommonPageSteps(CommonPage page)
        {
            _commonPage = page;
        }

        [Given(@"the calculator app is open")]
        public void TheCalculatorAppIsOpen()
        {
            _commonPage.AppOpened();
        }

        [Given(@"I have entered (.*) into calculator")]
        public void GivenIHaveEnteredIntoCalculator(string p0)
        {
            _commonPage.EnterNumber(p0);
        }

        [Given(@"I press (.*)")]
        public void GivenIPress(string p0)
        {
            _commonPage.EnterSign(p0);
        }

        [When(@"I press (.*)")]
        public void WhenIPressEquals(string p0)
        {
            _commonPage.EnterSign(p0);
        }

        [Then(@"Calculator title is (.*)")]
        public void ThenBrowserTitleIs(string title)
        {
            _commonPage.GetTitle().Should().Be(title);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string result)
        {
            _commonPage.GetResult().Should().Be(result);
        }
    }
}
