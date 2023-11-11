#include<iostream>
#include <vector>
using namespace std;
string longest7SegmentWord(int numbers, string arr[]);
bool RestrictedLetters(string words); 

int ActualWord = 0;
 

main()
{
    vector<string> correctWords;
    int words;
    cout<<"Enter the number of words: ";cin>>words;
    cout<<"Enter the words, one by one: "<<endl;

    string arr[words];
    for(int i=0 ; i<words ; i++)
    {
        cin>>arr[i];
    }

    for(int i=0 ; i<words ; i++)
    {
        bool CorrectWord =  RestrictedLetters(arr[i]);
        if(CorrectWord)
            {
                correctWords.push_back(arr[i]);    
            }
    }

     string longestWord;
    for (string word : correctWords) {
        if (word.length() > longestWord.length()) {
            longestWord = word;
        }
    }

      cout << "Longest 7-segment word: " << longestWord ;
}

bool RestrictedLetters(string word) {
    for (char ch : word) {
        if (ch == 'k' || ch == 'm' || ch == 'v' || ch == 'w' || ch == 'x') {
            return false;
        }
    }
    return true;
}