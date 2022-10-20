using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeGameWinForms
{
    class Rogue : Unit
    {
        public Rogue(string name, string Class, double health, double damage, double magicdamage, double physicaldefence, double manapool, double Strength, double Dexterity, double Constitution, double Intellisence, int LVL) : base(name, Class, health, damage, magicdamage, physicaldefence, manapool, Strength, Dexterity, Constitution, Intellisence, LVL)
        {
        }
    }
}
