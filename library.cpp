#include <iostream>// to use cout and cin statement
#include <windows.h>//to use gotoxy() function
#include <conio.h>// to use getch() function
#include <limits>//to use cin.ignore to clear buffer
#include<vector>// to use dynamic arrays
#include<iomanip>//to use setw()
#include<fstream>//to read and write a file
#include<string>
using namespace std;

int count=0;
void Interface();
void header1();// prints main header
void gotoxy(int x, int y);
void header2();// prints header
int x = 50;
int y = 17;
string log_in_menu(); // show main menu
string sign_in_menu(); // to sign in as an admin or student
string sign_in_username(); // admin username
string sign_in_userpassword(); // admin password
string sign_up(); // registeration menu
void Student_login(); // students login menu
void sign_up_admin(int &admin, string &admin_user, string &admin_cnic,  string &admin_password); // sign up as an admin
void sign_up_student(string &stu_username ,string &stu_userpassword ,string &stu_CNIC); // sign up as a student
bool check_number(string check, int length); // to check whether a given number has required length or not
void for_string_length(int x_axis, int y_axis);// for string length
bool check_int(string check); // to check whether a string contains digit or not
void for_string_int(int x_axis, int y_axis); // to check that input must be in integers
bool check_repeatition(string input, string arr[], int index); 
void for_string_repeatition(int x_axis, int y_axis);// for repeated string
bool empty(string check);// for empty input
void NOstring(int x_axis, int y_axis);
void invalid_option();//for invalid input
string getField(string record, int field);
void writeAdmin(int &admin, string admin_user, string admin_cnic, string admin_password);
void readAdmin(int &admin, string &admin_user, string &admin_cnic, string &admin_password);
void writeStudent(vector<string>USER_NAME  , vector<string>USER_PASS, vector<string>CNIC);
void readStudent();
void writeBook(vector<string>AUTHOR_NAME  , vector<string>BOOK_TITLE, vector<string>BOOK_EDITION, vector<string>BOOK_ISBN, vector<string>STATUS);
void readBook();
void writeStudentInfo(vector<string>NAME1  , vector<string>NAME2, vector<string>AGE, vector<string>NUMBER, vector<string>GENDER);
void readStudentInfo();

void adminsMenu();// to show admins main menu
void addBook(); // to add books
void delBook(); // to delete books
void displayBooks(); // to display books
void BookUpdate(); // to update books
void borrowedBooks();// to view those students who have borrowed a book
void delUsersAccounts();// to delete users accounts
void displayaccounts(); // to view students username and passwords

void studentsMenu();// to show students main menu 
void displayBooksforStudent();// to display books 
void BorrowBook(); // to borrow a book
void displayBorrowedBook();// to check which book was borrowed
void studentsInfo();// to enter personal info
void DisplaypersonalInfo();// to display info


HANDLE h = GetStdHandle(STD_OUTPUT_HANDLE);//to change the color of specific output

 //ARRAYS TO STORE DATA;
vector<string>BOOK_NAME;
vector<string>BOOK_TITLE;
vector<string>AUTHOR_NAME;
vector<string>BOOK_EDITION;
vector<string>BOOK_ISBN;
vector<string>NAME1;
vector<string>NAME2;
vector<string>AGE;
vector<string>NUMBER;
vector<string>GENDER;
vector<string>BOOK_NAME1;
vector<string>AUTHOR_NAME1;
vector<string>ISBN1;
vector<string>USER_NAME;
vector<string>USER_PASS;
vector<string>CNIC;
vector<string>STATUS;
vector<string>BORROWED_BOOKS;
vector<string>READBOOKS;



main()
{
    //VARIABLES;
    string sign_in_menu_option;
    string sign_in_name="";
    string sign_in_password="";
    string sign_up_menu_option;
    string admin_user="";
    string admin_cnic="";
    string admin_password="";
    string forgot="";
    int admin=0;
    string choice;
    string stu_username , stu_userpassword , stu_CNIC;
    //ARRAYS;
    readAdmin(admin, admin_user, admin_cnic, admin_password);
    readStudent();
    readBook();
    readStudentInfo();


    
    system("cls");
    
      Interface();
    while (choice!="3")
    {
     
        choice = log_in_menu();
        if (choice == "2")
        {
           sign_in_menu_option=sign_in_menu();
           if(sign_in_menu_option=="1")
           {
            sign_in_name=sign_in_username();
            sign_in_password=sign_in_userpassword(); 
           

            if(sign_in_name==admin_user && sign_in_password==admin_password)//if sign up useername and password matches
            {
                  adminsMenu();
            }
           }       
           else if(sign_in_menu_option == "2")
           {
            Student_login();
           }
        }
       
        else if (choice == "1")
        {   
            sign_up_menu_option=sign_up();
            if(sign_up_menu_option=="1")
            {
                 sign_up_admin(admin,  admin_user, admin_cnic,  admin_password);
            }
            else if(sign_up_menu_option=="2")
            {
                sign_up_student(stu_username ,stu_userpassword ,stu_CNIC);
            }
        } 
        
         else if(choice=="3")
         {
            return 0;// end the program
         }       
      
        else
        {
            invalid_option();
        }
       
    }

}

