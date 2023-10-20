#include<iostream>
using namespace std;
string decideActivity(string temp , string humidity , string activity);

main()
{
   string temp , humidity , activity;
   cout<<"Enter temperature (warm or cold): ";cin>>temp;
   cout<<"Enter humidity (dry or humid): ";cin>>humidity;
   cout<<"Recommended activity: "<<decideActivity( temp ,  humidity ,  activity);
}

string decideActivity(string temp , string humidity , string activity)
{
    if(temp=="warm"&&humidity=="dry")
    {
        return "Play tennis";
    }
    if(temp=="warm"&&humidity=="humid")
    {
        return "swim";
    }
    if(temp=="cold"&&humidity=="dry")
    {
        return "Play basketball";
    }
    else{
        return "Watch TV";
    }
}