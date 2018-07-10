using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.TwoArgumentOperation
{/// <summary>
/// class for calculating the result of integer division between two numbers
/// </summary>
    public class IntegerDivisionCalculator : ITwoArgumentCalculator
    {/// <summary>
    /// calculalting the result of integer division between two numbers
    /// </summary>
    /// <param name="firstValue">dividend</param>
    /// <param name="secondValue">divider</param>
    /// <returns>returns the result of integer division</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new Exception("Деление на 0");
            }
            return (int) (firstValue / secondValue);
        }
    }
}