void Interface()
{
  system("cls");
  
  gotoxy(25, 2);
  // Using setconsoletextAttribute to give different colors
     
                   SetConsoleTextAttribute(h, 7);                                                                                                        

   cout<<"     ***********************************************************************************************"<<endl;
     gotoxy(25, 3);

              SetConsoleTextAttribute(h, 9);                                                                                                        

   cout<<"     *                                  LIBRARY MANAGEMENT SYSTEM                                  *"<<endl;
     gotoxy(25, 4);

              SetConsoleTextAttribute(h, 7);                                                                                                        

   cout<<"     ***********************************************************************************************"<<endl;
                                                                                                      
                                                                                                                                                                                                    
           SetConsoleTextAttribute(h, 9);                                                                                                        
 cout<<"                                                                               ....                          "<<endl; 
            SetConsoleTextAttribute(h, 9);                                                                                                        
                
 cout<<"                                                ::::+ :-=:       ... .::       :====                  =**=   "<<endl;  
            SetConsoleTextAttribute(h, 9);                                                                                                        
                
 cout<<"                                                ::::: -==-.=*    .:. .:=***    .:---         :-=- ::-:.::.   "<<endl; 
            SetConsoleTextAttribute(h, 9);                                                                                                        
                 
 cout<<"                                                :-=== :.-:.==    ... :::***    .::::         .::: --===**=   "<<endl;
            SetConsoleTextAttribute(h, 9);                                                                                                        
                  
 cout<<"                                                -**** :.-:.=+    .:: ::::**    .::::.:.      .=+: ::::=+*=   "<<endl; 
            SetConsoleTextAttribute(h, 9);                                                                                                        
                 
 cout<<"                                                -**** :.-::=* *= ::: ::: ***   .::::.-:      .=+: ::::=**=   "<<endl;  
            SetConsoleTextAttribute(h, 9);                                                                                                        
                
 cout<<"                                                -**** :::.-** *= ...   .:: ***=  ::---.-.      .=+: ::::=**=   "<<endl; 
            SetConsoleTextAttribute(h, 9);                                                                                                        
                 
 cout<<"                                                -****:=+*=:=* *= ... =+= :**+::=+++* -.      .::: ::--:==:   "<<endl; 
            SetConsoleTextAttribute(h, 9);                                                                                                        
                 
 cout<<"                                                :****.::-:.==    ... .::..:::. .::::...:    ..:::.::-:=**-   "<<endl;
            SetConsoleTextAttribute(h, 10);                                                                                                        
                  
 cout<<"                                                :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::  "<<endl; 
            SetConsoleTextAttribute(h, 10);                                                                                                        

 cout<<"                                                -----------------------------------------------------------   "<<endl; 
            SetConsoleTextAttribute(h, 4);                                                                                                        
                
 cout<<"                                                           :::                               :::              "<<endl;
            SetConsoleTextAttribute(h, 4);                                                                                                        

 cout<<"                                                                                                             "<<endl;                  
 cout<<"                                                                                                             "<<endl;                  
 cout<<"                                                                                                             "<<endl;
            SetConsoleTextAttribute(h, 4);                                                                                                        

 cout<<"                                                                                                   .  :.     "<<endl; 
             SetConsoleTextAttribute(h, 4);                                                                                                        
                 
 cout<<"                                                                                                  .: :==     "<<endl; 
             SetConsoleTextAttribute(h, 4);                                                                                                        
                 
 cout<<"                                                      .:-==                                    ==..::==-     "<<endl; 
             SetConsoleTextAttribute(h, 4);                                                                                                        
                 
 cout<<"                                                    ..=**#*       .:: ==:    :......... .:.    .==:::=+- .   "<<endl; 
             SetConsoleTextAttribute(h, 4);                                                                                                        
                 
 cout<<"                                                   -=+:-=+=     .....:==: := =:::::*:+:::+--    ===::=-...   "<<endl;   
             SetConsoleTextAttribute(h, 4);                                                                                                        
               
 cout<<"                                                   .:::===+    ::::::*#*= -= +     %.*.         :==:-=::.    "<<endl; 
             SetConsoleTextAttribute(h, 4);                                                                                                        
                 
 cout<<"                                                    :::===+  ..:::.:+#*-  -+ = ::  +.+:: .      .:=:=:::     "<<endl;
             SetConsoleTextAttribute(h, 4);                                                                                                        
                  
 cout<<"                                                   .:::-==+ .::::: +**:      =-**=====+*=-      ::::::-:     "<<endl;
             SetConsoleTextAttribute(h, 4);                                                                                                        
                  
 cout<<"                                                   -=+=+*** ::::. .-*=     -*==**********:      .::::::.     "<<endl;
             SetConsoleTextAttribute(h, 4);                                                                                                        
                  
 cout<<"                                                    .. ==++  ...  .-:      =*==##########:       .:::::.     "<<endl; 
             SetConsoleTextAttribute(h, 9);                                                                                                        
                 
 cout<<"                                                ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::   "<<endl;
             SetConsoleTextAttribute(h, 10);                                                                                                        
                  
 cout<<"                                                ----------------------------------------------------------    "<<endl;  

                    SetConsoleTextAttribute(h, 10);                                                                                                        
                                                                                             
                                                                                                    
  cout<<"                        @--------------------------------------------------------------------------------------------------------@      "<<endl;                                                                                                  
                                                                                                 
                                                                                                    
   gotoxy(1 , 35);
   cout<<"Press any key to continue..."; 
   getch(); //Do not go to another function until user presses  any button
                                                                                                          
}
void header1()
{
    SetConsoleTextAttribute(h,6);
      
cout<<"                            __        ______  _______   _______    ______   _______  __      __        __       __   ______                 "<<endl;
cout<<"                           |  \\      |      \\|       \\ |       \\  /      \\ |       \\|  \\    /  \\      |  \\     /  \\ /      \\     "<<endl;
cout<<"                           | $$       \\$$$$$$| $$$$$$$\\| $$$$$$$\\|  $$$$$$\\| $$$$$$$\\$$\\  /  $$      | $$\\   /  $$|  $$$$$$\\        "<<endl;
cout<<"                           | $$        | $$  | $$__/ $$| $$__| $$| $$__| $$| $$__| $$ \\$$\\/  $$       | $$$\\ /  $$$| $$___\\$$           "<<endl;
cout<<"                           | $$        | $$  | $$    $$| $$    $$| $$    $$| $$    $$  \\$$  $$        | $$$$\\  $$$$ \\$$    \\            "<<endl;
cout<<"                           | $$        | $$  | $$$$$$$\\| $$$$$$$\\| $$$$$$$$| $$$$$$$\\   \\$$$$         | $$\\$$ $$ $$ _\\$$$$$$\\        "<<endl;
cout<<"                           | $$_____  _| $$_ | $$__/ $$| $$  | $$| $$  | $$| $$  | $$   | $$          | $$ \\$$$| $$|  \\__| $$             "<<endl;
cout<<"                           | $$     \\|   $$ \\| $$    $$| $$  | $$| $$  | $$| $$  | $$   | $$          | $$  \\$ | $$ \\$$    $$           "<<endl;
cout<<"                            \\$$$$$$$$ \\$$$$$$ \\$$$$$$$  \\$$   \\$$ \\$$   \\$$ \\$$   \\$$    \\$$           \\$$      \\$$  \\$$$$$$   "<<endl;
cout<<"                           ____________________________________________________________________________________________________             "<<endl;

}

