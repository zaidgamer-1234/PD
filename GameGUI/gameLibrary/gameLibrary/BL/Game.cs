using EZInput;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace gameLibrary
{
    public class Game
    {
        Game(Form form)
        {
            startTime = DateTime.Now;
            this.form = form;
            gameObjects = new List<GameObject>();
        }
        DateTime startTime;
        int health = 100;
        int lanetime = 50;
        int fireCount;
        Form form;
        int score = 0;

        
        public static Game instance;
        List<GameObject> gameObjects;
        

        public static Game GetGameInstance(Form form)
        {
            if(instance == null)
            {
               instance = new Game(form);
            }
            return instance;
        }

        public void AddGameObject(Image image,int left,int top,Imove controller,PlayerType type)
        {
            GameObject gameObject = new GameObject(form,image,left,top,controller,type);
            form.Controls.Add(gameObject.pictureBox);
            gameObjects.Add(gameObject);
        }

        public Form getFormRefrence()
        {
            return form;
        }

        public List<GameObject> GetGameObjects()
        {
            return gameObjects;
        }

        public void Update()
        {
            foreach(GameObject obj in gameObjects)
            {
                if(obj.GetPlayerType() == PlayerType.Player)
                {
                    if(obj.checkCollision(PlayerType.Fire))
                    {
                        health -= 10;
                        break;
                    }
                }
                obj.update();
            }
        }
        public void DecreaseLaneTime()
        {
            for (int i = GetLaneTime(); i >=0 ; i--)
            {
                if (Keyboard.IsKeyPressed(Key.LeftArrow)|| Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    SetLaneTime(GetLaneTime() + 1);
                }
                else
                {
                    SetLaneTime(GetLaneTime() - 1);
                }
                
            }
        }
        public List<GameObject> getEnemies()
        {
            List<GameObject> enemies = new List<GameObject> ();
            foreach(GameObject obj in gameObjects)
            {
                if(obj.GetPlayerType() == PlayerType.Enemy)
                {
                    enemies.Add(obj);
                }
            }
            return enemies;
        }
        public GameObject getPlayer()
        {
            foreach(GameObject gameObject in gameObjects)
            {
                if(gameObject.GetPlayerType() == PlayerType.Player) { return gameObject; }
            }
            return null;
        }


        public int GetFireCount()
        {
            return fireCount;
        }
        public void SetFireCount(int fireCount)
        {
            this.fireCount = fireCount;
        }
        public void SetHealth(int health)
        {
            this.health = health;
        }
        public int GetHealth()
        {
            return health;
        }
        public void SetScore(int health)
        {
            this.score = health;
        }
        public int GetScore()
        {
            return score;
        }
        public void SetLaneTime(int health)
        {
            this.lanetime = health;
        }
        public int GetLaneTime()
        {
            return lanetime;
        }
    }


}
