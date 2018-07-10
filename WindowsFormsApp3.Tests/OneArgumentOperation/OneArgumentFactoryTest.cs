using System;
using WindowsFormsApp3.OneArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.OneArgumentOperation
{
    [TestFixture]
    public class OneArgumentFactoryTests
    {
        [TestCase("sin", typeof(SineCalculator))]
        [TestCase("cos", typeof(CosCalculator))]
        [TestCase("naturalLogarithm", typeof(NaturalLogarithmCalculator))]
        [TestCase("logTwo", typeof(LogarithmForBaseTwoCalculator))]
        [TestCase("logTen", typeof(LogarithmForBaseTenCalculator))]
        [TestCase("sqr", typeof(SquareCalculator))]
        [TestCase("twoPowerOf", typeof(PowerOfTwoCalculator))]
        [TestCase("tenPowerOf", typeof(PowerOfTenCalculator))]
        [TestCase("negative", typeof(NegativeArgumentCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentCalculatorFactory.createCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }
    }

}
