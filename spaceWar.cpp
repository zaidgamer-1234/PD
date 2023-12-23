#include<iostream>// for cout and cin commands
#include<windows.h>// for sleep and other built_in functions
#include<conio.h>// for getch()
#include<fstream>// for file handling
using namespace std;

//charaters ascci
char pa = 176 , pb= 177 , pc = 178;
char e1a = 98 , e1b = 177 , e1c = 23;
char e2a = 45 , e2b =177 , e2c = 177;
char e3a = 65, e3b = 177, e3c = 176;
char heart = 3;

//player and enemy variables to print them on desired locatin on console
int x=63, y = 17;
const int limit = 100000;
int px = 50 , py = 26;
int ex = 50 , ey = 2;
int ex2 = 7, ey2 = 14;
int ex3 = 75 , ey3 = 27;
int heartX = 40, heartY = 5;
int plx , ply =0 ,  Ebulletcount =0, Eindex=0, E2bulletCount = 0, E2index =0;

int Health = 30,  fireDelay =0,  fireDelay2 =0, pillDelay =0;
int index =0, bulletCount =0,  score =0;
int Pindex , Pcount = 0;


// PLAYER ARRAYS
int Pbulletx[limit];
int Pbullety[limit];
bool activeBullet[limit];

//ENEMY1 ARRAYS
int E1bulletX[limit];
int E1bulletY[limit];
bool activeE1b[limit];
string EnemyDirection = "Right";
string Enemy2Direction = "Left";

//ENEMY2 ARRAYS
int E2bulletX[limit];
int E2bulletY[limit];
bool activeE2bullet[limit];

//PILL
int pillx[limit];
int pilly[limit];
bool activePill[limit];


void printBoard();//to print board
void printPlayer(int px, int py);//to print player
void gotoxy(int x, int y);//for printing text on specific place on console
char getCharAtxy(short int x, short int y);//to check whether the next coordinate is space or '#';
void hideCursor();//this function hides the cursor
void erasePlayer(int px ,int py);//to remove player
void printEnemy1(int ex, int ey, char Enemy1[][5]);//to print enemy1
void eraseEnemy1(int ex, int ey, char Enemy1[][5]);//to erase enemy1
void printEnemy2(int ex2, int ey2, char Enemy2[][7]);//to print enemy2
void eraseEnemy2(int ex2, int ey2, char Enemy2[][7]);//to erase enemy2
void printEnemy3(int ex3, int ey3, char Enemy3[][5]);// to print enemy3
void eraseEnemy3(int ex3, int ey3, char Enemy2[][5]);// to remove enemy3
void movePlayerRight(int &px, int &py);//function to move player right
void movePlayerLeft(int &px, int &py);//to move left
void movePlayerUp(int &px, int &py);// to move up
void movePlayerDown(int &px, int &py);//to move down
void fireBullet(int &px, int &py);//funtion of bullet
void moveEnemy2( int &ex2, int &ey2);//to move enemy2
void removeEnemy2(int &ex2, int &ey2);
void moveEnemy3(int &ex3, int &ey3);//to move enemy3
void enemyFire(int &ex, int &ey);// enemy fire
void enemyBulet();
void enemyBulletmove();//movement of enemy bullet
void enemy2fire(int &ex2, int &ey2);// enemy 2 fire function
void enemy2moveFire();// to move enemy2 fire
void movePlayerBullet();// move player bullet
void bullet();//player bullet
void enemy2Bullet();//enemy2 bullet function
void Score();// to show score
void gameName();// to print game name
void loading();// for loading
void logo();// game logo
void win();// print win if you win the game
void lose();// print lose if you lose the game
void scoreBoard();// print score board
void PlayerHealth();//show player health
void moveEnemy();//move enemy
void removeEnemy();//to remove enemy
string menu();// main menu
void playerPill();
void pill(int &heartX , int &heartY);
void movepill();//health
void invalid_option();//validation
void instructions();
void clear_all(); // Clears the console

HANDLE h = GetStdHandle(STD_OUTPUT_HANDLE);//to change the color of specific output

