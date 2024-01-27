using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Student_MS
{
    internal class Program
    {
        class Student
        {
            public Student(string name,float  Ecatmarks ,float  matricMarks ,float Fscmarks)
            {
                sname = name;
                mMarks = matricMarks;
                Fmarks = Fscmarks;
                Emarks = Ecatmarks;
                aggregate = 0; 
            }
            public string sname;
            public float mMarks;
            public float Fmarks;
            public float Emarks;
            public float aggregate;
        }
        static void Main(string[] args)
        {
            List<Student>students = new List<Student>();
            List<float> aggr = new List<float>();
            

            string choice = "";
            string menu;

            while (choice != "5")
            {
                menu = Menu();
                if (menu == "1")
                {
                    AddStudent(students);
                }
                else if (menu == "2")
                {
                    Display(students);
                }
                else if (menu == "3")
                {
                    calculate_Aggregate(students, aggr);
                }
                else if (menu == "4") 
                    {
                    DisplayStudents(students);
                }
                else if(menu == "5")
                {
                    break;
                }
            }

        }
        static string Menu()
        {
            Console.Clear();
            Console.WriteLine("1.Add student");
            Console.WriteLine("2.Show students");
            Console.WriteLine("3.Calculate aggragate");
            Console.WriteLine("4.Top studets");
            Console.WriteLine("5.Exit the program");
            string input;
            Console.Write("Please enter your choice: ");
            input = Console.ReadLine();

            return input;
        }
        static Student AddStudent(List<Student>students)
        {
            
            Console.Clear();

            string name; float Ecatmarks , matricMarks ,  Fscmarks;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter matric marks: ");
            matricMarks = float.Parse(Console.ReadLine());

            Console.Write("Enter fsc marks: ");
            Fscmarks = float.Parse(Console.ReadLine());

            Console.Write("Enter Ecat marks: ");
            Ecatmarks = float.Parse(Console.ReadLine());
            Student s = new Student(name, Ecatmarks, matricMarks, Fscmarks);

            students.Add(s);

            return s;

        }

        static void Display(List<Student>students)
        {
            Console.Clear();
            Console.WriteLine("NAME \t Emarks \t Fmarks \t Mmarks");
            Console.WriteLine();
            for (int i = 0; i < students.Count ; i++)
            {
                Console.WriteLine(students[i].sname + "\t" + students[i].Emarks + "\t\t" + students[i].Fmarks + "\t\t" + students[i].mMarks);
            }
            Console.Read();

        }

        static void calculate_Aggregate(List<Student>students , List<float>agg)
        {
            Console.Clear();
            for(int i=0; i<students.Count; i++)
            {
                agg.Add((students[i].Fmarks * 33 / 100) + (students[i].mMarks * 17 / 100) + (students[i].Emarks * 33 / 100));
                
            }
            Console.WriteLine("Showing Aggrgates");
            for(int i=0; i<agg.Count; i++)
            {
                Console.WriteLine(agg[i]);
            }
            Console.Read();
            
        }

        static void DisplayStudents(List<Student> students)
        {
            Console.Clear();

            var sortedStudents = students.OrderByDescending(s => s.aggregate).ToList();

            Console.WriteLine("Top 3 Students:");
            Console.WriteLine("NAME \t Emarks \t Fmarks \t Mmarks ");
            Console.WriteLine();

            int count = Math.Min(3, sortedStudents.Count);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{sortedStudents[i].sname}\t{sortedStudents[i].Emarks}\t\t{sortedStudents[i].Fmarks}\t\t{sortedStudents[i].mMarks}");
            }

            Console.Read();
        }
    }
}
