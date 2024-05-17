using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameLibrary
{
    public class GameObject
    {
        public GameObject(Form refrence,Image image,int left,int top,Imove controller,PlayerType type)
        { 

            pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Image = image;
            pictureBox.Width = image.Width;
            pictureBox.Height = image.Height;            
            pictureBox.Left = left;
            pictureBox.Top = top;
            this.controller = controller;
            this.type = type;
        }

        public PictureBox pictureBox;
        Imove controller;
        PlayerType type;
        int health = 100;

        public void update()
        {

            pictureBox.Location = controller.Move(pictureBox.Location);
        }

        public Imove GetMovementController()
        {
            return controller;
        }


        public bool checkCollision(PlayerType type)
        {
            foreach (GameObject gameObject in Game.instance.GetGameObjects())
            {
                if(gameObject.GetPlayerType() == type)
                {
                    if(this.pictureBox.Location.X <= gameObject.pictureBox.Location.X+gameObject.pictureBox.Width
                    &&this.pictureBox.Location.X + this.pictureBox.Width >= gameObject.pictureBox.Location.X
                    &&this.pictureBox.Location.Y <= gameObject.pictureBox.Location.Y+gameObject.pictureBox.Height
                    &&this.pictureBox.Location.Y + this.pictureBox.Height >= gameObject.pictureBox.Location.Y)
                    {
                        CollisionAction(type,gameObject);
                        return true;
                    }
                }
            }
            return false;
        }

        public void CollisionAction(PlayerType type,GameObject obj)
        {
            if(PlayerType.Enemy == type)
            {
            obj.pictureBox.Top = 10;
            }
        }            

        public Point GetLocation()
        {
            return pictureBox.Location;
        }

        public void SetHealth(int health)
        {
            this.health = health;
        }

        public int GetHealth()
        {
            return health;
        }
        public PlayerType GetPlayerType()
        {
            return this.type;
        }
    }
}