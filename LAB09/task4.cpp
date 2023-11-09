#include<iostream>
using namespace std;
void reverseNumber(int arr[] , int n);
main()
{
    int n;
    cout<<"Enter the number of elements: ";cin>>n;
    cout<<"Enter"<<n<<" numbers, one per line:"<<endl;;

    int arr[n];

    for(int i=0 ; i<n ; i++)
    {
        cin>>arr[i];
    }
    cout<<"Numbers in reverse order: ";
    reverseNumber(arr , n);


}

void reverseNumber(int arr[] , int n)
{
    for(int i=n-1 ; i>=0 ; i--)
    {
        cout<<arr[i]<<" ";
    }
}
    