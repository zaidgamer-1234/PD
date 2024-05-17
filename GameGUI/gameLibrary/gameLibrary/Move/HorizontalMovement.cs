using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameLibrary
{
    public class HorizontalMovement:Imove
    {
        public HorizontalMovement(int speed,Direction direction,Point boundary)
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
            if(position.X + offset > boundary.X)
            {
                direction = Direction.Left;
            }else if(position.X <= 0)
            {
                direction = Direction.Right;
            }
            
            if(direction == Direction.Left)
            {             
                position.X -= speed;
            }
            else if(direction == Direction.Right)
            {
                position.X += speed;
            }
            return position;
        }
    }
}
