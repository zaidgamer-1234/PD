#include <iostream>
using namespace std;
void displayLocations(string word ) ;
int main() {
     string word; char letter;
    
    cout << "Enter a word: ";
    getline(cin , word);

    displayLocations(word);
}


void displayLocations(string word ) {
    for (int i = 0; word[i] != '\0'; i++) {
         
         cout << word[i] <<" found at position " << i  << endl;
        }
    }


