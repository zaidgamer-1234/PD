#include <iostream>
using namespace std;

double calculateTotalResistance(double resistance[], int size);

int main() {
    int n;
    cout << "Enter the number of resistors in the series circuit: ";cin>>n;


    if (n <= 0) {
        cout << "Number of resistors must be greater than 0." << endl;
    }

    double resistanceArray[n];

    cout << "Enter the resistance values (in ohms) of the " <<n<< " resistors, one per line:"<< endl;
    for (int i = 0; i < n; i++) {
        cin >> resistanceArray[i];
    }

    double totalResistance = calculateTotalResistance(resistanceArray, n);

    cout << "The total resistance of the series circuit is " << totalResistance << " ohms." << endl;

    
}

double calculateTotalResistance(double resistance[], int size) {
    double totalResistance = 0.0;

    for (int i = 0; i < size; i++) {
        totalResistance += resistance[i];
    }

    return totalResistance;
}
