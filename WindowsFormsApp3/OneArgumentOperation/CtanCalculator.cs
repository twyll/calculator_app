using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.OneArgumentOperation
{
    public class CtanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            if (argument % Math.PI == 0)
            {
                throw new Exception("Недопустимый аргумент");
            }
            return 1/Math.Tan(argument);
        }
    }
}
