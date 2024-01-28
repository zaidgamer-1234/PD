using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EZInput;

namespace game
{
    internal class Program
    {
        //charaters ascci
     public static   char pa = (char)176, pb = (char)177, pc = (char)178;
     public static   char e1a = (char)98, e1b = (char)177, e1c = (char)23;
     public static   char e2a = (char)45, e2b = (char)177, e2c = (char)177;
     public static   char e3a = (char)65, e3b = (char)177, e3c = (char)176;
     public static   char heart = (char)3;

        //player and enemy variables to print them on desired locatin on console
      public static  int x = 63, y = 17;
        
      public static  int px = 50, py = 26;
      public static  int ex = 50, ey = 2;
      public static  int ex2 = 7, ey2 = 14;
      public static  int ex3 = 75, ey3 = 27;
      public static int heartX = 40, heartY = 5;
      public static int plx, ply = 0, Ebulletcount = 0, Eindex = 0, E2bulletCount = 0, E2index = 0;

      public static int Health = 30, fireDelay = 0, fireDelay2 = 0, pillDelay = 0;
      public static int index = 0, bulletCount = 0, score = 0;
      public static int Pindex, Pcount = 0;

        const int LIMIT = 100000;
        // PLAYER ARRAYS
     public static   int [] Pbulletx = new int[LIMIT];
     public static  int [] Pbullety = new int[LIMIT];
     public static  bool[] activeBullet = new bool[LIMIT];

        //ENEMY1 ARRAYS
      public static int[] E1bulletX = new int[LIMIT];
      public static int [] E1bulletY = new int[LIMIT];
      public static bool[] activeE1b = new bool[LIMIT];
      public static string EnemyDirection = "Right";
      public static string Enemy2Direction = "Left";

        //ENEMY2 ARRAYS
       public static int[] E2bulletX = new int[LIMIT];
       public static int[] E2bulletY = new int[LIMIT];
       public static bool[] activeE2bullet = new bool[LIMIT];

        //PILL
       public static int[] pillx = new int[LIMIT];
       public static int[] pilly = new int[LIMIT];
       public static bool[] activePill = new bool[LIMIT];


            // Maze
       public static  char[][] maze = new char[][]
            {
            "##########################################################################################################################################################".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |___________________________||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          | Fire button = Space       ||".ToCharArray(),
            "||                                                                                                                          | To exit press Escape.     ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          | Score will increase when  ||".ToCharArray(),
            "||                                                                                                                          | you fire the upper blue   ||".ToCharArray(),
            "||                                                                                                                          |          enemy.           ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |   Score 20 points to win  ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "||                                                                                                                          |                           ||".ToCharArray(),
            "##########################################################################################################################################################".ToCharArray()
            };

            // Characters
       public static     char[][] player = new char[][]
            {
            new char[] { '-',pa, '-' },
            new char[] { pb, '|', pb },
            new char[] { '|', pc, '|' },
            new char[] { '|', pc, '|' },
            new char[] { pc, '-', pc }
            };

       public static     char[][] Enemy1 = new char[][]
            {
            new char[] { ' ', '-', e2a, '-', ' ' },
            new char[] { '(', e2b, '|', e2b, ')' },
            new char[] { e2b, ' ', '|', ' ', e2b },
            new char[] { '(', e2c, '|', e2c, ')' },
            new char[] { ' ', '-', '8', '-', ' ' }
            };

       public static    char[][] Enemy2 = new char[][]
            {
            new char[] { ' ', ' ', ' ', e2a, ' ', ' ', ' ' },
            new char[] { ' ', ')', e2b, '|', e2b, '(', ' ' },
            new char[] { '-', e2b, ' ', '|', ' ', e2b, '-' },
            new char[] { ' ', ')', e2c, '|', e2c, '(', ' ' },
            new char[] { ' ', ' ', ' ', '_', ' ', ' ', ' ' }
            };

       public static     char[][] Enemy3 = new char[][]
            {
            new char[] { ' ', '^', '^', '^', ' ' },
            new char[] { '<', e3b, e3b, e3b, '(' },
            new char[] { '<', e3b, e3b, e3b, '(' }
            };

