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
        public int Currentexp { get; set; }
        public int TotalExp { get; set; }
        public double health { get; set; }
        public double MaxHealth { get; set; }
        public double physicaldefence { get; set; }
        public double damage { get; set; }
        public double magicdamage { get; set; }
        public double manapool { get; set; }
        public double MaxMana { get; set; }
        public double Strength { get; set; }
        public double Dexterity { get; set; }
        public double Constitution { get; set; }
        public double Intellisence { get; set; }
       // public bool IsAlive { get; set; }
        public string? helmet { get; set; }
        public string? armor { get; set; }     
        public string? weapon { get; set; }

        [BsonIgnoreIfNull]
        [BsonIgnoreIfDefault]
        public List<Item> Items { get; set; }

        [BsonIgnoreIfNull]
        [BsonIgnoreIfDefault]
        public List<Skill> Skills { get; set; }

        public Unit(string name, string Class, double health, double damage, double magicdamage, double physicaldefence, double manapool, double Strength, double Dexterity, double Constitution, double Intellisence, int LVL)
        {
            this.name = name;
            this.Class = Class;
            this.health = health;
            this.MaxHealth = this.health;
            this.damage = damage;
            this.physicaldefence = physicaldefence;
            this.manapool = manapool;
            this.MaxMana = manapool;
            this.magicdamage = magicdamage;
           // this.IsAlive = true;
            this.Strength = Strength;
            this.Dexterity = Dexterity;
            this.Constitution = Constitution;
            this.Intellisence = Intellisence;
            this.Items = new List<Item>();
            this.Skills = new List<Skill>();
            this.LVL = 1;
            this.Currentexp = Currentexp;
            this.TotalExp = TotalExp;
            this.helmet = helmet;
            this.armor = armor;
            this.weapon = weapon;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }
    }
}
