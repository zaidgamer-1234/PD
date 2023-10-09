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