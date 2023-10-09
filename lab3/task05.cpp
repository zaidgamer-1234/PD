#include<iostream>
using namespace std;
main(){
 cout<<"Enter the student's name: ";
 string name;
 cin>>name;

 float matric_marks;
 cout<<"Enter matriculation marks (out of 1100): ";
 cin>> matric_marks;

 float FSC_marks;
cout<<"Enter intermediate marks (out of 550): ";
 cin>> FSC_marks;

cout<<"Enter Ecat marks (out of 400): ";
 float Ecat;
 cin>> Ecat;
  
 float aggregate;
 aggregate=(matric_marks/1100*10)+(FSC_marks/550*40)+(Ecat/400*50);
 cout<<"Aggregate score for "<<name<<" in UET is: "<<aggregate<<"%";
}	