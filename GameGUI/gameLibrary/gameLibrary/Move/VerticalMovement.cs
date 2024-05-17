using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameLibrary
{
    public class VerticalMovement : Imove
    {
        public VerticalMovement(int speed,Direction direction,Point boundary)
        {
            this.speed = speed;
            this.direction = direction;
            this.boundary = boundary;
        }

        int speed;
        Direction direction;
        Point boundary;
        int offset = 10;

        public Point Move(Point position)
        {
            if(position.Y + offset > boundary.Y)
            {
                direction = Direction.Top;
            }else if(position.Y <= 0)
            {
                direction = Direction.Bottom;
            }
            
            if(direction == Direction.Top)
            {             
                position.Y -= speed;
            }
            else if(direction == Direction.Bottom)
            {
                position.Y += speed;
            }
            return position;
        }
    }
}
