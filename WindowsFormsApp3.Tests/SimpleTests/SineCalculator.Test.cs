using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.OneArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests
{
    [TestFixture]
    public class SinenCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            IOneArgumentCalculator sineCalculator = new SineCalculator();
            double actualResult = sineCalculator.Calculate(0);
            double estimatedResult = 0;
            Assert.AreEqual(estimatedResult, actualResult);
        }
    }
}
