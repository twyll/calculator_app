using System;

namespace WindowsFormsApp3.OneArgumentOperation
{
    public class SineCalculator: IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}
