using System;

namespace WindowsFormsApp3.OneArgumentOperation
{
    public class CosCalculator: IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}
