#include<iostream>
using namespace std;
float Studiocalculation(string month ,  int stays);
float ApartmentCalculation(string month, int stays);

main()
{
    string month; int stays;
    cout<<"Enter the month: ";cin>>month;
    cout<<"Enter the number of stays: ";cin>>stays;
    cout<<"Apartment: "<<ApartmentCalculation( month,  stays)<<"$"<<endl;
    cout<<"Studio: "<< Studiocalculation( month ,   stays)<<"$";
}

float Studiocalculation(string month ,  int stays)
{   float price ;
    if(month=="may" || month=="october" )
    {
        price= stays * 50;
    }
    if(month=="june" || month=="september" )
    {
        price= (stays * 75.2);
    }
    if(month=="july" || month=="august" )
    {
        price= (stays * 76); 
    }
    if(month=="may" || month=="october" && stays>7)
    {
        price= (stays * 50) - (stays * 50 * .05);
    }
    if(month=="may" || month=="october" && stays>14)
    {
        price= (stays * 50) - (stays * 50 * .3);
    }
    if(month=="june" || month=="september" && stays>14)
    {
        price= (stays * 75.2)- (stays * 75.2* .1);
    }
    return price;
}

float ApartmentCalculation(string month, int stays)
{     float price2;
     if(month=="may" || month=="october" && stays<=14)
     {
       price2=65 * stays;
     }
     if(month=="june" || month=="september" && stays<=14)
     {
       price2=68.7 * stays;
     }
     if(month=="july" || month=="august" && stays<=14)
     {
       price2=77 * stays;
     }
     if(stays>14 && month=="may" || month=="october" )

     {
        price2= (stays * 65)- (stays * 65 * .1);
     }
     if(stays>14 && month=="june" || month=="september" )

     {
        price2= (stays * 68.7)- (stays * 68.7 * .1);
     }
     if(stays>14 && month=="july" || month=="august" )

     {
        price2= (stays * 77)- (stays * 77 * .1);
     }
     return price2;
}