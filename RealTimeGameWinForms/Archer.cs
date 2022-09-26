using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeGameWinForms
{
    class Archer : Unit
    {
        public Archer() : base("Archer", 70, 5, 37)
        {
        }
        public virtual new void Attack(Unit unit)
        {
            int Arrows = 20;
            if (unit.health - damage > 0)
            {
                if (Arrows > 0)
                {
                    Arrows--;
                    unit.health -= damage;
                    Console.WriteLine($"the {name} attacked {unit.name} has hp={unit.health}");
                    Console.WriteLine($"{Arrows} осталось");
                }
            }
            else
            {
                IsAlive = false;
                Console.WriteLine($"the {unit.name} was killed");
            }
        }
    }
}
