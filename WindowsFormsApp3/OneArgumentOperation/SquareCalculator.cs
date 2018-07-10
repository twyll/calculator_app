using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.OneArgumentOperation
{/// <summary>
/// class for calculating square of argument
/// </summary>
    public class SquareCalculator : IOneArgumentCalculator
    {/// <summary>
    /// calculating square of argument
    /// </summary>
    /// <param name="argument">any real number</param>
    /// <returns>returns the result of x^2</returns>
        public double Calculate(double argument)
        {
            return Math.Pow(argument, 2);
        }
    }
}
