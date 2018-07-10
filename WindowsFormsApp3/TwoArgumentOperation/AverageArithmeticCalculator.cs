using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.TwoArgumentOperation
{
    public class AverageArithmeticCalculator: ITwoArgumentCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return (firstValue + secondValue) / 2;
        }
    }
}
