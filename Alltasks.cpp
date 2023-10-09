#include<iostream>
using namespace std;

main() {
float degrees;
cout<<"Enter the number of sides of the polygon: ";
int sides_of_polygon;
cin>>sides_of_polygon;

int sum_of_internal_angles = (sides_of_polygon-2) * 180;

cout<<"The sum of internal angles of a " <<sides_of_polygon << "-sided polygon is: "<<sum_of_internal_angles<<" degrees" ;

}


#include<iostream>
using namespace std;

main() {

cout<<"Number of Minutes: ";
int minutes;
cin>>minutes;

cout<<"Frames per Second: ";
int frames;
cin>>frames;

int total_number_of_frames= minutes * frames*60;

cout<<"Total Number of Frames: "<<total_number_of_frames;}

#include<iostream>
using namespace std;

main() {
float i_velocity ;
float acceleration ;
float time ;
float f_velocity;

cout<<"Enter Initial Velocity (m/s): ";
cin>>i_velocity;

cout<<"Enter Acceleration (m/s^2): ";
cin>>acceleration;

cout<<"Enter Time (s): ";
cin>>time;

f_velocity=acceleration*time+i_velocity;

cout<<"Final Velocity (m/s): "<<f_velocity;
 }

 #include<iostream>
using namespace std;

main(){

cout<<"Enter Imposter Count: ";

float Imposter_count;

cin>>Imposter_count;

cout<<"Enter Player Count: ";

float playerCount;

cin>>playerCount;


float chance_of_being_imposter= 100 * (Imposter_count/playerCount);

cout<<"Chance of being an imposter: " <<chance_of_being_imposter <<"%";
}

#include<iostream>
using namespace std;
main() {
string name;
int weight;
int days;

cout<<"Enter the Name of the Person: ";
cin>>name;

cout<<"Enter the target weight loss in kilograms: ";
cin>>weight;

days=weight*15;

cout<<name<<" will need "<<days<<" days to lose "<<weight<<" kg of weight by following the doctor's suggestions";

}

# include <iostream>
using namespace std;
main ()
{
float pound;
float cost;
float size;
float costp_pound;
float costp_sq_foot;

cout<<"Enter the size of the fertilizer bag in pounds: ";
cin>>pound;

cout<<"Enter the cost of the bag: $";
cin>>cost;

cout<<"Enter the area in square feet that can be covered by the bag: ";
cin>>size;

costp_pound=cost/pound;
costp_sq_foot=cost/size;

cout<<"Cost of fertilizer per pound: "<<"$"<<costp_pound<<endl;
cout<<"Cost of fertilizing per square foot: "<<"$"<<costp_sq_foot;


}

# include <iostream>
using namespace std;
main ()
{
string name;
int adult_tic_price;
int chil_tic_price;
int adults;
int childs;
float donation;
float total;
float donar;
int remaining;

cout<<"Enter the movie name: ";
cin>>name;

cout<<"Enter the adult ticket price: $";
cin>>adult_tic_price;

cout<<"Enter the child ticket price: $";
cin>>chil_tic_price;

cout<<"Enter the number of adult tickets sold: ";
cin>>adults;

cout<<"Enter the number of child tickets sold: ";
cin>>childs;

cout<<"Enter the percentage of the amount to be donated to charity: ";
cin>>donation;

total=(adult_tic_price*adults)+(chil_tic_price*childs);

donar=(total/100)*donation;

remaining=total-donar;
cout<<endl;

cout<<"Movie: "<<name<<endl;
cout<<"Total amount generated from ticket sales: $"<<total<<endl;
cout<<"Donation to charity ("<<donation<<"%): $"<<donar<<endl;
cout<<"Remaining amount after donation: $"<<remaining;



}

