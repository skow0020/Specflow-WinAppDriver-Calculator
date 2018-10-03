using CalculatorUnitTests.Pages;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace CalculatorUnitTests.Steps
{
    [Binding]
    public class PageSteps
    {
        private readonly CommonPage _commonPage;

        public PageSteps(CommonPage page)
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
        public void ThenBrowserTitleIs(string p0)
        {
            _commonPage.GetTitle().Should().Be(p0);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string p0)
        {
            _commonPage.GetResult().Should().Be(p0);
        }
    }
}
