using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayMagicalDuel
{
    internal class Stats
    {
        public string Name;
        public int Damage;
        public string Description;
        public int Penetration;
        public int Cost;
        public int Heal;
        public Stats(string name, int damage, double penetration, int heal, int cost, string description)
        {
            Name = name;
            Damage = damage;
            Description = description;
            Penetration = (int)penetration; 
            Cost = cost;
            Heal = heal;
        }
    }
}
