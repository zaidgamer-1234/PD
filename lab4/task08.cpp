#include<iostream>
using namespace std;
void  calculatePayableAmount (string day,float bill);
main()
{
    
    
 string day;
 cout<<"Enter the day of purchase: ";
 cin>>day;
 int purchase;
 cout<<"Enter the total purchase amount: $";
 cin>>purchase;

 
 calculatePayableAmount (day , purchase);
}



void calculatePayableAmount (string day,float bill_amount)
{
float Discounted_bill;
if (day == "Sunday")
{
 Discounted_bill=bill_amount-0.1*bill_amount;
}


cout<<"Payable Amount: $"<<Discounted_bill;

}


 
  