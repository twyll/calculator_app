namespace WindowsFormsApp3.TwoArgumentOperation
{
    public class SubstractionCalculator: ITwoArgumentCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
}
