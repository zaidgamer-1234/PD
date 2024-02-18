using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanNavigation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ship>ship = new List<Ship>();
            string menu = "";
            string choice = "";
            while(choice != "5")
            {
                menu = Menu();
                if(menu == "1")
                {
                    addShip(ship);
                }
                else if(menu == "2")
                {
                    
                    Console.Write("Enter the ship serial number to find its position:");
                    string serNumber = Console.ReadLine();
                    for (int i = 0; i < ship.Count; i++)
                    {
                        if (serNumber == ship[i].shipNumber)
                        {
                            Console.Write(ship[i].shipsLatitude.concatenate());
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid serial number");
                        }
                    }
                }
                else if(menu == "3")
                {
                    Console.Clear();
                    string latitiude;
                    Console.Write("Enter the ship latitude: ");
                    latitiude = Console.ReadLine();

                    for(int i=0; i<ship.Count; i++)
                    {
                        if(latitiude == ship[i].shipsLatitude.concatenate())
                        {
                            Console.WriteLine("Ships serial number is: " + latitiude);
                        }
                    }

                }
                else if(menu == "4")
                {
                    Console.Clear();
                    string changePsosition;
                    Console.Write("Enter the serial number whose position you want to change: ");
                    changePsosition = Console.ReadLine();

                    for(int i=0; i < ship.Count; i++)
                    {
                        if(changePsosition == ship[i].shipNumber)
                        {
                            Console.WriteLine("Enter ship Latitude\n");
                            Console.Write("Enter latitude Degree: ");
                            int degree = int.Parse(Console.ReadLine());
                            Console.Write("Enter latitude minute: ");
                            float min = float.Parse(Console.ReadLine());
                            Console.WriteLine("Ente latitide direction: ");
                            char direction = char.Parse(Console.ReadLine());
                            Angle a1 = new Angle(degree, min, direction);

                            
                        }
                    }
                }
            }
        }

        static string Menu()
        {
            Console.Clear();
            Console.WriteLine("1.Add ship.");
            Console.WriteLine("2.View ship position.");
            Console.WriteLine("3.View ship serial number.");
            Console.WriteLine("4.Change ship position.");
            Console.WriteLine("5.Exit");
            string option;
            option = Console.ReadLine();
            return option;
        }

        static Ship addShip(List<Ship>ship)
        {
            Console.Clear();
            Console.Write("Enter ship number: ");
            string shipNumber = Console.ReadLine();
            Console.WriteLine("Enter ship Latitude\n");
            Console.Write("Enter latitude Degree: ");
            int degree =int.Parse( Console.ReadLine());
            Console.Write("Enter latitude minute: ");
    float min = float.Parse(Console.ReadLine());
            Console.WriteLine("Ente latitide direction: ");
            char direction = char.Parse( Console.ReadLine());

            Angle a = new Angle(degree, min, direction);

            Console.WriteLine("Enter ship Longitude\n");
            Console.Write("Enter longitude Degree");
            int Degree = int.Parse( Console.ReadLine());
            Console.Write("Enter longitude minute");
            float Min= float.Parse(Console.ReadLine());
            Console.WriteLine("Ente longitude direction");
            char Drection = char.Parse(Console.ReadLine());

            Angle a1 = new Angle(Degree, min, direction);

            Ship s = new Ship(shipNumber, a);

            ship.Add(s);
            return s;

        }
    }
}
