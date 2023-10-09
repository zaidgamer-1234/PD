#include<iostream>
using namespace std;
void HowManyStickers (int stickers);
main()
{
  
 int Side_length;
 cout<< "Enter the side length of the Rubik's Cube: ";
 cin >> Side_length;  
    HowManyStickers (Side_length);

}
void HowManyStickers (int stickers)
{
int Stickers_needed; 
Stickers_needed =stickers*stickers*6;
cout<<"Number of stickers needed: "<<Stickers_needed;

}







