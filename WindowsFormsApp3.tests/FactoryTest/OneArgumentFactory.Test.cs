using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.OneArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.FactoryTest
{
    [TestFixture]
    public class OneArgumentFactoryTests
    {
        [TestCase("sin", typeof(SineCalculator))]
        [TestCase("cos", typeof(CosCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentCalculatorFactory.createCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }
    }

}
