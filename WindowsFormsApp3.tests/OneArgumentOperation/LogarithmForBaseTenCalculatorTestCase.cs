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
   public class LogarithmForBaseTenCalculatorTestCase
    {
        [TestCase(0, 1)]
        [TestCase(1000, 3)]
        [TestCase(8, 0.9031)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new LogarithmForBaseTenCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
