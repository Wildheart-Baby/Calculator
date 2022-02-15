using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface ISimpleCalculator
    {
        int Add(int start, int amount);
        int Subtract(int start, int amount);
        int Multiply(int start, int by);
        float Divide(int start, float by);
    }

    internal interface OutputResults //I thought that this interface was the best way to output the result to the debugger 
    {
        void OutputResults(string result, String type);
    }

}
