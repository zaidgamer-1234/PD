#include<iostream>
#include<windows.h>
using namespace std;


void printMaze()
{
 cout << "#######################" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#                     #" << endl;
 cout << "#######################" << endl;
}

void gotoxy(int x, int y)
{
 COORD coordinates;
 coordinates.X = x;
 coordinates.Y = y;
 SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coordinates);
}

main()
{
    system("cls");
    printMaze();
    gotoxy(4,3);
    cout<<"P";
    gotoxy(0 , 10);
}
