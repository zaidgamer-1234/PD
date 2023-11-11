#include<iostream>
using namespace std;

void evenOddTransform(int arr[], int size, int n);

main()
{
    int size, n;
    cout<<"Enter the size of Array: ";
    cin>>size;

    int arr[size];

    for (int i = 0; i < size; i++)
    {
        cout<< "Enter Element " << i + 1 << ": ";
        cin>> arr[i];
    }

    cout<< "Enter number of times even-odd transformation need to be done: ";
    cin>> n;

    evenOddTransform(arr, size, n);

   
}

void evenOddTransform(int arr[], int size, int n)
{
    for (int i = 0; i < size; i++)
    {
        if (arr[i] % 2 == 0)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i] = arr[i] - 2;
            }
        }
        else
        {
            for (int j = 0; j < n; j++)
            {
                arr[i] = arr[i] + 2;
            }
        }
    }

    cout << "[";
    for (int i = 0; i < size; i++)
    {
        cout << arr[i];
        if (i < size - 1)
        {
            cout << ", ";
        }
    }
    cout << "]" << endl;
}
