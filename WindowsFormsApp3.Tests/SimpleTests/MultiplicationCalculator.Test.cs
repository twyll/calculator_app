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
    public class MultiplicationCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentCalculator multiplicationCalculator = new MultiplicationCalculator();
            double actualResult = multiplicationCalculator.Calculate(10, 10);
            double estimatedResult = 100;
            Assert.AreEqual(estimatedResult, actualResult);
        }
        // ...
    }

}
