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
        public int health { get; set; }
        public int MaxHealth { get; set; }
        public int armor { get; set; }
        public int damage { get; set; }
        public bool IsAlive { get; set; }
        

        public Unit(string name, int health, int armor, int damage)
        {
            this.name = name;
            this.health = health;
            this.MaxHealth = this.health;
            this.damage = damage;
            this.armor = armor;
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
