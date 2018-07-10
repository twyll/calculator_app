﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.TwoArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests
{
    [TestFixture]
    public class MultiplicationCalculatorTestCase
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 12)]
        [TestCase(-7, -2, 14)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new MultiplicationCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}