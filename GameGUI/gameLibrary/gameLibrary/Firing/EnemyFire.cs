using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameLibrary
{
    public class EnemyFire
    {
        static EnemyFire instance; 
        EnemyFire(Form form)
        {
            this.form = form;
            firePlayer = new FirePlayer(form);
        }

        

        public static EnemyFire GetEnemyFireInstance(Form form)
        {
            if(instance == null)
            {
                instance = new EnemyFire(form);
            }
            return instance;
        }
        Form form;
        
        FirePlayer firePlayer;
        List<Fire> fires = new List<Fire>();

        public void AddFire(Image image,int left,int top,Imove controller,int borderY)
        {
            Fire fire =  new Fire(image,left,top,controller,PlayerType.Fire,borderY);
            form.Controls.Add(fire.pictureBox);
            fires.Add(fire);    
        }

        public void FireUpdate()
        {
            for(int i=fires.Count-1;i>=0;i--)
            {
                Fire fire = fires[i];
                fire.update();
                checkCollision(fire);
            }
        }
        void checkCollision(Fire fire)
        {
            GameObject player = Game.instance.getPlayer();
            
                if (fire.pictureBox.Location.X <= player.pictureBox.Location.X+player.pictureBox.Width
                    &&fire.pictureBox.Location.X + player.pictureBox.Width >= player.pictureBox.Location.X
                    &&fire.pictureBox.Location.Y <= player.pictureBox.Location.Y+player.pictureBox.Height
                    &&fire.pictureBox.Location.Y + player.pictureBox.Height >= player.pictureBox.Location.Y)
                    {
                        CollisionAction(fire);
            }
        }

        public List<Fire> GetFires()
        {
            return fires;
        }
        void CollisionAction(Fire fire)
        {
            if (fire.isStatic())
            {
                Game.instance.SetFireCount(Game.instance.GetFireCount() +1);
            }
            else
            {
                Game.instance.SetHealth(Game.instance.GetHealth()-10);
                
            }
            fire.pictureBox.Left = -10;
            fire.pictureBox.Top = -10;
            form.Controls.Remove(fire.pictureBox);
            fires.Remove(fire);
        }
    }


    }
