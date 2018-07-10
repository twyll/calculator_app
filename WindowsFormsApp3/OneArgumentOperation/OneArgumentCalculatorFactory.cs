using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class OneArgumentCalculatorFactory
    {
        public static IOneArgumentCalculator createCalculator(string operationName)
        {
            switch (operationName)
            {
                case "sin":
                    return new SineCalculator();
                case "cos":
                    return new CosCalculator();
                default:
                    throw new ArgumentException("Неизвестная операция", "operationName");
            }
        }
    }
}
