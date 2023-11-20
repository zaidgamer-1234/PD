#include<iostream>
using namespace std;
int sameLetters(int words , string arr[] , char letter);
int count = 0;
main()
{
  int words; char letter;
  cout<<"Enter how many words you want to enter: ";cin>>words;

  string arr[words];
  for(int i=0 ; i<words ; i++)
  {
    cout<<"Enter word "<<i+1<<": ";
    cin>>arr[i];
  }
  cout<<"Enter the letter you want to count: ";cin>>letter;

  int result = sameLetters(words , arr , letter);
  cout<<letter<<" shows up "<<count<<" times in the data.";
  
}

int sameLetters(int words , string arr[] , char letter)
{
  for(int i=0 ; i<words ; i++)
  {
    for(char(c) : arr[i])
    {
      if(char(c) == letter)
      {
        count ++;
      }
    }
  }
  return count;
}