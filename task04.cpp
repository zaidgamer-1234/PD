#include<iostream>
using namespace std;

void condition(int sp)
{
    if(sp>100)
    {
        cout<<"Halt... YOU WILL BE CHALLENGED!!!";
    }
    if(sp<=100)
    {
        cout<<"Perfect! You're going good.";
    }
}
main()
{
    
    cout<<"Speed: ";
     int sp;cin>>sp;
    condition(sp);
}