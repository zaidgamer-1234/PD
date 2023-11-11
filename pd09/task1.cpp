#include<iostream>
using namespace std;
bool isLengthEven(string input);


main()
{

    string input;
    cout<<"Enter a String: ";
    getline(cin , input);
   cout<< isLengthEven(input);


}

bool isLengthEven(string input)
{
    if(input.length() % 2==0)
    {
        return true;
    }
    return false;

}
