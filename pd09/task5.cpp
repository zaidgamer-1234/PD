
#include <iostream>
#include <algorithm>
using namespace std;
int countCommonCharacters(string s1, string s2); 

 main()
 {
      string s1, s2;
      cout<<"Enter the first string: ";cin>>s1;
      cout<<"Enter the second string: ";cin>>s2;

      int result = countCommonCharacters(s1, s2);
      cout<<"Number of common characters: "<<result;
      
 } 


int countCommonCharacters(string s1, string s2) {
    

    sort(s1.begin(), s1.end());
    sort(s2.begin(), s2.end());

    
    int Count = 0;

    int i = 0, j = 0;
    while (i < s1.size() && j < s2.size()) {
        if (s1[i] == s2[j]) {
            
            Count++;
            i++;
            j++;

        } else if (s1[i] < s2[j]) {
           
            i++;
        } else {
            
            j++;
        }
    }

   
    return Count;
}