// #include <iostream>
// #include <string>
// #include <cstring>
// using namespace std;

// void convertPINToDance(string pin);

// string moves[] = {"Shimmy", "Shake", "Pirouette", "Slide", "Box Step", "Headspin", "Dosado", "Pop", "Lock", "Arabesque"};

// main()
// {

//     // string digits[4];
//     string PIN;
//     cout << "ENter your PIN";
//     cin >> PIN;
//     // for(int i=0; i<digits; i++)
//     //     {
//     //         cin>>digits[i];
//     //     }
//     convertPINToDance(PIN);
// }

// void convertPINToDance(string pin)
// {

//     int numbers[4];
//     string ans[4];


//     for (int i = 0; i < pin.length(); i++)
//     {
//         if (pin[i] >= '0' && pin[i] <= '9')
//         {
//             numbers[i] = pin[i] - '0';
            
//         }
//         else
//         {
//             cout << "Invalid Input";
//         }
//     }

//     for (int i = 0; i < 4; i++)
//     {
//         int index = (numbers[i] + i) % 10;
//         string move = moves[index];
//         //    string move = moves[numbers[i]  + i];
//         ans[i] = move;
//     }

//     for (int i = 0; i < 4; i++)
//     {
//         cout << ans[i] << " ";
//     }
// }


#include <iostream>
#include <string>
#include <cstring>

using namespace std;

void convertPINToDance(string pin);

string moves[] = {"Shimmy", "Shake", "Pirouette", "Slide", "Box Step", "Headspin", "Dosado", "Pop", "Lock", "Arabesque"};

int main()
{
    string PIN;
    cout << "Enter your PIN (4 digits): ";
    cin >> PIN;
    convertPINToDance(PIN);

    
}

void convertPINToDance(string pin)
{
    int numbers[4];
    string ans[4];

    bool validInput = true;
    for (char c : pin)
    {
        if (!isdigit(c) || pin.length()<4)
        {
            validInput = false;
            break;
        }
    }

    if (!validInput)
    {
        cout << "Invalid input." << endl;
        return;
    }

    for (int i = 0; i < pin.length(); i++)
    {
        numbers[i] = pin[i] - '0';
    }

    for (int i = 0; i < 4; i++)
    {
        int index = (numbers[i] + i) % 10;
        string move = moves[index];
        ans[i] = move;
    }

    for (int i = 0; i < 4; i++)
    {
         cout << ans[i] ;
        if(i<3)
        {
            cout<<","<<" ";
        }
       
    }
}
