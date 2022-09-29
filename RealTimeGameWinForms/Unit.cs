using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeGameWinForms
{
    [BsonIgnoreExtraElements]
    class Unit
    {
        [BsonId]
        public string name { get; set; }
        public double health { get; set; }
        public double MaxHealth { get; set; }
        public double armor { get; set; }
        public double damage { get; set; }
        public double magicdamage { get; set; }
        public double manapool { get; set; }
        public double MaxMana { get; set; }
        public bool IsAlive { get; set; }
        
        public Unit(string name, double health, double damage, double magicdamage, double armor, double manapool)
        {
            this.name = name;
            this.health = health;
            this.MaxHealth = this.health;
            this.damage = damage;
            this.armor = armor;
            this.manapool = manapool;
            this.MaxMana = MaxMana;
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
