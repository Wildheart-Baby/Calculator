namespace Calculator
{
    public class Calculator : ISimpleCalculator
    {
        public int Add(int start, int amount)
        {
            return start + amount;
        }

        public float Divide(int start, float by)
        {
            return start / by;
        }

        public int Multiply(int start, int by)
        {
            return start * by;
        }

        public int Subtract(int start, int amount)
        {
            return start - amount;
        }
    }
}