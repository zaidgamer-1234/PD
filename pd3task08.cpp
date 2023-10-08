# include <iostream>
using namespace std;
main()
{
float veg_price;
float frt_price;
int veg_total_kgs;
int frt_total_kgs;
float coins_total;
float rupees_total;

cout<<"Enter vegetable price per kilogram (in coins): ";
cin>>veg_price;

cout<<"Enter fruit price per kilogram (in coins): ";
cin>>frt_price;

cout<<"Enter total kilograms of vegetables: ";
cin>>veg_total_kgs;

cout<<"Enter total kilograms of fruits: ";
cin>>frt_total_kgs;

coins_total=(veg_price*veg_total_kgs)+(frt_price*frt_total_kgs);
rupees_total=coins_total/1.94;

cout<<"Total earnings in Rupees (Rps): "<<rupees_total;

}