void header2()
{
    SetConsoleTextAttribute(h,2);

  cout<<"                               ***************************************************************************************"<<endl;
      SetConsoleTextAttribute(h,7);

  cout<<"                               |                                     Welcome to the                                  |"<<endl;
      SetConsoleTextAttribute(h,7);

  cout<<"                               |                              (LIBRARY MANAGEMENT SYSTEM)                            |"<<endl;
      SetConsoleTextAttribute(h,2);
    
  cout<<"                               ***************************************************************************************"<<endl;

}
void gotoxy(int x, int y)//for printing text on specific location on console
{
    COORD coordinates;
    coordinates.X = x;
    coordinates.Y = y;
    SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coordinates);
}
string log_in_menu() 
{

    system("cls");//clears screen
    header1();
    header2();
     SetConsoleTextAttribute(h , 9);

    string option;
    gotoxy(x, y);
    cout << "|Press 1 to REGISTER yourself...   |" << endl;
    gotoxy(x, y + 1);
    cout << "|Press 2 to LOGIN...               |" << endl;

    gotoxy(x, y + 2);
    cout << "|Press 3 to EXIT...                |" << endl ;
   
    gotoxy(x, y + 4);
    cout << " Please enter your choice: ";
    cin >> option;

    return option;
}
string sign_in_menu()
{   
    string sign_in_menu_option;
    system("cls");
    header1();
    SetConsoleTextAttribute(h , 9);

    gotoxy(x, y);
    cout<<"You want to sign_IN as a: ";
    gotoxy(x, y+1);
    cout<<"1. ADMIN";
    gotoxy(x, y+2);
    cout<<"2. STUDENT";
    gotoxy(x, y+4);
    cout<<"Enter your option: ";
    cin >> sign_in_menu_option;

    return sign_in_menu_option;    
}
  
string sign_in_username()
{
    cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');//clear buffer
    system("cls");
    header1();
    string a; 
    //if user gives no input then take the input again using while loop

 while(1)
  {
    gotoxy(x, y);
    SetConsoleTextAttribute(h , 7);

    cout<<"Enter USERNAME: ";
    getline(cin, a);

    if(empty(a)==1)
     {
        NOstring(x , y+4);
     }
    
     else
     {
        break;
     }

   }
    return a;
}

string sign_in_userpassword()
{
    string b;
    SetConsoleTextAttribute(h ,7);

while(1)
{
    gotoxy(x, y+2);
    cout<<"Enter PASSWORD: ";
    getline(cin, b);

    if(empty(b)==1)
     {
        NOstring(x , y+4);
     }
     else
     {
        break;
     }
    
}
    return b;
}

void Student_login()

