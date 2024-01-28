using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace App
{
    internal class Program
    {
        //ARRAYS TO STORE DATA;
        public static   List<string> BOOK_NAME;
        public static List<string> BOOK_TITLE;
        public static List<string> AUTHOR_NAME;
        public static List<string> BOOK_EDITION;
        public static List<string> BOOK_ISBN;
        public static List<string> NAME1;
        public static List<string> NAME2;
        public static List<string> AGE;
        public static List<string> NUMBER;
        public static List<string> GENDER;
        public static List<string> BOOK_NAME1;
        public static List<string> AUTHOR_NAME1;
        public static List<string> ISBN1;
        public static List<string> USER_NAME;
        public static List<string> USER_PASS;
        public static List<string> CNIC;
        public static List<string> STATUS;
        public static List<string> BORROWED_BOOKS;
        public static List<string> READBOOKS;

        public static int x = 50;
        public static int y = 17;
        public static int count = 0;

        static void Main(string[] args)
        {
            //VARIABLES;
            string sign_in_menu_option;
            string sign_in_name ;
            string sign_in_password ;
            string sign_up_menu_option;
            string admin_user = "";
            string admin_cnic = "";
            string admin_password = "";
            int admin = 0;
            string choice = "";
            string stu_username = "", stu_userpassword = "", stu_CNIC = "";
            //ARRAYS;
           readAdmin(ref admin,ref admin_user,ref admin_cnic,ref admin_password);
            readStudent();
            readBook();
            readStudentInfo();



            Console.Clear();

            Interface();
            while (choice != "3")
            {

                choice = log_in_menu();
                if (choice == "2")
                {
                    sign_in_menu_option = sign_in_menu();
                    if (sign_in_menu_option == "1")
                    {
                        sign_in_name = sign_in_username();
                        sign_in_password = sign_in_userpassword();


                        if (sign_in_name == admin_user && sign_in_password == admin_password)//if sign up useername and password matches
                        {
                            adminsMenu();
                        }
                    }
                    else if (sign_in_menu_option == "2")
                    {
                        Student_login();
                    }
                }

                else if (choice == "1")
                {
                    sign_up_menu_option = sign_up();
                    if (sign_up_menu_option == "1")
                    {
                        sign_up_admin(ref admin,ref admin_user,ref admin_cnic,ref admin_password);
                    }
                    else if (sign_up_menu_option == "2")
                    {
                        sign_up_student(ref stu_username,ref stu_userpassword,ref stu_CNIC);
                    }
                }

                else if (choice == "3")
                {
                    break;// end the program
                }

                else
                {
                    invalid_option();
                }

            }

        }

        static void Interface()
        {
            
            Console.Clear();

            Console.SetCursorPosition(25, 2);
            // Using setconsoletextAttribute to give different colors



            Console.WriteLine("     ***********************************************************************************************");
            Console.SetCursorPosition(25, 3);

            

            Console.WriteLine ("     *                                  LIBRARY MANAGEMENT SYSTEM                                  *") ;
            Console.SetCursorPosition(25, 4);

            Console.WriteLine ("     ***********************************************************************************************") ;

            Console.WriteLine ("                                                                               ....                          " );
            
            Console.WriteLine ("                                                ::::+ :-=:       ... .::       :====                  =**=   ") ;


            Console.WriteLine ("                                                ::::: -==-.=*    .:. .:=***    .:---         :-=- ::-:.::.   " );
            

            Console.WriteLine ("                                                :-=== :.-:.==    ... :::***    .::::         .::: --===**=   " );


            Console.WriteLine ("                                                -**** :.-:.=+    .:: ::::**    .::::.:.      .=+: ::::=+*=   " );
            

            Console.WriteLine( "                                                -**** :.-::=* *= ::: ::: ***   .::::.-:      .=+: ::::=**=   ");
            

            Console.WriteLine( "                                                -**** :::.-** *= ...   .:: ***=  ::---.-.      .=+: ::::=**=   " );
            

            Console.WriteLine ("                                                -****:=+*=:=* *= ... =+= :**+::=+++* -.      .::: ::--:==:   " );
            

            Console.WriteLine ("                                                :****.::-:.==    ... .::..:::. .::::...:    ..:::.::-:=**-   " );
            

            Console.WriteLine ("                                                :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::  " );


            Console.WriteLine ("                                                -----------------------------------------------------------   " );
            

            Console.WriteLine ("                                                           :::                               :::              " );
            

            Console.WriteLine ("                                                                                                             " );
            Console.WriteLine ("                                                                                                             " );
            Console.WriteLine ("                                                                                                             " );
            

            Console.WriteLine ("                                                                                                   .  :.     " );
            

            Console.WriteLine ("                                                                                                  .: :==     " );


            Console.WriteLine ("                                                      .:-==                                    ==..::==-     " );
            

            Console.WriteLine ("                                                    ..=**#*       .:: ==:    :......... .:.    .==:::=+- .   " );
            

            Console.WriteLine ("                                                   -=+:-=+=     .....:==: := =:::::*:+:::+--    ===::=-...   " );
            

            Console.WriteLine ("                                                   .:::===+    ::::::*#*= -= +     %.*.         :==:-=::.    " );
            

            Console.WriteLine ("                                                    :::===+  ..:::.:+#*-  -+ = ::  +.+:: .      .:=:=:::     " );
            

            Console.WriteLine ("                                                   .:::-==+ .::::: +**:      =-**=====+*=-      ::::::-:     " );
            

            Console.WriteLine ("                                                   -=+=+*** ::::. .-*=     -*==**********:      .::::::.     " );
            

            Console.WriteLine ("                                                    .. ==++  ...  .-:      =*==##########:       .:::::.     " );
            

            Console.WriteLine ("                                                ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::   " );
            

            Console.WriteLine ("                                                ----------------------------------------------------------    " );




            Console.WriteLine ("                        @--------------------------------------------------------------------------------------------------------@      " );


            Console.SetCursorPosition(1, 35);
            Console.WriteLine ("Press any key to continue...");
            Console.Read(); //Do not go to another function until user presses  any button

        }
        static void header1()
        {


            Console.WriteLine ("                            __        ______  _______   _______    ______   _______  __      __        __       __   ______                 " );
            Console.WriteLine ("                           |  \\      |      \\|       \\ |       \\  /      \\ |       \\|  \\    /  \\      |  \\     /  \\ /      \\     " );
            Console.WriteLine ("                           | $$       \\$$$$$$| $$$$$$$\\| $$$$$$$\\|  $$$$$$\\| $$$$$$$\\$$\\  /  $$      | $$\\   /  $$|  $$$$$$\\        " );
            Console.WriteLine ("                           | $$        | $$  | $$__/ $$| $$__| $$| $$__| $$| $$__| $$ \\$$\\/  $$       | $$$\\ /  $$$| $$___\\$$           " );
            Console.WriteLine ("                           | $$        | $$  | $$    $$| $$    $$| $$    $$| $$    $$  \\$$  $$        | $$$$\\  $$$$ \\$$    \\            " );
            Console.WriteLine ("                           | $$        | $$  | $$$$$$$\\| $$$$$$$\\| $$$$$$$$| $$$$$$$\\   \\$$$$         | $$\\$$ $$ $$ _\\$$$$$$\\        " );
            Console.WriteLine ("                           | $$_____  _| $$_ | $$__/ $$| $$  | $$| $$  | $$| $$  | $$   | $$          | $$ \\$$$| $$|  \\__| $$             " );
            Console.WriteLine ("                           | $$     \\|   $$ \\| $$    $$| $$  | $$| $$  | $$| $$  | $$   | $$          | $$  \\$ | $$ \\$$    $$           " );
            Console.WriteLine ("                            \\$$$$$$$$ \\$$$$$$ \\$$$$$$$  \\$$   \\$$ \\$$   \\$$ \\$$   \\$$    \\$$           \\$$      \\$$  \\$$$$$$   " );
            Console.WriteLine ("                           ____________________________________________________________________________________________________             " );

        }

        static void header2()
        {
            

            Console.WriteLine ("                               ***************************************************************************************" );
            
            Console.WriteLine ("                               |                                     Welcome to the                                  |" );
          
            Console.WriteLine ("                               |                              (LIBRARY MANAGEMENT SYSTEM)                            |" );

            Console.WriteLine ("                               ***************************************************************************************" );

        }
       
        static string log_in_menu()
        {

            Console.Clear();//clears screen
            header1();
            header2();
            

            string option;
            Console.SetCursorPosition(x, y);
            Console.WriteLine ("|Press 1 to REGISTER yourself...   |" );
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine ("|Press 2 to LOGIN...               |" );

            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine ("|Press 3 to EXIT...                |" );

            Console.SetCursorPosition(x, y + 4);
            Console.Write (" Please enter your choice: ");
             option = Console.ReadLine();

            return option;
        }
        static string sign_in_menu()
        {
            string sign_in_menu_option;
            Console.Clear();
            header1();

            Console.SetCursorPosition(x, y);
            Console.WriteLine ("You want to sign_IN as a: ");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine ("1. ADMIN");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine ("2. STUDENT");
            Console.SetCursorPosition(x, y + 4);
            Console.Write ("Enter your option: ");
            sign_in_menu_option = Console.ReadLine();

            return sign_in_menu_option;
        }

        static string sign_in_username()
        {
            Console.Clear();
            header1();
            string a;
            //if user gives no input then take the input again using while loop

            while (true)
            {
                Console.SetCursorPosition(x, y);
               
                Console.WriteLine ("Enter USERNAME: ");
                a = Console.ReadLine();

                if (empty(a) == true)
                {
                    NOstring(x, y + 4);
                }

                else
                {
                    break;
                }

            }
            return a;
        }

         static string sign_in_userpassword()
        {
            string b;

            while (true)
            {
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine ("Enter PASSWORD: ");
                b = Console.ReadLine();

                if (empty(b) == true)
                {
                    NOstring(x, y + 4);
                }
                else
                {
                    break;
                }

            }
            return b;
        }

        static void Student_login()
        {

            Console.Clear();
            header1();
           
            string e, f;
            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine ("Enter USERNAME: ");
                e = Console.ReadLine();

                if (empty(e) == true)
                {
                    NOstring(x, y + 4);
                }
                else
                {
                    break;
                }

            }

            while (true)
            {

                Console.SetCursorPosition(x, y + 6);
                Console.WriteLine ("Enter PASSWORD: ");
                f = Console.ReadLine();

                if (empty(f) == true)
                {
                    NOstring(x, y + 7);
                }
                else
                {
                    break;
                }

            }

            bool found_name = false;
            //to check  that username has been found
            for (int i = 0; i < USER_NAME.Count(); i++)
            {
                if (e == USER_NAME[i] && f == USER_PASS[i])
                {
                    found_name = true;
                    studentsMenu();
                    break;
                }
            }

            if (!found_name)
            {
                Console.SetCursorPosition(x, y + 9);


                Console.WriteLine ("Error:Enter correct username and password.");
                Console.Read();
                log_in_menu();
            }
        }
        static string sign_up()
        {

            string option;
            Console.Clear();
            header1();
            

            Console.SetCursorPosition(x, y);
            Console.WriteLine ("1. PRESS 1 to sign_up as an ADMIN.");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine ("2. PRESS 2 to sign_up as a STUDENT.");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine ("Enter your choice...");
            option = Console.ReadLine();
            return option;

        }
        static void sign_up_admin(ref int admin,ref string  admin_user,ref  string  admin_cnic,ref string  admin_password)
        {

            Console.Clear();
            header1();
            

            if ( admin == 1)//if admin is trying to register again
            {

                Console.SetCursorPosition(x, y);
                Console.WriteLine ("ADMIN has already signed up.");
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine ("PRESS any key to continue....");
                Console.Read();

            }
            if (admin == 0)//if admin is new
            {

                while (true)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine ("Enter USERNAME: ");
                    //cin.ignore();
                    admin_user = Console.ReadLine();
                    if (empty(admin_user) == true)
                    {
                        NOstring(x, y + 2);
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    Console.SetCursorPosition(x, y + 4);
                    Console.WriteLine ("Enter admin's CNIC(length must be 13 digits without any spaces): ");
                    admin_cnic = Console.ReadLine();

                    if (empty(admin_cnic) == true)
                    {
                        NOstring(x, y + 5);
                    }
                    else if (check_number(admin_cnic, 13) == true)
                    {
                        for_string_length(x, y + 9);
                    }
                    else if (check_int(admin_cnic) == true)
                    {
                        for_string_int(x, y + 7);
                    }
                    else
                    {
                        break;
                    }
                }

                while (true)
                {
                    Console.SetCursorPosition(x, y + 11);
                    Console.WriteLine ("Enter PASSWORD: ");
                    admin_password = Console.ReadLine();//using getline to take inputs having space
                    if (empty(admin_password) == true)
                    {
                        NOstring(x, y + 12);
                    }
                    else
                    {
                        break;
                    }
                }
                admin++;
                //writeAdmin(admin, admin_user, admin_cnic, admin_password);
            }

        }

        static void sign_up_student(ref string stu_username ,ref string stu_userpassword ,ref string stu_CNIC)
        {

            Console.Clear();
            header1();
            

            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine ("Enter your USERNAME: ");
                stu_username = Console.ReadLine();

                if (empty(stu_username) == true)
                {
                    NOstring(x, y + 2);
                }
                else
                {
                    break;
                }

            }
            while (true)
            {
                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine ("Enter your PASSWORD: ");
                stu_userpassword = Console.ReadLine();
                if (empty(stu_userpassword) == true)
                {
                    NOstring(x, y + 5);
                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.SetCursorPosition(x, y + 7);
                Console.WriteLine ("Enter your CNIC(13 digits without spaces: ");
                stu_CNIC = Console.ReadLine();

                if (empty(stu_CNIC) == true)
                {
                    NOstring(x, y + 8);
                }
                else if (check_number(stu_CNIC, 13) == true)
                {
                    for_string_length(x, y + 9);
                }
                else if (check_int(stu_CNIC) == true)
                {
                    for_string_int(x, y + 11);
                }

                else
                {
                    break;
                }
            }
            for (int i = 0; i < USER_NAME.Count(); i++)
            {
                if (stu_username == USER_NAME[i] || stu_userpassword == USER_PASS[i])
                {
                    
                    Console.SetCursorPosition(x, y + 10);
                    Console.WriteLine ("This username or password is already taken.");
                    Console.Read();
                }
            }//storing data in the arrays
            USER_NAME.Add(stu_username);
            USER_PASS.Add(stu_userpassword);
            CNIC.Add(stu_CNIC);
            //writeStudent(USER_NAME, USER_PASS, CNIC);


        }
        static bool check_number(string check, int length)//to check the length of entered input
        {

            if (check.Count() != length)
            {
                return true;
            }
            return false;
        }
        static bool check_int(string check)
        {
            for (int i = 0; check[i] != '\0'; i++)
            {

                int b = check[i];
                if (b != 48 && b != 49 && b != 50 && b != 51 && b != 52 && b != 53 && b != 54 && b != 55 && b != 56 && b != 57)
                {
                    return true;
                }
            }
            return false;
        }
        static bool check_repeatition(string input, string[] arr, int index)
        {
            //if input is repeated
            for (int i = 0; i < index; i++)
            {

                if (input == arr[i])
                {
                    return true;
                }
            }
            return false;
        }
        static bool empty(string check)
        {
            if (check == "")//if user enters no input
            {
                return true;

            }
            return false;
        }

        static void spacesError(int x, int y)
        {
            Console.Clear();
            header1();
            Console.WriteLine ("Enter inputs without spacing.");
            Console.Read();
        }
        //Different validations
        static void NOstring(int x_axis, int y_axis)
        {

            Console.SetCursorPosition(x_axis, y_axis);
            Console.WriteLine ("Please Enter some input. ");
            Console.SetCursorPosition(x_axis, y_axis + 1);
            Console.WriteLine ("Press any key to continue....");
            Console.Read();
        }
        static void for_string_repeatition(int x_axis, int y_axis)
        {

            Console.SetCursorPosition(x_axis, y_axis);
            Console.WriteLine ("Sorry, but that input has already been claimed.                  ") ;
            Console.SetCursorPosition(x_axis, y_axis + 1);
            Console.WriteLine ("Press any key to continue...");
            Console.Read();

        }
        static void for_string_length(int x_axis, int y_axis)
        {

            Console.SetCursorPosition(x_axis, y_axis);
            Console.WriteLine ("The specified length is not accurate. Please try again.                ") ;
            Console.SetCursorPosition(x_axis, y_axis + 1);
            Console.WriteLine ("Press any key to continue....");
            Console.Read();

        }
        static void for_string_int(int x_axis, int y_axis)
        {
            Console.SetCursorPosition(x_axis, y_axis);
            Console.WriteLine ("Input must be in integers.                                                                ");
            Console.SetCursorPosition(x_axis, y_axis + 1);
            Console.WriteLine ("Press any key to continue....");
            Console.Read();
        }

       static void forInt(int x_axis, int y_axis)
        {

            Console.SetCursorPosition(x_axis, y_axis);
            Console.WriteLine ("Please enter an integer.");
            Console.Read();

        }
        static void invalid_option()
        {

            Console.Clear();
            header1();
            Console.SetCursorPosition(x, y);
            Console.WriteLine ("Please choose the option that are given.") ;
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine ("Press any key to continue...");
            Console.Read();

        }
        //Admin Menu
        static void adminsMenu()
        {
            Console.Clear();
            header1();

            string choice2;


            Console.SetCursorPosition(x, y);
            Console.WriteLine ("|Press 1 to add a book & atricle...                      |" );
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine ("|Press 2 to delete a book & article...                   |" );
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine ("|Press 3 to display books...                             |" );
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine ("|Press 4 to update a book...                             |" );
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine ("|Press 5 to view those students who have borrowed a book.|" );
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine ("|Press 6 to delete users accounts..                      |" );
            Console.SetCursorPosition(x, y + 6);
            Console.WriteLine ("|Press 7 to view students accounts..                     |" );
            Console.SetCursorPosition(x, y + 7);
            Console.WriteLine ("|Press 8 to go back to main menu...                      |" );


            Console.SetCursorPosition(x, y + 9);
            Console.WriteLine (" Please enter your choice: ");

            choice2 = Console.ReadLine();
            // using else if to go to entered option

            if (choice2 == "1")
            {
                addBook();
            }

            else if (choice2 == "2")
            {
                delBook();
            }

            else if (choice2 == "3")
            {
                displayBooks();
            }

            else if (choice2 == "4")
            {
                BookUpdate();
            }

            else if (choice2 == "5")
            {
                borrowedBooks();
            }
            else if (choice2 == "6")
            {
                delUsersAccounts();
            }
            else if (choice2 == "7")
            {
                displayaccounts();
            }
            else if (choice2 == "8")
            {
                log_in_menu();
            }
            else if (choice2 != "1" || choice2 != "2" || choice2 != "3" || choice2 != "4" || choice2 != "5" || choice2 != "6" || choice2 != "7" || choice2 != "8")
            {
                invalid_option();
            }
        }
        static void addBook()
        {
            Console.Clear();
            header1();

            string title, author, edition, ISBN, status;


            while (true)
            {
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine ("Enter the book title: ");
                title = Console.ReadLine();

                if (empty(title) == true)
                {
                    NOstring(x, y + 2);
                }
                else
                {

                    break;
                }
            }

            while (true)
            {
                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine ("Enter the name of AUTHOR: ");
                author = Console.ReadLine();

                if (empty(author) == true)
                {
                    NOstring(x, y + 5);
                }

                else
                {

                    break;
                }
            }
            while (true)
            {
                Console.SetCursorPosition(x, y + 7);
                Console.WriteLine ("Enter the book edition: ");
                edition = Console.ReadLine();

                if (empty(edition) == true)
                {
                    NOstring(x, y + 8);
                }

                else
                {

                    break;
                }
            }
            while (true)
            {
                Console.SetCursorPosition(x, y + 10);
                Console.WriteLine ("Enter the book ISBN: ");
                ISBN = Console.ReadLine();

                if (empty(ISBN) == true)
                {
                    NOstring(x, y + 11);
                }

                else
                {

                    break;
                }
            }
            while (true)
            {
                Console.SetCursorPosition(x, y + 14);
                Console.WriteLine ("Enter the status (available): ");
                status = Console.ReadLine();

                if (empty(status) == true)
                {
                    NOstring(x, y + 15);
                }

                else
                {

                    break;
                }
            }



            Console.SetCursorPosition(x, y + 19);
            Console.WriteLine ("Thanks for adding a book....");

            //adding data in arrays
            AUTHOR_NAME.Add(author);
            BOOK_TITLE.Add(title);
            BOOK_EDITION.Add(edition);
            BOOK_ISBN.Add(ISBN);
            STATUS.Add(status);

            writeBook(AUTHOR_NAME, BOOK_TITLE, BOOK_EDITION, BOOK_ISBN, STATUS);

            Console.Read();
            adminsMenu();


        }
        static void delBook()
        {
            Console.Clear();
            header1();
            

            string title1, author1, edition1, ISBN1, status1;

            while (true)
            {
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine ("Enter the book title: ");
                title1 = Console.ReadLine();

                if (empty(title1) == true)
                {
                    NOstring(x, y + 4);
                }
                else
                {

                    break;
                }
            }
            while (true)
            {
                Console.SetCursorPosition(x, y + 6);
                Console.WriteLine ("Enter the name of AUTHOR: ");
                author1 = Console.ReadLine();

                if (empty(author1) == true)
                {
                    NOstring(x, y + 7);
                }

                else
                {

                    break;
                }
            }

            while (true)
            {
                Console.SetCursorPosition(x, y + 9);
                Console.WriteLine ("Enter the book edition: ");
                edition1 = Console.ReadLine();

                if (empty(edition1) == true)
                {
                    NOstring(x, y + 10);
                }

                else
                {

                    break;
                }
            }
            while (true)
            {
                Console.SetCursorPosition(x, y + 12);
                Console.WriteLine ("Enter the book ISBN: ");
                ISBN1 = Console.ReadLine();

                if (empty(ISBN1) == true)
                {
                    NOstring(x, y + 13);
                }
                else
                {

                    break;
                }
            }
            while (true)
            {
                Console.SetCursorPosition(x, y + 15);
                Console.WriteLine ("Enter the book status: ");
                status1 = Console.ReadLine();

                if (empty(status1) == true)
                {
                    NOstring(x, y + 16);
                }
                else
                {

                    break;
                }
            }

            bool found = false;//making a bool variable to delete a book

            for (int i = 0; i < BOOK_TITLE.Count(); i++)
            {
                Console.SetCursorPosition(x, y + 17);
                if (author1 == AUTHOR_NAME[i] && title1 == BOOK_TITLE[i] && edition1 == BOOK_EDITION[i] && ISBN1 == BOOK_ISBN[i] && status1 == STATUS[i])
                {
                    //deleting data
                    STATUS.RemoveAt (i);
                    BOOK_TITLE.RemoveAt(i);
                    AUTHOR_NAME.RemoveAt(i);
                    BOOK_EDITION.RemoveAt(i);
                    BOOK_ISBN.RemoveAt(i);
                    found = true;

                    Console.WriteLine ("Your book has been deleted.");
                    Console.Read();
                    adminsMenu();
                    break;
                }
            }
            Console.SetCursorPosition(x, y + 17);
            if (!found)//if book does not find
            {
                
                Console.WriteLine ("Firstly, You have to add the book. Press any key.");
                Console.Read();
                adminsMenu();
            }
        }

        static void displayBooks()
        {
            Console.Clear();
            //Displaying books data in the table form 


            Console.WriteLine("\t\t\t\t\t\t\t\tSTORED BOOKS DATA");

            Console.WriteLine("$\t\t\t\tTITLE " , "AUTHOR NAME" , "ISBN"  , "EDITION" , "STATUS");
                 

            bool found_books = false;
            for (int i = 0; i < BOOK_TITLE.Count(); i++)
            {


                Console.WriteLine("\t\t\t\t", BOOK_TITLE[i], AUTHOR_NAME[i], BOOK_ISBN[i], BOOK_EDITION[i], STATUS[i]);

                found_books = true;
            }

            Console.SetCursorPosition(x, y + 19);
            //ti find that whether the books are added in admin's menu or not
            if (!found_books)
            {
                Console.WriteLine ("No books yet! Please add a book.");
            }
            else
            {

                Console.WriteLine ("Press any key to continue..");
            }
            Console.Read();
            adminsMenu();

        }

        static void BookUpdate()
        {
            //when admin wants to update the book
            Console.Clear();
            header1();

            string BookTitle, Edition;


            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine ("Enter the title of the book that you want to update: ");
                BookTitle = Console.ReadLine();

                if (empty(BookTitle) == true)
                {
                    NOstring(x, y + 1);
                }

                else
                {

                    break;
                }
            }
            while (true)
            {
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine ("Enter the updated book edition: ");
                Edition = Console.ReadLine();

                if (empty(Edition) == true)
                {
                    NOstring(x, y + 4);
                }

                else
                {

                    break;
                }
            }
            bool title_found = false;
            //find a book in the array and change the it's title at that index
            for (int i = 0; i < BOOK_TITLE.Count(); i++)
            {
                if (BookTitle == BOOK_TITLE[i])
                {
                    BOOK_EDITION[i] = Edition;
                    title_found = true;
                    break;// if book found , break the loop
                }
            }

            Console.SetCursorPosition(x, y + 6);

            if (!title_found)
            {

                Console.WriteLine ("Please Enter correct title.");
            }
            else
            {
                
                Console.WriteLine ("Press any key to continue..");
            }
            Console.Read();
            adminsMenu();
        }

        static void borrowedBooks()
        {
            //displaying borrowed books data to the admin
            Console.Clear();


            Console.WriteLine("\t\t\t\t\t\t\t\tBORROWED BOOKS DATA");
            bool borrowedbook = false;

            Console.WriteLine ("\t\t\t\t\t\t\tUSER_NAME" ,   "BORROWED_BOOKS" );
            for (int i = 0; i < USER_NAME.Count(); i++)
            {
                if (BORROWED_BOOKS[i] != " ")
                {


                    Console.WriteLine("\t\t\t\t\t\t\t" , USER_NAME[i] ,  BORROWED_BOOKS[i]);
                    borrowedbook = true;

                }
            }

            Console.SetCursorPosition(x, y + 16);

            if (!borrowedbook)
            {
                
                Console.WriteLine ("NO BOOKS BORROWED YET.");

            }
            else
            {
                
                Console.WriteLine ("Press any key to continue");
            }
            Console.Read();
            adminsMenu();
        }

       static void delUsersAccounts()
        {
            //deleting user_accounts
            Console.Clear();
            header1();

            string Studentusername, Studentpassword;
            

            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine ("Enter the students username: ");
                Studentusername = Console.ReadLine();

                if (empty(Studentusername) == true)
                {
                    NOstring(x, y + 1);
                }

                else
                {

                    break;
                }
            }

            while (true)
            {
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine ("Enter the students password: ");
                Studentpassword = Console.ReadLine();

                if (empty(Studentpassword) == true)
                {
                    NOstring(x, y + 4);
                }

                else
                {

                    break;
                }
            }

            bool found_account = false;
            //using for loop to find the account at specific index in the array and delete it

            for (int i = 0; i < USER_NAME.Count(); i++)
            {
                if (Studentusername == USER_NAME[i] && Studentpassword == USER_PASS[i])
                {
                    USER_NAME.RemoveAt(i);
                    USER_PASS.RemoveAt(i);

                    found_account = true;

                    Console.SetCursorPosition(x, y + 10);
                    Console.WriteLine ("This account has been deleted.");
                    Console.Read();
                    adminsMenu();
                    break;
                }
            }
            Console.SetCursorPosition(x, y + 9);


            if (!found_account)
            {
                Console.WriteLine("This account does not exist.");
                Console.Read();
                adminsMenu();
            }

        }

        static void displayaccounts()
        {
            //show user accounts to admin

            Console.Clear();

            Console.WriteLine("\t\t\t\t\tUSER ACCOUNTS");

            //using setw()to give spaces
            Console.WriteLine("\t\t\t\t" , "USERNAME",   "PASSWORDS");
                 

            bool found_user = false;
            for (int i = 0; i < USER_NAME.Count(); i++)
            {


                Console.WriteLine("\t\t\t\t" ,  USER_NAME[i] ,  USER_PASS[i]);

                found_user = true;
            }

            Console.SetCursorPosition(x, y + 16);

            if (!found_user)
            {
                
                Console.WriteLine ("No accounts yet!.");
            }
            else
            {
                
                Console.WriteLine ("Press any key to continue..");
            }
            Console.Read();
            adminsMenu();
        }

        static void studentsMenu()
        {
            Console.Clear();
            header1();

            string choice3;
            

            Console.SetCursorPosition(x, y);
            Console.WriteLine("|Press 1 to view BOOKS...                  |");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine ("|Press 2 to borrow a book                  |");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("|Press 3 to display borrowed books...      |"); ;
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine ("|Press 4 to Enter personal information..   |");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine ("|Press 5 to display personal information...|");
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine ("|Press 6 to go back to Main Menu...        |");
            Console.SetCursorPosition(x, y + 7);
            Console.WriteLine (" Please enter your choice: ");

             choice3 = Console.ReadLine();
            //using else if to go to entered option

            if (choice3 == "1")
            {
                displayBooksforStudent();
            }
            else if (choice3 == "2")
            {
                BorrowBook();
            }
            else if (choice3 == "3")
            {
                displayBorrowedBook();
            }
            else if (choice3 == "4")
            {
                studentsInfo();
            }
            else if (choice3 == "5")
            {
                DisplaypersonalInfo();
            }
            else if (choice3 == "6")
            {
                log_in_menu();
            }
            else if (choice3 != "1" || choice3 != "2" || choice3 != "3" || choice3 != "4" || choice3 != "5" || choice3 != "6")
            {
                invalid_option();
            }

        }

        static void displayBooksforStudent()
        {
            //diplay books for students so that they may borrow
            Console.Clear();


            Console.WriteLine("\t\t\t\t\t\t\t\tSTORED BOOKS DATA");


            Console.WriteLine("\t\t\t", "AUTHOR NAME", "ISBN", "EDITION", "TITLE", "STATUS");

            bool found2 = false;
            for (int i = 0; i < BOOK_TITLE.Count(); i++)
            {

                Console.WriteLine("\t\t\t\t", AUTHOR_NAME[i], BOOK_ISBN[i], BOOK_EDITION[i], BOOK_TITLE[i], STATUS[i]);
                     
                found2 = true;
            }

            Console.SetCursorPosition(x, y + 18);
            if (!found2)
            {
                
                Console.WriteLine ("No books yet!");
            }
            else
            {

                Console.WriteLine ("Press any key to continue..");
            }
            Console.Read();
            studentsMenu();
        }

        static void BorrowBook()
        {
            //borrow a book
            Console.Clear();
            header1();

            string title_input; bool book = false;

            while (true)
            {

                Console.SetCursorPosition(x, y);
                Console.WriteLine ("Enter the book title: ");
               title_input = Console.ReadLine();

                if (empty(title_input) == true)
                {
                    NOstring(x, y + 1);
                }

                else
                {

                    break;
                }
            }

            for (int i = 0; i < BOOK_TITLE.Count(); i++)
            {
                if (title_input == BOOK_TITLE[i])
                {
                    STATUS[i] = "CHECKED OUT";//if student borrow a book then convert this status to available to CHECKED OUT
                    book = true;
                    BORROWED_BOOKS.Add(title_input);
                    break;
                }
            }
            Console.SetCursorPosition(x, y + 7);
            if (!book)
            {
                Console.WriteLine ("This book is not present in library.");
            }
            else
            {
                
                Console.WriteLine ("You have borrowed a book.");
            }
            Console.Read();
            studentsMenu();
        }

        static void displayBorrowedBook()
        {
            //TO CHECK WHICH BOOK WAS BORROWED BY A STUDENT
            Console.Clear();
            header1();
            string name; bool find_user = false;

            while (true)
            {

                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine ("Enter your username: ");
                name = Console.ReadLine();

                if (empty(name) == true)
                {
                    NOstring(x, y + 4);
                }

                else
                {

                    break;
                }
            }

            for (int i = 0; i < BOOK_ISBN.Count(); i++)
            {
                Console.SetCursorPosition(x, y + 7);

                if (name == USER_NAME[i])
                {
                    Console.WriteLine ("Borrowed book is: " ,  BORROWED_BOOKS[i]);
                    find_user = true;
                }
            }

            Console.SetCursorPosition(x, y + 9);

            if (!find_user)
            {
                
                Console.WriteLine ("Please Enter correct username.");
            }
            else
            {
                
                Console.WriteLine ("Press any key to continue.");
            }
            Console.Read();
            studentsMenu();
        }

        static void studentsInfo()

        {
            //student's information
            Console.Clear();
            header1();

            string name1, name2, age, number, gender;

            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine ("Enter your First name: ");
                name1 = Console.ReadLine();

                if (empty(name1) == true)
                {
                    NOstring(x, y + 1);
                }

                else
                {

                    break;
                }
            }

            while (true)
            {
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine ("Enter your last name: ");
                name2 = Console.ReadLine();

                if (empty(name2) == true)
                {
                    NOstring(x, y + 4);
                }

                else
                {

                    break;
                }
            }

            while (true)
            {
                Console.SetCursorPosition(x, y + 6);
                Console.WriteLine ("Enter your age (years): ");
                age = Console.ReadLine();

                if (empty(age) == true)
                {
                    NOstring(x, y + 7);
                }

                else
                {

                    break;
                }
            }

            while (true)
            {
                Console.SetCursorPosition(x, y + 9);
                Console.WriteLine ("Enter your mobile number: ");
                number = Console.ReadLine();

                if (empty(number) == true)
                {
                    NOstring(x, y + 10);
                }
                else if (check_number(number, 11) == true)
                {
                    for_string_length(x, y + 12);
                }
                else if (check_int(number) == true)
                {
                    for_string_int(x, y + 14);
                }

                else
                {

                    break;
                }
            }


            while (true)
            {
                Console.SetCursorPosition(x, y + 16);
                Console.WriteLine ("Enter your gender: ");
                 gender = Console.ReadLine();

                if (empty(gender) == true)
                {
                    NOstring(x, y + 17);
                }

                else
                {

                    break;
                }
            }
            //storing indormation in the arrays
            NAME1.Add(name1);
            NAME2.Add(name2);
            AGE.Add(age);
            NUMBER.Add(number);
            GENDER.Add(gender);

           // writeBook(NAME1, NAME2, AGE, NUMBER, GENDER);

            Console.SetCursorPosition(x, y + 18);
            Console.WriteLine ("Thanks for entering the information. Press any key to proceed.");
            Console.Read();
            studentsMenu();

        }

        static void DisplaypersonalInfo()

        {
            bool found = false;
            //displaying students information
            Console.Clear();

            Console.WriteLine("\t\t\t\t\t\t\t\tPERSONAL DATA");

            Console.WriteLine("\t\t\t\tGENDER", "NAME", "LAST_NAME", "AGE", "PH.no.");

            for (int i = 0; i < GENDER.Count(); i++)
            { 

                Console.WriteLine ("\t\t\t\t" ,  GENDER[i] ,  NAME1[i] ,  NAME2[i] ,  AGE[i] ,  NUMBER[i] );
                found = true;

            }

            Console.SetCursorPosition(x, y + 19);
            if (!found)
            {
                
                Console.WriteLine("No Informaion yet! Press any key.");
            }
            else
            {

                Console.WriteLine("Press any key to continue.");
            }
            Console.Read();
            studentsMenu();
        }
       static string getField(string record, int field)
        {
            int commaCount = 1;
            string item = "";
            for (int x = 0; x < record.Count(); x++)
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
       static void writeAdmin(ref int admin,ref string admin_user,ref string admin_cnic,ref string admin_password)
        {
            StreamWriter write = new StreamWriter("OwnerSignUp.txt");
            write.WriteLine($"{admin_user},{admin_cnic},{admin_password}");
            write.Flush();
            write.Close();
        }
        static void readAdmin(ref int admin,ref string admin_user,ref string admin_cnic,ref string admin_password)
        {
            
            string record= "";
            StreamReader read = new StreamReader("OwnerSignUp.txt");
            
            for (int i=0; i<1; i++)
            {
                record = read.ReadLine();
                if (record != null)
                {
                    admin_user = getField(record, 1);
                    admin_cnic = getField(record, 2);
                    admin_password = getField(record, 3);
                    admin++;

                }
                else
                {
                    break;
                }
            }
             
              
            
        }
        static void writeStudent(List<string> USER_NAME, List<string> USER_PASS, List<string> CNIC)
        {
            StreamWriter write = new StreamWriter("StudentSignUp.txt");
            for(int i=0; i<USER_NAME.Count(); i++)
            {
                write.WriteLine(USER_NAME[i] , ",", USER_PASS[i], ",", CNIC[i]);
            }
            
            write.Close();
        }
        static void readStudent()
        {
            
            string records = "";
            StreamReader read = new StreamReader("StudentSignUp.txt");
           
          
            while (!(read.EndOfStream))
            {
                records = read.ReadLine();

                if (records != null)
                {
                    USER_NAME.Add(getField(records, 1));
                    USER_PASS.Add(getField(records, 2));
                    CNIC.Add(getField(records, 3));
                    
                }
                else
                {
                    break;
                }
                

            }
        }
       static void writeBook(List<string> AUTHOR_NAME, List<string> BOOK_TITLE, List<string> BOOK_EDITION, List<string> BOOK_ISBN, List<string> STATUS)
        {
            StreamWriter write = new StreamWriter("BOOK.txt");
            for(int i=0; i<AUTHOR_NAME.Count(); i++)
            {
                write.WriteLine(AUTHOR_NAME[i], ",", BOOK_TITLE[i], ",", BOOK_EDITION[i], ",", BOOK_ISBN[i], ",", STATUS[i]);
            }
          
            write.Close();
        }
        static void readBook()
        {
            StreamReader linee = new StreamReader("BOOK.txt");

            while (!(linee.EndOfStream))
            {
                string recorD = linee.ReadLine();

                AUTHOR_NAME.Add(getField(recorD, 1));
                BOOK_TITLE.Add(getField(recorD, 2));
                BOOK_EDITION.Add(getField(recorD, 3));
                BOOK_ISBN.Add(getField(recorD, 4));
                STATUS.Add(getField(recorD, 5));
                if(recorD == "")
                {
                    break;
                }

            }
        }
       static void writeStudentInfo(List<string> NAME1, List<string> NAME2, List<string> AGE, List<string> NUMBER, List<string> GENDER)
        {
            StreamWriter LIINE = new StreamWriter("StudentInfo.txt");
            for(int i=0; i<NAME1.Count(); i++)
            {
                LIINE.WriteLine(NAME1[i], ",", NAME2[i], ",", AGE[i], ",", NUMBER[i], ",", GENDER[i]) ;
            }
            LIINE.Close();
          
        }

       static void readStudentInfo()
        {
            StreamReader Line = new StreamReader("StudentInfo.txt");
            
            while (!(Line.EndOfStream))
            {
                string Record = Line.ReadLine();
                
                if (Record == "")
                {
                    break;
                }

                NAME1.Add(getField(Record, 1));
                NAME2.Add(getField(Record, 2));
                AGE.Add(getField(Record, 3));
                NUMBER.Add(getField(Record, 4));
                GENDER.Add(getField(Record, 5));

            }
        }







    }
}
