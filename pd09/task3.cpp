#include<iostream>
using namespace std;
bool areAllElementsIdentical(string arr[] , int n);

main()
{
  int n;
  cout<<"Enter the size of Array: ";cin>>n;
   
  string arr[n];

   for(int i=0 ; i<n ; i++)
   {
     cout<<"Enter Element "<<i+1<<": ";
     cin>>arr[i];
   }
   cout<<areAllElementsIdentical(arr , n);

}


  bool areAllElementsIdentical(string arr[] , int n)
  {
    for(int i=1 ; i<n ; i++)
    {
        if(arr[i] == arr[i-1])
        {
            return true;
        }
    }
    return false;
  }

  