{
    cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');//clear buffer

    system("cls");
    header1();
      SetConsoleTextAttribute(h ,7);

    
    string e , f;
     while(1)
      {
        gotoxy(x, y);
        cout<<"Enter USERNAME: ";
        getline(cin, e);
    
        if(empty(e)==1)
         {
            NOstring(x , y+4);
         }
         else
         {
            break;
         }
    
       }
   
 while(1)
  {
 
    gotoxy(x, y+6);
    cout<<"Enter PASSWORD: ";
    getline(cin, f);

    if(empty(f)==1)
     {
        NOstring(x , y+7);
     }
     else
     {
        break;
     }

   }

bool found_name = false;
//to check  that username has been found
for (int i = 0; i < USER_NAME.size(); i++) 
{
    if (e == USER_NAME[i] && f == USER_PASS[i]) {
        found_name = true;
        studentsMenu();
        break; 
    }
}

if (!found_name) 
{
    gotoxy(x , y+9);
    SetConsoleTextAttribute(h ,4);

    cout<<"Error:Enter correct username and password.";
    getch();
    log_in_menu();
}
}
string sign_up()
{

    string option;
    system("cls");
    header1();
    SetConsoleTextAttribute(h ,9);

    gotoxy(x, y);
    cout<<"1. PRESS 1 to sign_up as an ADMIN.";
    gotoxy(x, y+1);
    cout<<"2. PRESS 2 to sign_up as a STUDENT.";
    gotoxy(x, y+3);
    cout << "Enter your choice...";
    cin>>option;
    return option;
    
}
void writeAdmin(int &admin, string admin_user, string admin_cnic, string admin_password)
{
    fstream line;
    line.open("OwnerSignUp.txt", ios::out);
    line<<admin_user<<","<<admin_cnic<<","<<admin_password<<endl;
    line.close();
}
void readAdmin(int &admin, string &admin_user, string &admin_cnic, string &admin_password)
{
    fstream line;
    string record;
    line.open("OwnerSignUp.txt", ios::in);
    for(int i=0; i<1; i++)
    {
    getline(line, record);
    if(record=="")
    {
        break;
    }
    admin_user=getField(record, 1);
    admin_cnic=getField(record, 2);
    admin_password=getField(record, 3);
    admin++;
    }
}
void sign_up_admin(int &admin,  string &admin_user, string &admin_cnic,  string &admin_password)
{   
  
    cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
    system("cls");
    header1();
      SetConsoleTextAttribute(h ,10);

    if(admin==1)//if admin is trying to register again
    {   
       
        gotoxy(x, y);
        cout<<"ADMIN has already signed up.";
        gotoxy(x, y+1);
        cout<<"PRESS any key to continue....";
        getch();

    }
     if(admin==0)//if admin is new
    {
    
    while(true)
    {
    gotoxy(x, y);
    cout<<"Enter USERNAME: ";
    //cin.ignore();
    getline(cin, admin_user);
    if(empty(admin_user)==1)
    {
        NOstring(x, y+2);
    }
    else
    {
        break;
    }
    }
    while(true)
    {
    gotoxy(x, y+4);
    cout<<"Enter admin's CNIC(length must be 13 digits without any spaces): ";
    getline(cin, admin_cnic);

    if(empty(admin_cnic)==1)
    {
        NOstring(x, y+5);
    }
    else if(check_number(admin_cnic, 13)==1)
    {
        for_string_length(x, y+9);
    }
    else if(check_int(admin_cnic)==1)
    {
        for_string_int(x, y+7);
    }
    else
    {
        break;
    }
    }
    
    while(true)
    {
    gotoxy(x, y+11);
    cout<<"Enter PASSWORD: ";
    getline(cin, admin_password);//using getline to take inputs having space
    if(empty(admin_password)==1)
    {
        NOstring(x, y+12);
    }
    else
    {
        break;
    }
    }
    admin++;
    writeAdmin(admin, admin_user, admin_cnic, admin_password);
    }
      
}   

 void sign_up_student(string &stu_username ,string &stu_userpassword ,string &stu_CNIC)
{

    cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');//to clear buffer
    system("cls");
    header1();
  SetConsoleTextAttribute(h ,9);

    while(true)
    {
    gotoxy(x, y);
    cout << "Enter your USERNAME: ";
    getline(cin, stu_username);

     if(empty(stu_username)==1)
    {
       NOstring(x, y+2);
    } 
    else
    {
        break;
    }
    
    }
    while(true)
    {
    gotoxy(x, y + 4);
    cout << "Enter your PASSWORD: ";
    getline(cin, stu_userpassword);
    if(empty(stu_userpassword)==1)
    {
        NOstring(x, y+5);
    }
    else
    {
        break;
    }
    }

    while(true)
    {
    gotoxy(x, y + 7);
    cout << "Enter your CNIC(13 digits without spaces): ";
    getline(cin, stu_CNIC);

    if(empty(stu_CNIC)==1)
    {
        NOstring(x, y+8);
    }
     else if(check_number(stu_CNIC, 13)==1)
    {
        for_string_length(x, y+9);
    }
    else if(check_int(stu_CNIC)==1)
    {
        for_string_int(x, y+11);
    }
    
    else
    {
        break;
    }
    }
    for(int i =0 ; i<USER_NAME.size() ; i++)
    {
       if(stu_username == USER_NAME[i] || stu_userpassword == USER_PASS[i])
       {
        SetConsoleTextAttribute(h, 4);
        gotoxy(x, y+10);
        cout<<"This username or password is already taken.";
        getch();
       }
    }//storing data in the arrays
   USER_NAME.push_back(stu_username);
   USER_PASS.push_back(stu_userpassword);
   CNIC.push_back(stu_CNIC);
   writeStudent(USER_NAME, USER_PASS, CNIC);

  
}
void writeStudent(vector<string>USER_NAME  , vector<string>USER_PASS, vector<string>CNIC)
{
    fstream line;
    line.open("StudentSignUp.txt", ios::out);
    for(int i=0; i<USER_NAME.size(); i++)
    {
    line<<USER_NAME[i]<<","<<USER_PASS[i]<<","<<CNIC[i]<<endl;
    }
    line.close();
}
void readStudent()
{
    fstream line;
    string record;
    line.open("StudentSignUp.txt", ios::in);
    while(!(line.eof()))
    {
    getline(line, record);
    if(record.empty())
    {
        break;
    }
   USER_NAME.push_back(getField(record, 1));
   USER_PASS.push_back(getField(record, 2));
   CNIC.push_back(getField(record, 3));

    }
}

void writeStudentsfile(string &stu_username ,string &stu_userpassword ,string &stu_CNIC)
{
    char a = ',';
    fstream studentFile;
    studentFile.open("studentsInfo.txt", ios:: out);
    studentFile << stu_username << a << stu_userpassword << a << stu_CNIC;
    studentFile.close();
}

bool check_number(string check, int length)//to check the length of entered input
{

    if (check.size() != length)
    {
        return 1;   
    }
    return 0;
}
bool check_int(string check)
{
    for (int i = 0; check[i] != '\0'; i++)
    {

        int b = check[i];
        if (b != 48 && b != 49 && b != 50 && b != 51 && b != 52 && b != 53 && b != 54 && b != 55 && b != 56 && b != 57)
        {
            return 1;
        }
    }
    return 0;
}
bool check_repeatition(string input, string arr[], int index)
{
    //if input is repeated
    for (int i = 0; i < index; i++)
    {
        
        if (input == arr[i] )
        {  
            return 1;
        }
    }
    return 0;
}
bool empty(string check)
{
    if (check == "")//if user enters no input
    {
        return 1;
        
    }
    return 0;
}

void spacesError(int x, int y)
{
    system("cls");
    header1();
    SetConsoleTextAttribute(h, 4);
    cout<<"Enter inputs without spacing.";
    getch();
}
//Different validations
void NOstring(int x_axis, int y_axis)
{

        gotoxy(x_axis, y_axis);
        cout<<"Please Enter some input. ";
        gotoxy(x_axis, y_axis+1);
        cout<<"Press any key to continue....";
        getch();
}      
void for_string_repeatition(int x_axis, int y_axis)
{

            gotoxy(x_axis, y_axis);
            cout << "Sorry, but that input has already been claimed.                  " << endl;
            gotoxy(x_axis, y_axis+1);
            cout << "Press any key to continue...";
            getch();
          
}
void for_string_length(int x_axis, int y_axis)
{

        gotoxy(x_axis, y_axis);
        cout << "The specified length is not accurate. Please try again.                " << endl;
        gotoxy(x_axis, y_axis+1);
        cout << "Press any key to continue....";
         getch();
        
}
void for_string_int(int x_axis, int y_axis)
{
          gotoxy(x_axis, y_axis);
          cout <<"Input must be in integers.                                                                ";
          gotoxy(x_axis, y_axis + 1);
          cout <<"Press any key to continue....";
          getch();       
}

