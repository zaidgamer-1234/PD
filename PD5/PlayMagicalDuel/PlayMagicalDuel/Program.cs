using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayMagicalDuel
{
    internal class Program
    {
        static void Main(string[] args)
        {
             List<Player> players = new List<Player>();
             List<Stats> stats = new List<Stats>();

            string menu;
            string choice = "";
            while(choice != "6")
            {
                menu = Menu();
                if(menu == "1")
                {
                    AddPlayer(players);
                }
                else if(menu == "2")
                {
                    AddSkill(stats);
                }
                else if(menu == "3")
                {
                    DisplayPlayerInfo(players);
                }
                else if(menu == "4")
                {
                    Attack(players, stats);
                }
            }
        }

        static string Menu()
        {
            Console.Clear();

            Console.WriteLine("1. Add Player");
            Console.WriteLine("2. Add Skill Statistics");
            Console.WriteLine("3. Display Player Info");
            Console.WriteLine("4. Attack");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice");
            string option;
            option = Console.ReadLine();
            return option;
        }
        static void AddPlayer(List<Player>players)
        {
            Console.Write("Enter player name: ");
            string name = Console.ReadLine();
            Console.Write("Enter health: ");
            int health = int.Parse(Console.ReadLine());
            Console.Write("Enter max health: ");
            int maxHealth = int.Parse(Console.ReadLine());
            Console.Write("Enter energy: ");
            int energy = int.Parse(Console.ReadLine());
            Console.Write("Enter max energy: ");
            int maxEnergy = int.Parse(Console.ReadLine());
            Console.Write("Enter armor: ");
            int armor = int.Parse(Console.ReadLine());

            Player p = new Player(name, health, maxHealth, energy, maxEnergy, armor);

            players.Add(p);
            Console.WriteLine("Player added successfully.");
        }
        static void AddSkill(List<Stats>stats)
        {
            Console.Write("Enter skill name: ");
            string name = Console.ReadLine();
            Console.Write("Enter damage: ");
            int damage = int.Parse(Console.ReadLine());
            Console.Write("Enter penetration: ");
            double penetration = double.Parse(Console.ReadLine());
            Console.Write("Enter heal: ");
            int heal = int.Parse(Console.ReadLine());
            Console.Write("Enter cost: ");
            int cost = int.Parse(Console.ReadLine());
            Console.Write("Enter description: ");
            string description = Console.ReadLine();

            Stats s = new Stats(name, damage, penetration, heal, cost, description);

            stats.Add(s);
            Console.WriteLine("Skill statistics added successfully.");
        }
        static void DisplayPlayerInfo(List<Player>player)
        {
            Console.WriteLine("Player Information:");
            for(int i=0; i<player.Count;i++)
            {
                Console.WriteLine($"Name: {player[i].Name}, Health: {player[i].Health}/{player[i].MaxHealth}, Energy: {player[i].Energy}/{player[i].MaxEnergy}, Armor: {player[i].Armor}");
            }
        }
        static void Attack(List<Player> players, List<Stats>stats)
        {
            Console.WriteLine("Select attacking player:");
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {players[i].Name}");
            }


            Console.Write("Enter number corresponding to attacking player: ");
            int PlayerIndex = int.Parse(Console.ReadLine());
            Player attackingPlayer = players[PlayerIndex - 1];

            Console.WriteLine("Select target player:");
            for (int i = 0; i < players.Count; i++)
            {
                
                    Console.WriteLine($"{i + 1}. {players[i].Name}");
            }

            Console.Write("Enter number corresponding to target player: ");
            int targetPlayerIndex = int.Parse(Console.ReadLine());
            Player targetPlayer = players[targetPlayerIndex - 1];

            Console.WriteLine("Select skill for attack:");
            for (int i = 0; i < stats.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {stats[i].Name}");
            }

            Console.Write("Enter number corresponding to skill: ");
            int skillIndex = int.Parse(Console.ReadLine());
            Stats selectedSkill = stats[skillIndex - 1];

            string attackResult = attackingPlayer.armor(targetPlayer, selectedSkill);
            Console.WriteLine(attackResult);
        }
    }
}
