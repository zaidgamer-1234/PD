#include<iostream>
using namespace std;

bool trueOrfalse(int num1 , int num2)
{
    if(num1>num2)
    {
        return true;
    }
    else{
        return false;
    }
    
    
   

}

main()
{
    int n1, n2;
    cout<<"Enter the first number: ";cin>>n1;
    cout<<"Enter the second number: ";cin>>n2;
    cout<<trueOrfalse(n1 , n2);
}