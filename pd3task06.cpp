# include <iostream>
using namespace std;
main ()
{
float pound;
float cost;
float size;
float costp_pound;
float costp_sq_foot;

cout<<"Enter the size of the fertilizer bag in pounds: ";
cin>>pound;

cout<<"Enter the cost of the bag: $";
cin>>cost;

cout<<"Enter the area in square feet that can be covered by the bag: ";
cin>>size;

costp_pound=cost/pound;
costp_sq_foot=cost/size;

cout<<"Cost of fertilizer per pound: "<<"$"<<costp_pound<<endl;
cout<<"Cost of fertilizing per square foot: "<<"$"<<costp_sq_foot;


}
