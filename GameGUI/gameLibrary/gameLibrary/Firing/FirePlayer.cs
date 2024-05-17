using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;

namespace gameLibrary
{
    public class FirePlayer
    {        
        public FirePlayer(Form form)
        {
            this.form = form;
            playerFires = new List<Fire>();
        }
        Form form;
        public List<Fire> playerFires;
        public void checkCollision(Fire fire)
        {
            foreach(GameObject player in Game.instance.getEnemies())
            {
                if (fire.pictureBox.Location.X <= player.pictureBox.Location.X+player.pictureBox.Width
                    &&fire.pictureBox.Location.X + player.pictureBox.Width >= player.pictureBox.Location.X
                    &&fire.pictureBox.Location.Y <= player.pictureBox.Location.Y+player.pictureBox.Height
                    &&fire.pictureBox.Location.Y + player.pictureBox.Height >= player.pictureBox.Location.Y)
                    {
                        CollisionAction(fire,player);
            } }
        }

        void CollisionAction(Fire fire,GameObject player)
        {
            
            player.pictureBox.Top = 10;
            form.Controls.Remove(fire.pictureBox);
            playerFires.Remove(fire);
            Game.instance.SetScore(Game.instance.GetScore()+5);
        }


        public void AddFire(Image image,int left,int top,Imove controller,int borderY)
        {
            Fire fire =  new Fire(image,left,top,controller,PlayerType.Fire,borderY);
            form.Controls.Add(fire.pictureBox);
            playerFires.Add(fire);    
        }

        public  void Update()
        {
           
            for (int i = playerFires.Count - 1; i >= 0; i--)
            {
                Fire fire = playerFires[i];

                if (fire.pictureBox.Location.Y <= 0)
                {
                    form.Controls.Remove(fire.pictureBox);
                }
            }
            
            for(int i=playerFires.Count-1; i >= 0; i--)
            {
                Fire fire = playerFires[i];
                fire.update();
                checkCollision(fire);
            }
        }
    }
}
