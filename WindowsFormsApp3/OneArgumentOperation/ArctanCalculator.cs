using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.OneArgumentOperation
{/// <summary>
/// Class for calculating Arctan of argument
/// </summary>
    public class ArctanCalculator : IOneArgumentCalculator
    {/// <summary>
    /// Calculating Arctan of argument
    /// </summary>
    /// <param name="argument">Value in radians</param>
    /// <returns>returns the angle of tan</returns>
        public double Calculate(double argument)
        {
            return Math.Atan(argument);
        }
    }
}
