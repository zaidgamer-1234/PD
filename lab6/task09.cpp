#include<iostream>
using namespace std;
string checkTitle(int age , char gender);
main()
{
    int age ; char gender;
    cout<<" Enter your age: ";cin>>age;
    cout<<"Enter your gender (m/f): ";cin>>gender;
    cout<<"Your pesonal title is: "<<checkTitle( age ,  gender);
}


string checkTitle(int age , char gender)
{
    string result;
    if(gender=='m' && age>=16)
    {
        result="Mr.";
    }
    if(gender=='m' && age<16)
    {
        result="Master";
    }
    if(gender=='f' && age>=16)
    {
        result="Ms.";
    }
    if(gender=='f' && age<16)
    {
        result="Miss";
    }
    return  result;

}