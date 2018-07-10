using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.OneArgumentOperation
{/// <summary>
/// class for calculating negative argument
/// </summary>
    public class NegativeArgumentCalculator : IOneArgumentCalculator
    { 
    /// <param name="argument">any real number</param>
    /// <returns>returns negative argument</returns>
        public double Calculate(double argument)
        {
            return -argument;
        }
    }
}
