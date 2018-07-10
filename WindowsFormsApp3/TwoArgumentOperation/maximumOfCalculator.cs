using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.TwoArgumentOperation
{
    public class maximumOfCalculator : ITwoArgumentCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            if (firstValue > secondValue)
                return firstValue;
            else
                return secondValue;
        }
    }
}
