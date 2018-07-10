using System;
using WindowsFormsApp3.TwoArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.TwoArgumentOperation
{
        [TestFixture]
        public class DivisionCalculatorTests
        {
            [Test]
            public void CalculateTest()
            {
                ITwoArgumentCalculator divisionCalculator = new DivisionCalculator();
                double actualResult = divisionCalculator.Calculate(10, 10);
                double estimatedResult = 1;
                Assert.AreEqual(estimatedResult, actualResult);
            }

            [Test]
            public void catchExceptions()
            {
            ITwoArgumentCalculator divisionCalculator = new DivisionCalculator();
            Assert.Throws<Exception>(() => divisionCalculator.Calculate(1,0));
            }
    }
}
