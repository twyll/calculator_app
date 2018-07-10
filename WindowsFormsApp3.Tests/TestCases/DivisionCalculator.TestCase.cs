using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.TwoArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests
{
    [TestFixture]
    public class DivisionCalculatorTestCase
    {
        [TestCase(2, 2, 1)]
        [TestCase(3, 4, 0.75)]
        [TestCase(-3, -8, 0.375)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new DivisionCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}