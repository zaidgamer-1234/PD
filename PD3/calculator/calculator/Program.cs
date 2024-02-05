using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
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
            else
            {

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
            Console.WriteLine("7Exit.");
            option = Console.ReadLine();

            return option;
        }
    }
   
}
    

