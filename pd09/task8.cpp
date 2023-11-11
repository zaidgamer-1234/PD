
#include <iostream>
#include <cstring>
#include <unordered_set>
using namespace std;

string findBrokenKeys(string correctPhrase, string actualTyped);
string removeDuplicates(string input);

 main()
{
    string correctPhrase, actualTyped;
    cout << "Enter the correct phrase: ";
    getline(cin, correctPhrase);

    cout << "Enter what you actually typed: ";
    getline(cin, actualTyped);
    
    string result = findBrokenKeys(correctPhrase, actualTyped);
    result =  removeDuplicates(result);


   


    cout << "Broken keys: " << result << endl;

    
}

string findBrokenKeys(string correctPhrase, string actualTyped)
{
    int i = 0, j = 0;
    string brokenKeys;

    char charArr1[correctPhrase.length() + 1];
    strcpy(charArr1, correctPhrase.c_str());

    char charArr2[actualTyped.length() + 1];
    strcpy(charArr2, actualTyped.c_str());

    for (i = 0; i < correctPhrase.length(); i++)
    {
        
        if (charArr1[i] != charArr2[i])
        {
            brokenKeys += charArr1[i];
        } 
       
    }



    return brokenKeys;
}

string removeDuplicates(string input) {
    string result;
    unordered_set<char> uniqueChars;

    for (char ch : input) {
       
        if (uniqueChars.find(ch) == uniqueChars.end()) {
            result += ch;
            uniqueChars.insert(ch);
        }
    }

    return result;
}





