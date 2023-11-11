#include<iostream>
using namespace std;
string containsSeven(int numbers[], int size);


main()
{
  int size;
  cout<<"Enter the size of Array: ";cin>>size;
  int numbers[size];

  for(int i=1 ; i<=size ; i++)
  {
    cout<<"Enter Element "<<i<<" :";
    cin>>numbers[i];
  }    
  string result =  containsSeven(numbers,size);
  cout<<result;
}
string containsSeven(int numbers[], int size)
{
     for(int i=0 ; i<=size ; i++)
     {
       if(to_string(numbers[i]).find('7') != string::npos)
        {
          return "Boom!";
        }
     }
     return"there is no 7 in the array";
}