#include <iostream>
#include <vector>
using namespace std;

int findSpecialValue(const vector<int>& nums);

int main() {
    int length;
    cout << "Enter the length of the array: ";
    cin >> length;
    
    cout << "Enter the elements of the array:" << endl;
    vector<int> arr(length);
    for (int i = 0; i < length; i++) {
        cin >> arr[i];
    }

    int result = findSpecialValue(arr);

     cout << "Special value: " << result << endl;
   
       
}

int findSpecialValue(const vector<int>& nums) {
    int n = nums.size();

    for (int i = 1; i <= n; ++i) {
        int count = 0;
        for (int num : nums) {
            if (num >= i) {
                ++count;
            }
        }

        if (count == i) {
            return i;
        }
    }

    return -1;
}
