using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.OneArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.OneArgumentOperation
{
    [TestFixture]
    public class NegativeArgumentCalculatorTestCase
    {
        [TestCase(0, 0)]
        [TestCase(-3.345, 3.345)]
        [TestCase(-9.23, 9.23)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new NegativeArgumentCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
