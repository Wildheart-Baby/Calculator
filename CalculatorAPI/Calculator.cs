using CalculatorAPI;
using javax.jws;

namespace Calculator
{
    public class Calculator : ISimpleCalculator
    {
        [WebMethod]
        public int Add(int start, int amount)
        {            
            return start + amount;
        }

        [WebMethod]
        public float Divide(int start, float by)
        {
            return  start / by;
        }

        [WebMethod]
        public int Multiply(int start, int by)
        {
            return start * by;
        }

        [WebMethod]
        public int Subtract(int start, int amount)
        {
            return start - amount;
        }
    }
}
