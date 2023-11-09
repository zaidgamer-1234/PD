#include <iostream>
#include <string>
using namespace std;

bool isVowel(char c) {
    c = tolower(c); 
    return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
}

string removeVowels(string in) {
    string result = "";
    for (char c : in) {
        if (!isVowel(c)) {
            result += c;
        }
    }
    return result;
}

int main() {
    string in;
    cout << "Enter a string: ";
    getline(cin, in);

    string result = removeVowels(in);

    cout << "String with vowels removed: " << result << endl;

    return 0;
}
