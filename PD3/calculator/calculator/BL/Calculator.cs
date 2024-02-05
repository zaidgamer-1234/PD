using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Calculator
    {
        public Calculator() 
        {
            number1 = 10;
            numebr2 = 10;

        }
        public int number1;
        public int numebr2;

        public int Addition()
        {
            return number1+numebr2;
        }
        public int Subtraction() 
        {
            return number1-numebr2;
        }
        public int Multiplication() 
        {
            return number1*numebr2;
        }
        public int Division()
        {
            return number1/numebr2;
        }
        public int Modulus() 
        {
            return number1 / numebr2;
        }
    }
}
