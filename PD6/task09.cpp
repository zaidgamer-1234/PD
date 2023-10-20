#include <iostream>
using namespace std;

string checkPointPosition(int h, int x, int y);

main()
{
    int h, x, y;
    cout << "Enter height: ";
    cin >> h;
    cout << "Enter x coordrinate: ";
    cin >> x;
    cout << "Enter y coordrinate: ";
    cin >> y;
    cout << checkPointPosition(h, x, y);
}
string checkPointPosition(int h, int x, int y) {
    if (x >= 0 && x <= 3 * h && y >= 0 && y <= h) {
        return "Inside";
    } else if (
        (x == 0 || x == h || x == 2 * h || x == 3 * h) && (y >= 0 && y <= 4 * h)
    ) {
        return "Border";
    } else {
        return "Outside";
    }
}