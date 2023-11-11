#include<iostream>
using namespace std;
int coloringTime(string cols[], int size);
main()
{
    int size;
    cout<<"Enter the size of Array: ";cin>>size;

    string cols[size];

    for(int i=0 ; i<size ; i++)
    {
        cout<<"Enter Element "<<i+1<<": ";
        cin>>cols[i];
    }

  
   

    cout<<"Time to color: "<<coloringTime(cols,  size)<<" seconds";
}

int coloringTime(string cols[], int size)
{
     
    int Sec_to_color = 2 * size;
   
    int switch_Color=0;

    for(int i=0 ; i<size ; i++)
    {
        if(i+1<size)
        {
            for(int j=i+1 ; j<=i+1 ; j++)
        {
            if(cols[i] != cols[j])
            {
               switch_Color++;
            }
        }
        }
        
    }
    return Sec_to_color + switch_Color;
}