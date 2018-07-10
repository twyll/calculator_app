using System;

namespace WindowsFormsApp3.OneArgumentOperation
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
