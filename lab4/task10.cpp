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