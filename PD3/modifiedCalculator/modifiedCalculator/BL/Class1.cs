using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace modifiedCalculator.BL
{
    internal class Class1
    {
        public Class1()
        {
            number1 = 101;
            numebr2 = 101;

        }
        public int number1;
        public int numebr2;

        public int Modulus()
        {
            return number1 / numebr2;
        }
        public int Addition()
        {
            return number1 + numebr2;
        }
        public int Subtraction()
        {
            return number1 - numebr2;
        }
        public int Multiplication()
        {
            return number1 * numebr2;
        }
        public int Division()
        {
            return number1 / numebr2;
        }
       
        public int Sqrt()
        {
            return Convert.ToInt32(Math.Sqrt(number1));
        }

        public double Expo()
        {
            return (Math.Exp(number1));
        }

        public double Log()
        {
            return (Math.Log(number1));
        }
        public double Sin()
        {
            return (Math.Log(number1));
        }
        public double Cos()
        {
            return (Math.Log(number1));
        }
        public double Tan()
        {
            return (Math.Log(number1));
        }
    }
}
