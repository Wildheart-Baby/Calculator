namespace CalculatorAPI
{
    internal interface ISimpleCalculator
    {
        int Add(int start, int amount);
        int Subtract(int start, int amount);
        int Multiply(int start, int by);
        float Divide(int start, float by);
    }
}
