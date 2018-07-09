using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public static class CalculatorFactory
    {
        public static ICalculator createCalculator(string operationName)
            {
            switch (operationName)
            {
                case "addition":
                    return new AdditionCalculator();
                case "substruction":
                    return new SubstractionCalculator();
                case "muliplication":
                    return new MultiplicationCalculator();
                case "division":
                    return new DivisionCalculator();
                default:
                    return null;
            }
            }
    }       
}
