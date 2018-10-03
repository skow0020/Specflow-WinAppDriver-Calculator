using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using CalculatorUnitTests.Driver;
using CalculatorUnitTests.Helper;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace CalculatorUnitTests.Steps
{
    [Binding]
    public class PageSteps
    {
        private readonly Calculator _calculator;
        private static Process _driver;

        public PageSteps(Calculator calculator)
        {
            _calculator = calculator;
        }

        [Given(@"the calculator app is open")]
        public void TheCalculatorAppIsOpen()
        {
            _calculator.AppOpened();
        }

        [Given(@"I have entered (.*) into calculator")]
        public void GivenIHaveEnteredIntoCalculator(string p0)
        {
            _calculator.EnterNumber(p0);
        }

        [Given(@"I press (.*)")]
        public void GivenIPress(string p0)
        {
            _calculator.EnterSign(p0);
        }

        [When(@"I press (.*)")]
        public void WhenIPressEquals(string p0)
        {
            _calculator.EnterSign(p0);
        }

        [Then(@"Calculator title is (.*)")]
        public void ThenBrowserTitleIs(string p0)
        {
            _calculator.GetTitle().Should().Be(p0);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string p0)
        {
            _calculator.GetResult().Should().Be(p0);
        }
    }
}
