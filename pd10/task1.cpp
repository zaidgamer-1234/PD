#include<iostream>
using namespace std;
int Progress(int number , int Arr[]);

main()
{
  int number;
  cout<<"Enter the number of Saturdays: ";cin>>number;

  int Arr[number];

  for(int i=1 ; i<=number ; i++)
  {
    cout<<"Enter miles run for Saturday "<<i<<": ";
    cin>>Arr[i];
  }
  int result =  Progress(number ,  Arr);
  cout<<"Total progress days: "<<result;

}

int Progress(int number , int Arr[])
{
  int count =0;
    for(int i=0 ; i<number ; i++)
    {
      if(Arr[i]<Arr[i+1])
      {
         count++;
      }
    }
    return count;
}