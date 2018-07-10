using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.OneArgumentOperation
{/// <summary>
/// class for calculating tan of argument
/// </summary>
    public class TanCalculator : IOneArgumentCalculator
    {/// <summary>
    /// calculating tan of argument
    /// </summary>
    /// <param name="argument">value in radians</param>
    /// <returns>returns tan of argument</returns>
        public double Calculate(double argument)
        {
            if (Math.Abs(Math.Cos(argument)) < 0.000001)
                throw new Exception("Неправильный аргумент");
            return Math.Tan(argument);
        }
    }
}