char maze[38][155] = {
    {"##########################################################################################################################################################"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |___________________________||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          | Fire button = Space       ||"},
    {"||                                                                                                                          | To exit press Escape.     ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          | Score will increase when  ||"},
    {"||                                                                                                                          | you fire the upper blue   ||"},
    {"||                                                                                                                          |          enemy.           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |   Score 20 points to win  ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"||                                                                                                                          |                           ||"},
    {"##########################################################################################################################################################"}};

 //CHARACTERS
  char player[5][3] = {
            {'-', pa, '-',},
            {pb, '|', pb,},
            {'|', pc, '|',}, 
            {'|', pc, '|',},
            { pc,'-', pc }}; 

   char Enemy1[5][5] = {
        {' ','-', e2a ,'-',' ', },
        {'(',e2b, '|', e2b, ')',},
        {e2b ,' ','|', ' ', e2b,},
        {'(',e2c, '|', e2c, ')',},
        {' ','-', '8','-' ,' ', }};

    char Enemy2[5][7] = {
        {' ',' ',' ', e2a ,' ',' ',' ',},
        {' ',')',e2b, '|', e2b, '(',' ',},
        {'-',e2b ,' ','|', ' ', e2b,'-',},
        {' ',')',e2c, '|', e2c, '(',' ',},
        {' ',' ',' ', '_',' ', ' ', ' '}};

  
     char Enemy3[3][5] = {
        
        {' ' ,'^', '^','^',' ',},
        {'<' ,e3b, e3b,e3b,'(',},
        {'<' ,e3b, e3b,e3b,'(', }};
        
    
main()
{
    system("cls");
      gameName();
      menu();
      string menu_option;
      string opt;
      
      while(menu_option != "4")// using while loop until the option is not equals to two
      {
         menu_option = menu();
        if(menu_option == "1")//if user enetes 1 then start the game
        {
            //functions calling;
            system("cls");
            logo();
            loading();
            system("cls");
            printBoard();
           hideCursor();
           printPlayer(px, py);
           printEnemy1(ex, ey, Enemy1);
           printEnemy2( ex2,  ey2, Enemy2);
           printEnemy3(ex3, ey3, Enemy3);

           while(1)
           {
              clear_all(); // Clears the console

               
             if(GetAsyncKeyState(VK_RIGHT))//if user press right arrow key , move player right
             {
               movePlayerRight(px, py);
             }
             else if(GetAsyncKeyState(VK_LEFT))//if user press left arrow key , move player left
             {
               movePlayerLeft(px, py);
             }
             else if(GetAsyncKeyState(VK_UP))//if user press up arrow key , move player up
             {
               movePlayerUp(px, py);
             }
             else if(GetAsyncKeyState(VK_DOWN))//if user press down arrow key , move player down
             {
               movePlayerDown(px, py);
             }
             else if(GetAsyncKeyState(VK_SPACE))// press space for fire
             {
               fireBullet(px, py); 
               enemy2fire(ex2, ey2);
             }
             else if(GetAsyncKeyState(VK_ESCAPE))// if user presses the escape key, then break the loop and go to main menu
             {
                break;
                menu();
                 
             }
             if(Health<=0)// if player health becomes less than 0, user will lose
             {
                system ("color 09");
                system("cls");
                Sleep(1000);
                lose();
                SetConsoleTextAttribute(h, 10);
                cout<<"Press any key to continue.";
                cin>>opt;
                Health = 0;
                score = 0;
                menu();
                break; 
             }

             if(score >= 20)// if score is greater than 20 , user will win
             {
                system("cls");
                Sleep(1000);
                win();  
                SetConsoleTextAttribute(h, 10);
                cout<<"Press any key to continue.";
                cin >> opt;
                score = 0;
                Health = 0;
                menu();
                break;
             }

              movePlayerBullet();
             Score();
             scoreBoard();
             PlayerHealth();
             moveEnemy2(ex2, ey2);
             moveEnemy3(ex3, ey3);
             moveEnemy();
             enemyBulletmove();
             enemy2moveFire();
             movepill();
             Sleep(10);
            }

         }   
         else if(menu_option == "2")
        {
            instructions();
        }

              else if(menu_option == "3")
             {
                 return 0;
             }

            
             else{
                invalid_option();
             }

 } 
     
}      

void invalid_option()
{

     system("cls");
     gameName();
     SetConsoleTextAttribute(h, 4);

     gotoxy(x, y);
     cout << "Please choose the option that are given." << endl;
     gotoxy(x, y+1);
     cout << "Press any key to continue...";
     getch();
   
}
void scoreBoard()
{
    SetConsoleTextAttribute(h, 4);
    gotoxy(133 , 2);
    cout<<"SCORE BOARD";
}

void printBoard()
{
    // using nested for loop to print the maze
  SetConsoleTextAttribute(h, 11); 
  for(int i = 0 ; i<38 ; i++)
  {
    for(int j=0 ; j<155 ; j++)
    {
      cout<<maze[i][j];
    }
    cout<<endl;
  }
}

void gotoxy(int x, int y)//for printing text on specific place on console
{
    COORD coordinates;
    coordinates.X = x;
    coordinates.Y = y;
    SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coordinates);
}
char getCharAtxy(short int x, short int y)//to check whether the next coordinate is space or '#';
{
    CHAR_INFO ci;
    COORD xy = {0, 0};
    SMALL_RECT rect = {x, y, x, y};
    COORD coordBufSize;
    coordBufSize.X = 1;
    coordBufSize.Y = 1;
    return ReadConsoleOutput(GetStdHandle(STD_OUTPUT_HANDLE), &ci, coordBufSize, xy, &rect) ? ci.Char.AsciiChar : ' ';
}
void hideCursor()
{
    HANDLE consoleHandle = GetStdHandle(STD_OUTPUT_HANDLE);

    CONSOLE_CURSOR_INFO cursorInfo;
    GetConsoleCursorInfo(consoleHandle, &cursorInfo);
    cursorInfo.bVisible = false;
    SetConsoleCursorInfo(consoleHandle, &cursorInfo);
}
void loading()
{ 
    // simple loading function
    int j = 1;
    SetConsoleTextAttribute(h, 9);
    for (int i = 1; i < 4; i++)
    {
        gotoxy(55, 35);
        cout << "Loading";
        gotoxy((i + j) + 65, 35);
        j = j + 2;// increment j by 2 after every iteration to print loading with accurate spacing
        cout << i;
        Sleep(1000);//to slow down the loading function
    }
}

void printPlayer(int px, int py)//printing player with nested for loop
{
    SetConsoleTextAttribute(h, 10);
    for(int i=0 ; i<5 ; i++)
    {
        gotoxy(px, py+i);
        for(int j=0 ; j<3 ; j++)
        {
            cout<<player[i][j];
        }
        cout<<endl;
    }
}
void erasePlayer(int px ,int py)//erasing player using same way
{
    for(int i=0 ; i<5 ; i++)
    {
        gotoxy(px, py+i);
        for(int j=0 ; j<3 ; j++)
        {
            cout<<"     ";
        }
        cout<<endl;
    }
}
void printEnemy1(int ex, int ey, char Enemy1[][5])//printing enemy1
{
    SetConsoleTextAttribute(h, 9);
      for(int i=0 ; i<5 ; i++)
    {
        gotoxy(ex, ey+i);
        for(int j=0 ; j<5 ; j++)
        {
            cout<<Enemy1[i][j];
        }
        cout<<endl;
    }
} 
void eraseEnemy1(int ex, int ey, char Enemy1[][5])//removing enemy1
{
      for(int i=0 ; i<4 ; i++)
    {
        gotoxy(ex, ey+i);
        for(int j=0 ; j<5 ; j++)
        {
            cout<<"     ";
        }
        cout<<endl;
    }
} 

void printEnemy2(int ex2, int ey2, char Enemy2[][7])
{
    SetConsoleTextAttribute(h, 6);
      for(int i=0 ; i<5 ; i++)
    {
        gotoxy(ex2, ey2+i);//adding i in ey2 to print whole player
        for(int j=0 ; j<7 ; j++)
        {
            cout<<Enemy2[i][j];
        }
        cout<<endl;
    }
} 

void eraseEnemy2(int ex2, int ey2, char Enemy2[][7])//erasing enemy2
{
      for(int i=0 ; i<5 ; i++)
    {
        gotoxy(ex2, ey2+i);
        for(int j=0 ; j<7 ; j++)
        {
            cout<<" ";
        }
        cout<<endl;
    }
} 

void printEnemy3(int ex3, int ey3, char Enemy3[][5])//printing enemy3
{
    SetConsoleTextAttribute(h, 7);
      for(int i=0 ; i<3 ; i++)
    {
        gotoxy(ex3, ey3+i);
        for(int j=0 ; j<5 ; j++)
        {
            cout<<Enemy3[i][j];
        }
        cout<<endl;
    }
} 
void eraseEnemy3(int ex3, int ey3, char Enemy2[][5])//erasing enemy3
{
      for(int i=0 ; i<3 ; i++)
    {
        gotoxy(ex3, ey3+i);
        for(int j=0 ; j<5 ; j++)
        {
            cout<<"    ";
        }
        cout<<endl;
    }
} 
  
  //To move the player so that it may not go outside the maze boundry using getcharAtxy()
  
void movePlayerRight(int &px, int &py)
{
    char space = getCharAtxy(px + 15, py );
    if (space == ' ')
    {
        erasePlayer(px, py);
        px++;
        printPlayer(px, py);
    
    }
    else if(space == heart)
    {
        Health = 30;
    }
  
}
void movePlayerLeft(int &px, int &py)
{
    if (getCharAtxy(px - 1 , py ) == ' ')
    {
        erasePlayer(px, py);
        px--;
        printPlayer(px, py);
    }
    else if(getCharAtxy(px - 1 , py ) == heart)
    {
        Health = 30;
    }
   
}
void movePlayerDown(int &px, int &py)
{
    if (getCharAtxy(px  , py + 5) == ' ')
    {
        erasePlayer(px, py);
        py++;
        printPlayer(px, py);
    
    }
    else if(getCharAtxy(px  , py + 5) == heart)
    {
        Health = 30;
    }
    
  
}
void movePlayerUp(int &px, int &py)
{
    if (getCharAtxy(px   , py - 1 ) == ' ')
    {
        erasePlayer(px, py);
        py--;
        printPlayer(px, py);
    
    }
    else if(getCharAtxy(px   , py - 1 ) == heart)
    {
        Health = 30;
    }
}

void fireBullet(int &px, int &py)
{
    plx = px + 1; // update the position of x, y coordinates from where the bullet will be fired
    ply = py - 1;
    gotoxy(plx, ply);
    bullet();
   Pbulletx[index] = plx;// stroing bullet index in array
   Pbullety[index] = ply;
   activeBullet[index]=true;//whether the bullet at corresponding index is active or not
    index++;
    bulletCount++;
    
}
void bullet()
{
    SetConsoleTextAttribute(h, 10);
    cout << "^";
}
void movePlayerBullet()
{
   
   for (int i = 0; i < bulletCount; i++)
    {
        if (activeBullet[i] == true)
        {
              
            if ( getCharAtxy(Pbulletx[i], Pbullety[i] - 1) == ' ')
            {
                gotoxy(Pbulletx[i], Pbullety[i]);
                cout << " ";
                Pbullety[i] = Pbullety[i] - 1;
                gotoxy(Pbulletx[i], Pbullety[i]);
                bullet();
            }
            else if ((getCharAtxy(Pbulletx[i], Pbullety[i] - 1) == '8' || getCharAtxy(Pbulletx[i], Pbullety[i] - 1) == '-') || getCharAtxy(Pbulletx[i], Pbullety[i] - 1) == ')'|| getCharAtxy(Pbulletx[i], Pbullety[i] - 1) == '(' || getCharAtxy(Pbulletx[i], Pbullety[i] - 1) == e2c || getCharAtxy(Pbulletx[i], Pbullety[i] - 1) == e2b)
            {
                gotoxy(Pbulletx[i], Pbullety[i]);
                cout << " ";
                activeBullet[i] = false;
                score++;
                
            }
            else
            {
                gotoxy(Pbulletx[i], Pbullety[i]);
                cout << " ";
                activeBullet[i] = false;
            }
        }
    }
}

void Score()
{
    SetConsoleTextAttribute(h, 10);
    gotoxy(128, 6);
    cout<<"SCORE: "<<score;
}
void PlayerHealth()
{
    SetConsoleTextAttribute(h, 10);
    gotoxy(128, 7);
    cout<<"PLAYER HEALTH: "<<Health;
}

void moveEnemy()
{
    if (EnemyDirection == "Right")
    {
        char space = getCharAtxy(ex + 7, ey + 2);
        
        if (space == ' ' )
        {
            gotoxy(ex, ey + 1);
            removeEnemy();
            ex = ex + 1;
            printEnemy1(ex, ey, Enemy1);
        }
        else if (space == '|')
        {
            EnemyDirection = "Left";
        }
    }
    else if (EnemyDirection == "Left")
    {
         
        if (getCharAtxy(ex - 1, ey + 2) == ' ' )
        {
            gotoxy(ex + 6, ey + 1);
            removeEnemy();
            ex = ex - 1;
            printEnemy1(ex, ey, Enemy1);
        }
        else if (getCharAtxy(ex - 1, ey + 2) == '|')
        {
            EnemyDirection = "Right";
        }
    }
}

void removeEnemy()
{
    gotoxy(ex, ey);
    cout<<"     ";
    gotoxy(ex, ey+1);
    cout<<"     ";
     gotoxy(ex, ey+2);
    cout<<"     ";
     gotoxy(ex, ey+3);
    cout<<"     ";
     gotoxy(ex, ey+4);
    cout<<"     ";
}

void moveEnemy2(int &ex2, int &ey2)
{
    
     removeEnemy2(ex2, ey2);
     ex2++;
     printEnemy2(ex2, ey2, Enemy2);
     if(ex2 >= 115)
     {
         removeEnemy2(ex2, ey2);
         ex2 = 7;
     }
     
}
void removeEnemy2(int &ex2, int &ey2)
{
    gotoxy(ex2, ey2);
    cout<<"       ";
     gotoxy(ex2, ey2+1);
    cout<<"       ";
     gotoxy(ex2, ey2+2);
    cout<<"       ";
     gotoxy(ex2, ey2+3);
    cout<<"       ";
     gotoxy(ex2, ey2+4);
    cout<<"       ";

}
void moveEnemy3(int &ex3, int &ey3)
{
  eraseEnemy3(ex3, ey3, Enemy3);
  ex3--;
  if(ex3 == '|'|| ex3 == pb || ex3 == pc || ex3 == '-' )
  {
    Health --;
  }
 
  printEnemy3(ex3, ey3, Enemy3);
  if(ex3 <= 4)
  {
    eraseEnemy3(ex3, ey3, Enemy3);
    ex3 = 98;
  }
}
void enemyFire(int &ex, int &ey)
{
    int ebx = ex + 3;
    int eby = ey + 5;
    gotoxy(ebx, eby);
    enemyBulet();

   E1bulletX[Eindex] = ebx;
   E1bulletY[Eindex] = eby;
   activeE1b[Eindex]=true;
    Ebulletcount++;
    Eindex++;   
}
void enemyBulet()
{
    SetConsoleTextAttribute(h, 4);
    cout<<"*";
}
void enemy2Bullet()
{
  SetConsoleTextAttribute(h, 6);
  cout<<".";
}
void enemyBulletmove()
{
    for (int i = 0; i < Ebulletcount; i++)
    {
        if (activeE1b[i] == true)
        {
            char space1 = getCharAtxy(E1bulletX[i], E1bulletY[i] + 1);
            if (space1 == ' ')// if next char is space
            {
                gotoxy(E1bulletX[i], E1bulletY[i]);
                cout << " ";
                E1bulletY[i] = E1bulletY[i] + 1;// increment in y
               
                gotoxy(E1bulletX[i], E1bulletY[i]);
                enemyBulet();// printing bullet
            }
            else if (space1 == pa ||  space1 == '|' || space1 == pb || space1 == pc)
            {
                //if bullet collides with player then decrease the health
                gotoxy(E1bulletX[i], E1bulletY[i]);
                cout << " ";
                activeE1b[i] = false;
                Health--;
            }
            else
            {
                gotoxy(E1bulletX[i], E1bulletY[i]);
                cout << " ";
                activeE1b[i] = false;
            }
        }
    }
    if(fireDelay > 9)
    {
        enemyFire(ex , ey);
        fireDelay = 0;
    }
    else{
        fireDelay++;
    }
}

void enemy2fire(int &ex2, int &ey2)
{
    int ex2bx = ex2 + 3;
    int ex2by = ey2 + 5;

    gotoxy(ex2bx, ex2by);
    enemy2Bullet();

    E2bulletX[E2index] = ex2bx;
    E2bulletY[E2index] = ex2by;
    activeE2bullet[E2index] = true;
    E2index++;
    E2bulletCount++;
}
void enemy2moveFire()
{
   for (int i = 0; i < E2bulletCount; i++)
    {
        if (activeE2bullet[i] == true)
        {
            char space2 = getCharAtxy(E2bulletX[i], E2bulletY[i] + 1);
            if (space2 == ' ')
            {
                gotoxy(E2bulletX[i], E2bulletY[i]);
                cout << " ";
                E2bulletY[i] = E2bulletY[i] + 1;
                gotoxy(E2bulletX[i], E2bulletY[i]);
                enemy2Bullet();
            }
            else if (space2 == pa || space2 == '-' || space2 == '|' || space2 == pb || space2 == pc)
            {
                gotoxy(E2bulletX[i], E2bulletY[i]);
                cout << " ";
                activeE2bullet[i] = false;
                Health--;
            }
            else
            {
                gotoxy(E2bulletX[i], E2bulletY[i]);
                cout << " ";
                activeE2bullet[i] = false;
            }
        }
    }
   
}

void playerPill()
{
    SetConsoleTextAttribute(h, 4);
    cout<<heart;

}

void pill(int &heartX , int &heartY)
{
    playerPill();
   pillx[Pindex] = heartX;
   pilly[Pindex] = heartY;
   
   Pcount++;
   Pindex++;
}

void movepill()
{
    for(int i=0 ; i<Pcount ; i++)
    {
        if(activePill[i] == true)
        {
            if(getCharAtxy(pillx[i], pilly[i] + 1) == ' ')
            {
                gotoxy(pillx[i], pilly[i]);
                cout<<" ";
                pilly[i] = pilly[i] + 1;
                gotoxy(pillx[i], pilly[i]);
                cout << heart; 
            }
            else 
            {
                gotoxy(pillx[i], pilly[i]);
                cout<<" ";
                activePill[i] = false;
            }

        }
    }
    if(pillDelay > 450)
    {
        pill(heartX, heartY);
        pillDelay = 0;
    }
    else{
        pillDelay++;
    }
}
void gameName()
{                  
    SetConsoleTextAttribute(h, 9);                       
                                                 
     cout<<"                                  ________  ________  ________  ________  _______           ___       __   ________  ________                                  "<<endl; 
     cout<<"                                 |\\   ____\\|\\   __  \\|\\   __  \\|\\   ____\\|\\  ___ \\         |\\  \\     |\\  \\|\\   __  \\|\\   __  \\                "<<endl;
     cout<<"                                 \\ \\  \\___|\\ \\  \\|\\  \\ \\  \\|\\  \\ \\  \\___|\\ \\   __/|        \\ \\  \\    \\ \\  \\ \\  \\|\\  \\ \\  \\|\\  \\   "<<endl;
     cout<<"                                  \\ \\_____  \\ \\   ____\\ \\   __  \\ \\  \\    \\ \\  \\_|/__       \\ \\  \\  __\\ \\  \\ \\   __  \\ \\   _  _\\          "<<endl;
     cout<<"                                   \\|____|\\  \\ \\  \\___|\\ \\  \\ \\  \\ \\  \\____\\ \\  \\_|\\ \\       \\ \\  \\|\\__\\_\\  \\ \\  \\ \\  \\ \\  \\  \\| "<<endl;
     cout<<"                                     ____\\_\\  \\ \\__\\    \\ \\__\\ \\__\\ \\_______\\ \\_______\\       \\ \\____________\\ \\__\\ \\__\\ \\__\\ _\\        "<<endl;
     cout<<"                                    |\\_________\\|__|     \\|__|\\|__|\\|_______|\\|_______|        \\|____________|\\|__|\\|__|\\|__|\\|__|                  "<<endl;
     cout<<"                                    \\|_________|                                                                                                               "<<endl<<endl;
     SetConsoleTextAttribute(h, 4);
     cout<<"                               ======================================================================================================="<<endl;
                                           
}

void logo()
{
    SetConsoleTextAttribute(h, 12);
    
     cout<<"                                                                                                       ..-+-:=======+##**.                .+:==-         "<<endl;
     cout<<"                                                                                                       .:+*++++***#%%#.                    .  .          "<<endl;    
     cout<<"                                                                                                    .:+=:-========+*##*+.                :-===*:         "<<endl;
     cout<<"                                                                                                 .-+-:==========+**#**=                .+-==++*-.        "<<endl;
     cout<<"                                                                                             .:==--============***#**#.              .:===+====+         "<<endl;
     cout<<"                                                                                     :+++==++-:-=============*****#**+              .+===*-===+-         "<<endl;
     cout<<"                                                                                  .+===++=-:===============*******#**=             -===+-=====*:         "<<endl;
     cout<<"                                                                            ..::-====*##**********+++====+*******##**:           .+===+-=====*#.         "<<endl;
     cout<<"                                                                  ..-+#****+--...::-+*+#####%@%##******#%%%%%%%%#####.         .-===+========*+          "<<endl;
     cout<<"                                                              :*###*:.-+*#############+##%@@@@@@@@@@#*****###%%%%%%%#.        .+===+========**:          "<<endl;
     cout<<"                                                          :*###*+*#####+#########%%@@@+@@@@@@@@@@@@@@@*+::::::::::::-----=====++++=========+*#.          "<<endl;
     cout<<"                                                    ..:-+*##########%%%*#@@@@@@@@@@@@@+%@@@@@@@@@@@%#+++++++++++========------:=+==========**#==+:       "<<endl;
     cout<<"                                             ..:=+==-:::==++++++****###**##%%%%%%%%###*****++++++++++++++++++++++++++++++++++++===========****+++:       "<<endl;
     cout<<"                                        .-**#=:::::::-==============++++++++++++++++++++++++++++++++++++++++++*******+++++++++=========+*****++++-       "<<endl;
     cout<<"                                  .-+**+=-=+++=============================++++++*+++++++=============+**********#**#**+++++=====++*#########****-       "<<endl;
     cout<<"                               :**+***********================================++++**+==================+*********#************+=--=========+***#=.       "<<endl;
     cout<<"                               .:=+*##########+++++++++++++++++++++++++++++++++********==================*********#**###**+=-:......=++=-========+#=.    "<<endl;
     cout<<"                                           ............................:::..::::::::::::-+================********#**#.                ....:=+=======+-. "<<endl;
     cout<<"                                                                             .-=+=----=#%%#+===============*******#***-                        ...:-====-"<<endl;
     cout<<"                                                                            =++====++++*#%%%%*==============*******#**+                                  "<<endl;
     cout<<"                                                                              ..-*########%###*+=-===========+*****#**#.                                 "<<endl;
     cout<<"                                                                                     ..-=======**#+-==========+****##**-                                 "<<endl;
     cout<<"                                                                                .-+==----========*%%*=-=========****#***                                 "<<endl;
     cout<<"                                                                               -+==============+***#%%*=-========***#**#:                                "<<endl;
     cout<<"                                                                                ..=#***************#%%%%#+-=======+**#**#:                               "<<endl;
     cout<<"                                                                                     ...:::--------::::::::+=-======**##**+.                             "<<endl;
     cout<<"                                                                                                            .==-=====+**##*#:                            "<<endl;
     cout<<"                                                                                                              .-+-====+***#**+.                          "<<endl;
     cout<<"                                                                                                                .:+--===***#***:                         "<<endl;
     cout<<"                                                                                                                   .===++=-:..                           "<<endl;
      SetConsoleTextAttribute(h, 10);
        
}

string menu() 
{

    system("cls");//clears screen
    gameName();
    SetConsoleTextAttribute(h , 10);
    string option;

    gotoxy(x, y);
    cout << "| Press 1 to Start the game.  |" << endl;
    gotoxy(x, y + 1);
    cout << "| Press 2 to view instructions|" << endl;
    gotoxy(x, y + 2);
    cout << "| Press 3 to exit the game.   |" << endl;
    
    gotoxy(x, y + 4);
    cout << " Please enter your choice: ";
    cin >> option;

    return option;
}

void win()
{
    SetConsoleTextAttribute(h, 9);                  
     cout<<"                   ( /(   ( /(              (  (      ( /(    ( /(  " <<endl;
     cout<<"                   )\\())  )\\())      (      )\\))(   ' )\\())   )\\()) " <<endl;
     cout<<"                  ((_)\\  ((_)\\       )\\    ((_)()\\ ) ((_)\\   ((_)\\  " <<endl;
     cout<<"                 __ ((_)   ((_)   _ ((_)   _(())\\_)()  ((_)   _((_) " <<endl;
     cout<<"                 \\ \\ / /  / _ \\  | | | |   \\ \\((_)/ / / _ \\  | \\| | " <<endl;
     cout<<"                  \\ V /  | (_) | | |_| |    \\ \\/\\/ / | (_) | | .` | " <<endl;
     cout<<"                   |_|    \\___/   \\___/      \\_/\\_/   \\___/  |_|\\_| " <<endl<<endl<<endl;
                                                  
}

void lose()
{
    SetConsoleTextAttribute(h, 4);
    cout<<"                                _______             _        _______  _______  _______  "<<endl;
    cout<<"                      |\\     /|(  ___  )|\\     /|  ( \\      (  ___  )(  ____ \\(  ____ \\ "<<endl;
    cout<<"                      ( \\   / )| (   ) || )   ( |  | (      | (   ) || (    \\/| (    \\/ "<<endl;
    cout<<"                       \\ (_) / | |   | || |   | |  | |      | |   | || (_____ | (__     "<<endl;
    cout<<"                        \\   /  | |   | || |   | |  | |      | |   | |(_____  )|  __)    "<<endl;
    cout<<"                         ) (   | |   | || |   | |  | |      | |   | |      ) || (       "<<endl;
    cout<<"                         | |   | (___) || (___) |  | (____/\\| (___) |/\\____) || (____/\\ "<<endl;
    cout<<"                         \\_/   (_______)(_______)  (_______/(_______)\\_______)(_______/ "<<endl;
   cout<<endl<<endl;                                                             
}


void instructions()
{
    system("cls");
    gotoxy(30, 5);
cout<<"    __ __  __  __  ______ ____  __ __   ___ ______ __   ___   __  __ "<<endl;
gotoxy(30, 6); 
cout<<"|| ||\\ || (( \\ | || | || \\\\ || ||  //   | || | ||  // \\\\  ||\\ || (( \\"<<endl;
gotoxy(30, 7);
cout<<"|| ||\\\\||  \\\\    ||   ||_// || || ((      ||   || ((   )) ||\\\\||  \\\\ "<<endl;
gotoxy(30, 8);
cout<<"|| || \\|| \\_))   ||   || \\\\ \\\\_//  \\\\__   ||   ||  \\\\_//  || \\|| \\_))"<<endl;
    SetConsoleTextAttribute(h, 10);
    gotoxy(40, 10);
    cout<<"- VK_UP for moving up";
    gotoxy(40, 11);
    cout<<"- VK_DOWN for moving down";
    gotoxy(40, 12);
    cout<<"- VK_LEFT for moving left";
    gotoxy(40, 13);
    cout<<"- VK_RIGHT for moving right";
    gotoxy(40, 14);
    cout<<"- VK_SPACE for fire bullet";
    gotoxy(40, 15);
    cout<<"- Score 30 to owin the game";
    gotoxy(40, 16);
    cout<<"- Score can be increase by firing bullets at enemies.";
    gotoxy(40, 17);
    cout<<"- Your health decreases when you will hit by a enemy bullet";
    gotoxy(40, 18);
    cout<<"- You have maximum health of 30";
    gotoxy(40, 19);
    cout<<"- You will die in no time if you collide with the enemies.";
    gotoxy(40,20);
    cout<<"To continue, press any key...";
    getch();

}

void clear_all() // Clears the console
{
    COORD cursorPos;
    cursorPos.X = 0;
    cursorPos.Y = 0;
    SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), cursorPos);
    return;
}