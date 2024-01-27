using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn_menu
{
    internal class Program
    {
        class MUser
        {
            public MUser(string admin_Username , string admin_Password)
            {
                username = admin_Username;
                password = admin_Password;
            }
           public string username;
           public string password;
            public string role;
        }
        static void Main(string[] args)
        {
            List<MUser>users = new List<MUser>();
            string Menu;
            string choice = "";
            string admin_user = "";
            string admin_password="";

            MUser user = new MUser(admin_user, admin_password);
          

            while (choice != "3")
            {
                Menu = menu();
                if(Menu == "1")
                {
                    admin_sign_up(users , admin_user , admin_password , user);
                }
                else if(Menu == "2")
                {
                    read_admin(users);
                    admin_sign_in(users);
                }
                else if(Menu == "3")
                {
                    break;
                }
                
            }
        }

        static string menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to my buisness app");
            Console.WriteLine();
            Console.WriteLine("1.Sign up");
            Console.WriteLine("2.Sign in");
            Console.WriteLine("3.Exit the program");
            Console.WriteLine();
            Console.Write("Enter your choice: ");

            string input = Console.ReadLine();
            return input;
        }

        static void admin_sign_up(List<MUser>MUSERS, string admin_username , string admin_password, MUser m)
        {
            Console.Clear();
            Console.Write("Enter username: ");
            m.username = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter password: ");
             m.password = Console.ReadLine();
            MUSERS.Add(m);
            write_admin(m);


            Console.Read();
        }

        static void admin_sign_in(List<MUser>musers)
        {
            Console.Clear();
            string Username, Password;
            Console.Write("Enter username: ");
            Username = Console.ReadLine();
            Console.Write("Enter password: ");
            Password = Console.ReadLine();

            for(int i=0; i<musers.Count; i++)
            {
                if(Username == musers[i].username && Password == musers[i].password)
                {
                    Console.WriteLine("User signed in as " + Username);
                    break;
                }
                else
                {
                    Console.WriteLine("invalid username or password");
                }
            }
            Console.Read();

        }
        static void write_admin(MUser m)
        {
            string path = "E:\\zaid\\semester 2\\LABS\\lab1 tasks\\SignIn menu\\admin.txt";
            StreamWriter fileVariable = new StreamWriter(path, true);

            fileVariable.WriteLine(m.username + "," + m.password);
            fileVariable.Flush();
            fileVariable.Close();
        }

        static void read_admin(List<MUser>user)
        {
            string path = "E:\\zaid\\semester 2\\LABS\\lab1 tasks\\SignIn menu\\admin.txt";
            if(File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record = "";

                for (int i = 0; i < 1; i++)
                {
                    record = file.ReadLine();
                    if (record != null)
                    {
                        MUser user1 = new MUser(getField(record, 1), getField(record, 2));
                        user.Add(user1);
                    }
                    else
                    {
                        break;
                    }
                }
                file.Close();
            }
            else
            {
                Console.Write("File not found");
            }
        
        }
        static string getField(string record, int field)
        {
            int commaCount = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    commaCount = commaCount + 1;
                }
                else if (commaCount == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }


    }
}
