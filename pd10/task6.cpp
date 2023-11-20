#include<iostream>
#include<string>
#include<vector>
using namespace std;

vector<string> words;
string word ="";

int main()
{
    string sentence;
    cout<<"Enter a string: ";
    getline(cin, sentence);




    char* char_array = new char[sentence.length() + 1];

    // make sure that the new string is null terminated
    char_array[sentence.length()] = '\0';

    for (int i = 0; i < sentence.length(); i++) {
        char_array[i] = sentence[i];
    }

    for (int i = 0; i < sentence.length(); i++) {

             word+=sentence[i];

        if(sentence[i] == ' '  || i == sentence.length() - 1)
                {
                    words.push_back(word); // Use push_back to add the word to the vector
                    word = ""; // Reset the word variable for the next word
                }

    }

    cout<<"Reversed string: ";
    for (int i = words.size()-1; i >= 0; i--) {
        cout<<words[i]<<" ";
    }





}
