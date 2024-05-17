using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gameLibrary;
using EZInput;

namespace GameProject
{
    public partial class v : Form
    {
        public v()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            WindowState = FormWindowState.Maximized;
        }

        Game game;
        private void Form1_Load(object sender, EventArgs e)
        {
            int width = this.Width;
            int height = this.Height;
            game = Game.GetGameInstance(this);
            firePlayer = new FirePlayer(this);
            enemyFire = EnemyFire.GetEnemyFireInstance(this);
            game.AddGameObject(Properties.Resources.carYellow,100,25,new VerticalMovement(30,Direction.Top,new System.Drawing.Point(550,600)),PlayerType.Enemy);
            game.AddGameObject(Properties.Resources.CarRed,180,500,new KeyBoardMovement(30,new System.Drawing.Point(width,height)),PlayerType.Player);
            game.AddGameObject(Properties.Resources.carGrey, 500, 190, new VerticalMovement(30, Direction.Top, new System.Drawing.Point(350, 600)), PlayerType.Enemy);
            game.AddGameObject(Properties.Resources.carGreen, 760, 150, new VerticalMovement(30, Direction.Top, new System.Drawing.Point(10,600)), PlayerType.Enemy);
            game.AddGameObject(Properties.Resources.carPink, 1000, 15, new VerticalMovement(30, Direction.Top, new System.Drawing.Point(50, 600)), PlayerType.Enemy);

        }
        EnemyFire enemyFire;
        FirePlayer firePlayer;
        private void timer1_Tick(object sender, EventArgs e)
        {
            GameObject enem = game.getEnemies()[0];
            GameObject player = game.getPlayer();

            for( int i=firePlayer.playerFires.Count-1; i>=0;i--)
            {
                Fire fire = firePlayer.playerFires[i];
                firePlayer.checkCollision(fire);     
            }
            if (player.checkCollision(PlayerType.Enemy))
            {
                if(game.GetHealth() <= 0 )
                {
                    timer1.Enabled = false;
                    GameOver newa = new GameOver();
                    newa.Show();
                    Visible = false;
                }
                else
                {
                    game.SetHealth(game.GetHealth() - 10);
                }
                
            }

            
            game.Update();
            firePlayer.Update();
            Shoot();
            Healthlable.Text = game.GetHealth().ToString();
        }
        public void Shoot()
        {
            GameObject player = game.getPlayer();
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                    firePlayer.AddFire(Properties.Resources.fire, player.GetLocation().X + 5, player.GetLocation().Y - 5, new FireMovement(20, Direction.Top, 0), 0); 
                    Healthlable.Text = "Health: " + player.GetHealth().ToString();
                    Score.Text = "Score: " + game.GetScore().ToString();
                   
                
            }
        }

        private void Score_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
