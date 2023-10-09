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







