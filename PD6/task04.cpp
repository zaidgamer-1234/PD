#include<iostream>
using namespace std;
float calculation( char code , char time , int mins , string type);


main()
{
    char code ,  time ; int mins ; string type;

    cout<<"Enter the service code: ";cin>>code;
    if(code=='p'|| code=='P')
    {
            cout<<"Enter the time of the call: ";cin>>time;
    }

    cout<<"Enter the number of minutes used: ";cin>>mins;
    cout<<"Service type: ";cin>>type;
    cout<<"Total minutes used: "<<mins<<endl;
    cout<<"Amount due: $"<<calculation(  code ,  time ,  mins ,  type);
}

float calculation( char code , char time , int mins , string type)
{    
    float amount ;
    if(code=='p'||code=='P')
    {
       amount=25;
    }
    if(code=='r'|| code=='R')
    {
        amount=10;
    }
     if (code=='r' || code=='R'&& time == 'D' || time == 'd' && mins>75) {
             
                amount = 10+ 0.10 * (mins - 75);
            
        }
         if (code=='r' || code=='R'&& time == 'N' || time == 'n' && mins>100) {
            
                amount =10+ 0.05 * (mins - 100);
            
        }

        if (code=='r' || code=='R'&& mins > 50 ) {
            amount =10+ 0.20 * (mins - 50);
        }
        return amount;
}    

    
