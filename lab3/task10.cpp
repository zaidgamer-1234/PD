#include<iostream>
using namespace std;

main()
{
    string name ; int Wins , Draws , Losses;

    cout<<"Enter the name of the cricket team: ";
    cin>>name;
    cout<<"Enter the number of wins: ";
    cin>>Wins;
    cout<<"Enter the number of draws: ";
    cin>>Draws;
    cout<<"Enter the number of losses: ";
    cin>>Losses;


    Wins= 3 * Wins;
    Draws=1 * Draws;
   Losses=0 * Losses;
     int totalPoints = Wins + Draws + Losses;

    cout<<name<< " has obtained "<<totalPoints<< " points in the asia cup tournament.";


}

