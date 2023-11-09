#include <iostream>
using namespace std;

bool isAlreadyEntered(int arr[], int size, int number);

int main() {

    int actual_size = 0;
    int n;
    cout << "Enter the number of elements: ";
    cin >> n;

    int arr[n]; 

    cout << "Enter " << n << " numbers, one per line:" << endl;

    for (int i = 0; i < n; i++) {
        int num;
        cin >> num;

        if (isAlreadyEntered(arr, i, num)) {
            cout << "Already Entered: " << num << endl;
            
            
        } else {
            arr[actual_size] = num;
            actual_size++;
             
        }
    }

    cout << "Unique numbers entered: ";
    for (int i = 0; i < actual_size; i++) {
        cout << arr[i] << " ";
    }
    cout << endl;

    return 0;
}

bool isAlreadyEntered(int arr[], int size, int number) {
    
    for (int i = 0; i <= size; i++) {
        
        if (arr[i] == number) {
            return true; 
        }
    }
    return false;
}
