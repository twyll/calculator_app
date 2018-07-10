using System;

namespace WindowsFormsApp3.TwoArgumentOperation
{
    public class DivisionCalculator : ITwoArgumentCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new Exception("Деление на 0");
            }
            return firstValue / secondValue;
        }
    }
}
