namespace Calculator
{
    public class Calculator : ISimpleCalculator, OutputResults

    {
        public int Add(int start, int amount)
        {
            int number = start + amount;
            OutputResults(number.ToString(), "add");
            return start + amount;
        }

        public float Divide(int start, float by)
        {
            float number = start / by;
            OutputResults(number.ToString(), "divide");
            return number;
        }

        public int Multiply(int start, int by)
        {
            int number = start * by;
            OutputResults(number.ToString(), "multiply");
            return number;
        }

        public int Subtract(int start, int amount)
        {
            int number = start - amount;
            OutputResults(number.ToString(), "subtract");
            return number;
        }

        public void OutputResults(string answer, string type) //this function will output the result from the method to the console
        {
            Console.WriteLine("The answer to the " + type + " method was " + answer);
        }
       
    }

}