# include <iostream>
using namespace std;
main()
{
float veg_price;
float frt_price;
int veg_total_kgs;
int frt_total_kgs;
float coins_total;
float rupees_total;

cout<<"Enter vegetable price per kilogram (in coins): ";
cin>>veg_price;

cout<<"Enter fruit price per kilogram (in coins): ";
cin>>frt_price;

cout<<"Enter total kilograms of vegetables: ";
cin>>veg_total_kgs;

cout<<"Enter total kilograms of fruits: ";
cin>>frt_total_kgs;

coins_total=(veg_price*veg_total_kgs)+(frt_price*frt_total_kgs);
rupees_total=coins_total/1.94;

cout<<"Total earnings in Rupees (Rps): "<<rupees_total;

}
#include<iostream>
using namespace std;

main() {

cout<<"Enter a 4-digit number: ";

int number;
cin>>number;

int num1=number%10;

int num2=(number/10)%10;

int num3=(number/100)%10;

int num4=(number/1000);

int sum = num1 + num2 + num3 + num4;

cout<<"Sum of the individual digits: "<<sum; }


#include<iostream>
using namespace std;
 main() {
	int num1;
	cout << "Number 1: ";
	cin >> num1;
	int num2;
	cout << "Number 2: ";
	cin >> num2;
	int num3;
	cout << "Number 3: ";
	cin >> num3;
	int num4;
	cout << "Number 4: ";
	cin >> num4;
	int num5;
	cout << "Number 5: ";
	cin >> num5;
	int num6;
	cout << "Number 6: ";
	cin >> num6;
	int num7;
	cout << "Number 7: ";
	cin >> num7;
	int num8;
	cout << "Number 8: ";
	cin >> num8;
	int num9;
	cout << "Number 9: ";
	cin >> num9;
	int num10;
	cout << "Number 10: ";
	cin >> num10;
	int num11;
	cout << "Number 11: ";
	cin >> num11;
	int num12;
	cout << "Number 12: ";
	cin >> num12;
	int num13;
	cout << "Number 13: ";
	cin >> num13;
	int num14;
	cout << "Number 14: ";
	cin >> num14;
	int num15;
	cout << "Number 15: ";
	cin >> num15;
	int addition = num1+num2+num3+num4+num5;
	int multiplication = num6*num7*num8*num9*num10;
	int subtraction = num11-num12-num13-num14-num15;
	int n1 = addition+multiplication;
	int final_result = n1-subtraction;
	cout << "The final result is: " << final_result << endl;
}


#include<iostream>
using namespace std;

main(){
int age;cin>>age;
cout<<"Enter the person's age: ";

int num_of_times;
cout<<"Enter the number of times they've moved: ";
cin>>num_of_times;

int average_number_of_years= age/(num_of_times+1);

cout<<"Average number of years lived in the same house: "<<average_number_of_years; }

#include<iostream>
using namespace std;

main(){
    int square_meters;
cout<<"Number of square meters you can paint: ";
cin>>square_meters;
int width;
cout<<"Width of the single wall (in meters): ";
cin>>width;
int height;
cout<<"Height of the single wall (in meters): ";
cin>>height;

int numberOfWalls= (square_meters/width)/height;


cout<<"Number of walls you can paint: "<<numberOfWalls;}


# include <iostream>
using namespace std;
main ()
{
int num1;
int num2;

cout<<"Number 1: ";
cin>>num1;

num2=num1;

cout<<"Number 2: ";
cin>>num1;

num2=num2+num1;

cout<<"Number 3: ";
cin>>num1;

num2=num2+num1;

cout<<"Number 4: ";
cin>>num1;

num2=num2+num1;

cout<<"Number 5: ";
cin>>num1;

num2=num2+num1;

cout<<"Sum = "<<num2;



}

#include<iostream>
using namespace std;
main()
{
cout<<"Enter your name: ";
string name;
cin>>name;
cout<<"Enter your roll number: ";
int roll_no;
cin>>roll_no;
cout<<"Enter your Aggregate: ";
float aggregate;
cin>>aggregate;
cout<<"Enter your section: ";
char section;
cin>> section;
cout<<"Student Information:"<<endl<<endl;
cout<<"Name: "<<name<<endl;
cout<<"Roll Number: "<<roll_no<<endl;
cout<<"Aggregate: "<<aggregate<<endl;
cout<<"Section: "<<section<<endl;
}

