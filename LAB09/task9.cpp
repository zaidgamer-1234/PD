#include<iostream>
using namespace std;
bool canPayWithChange(double change[], double totalDue);
double Sum=0 ; 
main()
{
    
    int quarters , dimes , nickles , pennies ; double totalDue; double change[4];


    cout<<"Enter quarters: ";cin>>quarters;
    cout<<"Enter dimes: ";cin>>dimes;
    cout<<"Enter nickels: ";cin>>nickles;
    cout<<"Enter pennies: ";cin>>pennies;
    cout<<"Enter the total amount due: $";cin>>totalDue;

    change[0]= quarters;
    change[1]= dimes;
    change[2]= nickles;
    change[3]= pennies;



    bool result= canPayWithChange(change, totalDue);
    if(result)
    {
        cout<<"Can you pay the amount? Yes";
    }
    else{
            cout<<"Can you pay the amount? No";

    }


}

bool canPayWithChange(double change[], double totalDue)
{
   
    Sum = (change[0] * 0.25) + (change[1] * 0.1) + (change[2] * 0.05) + (change[3] * 0.01);
    
  
    if(Sum >= totalDue)
    {
        return true;
    }
    else{
          return false;
    }
     
}