#include<iostream>
using namespace std;
string findZodiacSign(int day , string month);

main()
{
    int day ; string month;
    cout<<"Enter the day of birth: ";cin>>day;
    cout<<"Enter the month of birth (e.g., Januaury, Febraury): ";cin>>month;
    cout<<"Zodiac sign: "<<findZodiacSign( day ,  month);
}

string findZodiacSign(int day , string month)
{
    string sign;
    if((month=="march" && day>=21 && day<=31) || (month=="april" && day>=1 && day<=19))
    {
       sign = "Aries";
    }
     if((month=="april" && day>=20 && day<=31) || (month=="may" && day>=1 && day<=20))
    {
       sign = "Taurus";
    }

   if((month=="may" && day>=21 && day<=31) || (month=="june" && day>=1 && day<=20))
    {
       sign = "Gemini";
    }
     if((month=="june" && day>=21 && day<=31) || (month=="july" && day>=1 && day<=22))
    {
       sign = "Cancer";
    }
     if((month=="july" && day>=23 && day<=31) || (month=="august" && day>=1 && day<=22))
    {
       sign = "Leo";
    }
     if((month=="august" && day>=23 && day<=31) || (month=="september" && day>=1 && day<=22))
    {
       sign = "Virgo";
    }
     if((month=="september" && day>=23 && day<=31) || (month=="october" && day>=1 && day<=22))
    {
       sign = "Libra";
    }
     if((month=="october" && day>=23 && day<=31) || (month=="november" && day>=1 && day<=21))
    {
       sign = "Scorpio";
    }
     if((month=="november" && day>=22 && day<=31) || (month=="december" && day>=1 && day<=21))
    {
       sign = "Sagittarius";
    }
     if((month=="december" && day>=22 && day<=31) || (month=="januaury" && day>=1 && day<=19))
    {
       sign = "Capricorn";
    }
     if((month=="januaury" && day>=20 && day<=31) || (month=="febuaury" && day>=1 && day<=18))
    {
       sign = "Aquarius";
    }
    return sign;
}    