namespace WindowsFormsApp3.TwoArgumentOperation
{
    public class MultiplicationCalculator : ITwoArgumentCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
    }
    

}
