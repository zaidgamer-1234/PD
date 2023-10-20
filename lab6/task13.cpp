#include<iostream>
using namespace std;
float lowestPrice(string period , int kms);
main()
{   double taxi_starting_fee = 0.70;
    double taxi_day_rate = 0.79;
    double taxi_night_rate = 0.90;
    double bus_rate = 0.09;
    double train_rate = 0.06;

    int kms ; string period ;
    cout<<"Enter the number of kilometers: ";cin>>kms;
    cout<<"Enter the period of the day (day/night): ";cin>>period;
    cout<<"Lowest price for "<<kms<<" kilometers: "<<lowestPrice( period ,  kms);
}
  float lowestPrice(string period , int kms)

{   float price;

    if(period=="day")
    {
      price= 0.7+(kms * 0.79);
    } 
    else{
        price= 0.7+(kms * 0.90);
    }
    
    

    if(kms>=20)
    {
        price= kms * .09;;
    }
    if(kms>=100)
    {
        price= kms * .06;;
    }


    return price;
}