void forInt(int x_axis , int y_axis)
{

    gotoxy(x_axis ,y_axis);
    cout<<"Please enter an integer.";
    getch();

}
void invalid_option()
{

     system("cls");
     header1();
     SetConsoleTextAttribute(h, 4);
     gotoxy(x, y);
     cout << "Please choose the option that are given." << endl;
     gotoxy(x, y+1);
     cout << "Press any key to continue...";
     getch();
   
}

//Admin Menu
void adminsMenu()
{
   system("cls");
   header1();

   string choice2;
    SetConsoleTextAttribute(h ,9);

   gotoxy(x , y);
   cout<<"|Press 1 to add a book & atricle...                      |"<<endl;
   gotoxy(x , y+1);
   cout<<"|Press 2 to delete a book & article...                   |"<<endl;
   gotoxy(x , y+2);
   cout<<"|Press 3 to display books...                             |"<<endl;
   gotoxy(x, y+3);
   cout<<"|Press 4 to update a book...                             |"<<endl;
   gotoxy(x , y+4);
   cout<<"|Press 5 to view those students who have borrowed a book.|"<<endl;
   gotoxy(x  , y+5);
   cout<<"|Press 6 to delete users accounts..                      |"<<endl;
   gotoxy(x , y+6);
   cout<<"|Press 7 to view students accounts..                     |"<<endl;
   gotoxy(x, y+7);
   cout<<"|Press 8 to go back to main menu...                      |"<<endl;
     SetConsoleTextAttribute(h ,9);

   gotoxy(x , y+9);
   cout<<" Please enter your choice: ";

   cin>>choice2;
   // using else if to go to entered option

    if(choice2 == "1")
    {
        addBook();
    }

   else if(choice2 == "2")
    {
        delBook();
    }

   else  if(choice2 == "3")
    {
        displayBooks();
    }

   else if(choice2 == "4")
    {
        BookUpdate();
    }

   else if(choice2 == "5")
    {
        borrowedBooks();
    }
    else if (choice2 == "6")
    {
        delUsersAccounts();
    }
    else if(choice2 == "7")
    {
        displayaccounts();
    }
     else if(choice2 == "8")
    {
        log_in_menu();
    }
   else if(choice2 != "1" || choice2 != "2" || choice2 != "3" || choice2 != "4" || choice2 != "5" || choice2 != "6" || choice2 != "7" || choice2 != "8")
    {
      invalid_option();
    }    
}
void addBook()
{

    cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
    system("cls");
    header1();
      SetConsoleTextAttribute(h ,8);

    string  title ,author ,edition ,ISBN ,status;
    

    while(1)
    {
        gotoxy(x , y+1);
        cout<<"Enter the book title: ";
        getline(cin , title);

        if(empty(title) == 1)
        {
            NOstring(x , y+2);
        }
        else{

           break;
        }
    }

    while(1)
    {
        gotoxy(x , y+4);
        cout<<"Enter the name of AUTHOR: ";
        getline(cin , author);

        if(empty(author) == 1)
        {
            NOstring(x , y+5);
        }

        else{

           break;
        }
    }
    while(1)
    {
        gotoxy(x , y+7);
        cout<<"Enter the book edition: ";
        getline(cin , edition);

        if(empty(edition) == 1)
        {
            NOstring(x , y+8);
        }

        else{

           break;
        }
    }
    while(1)
    {
        gotoxy(x , y+10);
        cout<<"Enter the book ISBN: ";
        getline(cin , ISBN);

        if(empty(ISBN) == 1)
        {
            NOstring(x , y+11);
        }

        else{

           break;
        }
    }
    while(1)
    {
        gotoxy(x , y+14);
        cout<<"Enter the status (available): ";
        getline(cin , status);
        
        if(empty(status) == 1)
        {
            NOstring(x , y+15);
        }
        
        else{

           break;
        }
    }

  SetConsoleTextAttribute(h ,10);

    gotoxy(x , y+19);
    cout<<"Thanks for adding a book....";

     //adding data in arrays
    AUTHOR_NAME.push_back(author);
    BOOK_TITLE.push_back(title);
    BOOK_EDITION.push_back(edition);
    BOOK_ISBN.push_back(ISBN);
    STATUS.push_back(status);

    writeBook(AUTHOR_NAME  , BOOK_TITLE, BOOK_EDITION, BOOK_ISBN, STATUS);

     getch();
    adminsMenu();
    
   
}
void writeBook(vector<string>AUTHOR_NAME  , vector<string>BOOK_TITLE, vector<string>BOOK_EDITION, vector<string>BOOK_ISBN, vector<string>STATUS)
{
    fstream line;
    line.open("BOOK.txt", ios::out);
    for(int i=0; i<AUTHOR_NAME.size(); i++)
    {
    line<<AUTHOR_NAME[i]<<","<<BOOK_TITLE[i]<<","<<BOOK_EDITION[i]<<","<<BOOK_ISBN[i]<<","<<STATUS[i]<<endl;
    }
    line.close();
}
void readBook()
{
    fstream line;
    string record;
    line.open("BOOK.txt", ios::in);
    while(!(line.eof()))
    {
    getline(line, record);
    if(record.empty())
    {
        break;
    }
    AUTHOR_NAME.push_back(getField(record, 1));
    BOOK_TITLE.push_back(getField(record, 2));
    BOOK_EDITION.push_back(getField(record, 3));
    BOOK_ISBN.push_back(getField(record, 4));
    STATUS.push_back(getField(record, 5));

    }
}
void delBook()
{
    cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');//to get accurate input using getline
    system("cls");
    header1();
    SetConsoleTextAttribute(h ,10);

    string  title1 , author1 , edition1 , ISBN1 , status1;

    while(1)
    {
        gotoxy(x , y+3);
        cout<<"Enter the book title: ";
        getline(cin , title1);

        if(empty(title1) == 1)
        {
            NOstring(x , y+4);
        }
        else{

           break;
        }
    }
    while(1)
    {
        gotoxy(x , y+6);
        cout<<"Enter the name of AUTHOR: ";
        getline(cin , author1);

        if(empty(author1) == 1)
        {
            NOstring(x , y+7);
        }

        else{

           break;
        }
    }

    while(1)
    {
        gotoxy(x , y+9);
        cout<<"Enter the book edition: ";
        getline(cin , edition1);

        if(empty(edition1) == 1)
        {
            NOstring(x , y+10);
        }

        else{

           break;
        }
    }
    while(1)
    {
        gotoxy(x , y+12);
        cout<<"Enter the book ISBN: ";
        getline(cin , ISBN1);

        if(empty(ISBN1) == 1)
        {
            NOstring(x , y+13);
        }
        else{

           break;
        }
    }
    while(1)
    {
        gotoxy(x , y+15);
        cout<<"Enter the book status: ";
        getline(cin , status1);

        if(empty(status1) == 1)
        {
            NOstring(x , y+16);
        }
        else{

           break;
        }
    }

    bool found = false;//making a bool variable to delete a book

    for(int i=0 ; i<BOOK_TITLE.size() ; i++)
    {
         gotoxy(x , y+17);
        if( author1 == AUTHOR_NAME[i] && title1 == BOOK_TITLE[i] && edition1 == BOOK_EDITION[i] && ISBN1 == BOOK_ISBN[i] && status1 == STATUS[i])
        {
                //deleting data
             STATUS.erase(STATUS.begin() + i); 
             BOOK_TITLE.erase(BOOK_TITLE.begin() + i);
             AUTHOR_NAME.erase(AUTHOR_NAME.begin() + i);
             BOOK_EDITION.erase(BOOK_EDITION.begin() + i);
             BOOK_ISBN.erase(BOOK_ISBN.begin() + i);
             found = true;
             SetConsoleTextAttribute(h ,9);

             cout<<"Your book has been deleted.";
             getch();
             adminsMenu();
             break;
        }
    }
        gotoxy(x ,y+17);
    if(!found)//if book does not find
    {
          SetConsoleTextAttribute(h ,9);
        cout<<"Firstly, You have to add the book. Press any key.";
        getch();
        adminsMenu();
    }   
}

