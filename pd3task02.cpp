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