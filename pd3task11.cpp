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