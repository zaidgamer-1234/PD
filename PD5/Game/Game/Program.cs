using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
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
}
