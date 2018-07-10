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
    public class PowerOfTwoCalculatorTestCase
    {
        [TestCase(0, 1)]
        [TestCase(10, 1024)]
        [TestCase(-0.5, 0.7071)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new PowerOfTwoCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
