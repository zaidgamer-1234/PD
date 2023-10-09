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
