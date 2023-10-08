#include<iostream>
using namespace std;

main() {
float i_velocity ;
float acceleration ;
float time ;
float f_velocity;

cout<<"Enter Initial Velocity (m/s): ";
cin>>i_velocity;

cout<<"Enter Acceleration (m/s^2): ";
cin>>acceleration;

cout<<"Enter Time (s): ";
cin>>time;

f_velocity=acceleration*time+i_velocity;

cout<<"Final Velocity (m/s): "<<f_velocity;
 }