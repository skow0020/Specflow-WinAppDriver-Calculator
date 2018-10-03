﻿using System;
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
    public class CalculatorFeatureSteps
    {
        private readonly Calculator _calculator;
        private static Process _driver;

        public CalculatorFeatureSteps(Calculator calculator)
        {
            _calculator = calculator;
        }

        [BeforeTestRun]
        public static void StartWinAppDriver()
        {
            try
            {
                _driver = Process.Start(ConfigurationManager.AppSettings["winAppPath"]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not locate WinAppDriver.exe, get it from https://github.com/Microsoft/WinAppDriver/releases and change the winAppPath in app.settings accordingly");
                throw new FileNotFoundException("Could not locate File WinAppDriver.exe", e);
            }
        }

        [AfterTestRun]
        public static void KillWinAppDriver()
        {
            _driver.Kill();
        }
    }
}
