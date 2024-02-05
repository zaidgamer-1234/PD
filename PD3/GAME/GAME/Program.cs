using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME
{
    internal class Program
    {
        class Player
        {
            public char DisplayChar;
            public int X;
            public int Y;

            public Player(char displayChar, int x, int y)
            {
                DisplayChar = displayChar;
                X = x;
                Y = y;
            }

            public void Print()
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(DisplayChar);
            }

            public void Clear()
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(" ");
            }

            public void MoveRight()
            {
                Clear();
                X++;
                Print();
            }

            public void MoveLeft()
            {
                Clear();
                X--;
                Print();
            }

            public void MoveDown()
            {
                Clear();
                Y++;
                Print();
            }

            public void MoveUp()
            {
                Clear();
                Y--;
                Print();
            }
        }

        class Enemy
        {
            public char DisplayChar;
            public int X;
            public int Y;

            public Enemy(char displayChar, int x, int y)
            {
                DisplayChar = displayChar;
                X = x;
                Y = y;
            }

            public void Print()
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(DisplayChar);
            }

            public void Clear()
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(" ");
            }

            public void MoveRight()
            {
                Clear();
                X++;
                Print();
            }

            public void MoveLeft()
            {
                Clear();
                X--;
                Print();
            }

            public void MoveDown()
            {
                Clear();
                Y++;
                Print();
            }

            public void MoveUp()
            {
                Clear();
                Y--;
                Print();
            }
        }

        static void Main(string[] args)
        {
            
            Player player = new Player('P', 10, 10);

            
            List<Enemy> enemies = new List<Enemy>
        {
            new Enemy('E', 4, 5),
            new Enemy('E', 2, 2),
            new Enemy('E', 5, 8)
        };
 
            while (true)
            {
                Console.Clear();

                player.Print();

                foreach (var enemy in enemies)
                {
                    enemy.Print();
                    enemy.MoveDown();
                }

                Console.ReadKey(true); 
            }
        }
    }
}
