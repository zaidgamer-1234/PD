# include <iostream>
using namespace std;
main ()
{
string name;
int adult_tic_price;
int chil_tic_price;
int adults;
int childs;
float donation;
float total;
float donar;
int remaining;

cout<<"Enter the movie name: ";
cin>>name;

cout<<"Enter the adult ticket price: $";
cin>>adult_tic_price;

cout<<"Enter the child ticket price: $";
cin>>chil_tic_price;

cout<<"Enter the number of adult tickets sold: ";
cin>>adults;

cout<<"Enter the number of child tickets sold: ";
cin>>childs;

cout<<"Enter the percentage of the amount to be donated to charity: ";
cin>>donation;

total=(adult_tic_price*adults)+(chil_tic_price*childs);

donar=(total/100)*donation;

remaining=total-donar;
cout<<endl;

cout<<"Movie: "<<name<<endl;
cout<<"Total amount generated from ticket sales: $"<<total<<endl;
cout<<"Donation to charity ("<<donation<<"%): $"<<donar<<endl;
cout<<"Remaining amount after donation: $"<<remaining;



}
