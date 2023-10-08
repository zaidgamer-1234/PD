#include <iostream>
#include <windows.h>
using namespace std;

void name();
void management();
void choice();
void choice1();
void choice2();
void calculateAggregate(string name, float Matric_Marks, float InterMarks, float EcatMarks);

int main()
{
    management();
    choice();
    return 0;
}

void name()
{
  
    cout << "University of Engineering and Technology" << endl;
}

void management()
{
    name();
    system("color 0B");
    int password;
    cout << " Uet Management system" << endl;
    system("color 0B");
    cout << "E-mail password : ";
    cin >> password;
}

void choice()
{
    system("cls");
    name();
    int choice;
    system("color 0B");
    cout << "For calculating aggregate, press 1" << endl;
    system("color 0B");
    cout << "For comparing marks, press 2" << endl;
    system("color 0B");
    cout << "Enter your choice: ";
    cin >> choice;

    if (choice == 1)
    {
        choice1();
    }
    else if (choice == 2)
    {
        choice2();
    }
}

void choice1()
{
    system("cls");
    name();
   
    float matric_marks, inter_marks, e_cat;
    string name;
    cout << "Enter student name: ";
    cin >> name;
    cout << "Enter matric marks: ";
    cin >> matric_marks;
    cout << "Enter inter marks: ";
    cin >> inter_marks;
    cout << "Enter ecat marks: ";
    cin >> e_cat;
    calculateAggregate(name, matric_marks, inter_marks, e_cat);
}

void calculateAggregate(string name1, float matricMarks, float interMarks, float ecatMarks)
{
    float aggregate = (matricMarks / 1100 * 30) + (interMarks / 1100 * 30) + (ecatMarks / 400 * 40);
    cout << "The aggregate of " << name1 << " is: " << aggregate << endl;
}

void choice2()
{
    string Std1;
    int ecat_Marks_Std1;
    string Std2;
    int ecat_Marks_Std2;

    cout << "Enter the name of student 1: ";
    cin >> Std1;

    cout << "Enter the ecat marks of student 1: ";
    cin >> ecat_Marks_Std1;

    cout << "Enter the name of student 2: ";
    cin >> Std2;

    cout << "Enter the ecat marks of student 2: ";
    cin >> ecat_Marks_Std2;

    if (ecat_Marks_Std1 > ecat_Marks_Std2)
    {
        cout << Std1 << " will get the first roll number." << endl;
    }
    else if (ecat_Marks_Std1 < ecat_Marks_Std2)
    {
        cout << Std2 << " will get the first roll number." << endl;
    }
    else
    {
        cout << "Both students have the same ecat marks." << endl;
    }
}