void displayBooks()
{
    system("cls");
    //Displaying books data in the table form 
      SetConsoleTextAttribute(h ,9);

    cout << "\t\t\t\t\t\t\t\tSTORED BOOKS DATA" << endl
         << endl;
        SetConsoleTextAttribute(h ,7);


    cout <<"\t\t\t\tTITLE" << setw(20) << "AUTHOR NAME" << setw(20) << "ISBN" << setw(20) << "EDITION" << setw(20) <<  "STATUS" <<endl
         << endl;

    bool found_books = false;
    for (int i = 0; i < BOOK_TITLE.size(); i++)
    {
          SetConsoleTextAttribute(h ,10);

        cout <<"\t\t\t\t" << BOOK_TITLE[i] << setw(20) << AUTHOR_NAME[i] << setw(20) << BOOK_ISBN[i] << setw(20) << BOOK_EDITION[i] << setw(20) << STATUS[i]<< endl
             << endl;
        found_books = true;
    }

    gotoxy(x, y + 19);
       //ti find that whether the books are added in admin's menu or not
    if (!found_books)
    {
      SetConsoleTextAttribute(h ,4);
        cout << "No books yet! Please add a book.";
    }
    else
    {
      SetConsoleTextAttribute(h ,10);
        cout << "Press any key to continue..";
    }
  getch();
  adminsMenu();

}

void BookUpdate()
{
    //when admin wants to update the book
    cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');//to get accurate input using getline
    system("cls");
    header1();

    string BookTitle ,Edition ;
    SetConsoleTextAttribute(h ,9);

    while(1)
    {
        gotoxy(x , y);
        cout<<"Enter the title of the book that you want to update: ";
        getline(cin , BookTitle);

        if(empty(BookTitle) == 1)
        {
            NOstring(x , y+1);
        }

        else{

           break;
        }
    }
    while(1)
    {
        gotoxy(x , y+3);
        cout<<"Enter the updated book edition: ";
        getline(cin , Edition);

        if(empty(Edition) == 1)
        {
            NOstring(x , y+4);
        }

        else{

           break;
        }
    }
    bool title_found = false;
    //find a book in the array and change the it's title at that index
    for(int i=0 ; i<BOOK_TITLE.size() ; i++)
    {
        if(BookTitle == BOOK_TITLE[i])
        {
            BOOK_EDITION[i] = Edition;
            title_found = true;
            break;// if book found , break the loop
        }
    }

    gotoxy(x , y+6);

    if(!title_found)
    {
              SetConsoleTextAttribute(h ,4);
       cout<<"Please Enter correct title."; 
    }
    else
    {
              SetConsoleTextAttribute(h ,10);
        cout<<"Press any key to continue.."; 
    }
    getch();
    adminsMenu();
}

void borrowedBooks()
{
    //displaying borrowed books data to the admin
  system("cls");
    SetConsoleTextAttribute(h ,9);

      cout << "\t\t\t\t\t\t\t\tBORROWED BOOKS DATA" << endl << endl;
  bool borrowedbook = false;
    SetConsoleTextAttribute(h ,7);

      cout<<"\t\t\t\t\t\t\tUSER_NAME"<< setw(25) << "BORROWED_BOOKS"<<endl <<  endl;
  for(int i=0 ; i<USER_NAME.size() ; i++)
  {
    if(BORROWED_BOOKS[i] != " ")
    {
          SetConsoleTextAttribute(h ,10);

        cout<<"\t\t\t\t\t\t\t" <<USER_NAME[i] << setw(25) << BORROWED_BOOKS[i]<<endl<<endl;
        borrowedbook = true;
        
    }
  }
  
  gotoxy(x , y+16);

  if(!borrowedbook)
  {
        SetConsoleTextAttribute(h ,4);
    cout<<"NO BOOKS BORROWED YET.";

  }
  else
  {
        SetConsoleTextAttribute(h ,10);
      cout<<"Press any key to continue";
  }
  getch();
  adminsMenu();
}

