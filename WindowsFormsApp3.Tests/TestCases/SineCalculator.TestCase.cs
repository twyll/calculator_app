using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.OneArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests
{
    [TestFixture]
    public class SineCalculatorTestCase
    {
        [TestCase(0, 0)]
        [TestCase(Math.PI, 0)]
        [TestCase(Math.PI/2, 1)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new SineCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
