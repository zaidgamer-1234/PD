using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameLibrary
{
    public class FireMovement:Imove
    {
        public FireMovement(int speed,Direction direction,int borderY)
        {
            this.speed = speed;
            this.direction = direction;
            this.borderY = borderY;
        }
        int speed;
        int borderY;
        Direction direction;
        public Point Move(Point position)
        {
            if(direction == Direction.Bottom && position.Y < borderY)
            {
                position.Y += speed;
            }
            else if(direction == Direction.Top && position.Y > borderY)
            {
                position.Y -= speed;
            }
            return position;
        }
    }
}