void delUsersAccounts()
{
    //deleting user_accounts
    cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');//to get accurate input using getline
    system("cls");
    header1();

    string Studentusername , Studentpassword;
      SetConsoleTextAttribute(h ,12);

   while(1)
    {
        gotoxy(x , y);
        cout<<"Enter the students username: ";
        getline(cin , Studentusername);

        if(empty(Studentusername) == 1)
        {
            NOstring(x , y+1);
        }

        else{

           break;
        }
    }
    
   while(1)
    {
        gotoxy(x , y+3);
        cout<<"Enter the students password: ";
        getline(cin , Studentpassword);

        if(empty(Studentpassword) == 1)
        {
            NOstring(x , y+4);
        }

        else{

           break;
        }
    }

    bool found_account = false;
    //using for loop to find the account at specific index in the array and delete it

    for(int i=0 ; i<USER_NAME.size() ; i++)
    {
        if(Studentusername == USER_NAME[i] && Studentpassword == USER_PASS[i])
        {
            USER_NAME.erase(USER_NAME.begin() + i);
            USER_PASS.erase(USER_PASS.begin() + i);

            found_account = true;

             gotoxy(x , y+10);
             cout<<"This account has been deleted.";
             getch();
             adminsMenu();
             break;
        }
    }
    gotoxy(x , y+9);
      SetConsoleTextAttribute(h ,4);

    if(!found_account)
    {
      cout<<"This account does not exist.";
      getch();
      adminsMenu();
    }

}

void displayaccounts()
{
    //show user accounts to admin
    
    system("cls");
      SetConsoleTextAttribute(h ,9);

    cout << "\t\t\t\t\tUSER ACCOUNTS" << endl
         << endl;
         SetConsoleTextAttribute(h ,7);
                                                  //using setw()to give spaces
    cout <<"\t\t\t\t"<< "USERNAME" << setw(20) << "PASSWORDS"  <<endl
         << endl;

    bool found_user = false;
    for (int i = 0; i < USER_NAME.size(); i++)
    {
          SetConsoleTextAttribute(h ,10);

        cout <<"\t\t\t\t"<< USER_NAME[i] << setw(20) << USER_PASS[i] << endl
             << endl;
        found_user = true;
    }

    gotoxy(x, y + 16);

    if (!found_user)
    {
          SetConsoleTextAttribute(h ,4);
        cout << "No accounts yet!.";
    }
    else
    {
                  SetConsoleTextAttribute(h ,10);
        cout << "Press any key to continue..";
    }
   getch();
   adminsMenu();
}

void studentsMenu()
{
  system("cls");
   header1();

   string choice3;
     SetConsoleTextAttribute(h ,9);

   gotoxy(x , y);
   cout<<"|Press 1 to view BOOKS...                  |"<<endl;
   gotoxy(x , y+1);
   cout<<"|Press 2 to borrow a book                  |"<<endl;
   gotoxy(x , y+2);
   cout<<"|Press 3 to display borrowed books...      |"<<endl;
   gotoxy(x , y+3);
   cout<<"|Press 4 to Enter personal information..   |"<<endl;
   gotoxy(x , y+4);
   cout<<"|Press 5 to display personal information...|"<<endl;
   gotoxy(x , y+5);
   cout<<"|Press 6 to go back to Main Menu...        |"<<endl<<endl;
   gotoxy(x  , y+7);
   cout<<" Please enter your choice: ";

   cin>>choice3;
   //using else if to go to entered option

   if(choice3 == "1")
   {
     displayBooksforStudent();
   }
   else if (choice3 == "2")
   {
    BorrowBook();
   }
   else if(choice3 == "3")
   {
     displayBorrowedBook();
   }
   else if(choice3 == "4")
   {
      studentsInfo();
   }
   else if(choice3 == "5")
   {
     DisplaypersonalInfo();
   }
   else if(choice3 == "6")
   {
    log_in_menu();
   }
    else if(choice3 != "1" || choice3 != "2" || choice3 != "3" || choice3 != "4" || choice3 != "5" || choice3 != "6")
    {
      invalid_option();
    }

}


void displayBooksforStudent()
{
    //diplay books for students so that they may borrow
    system("cls");
      SetConsoleTextAttribute(h ,9);

    cout << "\t\t\t\t\t\t\t\tSTORED BOOKS DATA" << endl
         << endl;
  SetConsoleTextAttribute(h ,7);

    cout <<"\t\t\t"<< "  AUTHOR NAME" << setw(20) << "ISBN" << setw(20) << "EDITION" << setw(20) << "TITLE" << setw(20) << setw(20)<< "STATUS" <<endl
         << endl;

    bool found2 = false;
    for (int i = 0; i < BOOK_TITLE.size(); i++)
    {
          SetConsoleTextAttribute(h ,10);

        cout <<"\t\t\t\t"<< AUTHOR_NAME[i] << setw(20) << BOOK_ISBN[i] << setw(20) << BOOK_EDITION[i] << setw(20) << BOOK_TITLE[i] << setw(20) << STATUS[i]<< endl
             << endl;
        found2 = true;
    }

    gotoxy(x, y + 18);
    if (!found2)
    {
          SetConsoleTextAttribute(h ,4);
        cout << "No books yet!";
    }
    else
    {
        SetConsoleTextAttribute(h ,10);
        cout << "Press any key to continue..";
    }
    getch();
    studentsMenu();
}

