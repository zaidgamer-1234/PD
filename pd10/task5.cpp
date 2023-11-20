#include<iostream>
#include<algorithm>
using namespace std;
int arr[10];  
main()
{

  cout<<"Enter the weights of the 10 packages: "<<endl;
  

  for(int i=0 ; i<10 ; i++)
  {
    cin>>arr[i];
  }

  for (int i = 0; i < 10 ; ++i) {
        for (int j = 0; j < 10- i - 1; ++j) {
            if (arr[j] > arr[j + 1]) {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
    cout<<"Sorted array in ascending order: [";
    for(int i=0 ; i<10 ; i++)
  {
    if(i==9)
    {
      
       cout<<arr[i];
       
    }
    if(i<9){
      cout<<arr[i];
    cout<<","<<" ";
    }
   
  }
  cout<<"]";
}
  
  


