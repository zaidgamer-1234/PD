using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZInput;

namespace gameLibrary
{
    public class KeyBoardMovement: Imove
    {
        public KeyBoardMovement(int speed,System.Drawing.Point boundary)
        {
            this.speed = speed;
            this.boundary = boundary;
        }
        int speed;
        System.Drawing.Point boundary;
        int offSet = 100;

        public System.Drawing.Point Move(System.Drawing.Point position)
        {
            if ((position.Y + offSet) <= boundary.Y&&Keyboard.IsKeyPressed(Key.DownArrow))
            {
                position.Y += speed;
            }

            else if (position.Y - offSet >= 0 && Keyboard.IsKeyPressed(Key.UpArrow))
            {
                position.Y -= speed;
            }
            else if (position.X - offSet >= 0 && Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                position.X -= speed;
            }
            if ((position.X + offSet) <= boundary.X && Keyboard.IsKeyPressed(Key.RightArrow))
            {
                position.X+= speed;
            }
            return position;
        }

    }
}
