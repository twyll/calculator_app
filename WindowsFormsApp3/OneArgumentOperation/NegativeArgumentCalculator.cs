using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.OneArgumentOperation
{
    public class NegativeArgumentCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return -argument;
        }
    }
}
