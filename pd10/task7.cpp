#include<iostream>
using namespace std;

bool Consecutive(int arr[], int length);

main()
{
  int  length;
  cout<<"Enter the length of the array: ";cin>>length;
  cout<<"Enter the elements of the array:"<<endl;


  int arr[length];

  for(int i=0 ; i<length ; i++)
  {
    cin>>arr[i];
  }
  bool result =  Consecutive(arr, length);
  cout<<"Can be arranged: "<<result;


}

bool Consecutive(int arr[] , int length)
{
   for (int i = 0; i < length ; ++i)
   {
        for (int j = 0; j <length- i - 1; ++j)
        {
            if (arr[j] > arr[j + 1])
             {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
             }


         }
   }

   for(int i=0 ; i<length-1 ; i++)
   {
     if((arr[i+1] - arr[i] != 1) || (arr[i+1] - arr[i] == 0) || ((arr[length]-2)  -  (arr[length]-1) !=-1) )
      {
           return false;
      }
    }

   return true;

}