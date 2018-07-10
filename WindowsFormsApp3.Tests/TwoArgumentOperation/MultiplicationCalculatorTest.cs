using WindowsFormsApp3.TwoArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.TwoArgumentOperation
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
