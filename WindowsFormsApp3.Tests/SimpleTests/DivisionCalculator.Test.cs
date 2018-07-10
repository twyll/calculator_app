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
        }
}
