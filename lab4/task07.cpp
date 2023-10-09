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
