#include<iostream>
#include<vector>
using namespace std;

bool isRepeatingCycle(int cycleLength, const vector<int>& arr);

int main() {
    int length1, cycleLength;
    cout << "Enter the length of the array: ";
    cin >> length1;
    cout << "Enter the elements of the array:" << endl;

    int arr[length1];
    for (int i = 0; i < length1; i++) {
        cin >> arr[i];
    }

    cout << "Enter the length of the cycle: ";
    cin >> cycleLength;

    bool result = isRepeatingCycle(cycleLength, vector<int>(arr, arr + length1));

    cout << "Output: " << result << endl;

    
}

bool isRepeatingCycle(int cycleLength, const vector<int>& arr) {
    int arrayLength = arr.size();

    // Return true if the cycle length is greater than the array length
    if (cycleLength > arrayLength) {
        return true;
    }

    // Check if the array forms a repeating cycle of the specified length
    for (int i = 0; i <= arrayLength - cycleLength; ++i) {
        bool isCycle = true;
        for (int j = 0; j < cycleLength; ++j) {
            if (arr[i + j] != arr[j]) {
                // If elements in the current segment do not match, it's not a repeating cycle
                isCycle = false;
                break;
            }
        }

        if (isCycle) {
            return true;
        }
    }

    // If no repeating cycle is found, return false
    return false;
}
