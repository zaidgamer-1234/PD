#include<iostream>
using namespace std;
int volleyballGames(string year, int weekends , int holidays);
main()
{
    string year; int weekends , holidays;
    cout<<"Enter year type: ";cin>>year;
    cout<<"Enter number of holidays: ";cin>>holidays;
    cout<<"Enter number of weekends: ";cin>>weekends;
    cout<<volleyballGames( year,  weekends ,  holidays);
}

int volleyballGames(string year, int weekends , int holidays)
{
    int weekendsInYear = 48;
    int weekendsInSofia= weekendsInYear - weekends;
    int SofiaHolidays = (2/3) * holidays;
    int WeekendsInSofia= weekendsInSofia - SofiaHolidays;
    int NoWorkWeekEnds= (3/4) * weekendsInSofia;
    int SofiaVolleyball= WeekendsInSofia - NoWorkWeekEnds;

    if (year == "leap") {
        int extraWeekends = (.15 * weekendsInYear) ;
       SofiaVolleyball = SofiaVolleyball + extraWeekends;

    }
    return SofiaVolleyball;
}
