using modifiedCalculator.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modifiedCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Class1 c = new Class1();
            string menu;


            menu = Menu();
            if (menu == "2")
            {
                Console.WriteLine(c.Addition());
            }
            else if (menu == "3")
            {
                Console.WriteLine(c.Subtraction());
            }
            else if (menu == "4")
            {
                Console.WriteLine(c.Multiplication());
            }
            else if (menu == "5")
            {
                Console.WriteLine(c.Division());
            }
            else if (menu == "6")
            {
                Console.WriteLine(c.Modulus());
            }
            else if(menu == "7")
            {
                Console.WriteLine(c.Sqrt());
            }
            else if(menu == "8")
            {
                Console.WriteLine(c.Expo());
            }
            else if (menu == "9")
            {
                Console.WriteLine(c.Log());
            }
            else if (menu == "10")
            {
                Console.WriteLine(c.Sin());
            }
            else if (menu == "11")
            {
                Console.WriteLine(c.Cos());
            }
            else if (menu == "12")
            {
                Console.WriteLine(c.Tan());
            }
        }
        static string Menu()
        {
            Console.Clear();
            string option;
            Console.WriteLine("1.Change values of attributes.");
            Console.WriteLine("2.Add.");
            Console.WriteLine("3.Subtract.");
            Console.WriteLine("4.Multiply.");
            Console.WriteLine("5.Divide.");
            Console.WriteLine("6.Modulo.");
            Console.WriteLine("7.Sqrt of a number.");
            Console.WriteLine("8.Exponent of a number.");
            Console.WriteLine("9.log of a number. ");
            Console.WriteLine("10.Sin of a number. ");
            Console.WriteLine("11.Cos of a number. ");
            Console.WriteLine("12.Tan of a number. ");
            Console.Write("Enter your choice.");
            option = Console.ReadLine();

            return option;
        }

     
    }
    
}
