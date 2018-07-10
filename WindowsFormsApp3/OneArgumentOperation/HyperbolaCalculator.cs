using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.OneArgumentOperation
{
    public class HyperbolaCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            if (argument == 0)
            {
                throw new Exception("Деление на 0");
            }
            return 1/argument;
        }
    }
}
