using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(2, calculator.Add(1, 1));
            Assert.AreEqual(25, calculator.Add(10, 15));
            Assert.AreEqual(100, calculator.Add(50, 50));
        }
        [TestMethod()]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(2, calculator.Divide(2, 1)); 
            Assert.AreEqual(5, calculator.Divide(10, 2));
            Assert.AreEqual(20, calculator.Divide(100, 5));
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(500, calculator.Multiply(100, 5));
            Assert.AreEqual(20, calculator.Multiply(4, 5));
            Assert.AreEqual(81, calculator.Multiply(9, 9));
        }

        [TestMethod()]
        public void SubtractTest()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(25, calculator.Subtract(40, 15));
            Assert.AreEqual(2, calculator.Subtract(3, 1));
            Assert.AreEqual(200, calculator.Subtract(212, 12));
        }
    }
}