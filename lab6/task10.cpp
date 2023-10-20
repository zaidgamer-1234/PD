#include<iostream>
using namespace std;
bool areSameNumber(int n1 , int n2 , int n3);
main()
{
    int n1 , n2 , n3;
    cout<<"Enter the first number: ";cin>>n1;
    cout<<"Enter the second number: ";cin>>n2;
    cout<<"Enter the third number: ";cin>>n3;
    cout<<areSameNumber( n1 ,  n2 ,  n3);
}

bool areSameNumber(int n1 , int n2 , int n3)
{
    if(n1==n2 && n2==n3)
    {
        return true;
    }
    else{
        return false;
    }
}