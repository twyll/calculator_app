using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.OneArgumentOperation
{/// <summary>
/// class for calculating power of ten
/// </summary>
    public class PowerOfTenCalculator : IOneArgumentCalculator
    {/// <summary>
    /// calculating 10^x
    /// </summary>
    /// <param name="argument">any real number</param>
    /// <returns>returns the result of 10^x</returns>
        public double Calculate(double argument)
        {
            return Math.Pow(10, argument);
        }
    }
}
