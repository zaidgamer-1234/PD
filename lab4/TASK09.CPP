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
