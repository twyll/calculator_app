﻿using System;

namespace WindowsFormsApp3.TwoArgumentOperation
{
    public static class TwoArgumentCalculatorFactory
    {
        
        public static  ITwoArgumentCalculator createCalculator(string operationName)
            {
            switch (operationName)
            {
                case "addition":
                    return new AdditionCalculator();
                case "substraction":
                    return new SubstractionCalculator();
                case "multiplication":
                    return new MultiplicationCalculator();
                case "division":
                    return new DivisionCalculator();
                case "max":
                    return new maximumOfCalculator();
                case "arithmetic":
                    return new AverageArithmeticCalculator();
                case "geometric":
                    return new AverageGeometricCalculator();
                default:
                    throw new ArgumentException("Неизвестная операция", "operationName") ;
            }
            }
    }       
}
