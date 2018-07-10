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
    public class SubstractionCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentCalculator substractionCalculator = new SubstractionCalculator();
            double actualResult = substractionCalculator.Calculate(10, 10);
            double estimatedResult = 0;
            Assert.AreEqual(estimatedResult, actualResult);
        }
        // ...
    }

}