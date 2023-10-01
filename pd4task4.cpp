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
void playerMove(int x, int y)
{
 gotoxy(x, y);
 cout << "P";
 Sleep(200);
 gotoxy(x, y);
 cout << " ";
;
}


main()
{
    int x=3 , y=4;
    system("cls");
    printMaze();

    while(1)
    {
        playerMove( x , y);
        x++;
        if(x==20)
        {
            x=3;
        }

    }
}

