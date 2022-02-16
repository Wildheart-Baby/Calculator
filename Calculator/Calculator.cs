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

        public int GetPrime(int position) {
            int num = 1;
            int count = 0;
            //Console.Write("Number : ");
            int n = position;
            //Console.WriteLine();
            while (true)
            {
                num++;
                if (isPrime(num))
                {
                    count++;
                }
                if (count == n)
                {
                    Console.WriteLine(n + "th prime number is " + num);
                    break;
                }
            }
            //Console.ReadKey();
            return num;
        }

        public static bool isPrime(int number)
        {
            int counter = 0;
            for (int j = 2; j < number; j++)
            {
                if (number % j == 0)
                {
                    counter = 1;
                    break;
                }
            }
            if (counter == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}