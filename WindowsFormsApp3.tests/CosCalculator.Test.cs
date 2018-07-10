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
    public class CosnCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            IOneArgumentCalculator cosCalculator = new CosCalculator();
            double actualResult = cosCalculator.Calculate(Math.PI);
            double estimatedResult = -1;
            Assert.AreEqual(estimatedResult, actualResult);
        }
    }
}