        static void Main(string[] args)
        {
            Console.Clear();
            gameName();
            menu();
            string menu_option ="";
            string opt;

            while (menu_option != "4")// using while loop until the option is not equals to two
            {
                menu_option = menu();
                if (menu_option == "1")//if user enetes 1 then start the game
                {
                    //functions calling;
                    Console.Clear();
                    logo();
                    loading();
                    Console.Clear();
                    printBoard();
                    printPlayer(px, py);
                    printEnemy1(ex, ey,  Enemy1);
                    printEnemy2(ex2, ey2, Enemy2);
                    printEnemy3(ex3, ey3, Enemy3);

                    while (true)
                    {
                        


                        if (Keyboard.IsKeyPressed(Key.RightArrow))//if user press right arrow key , move player right
                        {
                            movePlayerRight(ref px,ref py);
                        }
                        else if (Keyboard.IsKeyPressed(Key.LeftArrow))//if user press left arrow key , move player left
                        {
                            movePlayerLeft( ref px,ref py);
                        }
                        else if (Keyboard.IsKeyPressed(Key.UpArrow))//if user press up arrow key , move player up
                        {
                            movePlayerUp(ref px,ref py);
                        }
                        else if (Keyboard.IsKeyPressed(Key.DownArrow))//if user press down arrow key , move player down
                        {
                            movePlayerDown(ref px,ref py);
                        }
                        else if (Keyboard.IsKeyPressed(Key.Space))// press space for fire
                        {
                            fireBullet(ref px,ref py);
                            enemy2fire(ref ex2,ref ey2);
                        }
                        else if (Keyboard.IsKeyPressed(Key.Escape))// if user presses the escape key, then break the loop and go to main menu
                        {
                            break;
                            menu();

                        }
                        if (Health <= 0)// if player health becomes less than 0, user will lose
                        {

                            Console.Clear();
                            Thread.Sleep(1000);
                            lose();
                            Console.WriteLine ("Press any key to continue.");
                            opt = Console.ReadLine();
                            Health = 0;
                            score = 0;
                            menu();
                            break;
                        }

                        if (score >= 20)// if score is greater than 20 , user will win
                        {
                            Console.Clear();
                            Thread.Sleep(1000);
                            win();
                            Console.WriteLine ("Press any key to continue.");
                            opt = Console.ReadLine();
                            score = 0;
                            Health = 0;
                            menu();
                            break;
                        }

                        movePlayerBullet();
                        Score();
                        scoreBoard();
                        PlayerHealth();
                        moveEnemy2(ref ex2,ref ey2);
                        moveEnemy3(ref ex3, ref ey3);
                        moveEnemy();
                        enemyBulletmove();
                        enemy2moveFire();
                        movepill();
                        Thread.Sleep(10);
                    }

                }
                else if (menu_option == "2")
                {
                    instructions();
                }

                else if (menu_option == "3")
                {
                    break;
                }


                else
                {
                    invalid_option();
                }

            }
        }

       static void invalid_option()
        {

            Console.Clear();
            gameName();
            

            Console.SetCursorPosition(x, y);
            Console.WriteLine ("Please choose the option that are given.") ;
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine ("Press any key to continue...");
            Console.Read();

        }
        static void scoreBoard()
        {

            Console.SetCursorPosition(133, 2);
            Console.WriteLine ("SCORE BOARD");
        }

        static void printBoard()
        {
            // using nested for loop to print the maze

            for (int i = 0; i < 38; i++)
            {
                for (int j = 0; j < 155; j++)
                {
                    Console.WriteLine(maze[i][j]);
                }
                Console.WriteLine();
            }
        }

        static void loading()
        {
            // simple loading function
            int j = 1;
            
            for (int i = 1; i < 4; i++)
            {
                Console.SetCursorPosition(55, 35);
                Console.WriteLine ("Loading");
                Console.SetCursorPosition((i + j) + 65, 35);
                j = j + 2;// increment j by 2 after every iteration to print loading with accurate spacing
                Console.WriteLine (i);
                Thread.Sleep(1000);//to slow down the loading function
            }
        }

