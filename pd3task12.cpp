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