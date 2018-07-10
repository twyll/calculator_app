﻿using System;
using WindowsFormsApp3.TwoArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.FactoryTest
{
    [TestFixture]
    public class TwoArgumentFactoryTests
    {
        [TestCase("addition", typeof(AdditionCalculator))]
        [TestCase("substraction", typeof(SubstractionCalculator))]
        [TestCase("multiplication", typeof(MultiplicationCalculator))]
        [TestCase("division", typeof(DivisionCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentCalculatorFactory.createCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }
    }

}