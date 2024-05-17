using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameLibrary 
    {     
    public class Fire
    {
        public Fire(Image image,int left,int top,Imove controller,PlayerType type,int borderY)
        {
            this.controller = controller;

            pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Image = image;
            pictureBox.Width = image.Width;
            pictureBox.Height = image.Height;            
            pictureBox.Left = left;
            pictureBox.Top = top;
            this.borderY = borderY;
            this.type = type;
        }
        public PictureBox pictureBox;
        Imove controller;
        PlayerType type;
        int left,top;
        int borderY;

        public bool isStatic()
        {
           return (pictureBox.Location.Y >= borderY);
            
        }


        public void ChangeLeftandTop(Point point)
        {
            this.left = point.X+5;
            this.top = point.Y-2;
        }
        public void Setcontroller(Imove controller)
        {
            this.controller = controller;
        }

        public void SetPlayerType(PlayerType type)
        {
            this.type = type;
        }
        public void update()
        {
            pictureBox.Location = controller.Move(pictureBox.Location);
        }
    }
}
