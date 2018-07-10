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
    public class TanCalculatorTestCase
    {
        [TestCase(Math.PI, 0)]
        [TestCase(-Math.PI, 0)]
        [TestCase(-1, -1.55)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new TanCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }

        [TestCase(-Math.PI/2)]
        [TestCase(Math.PI/2)]
        [TestCase(3*Math.PI/2)]
        public void CatchExceptions(double argument)
        {
            var calculator = new TanCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(argument));
        }
    }
}