#include<iostream>
using namespace std;
main()
{
     cout<<"Enter weight in pounds: ";
    float lbs;
     cin>>lbs; 

 int kgs;
 kgs=lbs * 0.45;
 cout <<lbs<< " pounds is equal to " <<kgs<< " kilograms.";
}	

#include<iostream>
using namespace std;
main()
{
     int length;
 cout<<"Enter the length of the rectangle: ";
 cin>> length;
 float width;
 cout<<"Enter the width of the rectangle: ";
 cin>>width;
 
 float area;
 area=length * width;
 cout<<"The area of the rectangle is: "<<area;
	
}	

#include<iostream>
using namespace std;
main()
{
 float charge;
 cout<<"Enter the charge (Q) in Coulombs: ";
 cin>>charge;

 float time;
 cout<<"Enter the time (t) in seconds: ";
 cin>>time;
 
 float current;
 current=charge/time;
 cout<<"The current (I) is: "<<current<<" Amperes";
}	
	
	
	#include<iostream>
using namespace std;
main(){
 cout<<"Enter the student's name: ";
 string name;
 cin>>name;

 float matric_marks;
 cout<<"Enter matriculation marks (out of 1100): ";
 cin>> matric_marks;

 float FSC_marks;
cout<<"Enter intermediate marks (out of 550): ";
 cin>> FSC_marks;

cout<<"Enter Ecat marks (out of 400): ";
 float Ecat;
 cin>> Ecat;
  
 float aggregate;
 aggregate=(matric_marks/1100*10)+(FSC_marks/550*40)+(Ecat/400*50);
 cout<<"Aggregate score for "<<name<<" in UET is: "<<aggregate<<"%";
}	
	
	#include<iostream>
using namespace std;
main()
{
    int mbs;
 cout<<"Enter the size in megabytes (MB): ";
 cin>>mbs; 

 float bits;
 bits=mbs*1024*1024*8;
 cout<<mbs<<" MB is equivalent to "<<bits<<" bits.";
}	

#include<iostream>
using namespace std;
main(){
 cout<<"Enter the number of hours: ";
 int hours;
 cin>>hours; 

 int seconds;
 seconds=hours*60*60;
 cout<<hours<<" hours is equivalent to "<<seconds<<" seconds.";
}	
	
	#include<iostream>
using namespace std;
main()
{
  int volt;  
 cout<<"Enter voltage (in volts): ";
 cin>>volt;

 float current;
 cout<<"Enter current (in amperes): ";
 cin>>current;
 
 float power;
 power=volt * current;
 cout<<"The power is "<<power<<" watts.";
}	
	
	#include<iostream>
using namespace std;
main()
{
   int years; 
 cout<<"Enter your age in years: ";
 cin>>years; 

 float days;
 days=years * 365;
 cout<<"Your age in days is approximately "<<days<<" days.";
}	
	
	#include<iostream>
using namespace std;
main()
{
  int population;
cout<<"Enter the current world population: ";
cin>> population ;

cout<<"Enter the monthly birth rate (number of births per month): ";
int birth_rate;
cin>> birth_rate;

int popuInThreeDecades;
popuInThreeDecades=population+(birth_rate*3*10*12);
cout<<"The population in three decades will be: "<<popuInThreeDecades;
}


#include<iostream>
using namespace std;

main()
{
    string name ; int Wins , Draws , Losses;

    cout<<"Enter the name of the cricket team: ";
    cin>>name;
    cout<<"Enter the number of wins: ";
    cin>>Wins;
    cout<<"Enter the number of draws: ";
    cin>>Draws;
    cout<<"Enter the number of losses: ";
    cin>>Losses;


    Wins= 3 * Wins;
    Draws=1 * Draws;
   Losses=0 * Losses;
     int totalPoints = Wins + Draws + Losses;

    cout<<name<< " has obtained "<<totalPoints<< " points in the asia cup tournament.";


}

