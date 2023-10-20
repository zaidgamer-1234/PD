#include<iostream>
using namespace std;
float discount(string day , string month, float amount);
main()
{
    string day , month; float amount;

    cout<<"Enter purchase day: ";cin>>day;
    cout<<"Enter purchase month: ";cin>>month;
    cout<<"Enter purchase amount: ";cin>>amount;
    cout<<"Payable amount after discount: "<<discount( day ,  month,  amount);
}

float discount(string day , string month, float amount)
{
    float payAbleamount;
    if(day=="Sunday" || month == "October")
    {
        payAbleamount=amount-(amount*.1);
    }
   

    return payAbleamount;
}