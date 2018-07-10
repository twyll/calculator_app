using System;

namespace WindowsFormsApp3.OneArgumentOperation
{
    public class OneArgumentCalculatorFactory
    {
        public static IOneArgumentCalculator createCalculator(string operationName)
        {
            switch (operationName)
            {
                case "sin":
                    return new SineCalculator();
                case "cos":
                    return new CosCalculator();
                case "naturalLogarithm":
                    return new NaturalLogarithmCalculator();
                case "logTwo":
                    return new LogarithmForBaseTwoCalculator();
                case "logTen":
                    return new LogarithmForBaseTenCalculator();
                case "sqr":
                    return new SquareCalculator();
                case "twoPowerOf":
                    return new PowerOfTwoCalculator();
                case "tenPowerOf":
                    return new PowerOfTenCalculator();
                case "negative":
                    return new NegativeArgumentCalculator();
                default:
                    throw new ArgumentException("Неизвестная операция", "operationName");
            }
        }
    }
}
