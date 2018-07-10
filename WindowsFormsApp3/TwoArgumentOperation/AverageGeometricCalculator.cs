using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.TwoArgumentOperation
{/// <summary>
/// class for calculating geometric average between two numbers
/// </summary>
    public class AverageGeometricCalculator : ITwoArgumentCalculator
    {/// <summary>
    /// calculating geometric average between two numbers
    /// </summary>
    /// <param name="firstValue">first number</param>
    /// <param name="secondValue">second number</param>
    /// <returns>returns geometric average between two numbers</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue * secondValue, 0.5);
        }
    }
}