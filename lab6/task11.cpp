#include<iostream>
using namespace std;
string checkSpeed(float speed);

main()
{
    int speed;
    cout<<"Enter the speed: ";cin>>speed;
    checkSpeed(speed);
   cout<< checkSpeed( speed);
}

string checkSpeed(float speed)
{   
    if(speed<=10)
    {
        return"slow";
    }
    if(speed<=50)
    {
        return"average";
    }
    if(speed<=150)
    {
        return"fast";
    }
    if(speed<=1000)
    {
        return "ultra fast";
    }
    else
    {
        return "extremely fast";
    }
    

}