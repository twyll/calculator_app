using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.OneArgumentOperation
{
    public class TanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            if (Math.Abs(Math.Cos(argument)) < 0.000001)
                throw new Exception("Неправильный аргумент");
            return Math.Tan(argument);
        }
    }
}
