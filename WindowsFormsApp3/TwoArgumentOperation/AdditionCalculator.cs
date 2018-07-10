﻿namespace WindowsFormsApp3.TwoArgumentOperation
{
    public class AdditionCalculator : ITwoArgumentCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
}