#include<iostream>
using namespace std;
void calculateFuel (float fuel);
main()
{
  
 float fueldata;
 cout<< "Enter the distance: ";
 cin >> fueldata;  
    
    calculateFuel (fueldata);
}

void calculateFuel(float fuel)
{
 float  Needed_fuel; 
Needed_fuel =fuel*10;
cout<<"Fuel needed: "<<Needed_fuel;

}
#include<iostream>
using namespace std;
void InchesToFeet (float feet);
main()
{
  
 float inches;
 cout<< "Enter the measurement in inches: ";
 cin >> inches;  
    
InchesToFeet (inches);

}

void InchesToFeet(float noOfInches)
{
 float  feet; 
feet =noOfInches/12;
cout<<"Equivalent in feet: "<<feet;

}
#include<iostream>
using namespace std;
void HowManyStickers (int stickers);
main()
{
  
 int Side_length;
 cout<< "Enter the side length of the Rubik's Cube: ";
 cin >> Side_length;  
    HowManyStickers (Side_length);

}
void HowManyStickers (int stickers)
{
int Stickers_needed; 
Stickers_needed =stickers*stickers*6;
cout<<"Number of stickers needed: "<<Stickers_needed;

}
#include<iostream>
using namespace std;
void add (int n1,int n2);
void multiply (int n1,int n2);
void divide (float n1,float n2);
void subtract (int n1,int n2);
main()
{
  
 float num1 , num2;
 char op;
 

 cout<< "Enter 1st number: ";
 cin >> num1;  
 cout<< "Enter 2nd number: ";
 cin >> num2;  
 cout<< "Enter an operator (+, -, *, /): ";
 cin >> op;

 if(op == '+')
{
add (num1,num2);
}
if(op == '*')
{
multiply (num1,num2);
}
if(op == '/')
{
divide (num1,num2);
}
if(op == '-')
{
subtract (num1,num2);
}


}


void subtract (int n1,int n2)
{
int subtract;
subtract=n1-n2;
cout<<"Subtraction: "<<subtract;
}


void multiply  (int n1,int n2)
{
int Product;
Product=n1 * n2;
cout<<"Multiplication: " << Product;
}

void add (int n1,int n2)
{
int Sum;
Sum=n1+n2;
cout<<"Addition: "<<Sum;
}



void divide (float n1,float n2)
{
float divde;
divde=n1/n2;
cout<<"Division: " << divide;
}




#include<iostream>
using namespace std;
void vote (int age);
main()
{
  
 int age;
 cout<< "Enter your age: ";
 cin >> age;  
  
  vote (age);
}
void vote(int age)
{
 if(age <= 17)
{
cout<<"You are not eligible to vote.";
}

if(age > 17)
{
cout<<"You are eligible to vote.";
}
} 

#include<iostream>
using namespace std;
void PassOrfail (int age);
main()
{
  
 int score;
 cout<< "Enter your score: ";
 cin >> score;  
  
PassOrfail(score);
}

void PassOrfail(int result)
{
    
 if(result <= 50)
{
cout<<"Fail";
}

if(result > 50)
{
cout<<"Pass";
}
} 

#include<iostream>
using namespace std;
void evenOrOdd (int number);
main()
{
  
 int number;
 cout<< "Enter a number: ";
 cin >> number;
 
 evenOrOdd (number);  
  
}
void evenOrOdd (int number)
{
 if(number % 2 == 0)
{
cout<<"Number "<<number<<" is even";
}

if(number % 2==1)
{
cout<<"Number "<<number<<" is odd";
}
}


#include<iostream>
using namespace std;
void  calculatePayableAmount (string day,float bill);
main()
{
    
    
 string day;
 cout<<"Enter the day of purchase: ";
 cin>>day;
 int purchase;
 cout<<"Enter the total purchase amount: $";
 cin>>purchase;

 
 calculatePayableAmount (day , purchase);
}



