#include <iostream>
#include <cctype>
#include <string>
using namespace std;

string shiftedString(string word);

 main() {
    string word;
    cout << "Enter a String: ";
    getline(cin, word);

    cout << "Shifted String: " << shiftedString(word) << endl;

    
}

string shiftedString(string word) 
{
    string result = word;
    for (int i = 0; i < result.length(); i++)
    {
        if(result[i]=='z')
        {
            result[i]='a';
        }
        else if(result[i]=='Z')
        {
            result[i]='A';
        }
        else{
            result[i]++;
        }

    }
    return result; 
}
 

   
        
    
    
