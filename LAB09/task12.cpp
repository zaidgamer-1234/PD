#include<iostream>
using namespace std;
bool isSpecialArray(int arr[], int size); 

main()
{
    int size;
    cout<<"Enter the size of the array: ";cin>>size;
    cout<<"Enter "<<size<<" elements of the array:"<<endl;

    int arr[size];

    for(int i=0 ; i<size ; i++)
    {
      cin>>arr[i];
    }
    if(isSpecialArray(arr  , size))
    {
        cout<<"The array is special";
    }
    else{
        cout<<"The array is not special";
    }
}
bool isSpecialArray(int arr[], int size) {
    for (int i = 0; i < size; i++) {
        if (i % 2 == 0 && arr[i] % 2 != 0) {
            return false; 
        }
        if (i % 2 != 0 && arr[i] % 2 == 0) {
            return false; 
        }
    }
    return true;
}