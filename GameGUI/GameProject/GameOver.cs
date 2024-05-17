using gameLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProject
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }
        Game game;
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            game = Game.GetGameInstance(this);
            GameObject g = game.getPlayer();
            label1.Text = "Score" + game.GetScore().ToString(); 
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            v restart = new v();
            restart.Show();
            Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            Visible = false;
        }
    }
}
