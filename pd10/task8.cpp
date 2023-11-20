#include<iostream>
using namespace std;
int direction(int length , string arr[]);

main()
{
    int length;
    cout<<"Enter the length of the array: ";cin>>length;
    cout<<"Enter the elements of the array (\"left\" or \"right\"):"<<endl;

    string arr[length];

    for(int i=0 ; i<length ; i++)
    {
        cin>>arr[i];
    }
    int  result = direction(length , arr);

    cout<<"Number of full rotations: "<<result;

}

int direction(int length , string arr[])
{
    
    int direction = 0;
    for( int i=0; i<length ; i++)
    {
        if(arr[i] == "right")
        {
            direction += 90;
        }
        else if(arr[i] == "left")
        {
            direction -= 90;
        }
    }
    int rotation = direction / 360;

    return rotation;

    
}