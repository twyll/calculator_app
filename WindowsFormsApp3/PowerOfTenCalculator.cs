using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.OneArgumentOperation;

namespace WindowsFormsApp3
{
    public class PowerOfTenCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Pow(10, argument);
        }
    }
}
