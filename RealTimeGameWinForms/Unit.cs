using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeGameWinForms
{
    
    class Unit
    {
        public string name { get; set; }
        public double health { get; set; }
        public double MaxHealth { get; set; }
        public double armor { get; set; }
        public double damage { get; set; }
        public double magicdamage { get; set; }
        public double manapool { get; set; }
        public bool IsAlive { get; set; }

        {
            this.name = name;
            this.health = health;
            this.MaxHealth = this.health;
            this.damage = damage;
            this.armor = armor;
            this.manapool = manapool;
            this.magicdamage = magicdamage;
            this.IsAlive = true;
        }

        public void Attack(Unit unit)
        {
            if (unit.health - damage > 0)
            {
                unit.health -= damage;
                Console.WriteLine($"the {name} attacked {unit.name} has hp={unit.health}");
            }
            else
            {
                IsAlive = false;
                Console.WriteLine($"the {unit.name} was killed");
            }
        }

    }
}
