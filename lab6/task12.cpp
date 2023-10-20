#include<iostream>
using namespace std;
float totalIncome(string type , int rows , int coloumns);
main()
{
    string type; int rows , coloumns;
    cout<<"Enter the screening type (Premier/Normal/Discount): ";cin>>type;
    cout<<"Enter the number of rows: ";cin>>rows;
    cout<<"Enter the number of coloumns: ";cin>>coloumns;
    cout<<totalIncome( type ,  rows ,  coloumns); 
}

float totalIncome(string type , int rows , int coloumns)
{
    float result;
    if(type=="premier")
    {
        result=12 * rows * coloumns;
    }
    if(type=="normal")
    {
        result=7.5 * rows * coloumns;
    }
    if(type=="discount")
    {
        result=5 * rows * coloumns;
    }
    return result;
}

