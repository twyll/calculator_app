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
    public class HyperbolaCalculatorTestCase
    {
        [TestCase(1, 1)]
        [TestCase(0.5, 2)]
        [TestCase(-1, -1)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new HyperbolaCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
        [Test]
        public void CatchExceptions()
        {
            var hyperbolaCalculator = new HyperbolaCalculator();
            Assert.Throws<Exception>(()=>hyperbolaCalculator.Calculate(0));
        }
    }
}
