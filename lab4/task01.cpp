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







