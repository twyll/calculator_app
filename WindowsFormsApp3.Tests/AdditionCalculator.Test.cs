﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.TwoArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests
{
    [TestFixture]
    public class AdditionCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentCalculator additionCalculator = new AdditionCalculator();
            double actualResult = additionCalculator.Calculate(10, 10);
            double estimatedResult = 20;
            Assert.AreEqual(estimatedResult, actualResult);
        }
        // ...
    }

}