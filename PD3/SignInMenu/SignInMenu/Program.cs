using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SignInMenu
{
    internal class Program
    {
        class MUser
        {
            public MUser(string admin_user,string admin_password) 
            {
                username = admin_user;
                password = admin_password;

            }
            public MUser(string name,string isbn,string Author,string Edition)
            {
                book_name = name;
                book_isbn = isbn;
                author = Author;
               eidtion = Edition;
            }
            public string username;
            public string password;
            public string role;
            public string book_name;
            public string book_isbn;
            public string author;
            public string eidtion;

        }
        static void Main(string[] args)
        {
            List<MUser> users = new List<MUser>();
            string Menu;
            string choice = "";
            string admin_user = "";
            string admin_password = "";
            MUser user = new MUser(admin_user, admin_password);


            while (choice != "3")
            {
                Menu = menu();
                if (Menu == "1")
                {
                    admin_sign_up(users, admin_user, admin_password, user);
                }
                else if (Menu == "2")
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

        static void admin_sign_up(List<MUser> MUSERS, string admin_username, string admin_password, MUser m)
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

        static void admin_sign_in(List<MUser> musers)
        {
            Console.Clear();
            string Username, Password;
            Console.Write("Enter username: ");
            Username = Console.ReadLine();
            Console.Write("Enter password: ");
            Password = Console.ReadLine();

            for (int i = 0; i < musers.Count; i++)
            {
                if (Username == musers[i].username && Password == musers[i].password)
                {


                    admin_menu(musers);
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

        static void read_admin(List<MUser> user)
        {
            string path = "E:\\zaid\\semester 2\\LABS\\lab1 tasks\\SignIn menu\\admin.txt";
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

        static void admin_menu(List<MUser>musers)
        {
            Console.Clear();
          
            Console.WriteLine();
            Console.WriteLine("1.Add book");
            Console.WriteLine("2.Display books");
            Console.WriteLine("3.Delete books");
            Console.WriteLine("4.Update book");
            Console.WriteLine();
            Console.Write("Enter your choice: ");

            string option = Console.ReadLine();

            if (option == "1")
            {
                AddBooks(musers);
            }
            else if (option == "2")
            {
                displayBookInfo(musers);
            }
            else if(option == "3")
            {
                deleteBook(musers);
            }
            else if (option == "4") 
            {
                UpdateEidtion(musers);
            }

        }

        static void AddBooks(List<MUser>user)
        {
            Console.Clear();
            string name, isbn, author, Edition;
            Console.Write("Enter book name: ");
            name = Console.ReadLine();

            Console.Write("Enter book isbn: ");
            isbn = Console.ReadLine();

            Console.Write("Enter author name: ");
            author = Console.ReadLine();

            Console.Write("Enter book edition: ");
            Edition = Console.ReadLine();

            MUser m = new MUser(name, isbn, author, Edition);
            user.Add(m);
            
            admin_menu(user);
        }
        static void displayBookInfo(List<MUser>user)
        {
            Console.Clear();
            Console.WriteLine("NAME \t\t AUTHOR \t\t ISBN \t\t EDITION");

            for (int i=0; i<user.Count;i++)
            {
                Console.WriteLine(user[i].book_name + "\t\t" + user[i].author + "\t\t" + user[i].book_isbn + "\t\t" + user[i].eidtion);
            }

            Console.Read();
            
        }

        static void deleteBook(List<MUser>user)
        {
            Console.Clear();
            string book_name;
            Console.Write("Enter name of the book you want to delete: ");
            book_name = Console.ReadLine();
            for(int i=0; i<user.Count; i++)
            {
                if(book_name == user[i].book_name)
                {
                    user.RemoveAt(i);
                }
                else
                {
                    Console.Write("This book is not present in library.");
                }

            }
            Console.Read();
        }

        static void UpdateEidtion(List<MUser>user)
        {
            Console.Clear();
            string edition, updateEdition;
            Console.Write("Enter the  book edition: ");
            edition = Console.ReadLine();
            Console.Write("Enter the updated book edition: ");
            updateEdition = Console.ReadLine();

            for(int i=0; i<user.Count; i++)
            {
                if(edition == user[i].eidtion)
                {
                    user[i].eidtion = updateEdition;
                }
            }
            Console.Read();
        }
    
    }
}
