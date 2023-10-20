#include <iostream>
using namespace std;
#include<cmath>

void calculate(int timeh, int timem, int hours, int mins);

 main() {
    int timeh, timem, hours, mins;

    cout << "Enter exam starting time (hour): "; cin >> timeh;
    cout << "Enter exam starting time (minutes): ";cin >> timem;
    cout << "Enter student hour of arrival: ";cin >> hours;
    cout << "Enter student minutes of arrival: ";cin >> mins;

    calculate(timeh, timem, hours, mins);

    
}

void calculate(int timeh, int timem, int hours, int mins) 
{   
    int startingTimeInMins = timeh * 60 + timem;
    int arrivalInMins = hours * 60 + mins;
    int difference = arrivalInMins - startingTimeInMins;

    if (difference > 0) {
        cout << "Late" << endl;
    } else if (difference >= -30) {
        cout << "On time" << endl;
    } else {
        cout << "Early" << endl;
    }

    int hoursDifference = abs (difference) / 60;
    int minutesDifference =abs (difference) % 60;
   
   if(difference!=0 && difference>0)
   {
    cout<<hoursDifference<<" : "<<minutesDifference<<" hours ";
   }
   else{
    cout<<minutesDifference<<" minutes ";
   }
   if(difference<0)
   {
    cout<<" before the start";
   }
   else{
    cout<<" after the start";
   }
        
}