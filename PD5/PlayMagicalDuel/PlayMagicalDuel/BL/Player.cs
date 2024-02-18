using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayMagicalDuel
{
    internal class Player
    {
        public string Name;
        public int Health;
        public int MaxHealth;
        public int Energy;
        public int MaxEnergy;
        public int Armor;

        public Player(string Name, int Health,int MaxHealth,  int Energy,int MaxEnergy, int Armor)
        {
            this.Name = Name;
            this.Health = Health;
            this.MaxHealth = MaxHealth;
            this.Energy = Energy;
            this.MaxEnergy = MaxEnergy;
            this.Armor = Armor;
        }
        public void changeEnergy(int amount)
        {
            Energy += amount;
            if (Energy < 0)
            {
                Energy = 0;
            }
               
            else if (Energy > MaxEnergy)
            {
                Energy = MaxEnergy;
            }
               
        }
        public void changeArmor(int amount)
        {
            Armor += amount;
            if (Armor < 0)
            {
                Armor = 0;
            }
               
        }
        public void UpdateName(string newName)
        {
            Name = newName;
        }
        public void ChangeHealth(int amount)
        {
            Health += amount;
            if (Health < 0)
            {
                Health = 0;
            }   
            else if (Health > MaxHealth)
            {
                Health = MaxHealth;
            }
                
        }
        public string armor(Player p, Stats s)
        {
            int Armor = p.Armor - s.Penetration;
            if (Armor < 0)
            {
                Armor = 0;
            }
               

            if (Energy < s.Cost)
            {
                return $"{Name} attempted to use {s.Name}, but didn't have enough energy!";

            }

            Energy -= s.Cost;

            double damage = s.Damage * ((100 - Armor) / 100.0);
            p.Health -= (int) damage;

            string attackString = $"{Name} used {s.Name}, {s.Description}, against {p.Name}, doing {damage:F2} damage!";

            if (s.Heal > 0)
            {
                Health += s.Heal;
                attackString += $" {Name} healed for {s.Heal} health!";
            }

            if (p.Health <= 0)
            {
                attackString += $" {p.Name} died.";
            }
            else
            {
                double HealthPercentage = ((double)p.Health / p.MaxHealth * 100);
                attackString += $" {p.Name} is at {HealthPercentage:F2}% health.";
            }
            return attackString;
        }
    }
}
