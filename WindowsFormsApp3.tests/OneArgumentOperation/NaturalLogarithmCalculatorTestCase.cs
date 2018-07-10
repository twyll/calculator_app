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
    public class NaturalLogarithmCalculatorTestCase
    {
        [TestCase(1, 0)]
        [TestCase(3, 1.0986)]
        [TestCase(7, 1.9459)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new NaturalLogarithmCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
