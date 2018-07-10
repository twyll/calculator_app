using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.OneArgumentOperation
{
    public class SquareCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Pow(argument, 2);
        }
    }
}
