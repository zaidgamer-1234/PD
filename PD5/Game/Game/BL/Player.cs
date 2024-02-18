using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.BL
{
    internal class Player
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
}