void calculatePayableAmount (string day,float bill_amount)
{
float Discounted_bill;
if (day == "Sunday")
{
 Discounted_bill=bill_amount-0.1*bill_amount;
}


cout<<"Payable Amount: $"<<Discounted_bill;

}

 #include<iostream>
using namespace std;
void fuel (float fuel);
main()
{
  
 float fuel_data;
 cout<< "Enter the distance: ";
 cin >> fuel_data;  
    
    fuel (fuel_data);

}

void fuel(float fuel)
{
 float  Needed_fuel;
  
 if  (Needed_fuel >= 100 )
 {
 Needed_fuel =fuel*10; 
 cout<<"Fuel needed: "<<Needed_fuel;
 }
 if (Needed_fuel<100)
 {
 cout<<"Fuel needed: 100"<<Needed_fuel;
 }
 

}

#include<iostream>
using namespace std;
void add (int n1,int n2);
void multiply (int n1,int n2);
void divide (float n1,float n2);
void subtract (int n1,int n2);
main()
{
  
 float num1 , num2;
 char op;
 while(1)
{
 cout<< "Enter 1st number: ";
 cin >> num1;  
 cout<< "Enter 2nd number: ";
 cin >> num2;  
 cout<< "Enter an operator (+, -, *, /): ";
 cin >> op;

 if(op == '+')
{
add (num1,num2);
}
if(op == '*')
{
multiply (num1,num2);
}
if(op == '/')
{
divide (num1,num2);
}
if(op == '-')
{
subtract (num1,num2);
}


}

}
void subtract (int n1,int n2)
{
int subtract;
subtract=n1-n2;
cout<<"Subtraction: "<<subtract;
}


void multiply  (int n1,int n2)
{
int Product;
Product=n1 * n2;
cout<<"Multiplication: " << Product;
}

void add (int n1,int n2)
{
int Sum;
Sum=n1+n2;
cout<<"Addition: "<<Sum;
}



void divide (float n1,float n2)
{
float divde;
divde=n1/n2;
cout<<"Division: " << divide;
}


 #include <iostream>
using namespace std;
main()
{
	while(1)
  {
  cout<<"zaid"<<endl;
}
}

#include<iostream>
using namespace std;
void Name(string name);
main()
{

	string name;
	while(true){
	Name(name);
}
	
}
void Name(string name){
	string name;
	cout<<"Your name is "<<name;
	cin>>name;
	
}


  #include<iostream>
using namespace std;
void  calculatePayableAmount (string day,float bill);
main()
{
    
  while(1)
{    
 string day;
 cout<<"Enter the day of purchase: ";
 cin>>day;
 int purchase;
 cout<<"Enter the total purchase amount: $";
 cin>>purchase;

 
 calculatePayableAmount (day , purchase);
}
}


void calculatePayableAmount (string day,float bill_amount)
{
float Discounted_bill;
if (day == "Sunday")
{
 Discounted_bill=bill_amount-0.1*bill_amount;
}


cout<<"Payable Amount: $"<<Discounted_bill;

}

#include<iostream>
#include<windows.h>
using namespace std;

void gotoxy(int x, int y)
{
 COORD coordinates;
 coordinates.X = x;
 coordinates.Y = y;
 SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coordinates);
}

main()
{
    cout<<"TEST"<<endl;

    gotoxy(30,30);

    cout<<"MY NAME IS ZAID";

}

#include<iostream>
using namespace std;

void printMaze()
{
 cout << "#######################" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#######################" << endl;
}

main()
{
    system("cls");
    printMaze();
}

#include<iostream>
#include<windows.h>
using namespace std;


void printMaze()
{
 cout << "#######################" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#######################" << endl;
}

void gotoxy(int x, int y)
{
 COORD coordinates;
 coordinates.X = x;
 coordinates.Y = y;
 SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coordinates);
}

main()
{
    system("cls");
    printMaze();
    gotoxy(4,3);
    cout<<"P";
    gotoxy(0 , 10);
}


#include<iostream>
#include<windows.h>
using namespace std;


