using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeGameWinForms
{
    class Mage : Unit
    {
        int Mana;
        int MaxMana;

        public Mage() : base("Wizard", 60, 4, 40)
        {
            this.Mana = 1000;
            this.MaxMana = this.Mana;
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
            if ((unit.MaxHealth - unit.health) * 6 < this.Mana)
            {
                this.Mana -= (unit.MaxHealth - unit.health) * 6;
                unit.health += unit.MaxHealth - unit.health;
                Console.WriteLine(this.Mana);
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
