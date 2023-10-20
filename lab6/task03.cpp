#include<iostream>
using namespace std;

float perimeter(char side , float value);
main()
{
    float value , result; char side; 
    cout<<"Enter the shape (s for square, c for circle, t for triangle, h for hexagon): ";cin>>side;
    cout<<"Enter the value: ";cin>>value;
    result=perimeter(side , value);
    cout<<"The perimeter is: "<<result;
}

float perimeter(char side , float value)
{    
    float perimeter;
    if(side=='s')
    {
         perimeter= 4*value;
    }

    if(side=='c')
    {
         perimeter=value*6.28;
    }

    
    if(side=='t')
    {
       perimeter=value*3;
    }
    
    if(side=='h')
    {
         perimeter=value*6;
    }
    return perimeter;
}