void printMaze()
{
 cout << "#######################" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#######################" << endl;
}

void gotoxy(int x, int y)
{
 COORD coordinates;
 coordinates.X = x;
 coordinates.Y = y;
 SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coordinates);
}
void playerMove(int x, int y)
{
 gotoxy(x, y);
 cout << "P";
 Sleep(200);
 gotoxy(x, y);
 cout << " ";
;
}


main()
{
    int x=3 , y=4;
    system("cls");
    printMaze();

    while(1)
    {
        playerMove( x , y);
        x++;
        if(x==20)
        {
            x=3;
        }

    }
}


 #include<iostream>
#include<windows.h>
using namespace std;



void gotoxy(int x, int y)
{
 COORD coordinates;
 coordinates.X = x;
 coordinates.Y = y;
 SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coordinates);
}

main()
{
    gotoxy(50,15);

    cout<<"ZAID AMJAD";
}
  

#include<iostream>
using namespace std;

void printH()
{
    cout<<"H"<<endl;
}

void printa()
{
    cout<<"a"<<endl;
}


void prints()
{
    cout<<"s"<<endl;
}


void printn()
{
    cout<<"n"<<endl;
}

main()
{
    printH();
    printa();
    prints();
    prints();
    printa();
    printn();

}

#include<iostream>
#include<windows.h>
using namespace std;


void printMaze()
{
 cout << "#######################" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#######################" << endl;
}

void gotoxy(int x, int y)
{
 COORD coordinates;
 coordinates.X = x;
 coordinates.Y = y;
 SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coordinates);
}
void playerMove(int x, int y)
{
 gotoxy(x, y);
 cout << "Player";
 Sleep(200);
 gotoxy(x, y);
 cout << "      ";
;
}


main()
{
    int x=3 , y=1;
    system("cls");
    printMaze();

    while(1)
    {
        playerMove( x , y);
        y++;
        if(y==7)
        {
            y=1;
        }

    }
}

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

#include<iostream>
using namespace std;

void integers(int n1 , int n2)
{
    if(n1 ==  n2)
    {
        cout<<"true";
        
    }

    if(n1 > n2 ||  n1 < n2)
    {
        cout<<"false";
    }

}

main()
{
    
    
        
    int n1 ; int n2;
    cout<<"Enter the first number: ";cin>>n1;
    cout<<"Enter the second number: ";cin>>n2;

    integers(n1 , n2);

    
}

#include<iostream>
using namespace std;

void TrueOrFalse(string condition)
{
    
    if(condition=="true")

    cout<<"false";

    if(condition=="false")
    {
        cout<<"true";
    }
}

main()
{
    cout<<"Enter 'true' or 'false': ";
    string condition ; cin>>condition;

    TrueOrFalse(condition);
}

#include<iostream>
using namespace std;

void discount(string country, double ticketPrice)
{    
    double priceAfterDiscount; 
    
    if(country == "Pakistan")
    {   
        priceAfterDiscount = 0.95 * ticketPrice;
        cout << "Final ticket price after discount: $" << priceAfterDiscount;
    }
    if(country == "Ireland") 
    {
        priceAfterDiscount = 0.9 * ticketPrice;
        cout << "Final ticket price after discount: $" << priceAfterDiscount;
    }
    if(country == "India")
    {
        priceAfterDiscount = 0.8 * ticketPrice;
        cout << "Final ticket price after discount: $" << priceAfterDiscount;
    }
    if(country == "England")
    {
        priceAfterDiscount = 0.7 * ticketPrice;
        cout << "Final ticket price after discount: $" << priceAfterDiscount;
    }
    if(country == "Canada")
    {
        priceAfterDiscount = 0.55 * ticketPrice;
        cout << "Final ticket price after discount: $" << priceAfterDiscount;
    }
    
}

int main() 
{
    string name; 
    double ticketPrice;
    cout << "Enter the country's name: ";
    cin >> name;
    cout << "Enter the ticket price in dollars: $";
    cin >> ticketPrice;

    discount(name, ticketPrice);

  
}

