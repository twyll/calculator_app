using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.TwoArgumentOperation
{/// <summary>
/// class for calculating average between two numbers
/// </summary>
    public class AverageArithmeticCalculator: ITwoArgumentCalculator
    {/// <summary>
    /// calculating average between two number
    /// </summary>
    /// <param name="firstValue">first number</param>
    /// <param name="secondValue">second number</param>
    /// <returns>returns average between two numbers</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return (firstValue + secondValue) / 2;
        }
    }
}
