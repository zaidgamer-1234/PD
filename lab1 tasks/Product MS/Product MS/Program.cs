using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Product_MS
{
    internal class Program
    {
        class Product
        {
           public Product(string ID, string Name, string Category, float Price,  string Brand, string Country)
            {
                id = ID;
                name = Name;
                price = Price;
                category = Category;
                brand = Brand;
                country = Country;
                
            }
            public string id;
            public string name; 
            public float price;
            public string category;
            public string brand;
            public string country;
            public float Worth;
        }
        static void Main(string[] args)
        {
            List<Product>products = new List<Product>();


            string choice = "";
            string menu;

            while(choice != "4")
            {
                menu = Menu();
                if(menu == "1")
                {
                    addProduct(products);
                }
                else if(menu == "2")
                {
                    displayInfo(products);
                }
                else if(menu == "3")
                {
                    calculateWorh(products);
                }
                else if(menu =="4")
                {
                    break;
                }
                
            }
        }

        static string Menu()
        {
            Console.Clear();
            Console.WriteLine("1.Add product");
            Console.WriteLine("2.Display product information");
            Console.WriteLine("3.Total store worth");
            Console.WriteLine("4.Exit the program");
            Console.WriteLine();
            Console.Write("Enter your choice");
            string input;
            input = Console.ReadLine();

            return input;
        }

        static Product addProduct(List<Product>products)
        {
            Console.Clear();
            string ID, Name; float Price; string Category, Brand, Country;
            float worth = 0;
            Console.Write("Enter product id: ");
            ID = Console.ReadLine();

            Console.Write("Enter product name: ");
            Name = Console.ReadLine();

            Console.Write("Enter product category: ");
            Category = Console.ReadLine();


            Console.Write("Entr product price: ");
            Price = float.Parse(Console.ReadLine());

            Console.Write("Enter brand: ");
            Brand = Console.ReadLine();

            Console.Write("Enter country name: ");
            Country = Console.ReadLine();

            Product p = new Product(ID , Name , Category , Price , Brand , Country);
            products.Add(p);
            Console.Read();

            return p;

        }

        static void displayInfo(List<Product>p)
        {
            Console.Clear();
            Console.WriteLine("ID \t\t NAME \t\t CATEGORY \t\t PRICE \t\t BRAND \t\t COUNTRY");
            for(int i=0; i<p.Count; i++)
            {
                Console.WriteLine(p[i].id + "\t\t" + p[i].name + "\t\t" + p[i].category + "\t\t" + p[i].price + "\t\t\t" + p[i].brand + "\t\t" + p[i].category);

            }
            Console.Read();
        }
        
        static void calculateWorh(List<Product>p)
        {
            Console.Clear();
            Console.Write("Total worth is: ");
            float total_worth = 0; 
            for(int i=0; i<p.Count ; i++)
            {
                total_worth += p[i].price;
            }
            Console.Write(total_worth);
            Console.Read();
        }
    }
}