#include<iostream>
using namespace std;

void condition(int sp)
{
    if(sp>100)
    {
        cout<<"Halt... YOU WILL BE CHALLENGED!!!";
    }
    if(sp<=100)
    {
        cout<<"Perfect! You're going good.";
    }
}
main()
{
    
    cout<<"Speed: ";
     int sp;cin>>sp;
    condition(sp);
}


#include<iostream>
using namespace std;

void dice(int p1 , int p2)
{
    if(p2-p1 > 6)
    {
        cout<<"false";
    }
    if(p2-p1 <=6)
    {
        cout<<"true";
    }

}


int main()
    {int p1,p2;
        cout<<"Enter your position: ";cin>>p1;
        cout<<"Enter your friend's position: ";cin>>p2;
        dice(p1,p2);
    }


#include<iostream>
using namespace std;

void longestDuration(int h ,int m)
{
int hours_to_min = 60 * h;
if(hours_to_min > m)
    {
        cout<<h;
    }
    
if(hours_to_min < m)
    {
        cout<<m;
    }

}

int main()
{int hour,min;
    cout<<"Enter the number of hours: ";cin>>hour;
    cout<<"Enter the number of minutes: ";cin>>min;
    longestDuration(hour,min);
}

	
	#include<iostream>
using namespace std;

void flowerShop(int redRose , int whiteRose , int tulip)
{
    int red_price = 2 * redRose;
    float white_price = 4.1 * whiteRose;
    float tulip_price = 2.5 * tulip;
    float total_price = red_price+white_price+tulip_price;

    cout<<"Original price: $"<<total_price<<endl;
    if(total_price>=200)
    {
        float discounted_value = total_price*20/100;
        float actual_value = total_price-discounted_value;

        cout<<"Price after Discount: $"<<actual_value<<endl;
    }
    if(total_price<200)
    {
        cout<<"No discount applied."<<endl;
    }

}
main()
{
    int red , white , tulips;
    cout<<"Red Rose: ";cin>>red;
    cout<<"White Rose: ";cin>>white;
    cout<<"Tulips: ";cin>>tulips;

   flowerShop(red , white , tulips);
    
}
	
	
	#include<iostream>
using namespace std;

void pet(int holidays)
{
    int daysInYear = 365 ;
    int workingDays = daysInYear - holidays;
    int WorkingDaysmins = 63;
    int HolidaysMins = 127;
    int totalPlaytime = (workingDays * WorkingDaysmins) + (holidays * HolidaysMins);
    int norm = 30000;

    if(totalPlaytime<norm)
    {
        cout<<"Tom sleeps well"<<endl;

        int difference =  norm - totalPlaytime;

        int hours = difference / 60;
        int mins =  difference % 60;

        cout<<hours<<" hours and "<<mins<<" minutes less for play";


    }

    if(totalPlaytime>norm)
    {
        cout<<"Tom will run away"<<endl;
         int difference =  totalPlaytime - norm;
        int hours = difference / 60;
        int mins =  difference % 60;

        cout<<hours<<" hours and "<<mins<<" minutes for play";


    }
}


    


main()
{
    int holidays;
    cout<<"Holidays: ";cin>>holidays;
    pet(holidays);
}
	
	
	#include<iostream>
using namespace std;
 void tpChecker(int people , int tp)
 {
    int avg_sheets_day = people*57;
    int total_sheets = tp*500;
    int remaing_days = total_sheets/avg_sheets_day;
    
    if(remaing_days < 14)
    {
        cout<<"Your TP will only last " << remaing_days << " days, buy more!";
    }

    if(remaing_days >= 14)
    {
        cout<<"Your TP will last " << remaing_days << " days, no need to panic!";
    }

 }

 main()
 {
    int people , tp;
    cout<<"Number of people in the household: ";cin>>people;
    cout<<"Number of rolls of TP: ";cin>>tp;
    tpChecker(people,tp);
 }

	
	
	
	

	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
