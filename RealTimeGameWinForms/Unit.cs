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
    [BsonKnownTypes(typeof(Wizard), typeof(Rogue), typeof(Warrior))]
    class Unit
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;
        public string name { get; set; }
        public string Class { get; set; }
        public int LVL { get; set; }
        public int exp { get; set; }
        public double health { get; set; }
        public double MaxHealth { get; set; }
        public double armor { get; set; }
        public double damage { get; set; }
        public double magicdamage { get; set; }
        public double manapool { get; set; }
        public double MaxMana { get; set; }
        public double Strength { get; set; }
        public double Dexterity { get; set; }
        public double Constitution { get; set; }
        public double Intellisence { get; set; }
        public bool IsAlive { get; set; }
        [BsonIgnoreIfNull]
        [BsonIgnoreIfDefault]
        public List<Item> Items { get; set; }
        [BsonIgnoreIfNull]
        [BsonIgnoreIfDefault]
        public List<Skill> Skills { get; set; }

        public Unit(string name, string Class, double health, double damage, double magicdamage, double armor, double manapool, double Strength, double Dexterity, double Constitution, double Intellisence, int lvl, int exp)
        {
            this.name = name;
            this.Class = Class;
            this.health = health;
            this.MaxHealth = this.health;
            this.damage = damage;
            this.armor = armor;
            this.manapool = manapool;
            this.MaxMana = manapool;
            this.magicdamage = magicdamage;
            this.IsAlive = true;
            this.Strength = Strength;
            this.Dexterity = Dexterity;
            this.Constitution = Constitution;
            this.Intellisence = Intellisence;
            this.Items = new List<Item>();
            this.Skills = new List<Skill>();
            this.LVL = 1;
            this.exp = exp;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
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