void BorrowBook()
{
    //borrow a book
    system("cls");
    header1();

   string title_input; bool book = false;

   while(1)
    {
         cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');//clear buffer

        gotoxy(x , y);
        cout<<"Enter the book title: ";
        getline(cin , title_input);

        if(empty(title_input) == 1)
        {
            NOstring(x , y+1);
        }

        else{

           break;
        }
    }
   
   for(int i =0  ; i<BOOK_TITLE.size() ; i++)
   {
    if(title_input == BOOK_TITLE[i])
    {
        STATUS[i] = "CHECKED OUT";//if student borrow a book then convert this status to available to CHECKED OUT
        book = true;
        BORROWED_BOOKS.push_back(title_input);
        break;
    }
   }
    gotoxy(x , y+7);
   if(!book)
   {
    SetConsoleTextAttribute(h ,4);
     cout<<"This book is not present in library.";
   } 
   else
   {
    SetConsoleTextAttribute(h ,10);
    cout<<"You have borrowed a book.";
   }
   getch();
   studentsMenu();
}

void displayBorrowedBook()
{
    //TO CHECK WHICH BOOK WAS BORROWED BY A STUDENT
    system("cls");
    header1();
     string name; bool find_user = false;
  SetConsoleTextAttribute(h ,7);

  
    
    while(1)
    {
       cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');//clear buffer

        gotoxy(x , y+3);
        cout<<"Enter your username: ";
        getline(cin , name);

        if(empty(name) == 1)
        {
            NOstring(x , y+4);
        }

        else{

           break;
        }
    }
   
    for(int i=0 ; i<BOOK_ISBN.size() ; i++)
    {
     gotoxy(x , y+7);
       
         if(name == USER_NAME[i])
        {
            cout<<"Borrowed book is: "<<BORROWED_BOOKS[i];
            find_user = true;
        }    
    }
   
    gotoxy(x ,y+9);
      SetConsoleTextAttribute(h ,5);

    if(!find_user)
    {
        SetConsoleTextAttribute(h ,4);
      cout<< "Please Enter correct username.";
    }
    else
    {
        SetConsoleTextAttribute(h ,10);
         cout<<"Press any key to continue.";
    }
    getch();
    studentsMenu();
}

void studentsInfo()

{
    //student's information

    cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
    system("cls");
    header1();
      
     string name1 , name2 ,  age , number , gender ; 
  SetConsoleTextAttribute(h ,6);

    while(1)
    {
        gotoxy(x , y);
        cout<<"Enter your First name: ";
        getline(cin , name1);

        if(empty(name1) == 1)
        {
            NOstring(x , y+1);
        }

        else{

           break;
        }
    }

    while(1)
    {
        gotoxy(x , y+3);
        cout<<"Enter your last name: ";
        getline(cin , name2);

        if(empty(name2) == 1)
        {
            NOstring(x , y+4);
        }

        else{

           break;
        }
    }

    while(1)
    {
        gotoxy(x , y+6);
        cout<<"Enter your age (years): ";
        getline(cin , age);

        if(empty(age) == 1)
        {
            NOstring(x , y+7);
        }

        else{

           break;
        }
    }

    while(1)
    {
        gotoxy(x , y+9);
        cout<<"Enter your mobile number: ";
        getline(cin , number);

        if(empty(number) == 1)
        {
            NOstring(x , y+10);
        }
        else if(check_number(number, 11)==1)
        {
        for_string_length(x, y+12);
        }
        else if(check_int(number)==1)
        {
        for_string_int(x, y+14);
        }

        else{

           break;
        }
    }


    while(1)
    {
        gotoxy(x , y+16);
        cout<<"Enter your gender: ";
        getline(cin , gender);

        if(empty(gender) == 1)
        {
            NOstring(x , y+17);
        }

        else{

           break;
        }
    }
//storing indormation in the arrays
    NAME1.push_back(name1);
    NAME2.push_back(name2);
    AGE.push_back(age);
    NUMBER.push_back(number);
    GENDER.push_back(gender);


    gotoxy(x , y+18);
    cout<<"Thanks for entering the information. Press any key to proceed.";
    writeBook(NAME1  , NAME2, AGE, NUMBER, GENDER);
    getch();
    studentsMenu();

}
void writeStudentInfo(vector<string>NAME1  , vector<string>NAME2, vector<string>AGE, vector<string>NUMBER, vector<string>GENDER)
{
    fstream line;
    line.open("BOOK.txt", ios::out);
    for(int i=0; i<AUTHOR_NAME.size(); i++)
    {
    line<<NAME1[i]<<","<<NAME2[i]<<","<<AGE[i]<<","<<NUMBER[i]<<","<<GENDER[i]<<endl;
    }
    line.close();
}
void readStudentInfo()
{
    fstream line;
    string record;
    line.open("BOOK.txt", ios::in);
    while(!(line.eof()))
    {
    getline(line, record);
    if(record.empty())
    {
        break;
    }
    NAME1.push_back(getField(record, 1));
    NAME2.push_back(getField(record, 2));
    AGE.push_back(getField(record, 3));
    NUMBER.push_back(getField(record, 4));
    GENDER.push_back(getField(record, 5));

    }
}


void DisplaypersonalInfo()

{
    //displaying students information
     system("cls");
     SetConsoleTextAttribute(h ,9);

     cout<<"\t\t\t\t\t\t\t\tPERSONAL DATA"<<endl<<endl;
  SetConsoleTextAttribute(h ,7);

     cout<<"\t\t\t\tGENDER"<<setw(20)<<"NAME"<<setw(20)<<"LAST_NAME"<<setw(20)<<"AGE"<<setw(20)<<"PH.no."<<endl<<endl;

     bool found_info = false;
     for(int i=0 ; i<GENDER.size() ; i++)
     {
          SetConsoleTextAttribute(h ,10);

       cout<<"\t\t\t\t"<< GENDER[i] << setw(20) <<NAME1[i]<<setw(20)<<NAME2[i]<<setw(20)<<AGE[i]<<setw(24)<<NUMBER[i]<<endl<<endl;
      found_info = true;
    
     }

      gotoxy(x , y+19);
     if(!found_info)
     {
        SetConsoleTextAttribute(h ,4);
      cout<<"No Informaion yet! Press any key.";
     }
     else
     {
        SetConsoleTextAttribute(h ,10);
        cout<<"Press any key to continue.";
     }
     getch();
     studentsMenu();
}
string getField(string record, int field)
{
int commaCount = 1;
string item;
for (int x = 0; x < record.length(); x++)
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