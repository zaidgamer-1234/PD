#include<iostream>
using namespace std;
void displayReverse(string word);
main()
{
  string word;
  cout<<"Enter a string: ";
  getline(cin , word);
  cout<<"Reversed String: ";
  displayReverse(word);
}

void displayReverse(string word)
{
    for(int i=word.length()-1 ; i>=0 ; i--)
    {
        cout<<word[i];
    }
}