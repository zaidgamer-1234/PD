#include<iostream>
using namespace std;
float calculation( string fruit ,  string day , int quantity);


main()
{
    string fruit; string day; float quantity;
    cout<<"Enter fruit name: ";cin>>fruit;
    cout<<"Enter day: ";cin>>day;
    cout<<"Enter quantity: ";cin>>quantity;
    cout<<"Total price: "<<calculation(  fruit ,   day ,  quantity);
}

float calculation( string fruit ,  string day , int quantity)
{  float price;
   if(day=="Monday" || day=="Tuesday" || day=="Wednesday" || day=="Thursday" || day=="Friday"&& fruit=="Banana") 
   {
      price= 2.5 * quantity;
   }
  else if(day=="Monday" || day=="Tuesday" || day=="Wednesday" || day=="Thursday" || day=="Friday"&& fruit=="Apple") 
   {
    price=1.2 * quantity;
   }
 else  if(day=="Monday" || day=="Tuesday" || day=="Wednesday" || day=="Thursday" || day=="Friday"&& fruit=="Orange") 
   {
    price=.85 * quantity;
   }
  else if(day=="Monday" || day=="Tuesday" || day=="Wednesday" || day=="Thursday" || day=="Friday"&& fruit=="Grapefruit") 
   {
    price=1.45 * quantity;
   }
  else if(day=="Monday" || day=="Tuesday" || day=="Wednesday" || day=="Thursday" || day=="Friday"&& fruit=="Kiwi") 
   {
    price=2.7 * quantity;
   }
  else if(day=="Monday" || day=="Tuesday" || day=="Wednesday" || day=="Thursday" || day=="Friday"&& fruit=="Pineapple") 
   {
    price=5.5 * quantity;
   }
 else  if(day=="Monday" || day=="Tuesday" || day=="Wednesday" || day=="Thursday" || day=="Friday"&& fruit=="Grapes") 
   {
    price=3.85 * quantity;
   }
   else  if(day=="Saturday" || day=="Sunday" && fruit=="Banana") 
   {
    price=2.7 * quantity;
   }
    else  if(day=="Saturday" || day=="Sunday" && fruit=="Apple") 
   {
    price=1.25 * quantity;
   }
    else  if(day=="Saturday" || day=="Sunday" && fruit=="Orange") 
   {
    price=.9 * quantity;
   }
    else  if(day=="Saturday" || day=="Sunday" && fruit=="Grapefruit") 
   {
    price=1.6 * quantity;
   }
    else  if(day=="Saturday" || day=="Sunday" && fruit=="Kiwi") 
   {
    price=3 * quantity;
   }
    else  if(day=="Saturday" || day=="Sunday" && fruit=="Pineapple") 
   {
    price=5.6 * quantity;
   }
    else  if(day=="Saturday" || day=="Sunday" && fruit=="Grapes") 
   {
    price=4.2 * quantity;
   }
   return price;
}





