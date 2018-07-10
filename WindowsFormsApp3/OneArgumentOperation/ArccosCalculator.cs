using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.OneArgumentOperation
{
    public class ArccosCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            if (argument > 1 || argument < -1)
            {
                throw new Exception("Недопустимый аргумент");
            }
            return Math.Acos(argument);
        }
    }
}
