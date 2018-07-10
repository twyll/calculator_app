﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.OneArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.OneArgumentOperation
{
    [TestFixture]
    public class SquareCalculatorTestCase
    {
        [TestCase(0, 0)]
        [TestCase(1.2, 1.44)]
        [TestCase(-1.6, 2.56)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new SquareCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
