using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeGameWinForms
{
    class Wizard : Unit
    {
        public Wizard(string name, double health, double damage, double magicdamage, double armor, double manapool, double Strength, double Dexterity, double Constitution, double Intellisence) : base(name, health, damage, magicdamage, armor, manapool, Strength, Dexterity, Constitution, Intellisence)
        {
            MaxMana = manapool;
        }

        public void Fireboal(Unit unit)
        {
            if (unit.health - 35 > 0)
            {
                unit.health -= 35;
                Console.WriteLine($"the {name} conjured a fireball from the {unit.name} of {unit.health} health");
            }
            else
            {
                Console.WriteLine($"the {unit.name} was killed");
            }
        }

        public void treatment(Unit unit)
        {
            if ((unit.MaxHealth - unit.health) * 6 < this.manapool)
            {
                this.manapool -= (unit.MaxHealth - unit.health) * 6;
                unit.health += unit.MaxHealth - unit.health;
                Console.WriteLine(this.manapool);
                Console.WriteLine($"the {unit.name} has hp={unit.health} heal");
            }

            if (unit.health > unit.MaxHealth || unit.health <= 0)
            {
                Console.WriteLine($"{unit.name} treatment is impossible");
                return;
            }
        }
    }
}