       static void printPlayer(int px, int py)//printing player with nested for loop
        {
            
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(px, py + i);
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine (player[i][j]);
                }
                Console.WriteLine() ;
            }
        }
       static void erasePlayer(int px, int py)//erasing player using same way
        {
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(px, py + i);
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine ("     ");
                }
                Console.WriteLine() ;
            }
        }
       static void printEnemy1(int ex, int ey, char[,] Enemy1)//printing enemy1
        {

            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(ex, ey + i);
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine (Enemy1[i, j]);
                }
                Console.WriteLine();
            }
        }
       static void eraseEnemy1(int ex, int ey, char[,] Enemy1)//removing enemy1
        {
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(ex, ey + i);
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine ("     ");
                }
                Console.WriteLine();
            }
        }

       static void printEnemy2(int ex2, int ey2, char[,] Enemy2)
        {
            
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(ex2, ey2 + i);//adding i in ey2 to print whole player
                for (int j = 0; j < 7; j++)
                {
                    Console.WriteLine (Enemy2[i,j]);
                }
                Console.WriteLine(); 
            }
        }

       static void eraseEnemy2(int ex2, int ey2, char[,] Enemy2)//erasing enemy2
        {
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(ex2, ey2 + i);
                for (int j = 0; j < 7; j++)
                {
                    Console.WriteLine (" ");
                }
                Console.WriteLine(); 
            }
        }

       static void printEnemy3(int ex3, int ey3, char[,] Enemy3)//printing enemy3
        {
            
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(ex3, ey3 + i);
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine (Enemy3[i,j]);
                }
                Console.WriteLine();
            }
        }
        static void eraseEnemy3(int ex3, int ey3, char[,] Enemy2)//erasing enemy3
        {
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(ex3, ey3 + i);
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine ("    ");
                }
                Console.WriteLine();
            }
        }

        //To move the player so that it may not go outside the maze boundry using getcharAtxy()

      static  void movePlayerRight(ref int px,ref int py)
        {
            char space = getCharAtxy(px + 15, py);
            if (space == ' ')
            {
                erasePlayer(px, py);
                px++;
                printPlayer(px, py);

            }
            else if (space == heart)
            {
                Health = 30;
            }

        }
     
        static  void movePlayerLeft(ref int px,ref int py)
        {
            if (getCharAtxy(px - 1, py) == ' ')
            {
                erasePlayer(px, py);
                px--;
                printPlayer(px, py);
            }
            else if (getCharAtxy(px - 1, py) == heart)
            {
                Health = 30;
            }

        }
       static void movePlayerDown(ref int px,ref int py)
        {
            if (getCharAtxy(px, py + 5) == ' ')
            {
                erasePlayer(px, py);
                py++;
                printPlayer(px, py);

            }
            else if (getCharAtxy(px, py + 5) == heart)
            {
                Health = 30;
            }


        }
      static  void movePlayerUp(ref int px,ref int py)
        {
            if (getCharAtxy(px, py - 1) == ' ')
            {
                erasePlayer(px, py);
                py--;
                printPlayer(px, py);

            }
            else if (getCharAtxy(px, py - 1) == heart)
            {
                Health = 30;
            }
        }

       static void fireBullet(ref int px,ref int py)
        {
            plx = px + 1; // update the position of x, y coordinates from where the bullet will be fired
            ply = py - 1;
            Console.SetCursorPosition(plx, ply);
            bullet();
            Pbulletx[index] = plx;// stroing bullet index in array
            Pbullety[index] = ply;
            activeBullet[index] = true;//whether the bullet at corresponding index is active or not
            index++;
            bulletCount++;

        }
      static  void bullet()
        {
            
            Console.WriteLine ("^");
        }
       static void movePlayerBullet()
        {

            for (int i = 0; i < bulletCount; i++)
            {
                if (activeBullet[i] == true)
                {

                    if (getCharAtxy(Pbulletx[i], Pbullety[i] - 1) == ' ')
                    {
                        Console.SetCursorPosition(Pbulletx[i], Pbullety[i]);
                        Console.WriteLine (" ");
                        Pbullety[i] = Pbullety[i] - 1;
                        Console.SetCursorPosition(Pbulletx[i], Pbullety[i]);
                        bullet();
                    }
                    else if ((getCharAtxy(Pbulletx[i], Pbullety[i] - 1) == '8' || getCharAtxy(Pbulletx[i], Pbullety[i] - 1) == '-') || getCharAtxy(Pbulletx[i], Pbullety[i] - 1) == ')' || getCharAtxy(Pbulletx[i], Pbullety[i] - 1) == '(' || getCharAtxy(Pbulletx[i], Pbullety[i] - 1) == e2c || getCharAtxy(Pbulletx[i], Pbullety[i] - 1) == e2b)
                    {
                        Console.SetCursorPosition(Pbulletx[i], Pbullety[i]);
                        Console.WriteLine (" ");
                        activeBullet[i] = false;
                        score++;

                    }
                    else
                    {
                        Console.SetCursorPosition(Pbulletx[i], Pbullety[i]);
                        Console.WriteLine (" ");
                        activeBullet[i] = false;
                    }
                }
            }
        }

       static void Score()
        {
            
            Console.SetCursorPosition(128, 6);
            Console.WriteLine ("SCORE: " , score);
        }
       static void PlayerHealth()
        {
            
            Console.SetCursorPosition(128, 7);
            Console.WriteLine ("PLAYER HEALTH: " , Health);
        }

       static void moveEnemy()
        {
            if (EnemyDirection == "Right")
            {
                char space = getCharAtxy(ex + 7, ey + 2);

                if (space == ' ')
                {
                    Console.SetCursorPosition(ex, ey + 1);
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

                if (getCharAtxy(ex - 1, ey + 2) == ' ')
                {
                    Console.SetCursorPosition(ex + 6, ey + 1);
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

       static void removeEnemy()
        {
            Console.SetCursorPosition(ex, ey);
            Console.WriteLine( "     ");
            Console.SetCursorPosition(ex, ey + 1);
            Console.WriteLine ("     ");
            Console.SetCursorPosition(ex, ey + 2);
            Console.WriteLine ("     ");
            Console.SetCursorPosition(ex, ey + 3);
            Console.WriteLine ("     ");
            Console.SetCursorPosition(ex, ey + 4);
            Console.WriteLine ("     ");
        }

       static void moveEnemy2(ref int ex2,ref int ey2)
        {

            removeEnemy2(ref ex2,ref ey2);
            ex2++;
            printEnemy2( ex2, ey2, Enemy2);
            if (ex2 >= 115)
            {
                removeEnemy2(ref ex2,ref ey2);
                ex2 = 7;
            }

        }
       static void removeEnemy2(ref int ex2,ref int ey2)
        {
            Console.SetCursorPosition(ex2, ey2);
            Console.WriteLine ("       ");
            Console.SetCursorPosition(ex2, ey2 + 1);
            Console.WriteLine( "       ");
            Console.SetCursorPosition(ex2, ey2 + 2);
            Console.WriteLine ("       ");
            Console.SetCursorPosition(ex2, ey2 + 3);
            Console.WriteLine ("       ");
            Console.SetCursorPosition(ex2, ey2 + 4);
            Console.WriteLine ("       ");

        }
       static void moveEnemy3(ref int ex3,ref int ey3)
        {
            eraseEnemy3(ex3, ey3, Enemy3);
            ex3--;
            if (ex3 == '|' || ex3 == pb || ex3 == pc || ex3 == '-')
            {
                Health--;
            }

            printEnemy3(ex3, ey3, Enemy3);
            if (ex3 <= 4)
            {
                eraseEnemy3(ex3, ey3, Enemy3);
                ex3 = 98;
            }
        }
       static void enemyFire(ref int ex,ref int ey)
        {
            int ebx = ex + 3;
            int eby = ey + 5;
            Console.SetCursorPosition(ebx, eby);
            enemyBulet();

            E1bulletX[Eindex] = ebx;
            E1bulletY[Eindex] = eby;
            activeE1b[Eindex] = true;
            Ebulletcount++;
            Eindex++;
        }
       static void enemyBulet()
        {
            
            Console.WriteLine ("*");
        }
       static void enemy2Bullet()
        {
            
            Console.WriteLine (".");
        }
       static void enemyBulletmove()
        {
            for (int i = 0; i < Ebulletcount; i++)
            {
                if (activeE1b[i] == true)
                {
                    char space1 = getCharAtxy(E1bulletX[i], E1bulletY[i] + 1);
                    if (space1 == ' ')// if next char is space
                    {
                        Console.SetCursorPosition(E1bulletX[i], E1bulletY[i]);
                        Console.WriteLine (" ");
                        E1bulletY[i] = E1bulletY[i] + 1;// increment in y

                        Console.SetCursorPosition(E1bulletX[i], E1bulletY[i]);
                        enemyBulet();// printing bullet
                    }
                    else if (space1 == pa || space1 == '|' || space1 == pb || space1 == pc)
                    {
                        //if bullet collides with player then decrease the health
                        Console.SetCursorPosition(E1bulletX[i], E1bulletY[i]);
                        Console.WriteLine (" ");
                        activeE1b[i] = false;
                        Health--;
                    }
                    else
                    {
                        Console.SetCursorPosition(E1bulletX[i], E1bulletY[i]);
                        Console.WriteLine (" ");
                        activeE1b[i] = false;
                    }
                }
            }
            if (fireDelay > 9)
            {
                enemyFire(ref ex,ref ey);
                fireDelay = 0;
            }
            else
            {
                fireDelay++;
            }
        }

       static void enemy2fire(ref int ex2,ref int ey2)
        {
            int ex2bx = ex2 + 3;
            int ex2by = ey2 + 5;

            Console.SetCursorPosition(ex2bx, ex2by);
            enemy2Bullet();

            E2bulletX[E2index] = ex2bx;
            E2bulletY[E2index] = ex2by;
            activeE2bullet[E2index] = true;
            E2index++;
            E2bulletCount++;
        }
       static void enemy2moveFire()
        {
            for (int i = 0; i < E2bulletCount; i++)
            {
                if (activeE2bullet[i] == true)
                {
                    char space2 = getCharAtxy(E2bulletX[i], E2bulletY[i] + 1);
                    if (space2 == ' ')
                    {
                        Console.SetCursorPosition(E2bulletX[i], E2bulletY[i]);
                        Console.WriteLine (" ");
                        E2bulletY[i] = E2bulletY[i] + 1;
                        Console.SetCursorPosition(E2bulletX[i], E2bulletY[i]);
                        enemy2Bullet();
                    }
                    else if (space2 == pa || space2 == '-' || space2 == '|' || space2 == pb || space2 == pc)
                    {
                        Console.SetCursorPosition(E2bulletX[i], E2bulletY[i]);
                        Console.WriteLine (" ");
                        activeE2bullet[i] = false;
                        Health--;
                    }
                    else
                    {
                        Console.SetCursorPosition(E2bulletX[i], E2bulletY[i]);
                        Console.WriteLine (" ");
                        activeE2bullet[i] = false;
                    }
                }
            }

        }

       static void playerPill()
        {
            
            Console.WriteLine (heart);

        }

      static  void pill(ref int heartX ,ref int heartY)
        {
            playerPill();
            pillx[Pindex] = heartX;
            pilly[Pindex] = heartY;

            Pcount++;
            Pindex++;
        }

       static void movepill()
        {
            for (int i = 0; i < Pcount; i++)
            {
                if (activePill[i] == true)
                {
                    if (getCharAtxy(pillx[i], pilly[i] + 1) == ' ')
                    {
                        Console.SetCursorPosition(pillx[i], pilly[i]);
                        Console.WriteLine (" ");
                        pilly[i] = pilly[i] + 1;
                        Console.SetCursorPosition(pillx[i], pilly[i]);
                        Console.WriteLine (heart);
                    }
                    else
                    {
                        Console.SetCursorPosition(pillx[i], pilly[i]);
                        Console.WriteLine (" ");
                        activePill[i] = false;
                    }

                }
            }
            if (pillDelay > 450)
            {
                pill(ref heartX,ref heartY);
                pillDelay = 0;
            }
            else
            {
                pillDelay++;
            }
        }
      static  void gameName()
        {


            Console.WriteLine ("                                  ________  ________  ________  ________  _______           ___       __   ________  ________                                  " );
            Console.WriteLine ("                                 |\\   ____\\|\\   __  \\|\\   __  \\|\\   ____\\|\\  ___ \\         |\\  \\     |\\  \\|\\   __  \\|\\   __  \\                " );
            Console.WriteLine ("                                 \\ \\  \\___|\\ \\  \\|\\  \\ \\  \\|\\  \\ \\  \\___|\\ \\   __/|        \\ \\  \\    \\ \\  \\ \\  \\|\\  \\ \\  \\|\\  \\   " );
            Console.WriteLine ("                                  \\ \\_____  \\ \\   ____\\ \\   __  \\ \\  \\    \\ \\  \\_|/__       \\ \\  \\  __\\ \\  \\ \\   __  \\ \\   _  _\\          " );
            Console.WriteLine ("                                   \\|____|\\  \\ \\  \\___|\\ \\  \\ \\  \\ \\  \\____\\ \\  \\_|\\ \\       \\ \\  \\|\\__\\_\\  \\ \\  \\ \\  \\ \\  \\  \\| " );
            Console.WriteLine ("                                     ____\\_\\  \\ \\__\\    \\ \\__\\ \\__\\ \\_______\\ \\_______\\       \\ \\____________\\ \\__\\ \\__\\ \\__\\ _\\        " );
            Console.WriteLine ("                                    |\\_________\\|__|     \\|__|\\|__|\\|_______|\\|_______|        \\|____________|\\|__|\\|__|\\|__|\\|__|                  " );
            Console.WriteLine ("                                    \\|_________|                                                                                                               " );

            Console.WriteLine ("                               =======================================================================================================") ;

        }

       static void logo()
        {
            

            Console.WriteLine ("                                                                                                       ..-+-:=======+##**.                .+:==-         " );
            Console.WriteLine ("                                                                                                       .:+*++++***#%%#.                    .  .          " );
            Console.WriteLine ("                                                                                                    .:+=:-========+*##*+.                :-===*:         " );
            Console.WriteLine ("                                                                                                 .-+-:==========+**#**=                .+-==++*-.        " );
            Console.WriteLine ("                                                                                             .:==--============***#**#.              .:===+====+         " );
            Console.WriteLine ("                                                                                     :+++==++-:-=============*****#**+              .+===*-===+-         " );
            Console.WriteLine ("                                                                                  .+===++=-:===============*******#**=             -===+-=====*:         " );
            Console.WriteLine ("                                                                            ..::-====*##**********+++====+*******##**:           .+===+-=====*#.         " );
            Console.WriteLine ("                                                                  ..-+#****+--...::-+*+#####%@%##******#%%%%%%%%#####.         .-===+========*+          " );
            Console.WriteLine ("                                                              :*###*:.-+*#############+##%@@@@@@@@@@#*****###%%%%%%%#.        .+===+========**:          " );
            Console.WriteLine ("                                                          :*###*+*#####+#########%%@@@+@@@@@@@@@@@@@@@*+::::::::::::-----=====++++=========+*#.          " );
            Console.WriteLine ("                                                    ..:-+*##########%%%*#@@@@@@@@@@@@@+%@@@@@@@@@@@%#+++++++++++========------:=+==========**#==+:       " );
            Console.WriteLine ("                                             ..:=+==-:::==++++++****###**##%%%%%%%%###*****++++++++++++++++++++++++++++++++++++===========****+++:       " );
            Console.WriteLine ("                                        .-**#=:::::::-==============++++++++++++++++++++++++++++++++++++++++++*******+++++++++=========+*****++++-       " );
            Console.WriteLine ("                                  .-+**+=-=+++=============================++++++*+++++++=============+**********#**#**+++++=====++*#########****-       " );
            Console.WriteLine ("                               :**+***********================================++++**+==================+*********#************+=--=========+***#=.       " );
            Console.WriteLine ("                               .:=+*##########+++++++++++++++++++++++++++++++++********==================*********#**###**+=-:......=++=-========+#=.    " );
            Console.WriteLine ("                                           ............................:::..::::::::::::-+================********#**#.                ....:=+=======+-. " );
            Console.WriteLine ("                                                                             .-=+=----=#%%#+===============*******#***-                        ...:-====-" );
            Console.WriteLine ("                                                                            =++====++++*#%%%%*==============*******#**+                                  " );
            Console.WriteLine ("                                                                              ..-*########%###*+=-===========+*****#**#.                                 " );
            Console.WriteLine ("                                                                                     ..-=======**#+-==========+****##**-                                 " );
            Console.WriteLine ("                                                                                .-+==----========*%%*=-=========****#***                                 " );
            Console.WriteLine ("                                                                               -+==============+***#%%*=-========***#**#:                                " );
            Console.WriteLine ("                                                                                ..=#***************#%%%%#+-=======+**#**#:                               " );
            Console.WriteLine ("                                                                                     ...:::--------::::::::+=-======**##**+.                             " );
            Console.WriteLine ("                                                                                                            .==-=====+**##*#:                            " );
            Console.WriteLine ("                                                                                                              .-+-====+***#**+.                          " );
            Console.WriteLine ("                                                                                                                .:+--===***#***:                         " );
            Console.WriteLine ("                                                                                                                   .===++=-:..                           " );
            

        }

       static string menu()
        {

            Console.Clear();//clears screen
            gameName();
            
            string option;

            Console.SetCursorPosition(x, y);
            Console.WriteLine( "| Press 1 to Start the game.  |" );
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine ("| Press 2 to view instructions|" );
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine ("| Press 3 to exit the game.   |" );

            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine (" Please enter your choice: ");
            option = Console.ReadLine();

            return option;
        }

       static void win()
        {
            
            Console.WriteLine ("                   ( /(   ( /(              (  (      ( /(    ( /(  " );
            Console.WriteLine ("                   )\\())  )\\())      (      )\\))(   ' )\\())   )\\()) " );
            Console.WriteLine ("                  ((_)\\  ((_)\\       )\\    ((_)()\\ ) ((_)\\   ((_)\\  " );
            Console.WriteLine ("                 __ ((_)   ((_)   _ ((_)   _(())\\_)()  ((_)   _((_) " );
            Console.WriteLine ("                 \\ \\ / /  / _ \\  | | | |   \\ \\((_)/ / / _ \\  | \\| | " );
            Console.WriteLine ("                  \\ V /  | (_) | | |_| |    \\ \\/\\/ / | (_) | | .` | " );
            Console.WriteLine ("                   |_|    \\___/   \\___/      \\_/\\_/   \\___/  |_|\\_| " );

        }

       static void lose()
        {
            
            Console.WriteLine ("                                _______             _        _______  _______  _______  " );
            Console.WriteLine ("                      |\\     /|(  ___  )|\\     /|  ( \\      (  ___  )(  ____ \\(  ____ \\ " );
            Console.WriteLine ("                      ( \\   / )| (   ) || )   ( |  | (      | (   ) || (    \\/| (    \\/ " );
            Console.WriteLine ("                       \\ (_) / | |   | || |   | |  | |      | |   | || (_____ | (__     " );
            Console.WriteLine ("                        \\   /  | |   | || |   | |  | |      | |   | |(_____  )|  __)    " );
            Console.WriteLine ("                         ) (   | |   | || |   | |  | |      | |   | |      ) || (       " );
            Console.WriteLine ("                         | |   | (___) || (___) |  | (____/\\| (___) |/\\____) || (____/\\ " );
            Console.WriteLine ("                         \\_/   (_______)(_______)  (_______/(_______)\\_______)(_______/ " );
            
        }


       static void instructions()
        {
            Console.Clear();
            Console.SetCursorPosition(30, 5);
            Console.WriteLine ("    __ __  __  __  ______ ____  __ __   ___ ______ __   ___   __  __ " );
            Console.SetCursorPosition(30, 6);
            Console.WriteLine ("|| ||\\ || (( \\ | || | || \\\\ || ||  //   | || | ||  // \\\\  ||\\ || (( \\" );
            Console.SetCursorPosition(30, 7);
            Console.WriteLine ("|| ||\\\\||  \\\\    ||   ||_// || || ((      ||   || ((   )) ||\\\\||  \\\\ " );
            Console.SetCursorPosition(30, 8);
            Console.WriteLine ("|| || \\|| \\_))   ||   || \\\\ \\\\_//  \\\\__   ||   ||  \\\\_//  || \\|| \\_))" );

            Console.WriteLine();
            Console.SetCursorPosition(40, 10);
            Console.WriteLine ("- VK_UP for moving up");
            Console.SetCursorPosition(40, 11);
            Console.WriteLine ("- VK_DOWN for moving down");
            Console.SetCursorPosition(40, 12);
            Console.WriteLine ("- VK_LEFT for moving left");
            Console.SetCursorPosition(40, 13);
            Console.WriteLine ("- VK_RIGHT for moving right");
            Console.SetCursorPosition(40, 14);
            Console.WriteLine ("- VK_SPACE for fire bullet");
            Console.SetCursorPosition(40, 15);
            Console.WriteLine ("- Score 30 to owin the game");
            Console.SetCursorPosition(40, 16);
            Console.WriteLine ("- Score can be increase by firing bullets at enemies.");
            Console.SetCursorPosition(40, 17);
            Console.WriteLine ("- Your health decreases when you will hit by a enemy bullet");
            Console.SetCursorPosition(40, 18);
            Console.WriteLine ("- You have maximum health of 30");
            Console.SetCursorPosition(40, 19);
            Console.WriteLine ("- You will die in no time if you collide with the enemies.");
            Console.SetCursorPosition(40, 20);
            Console.WriteLine ("To continue, press any key...");
            Console.Read();

        }





    }


}
