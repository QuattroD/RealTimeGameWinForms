﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeGameWinForms
{
    class Warrior : Unit
    {
        public Warrior(string name, double health, double damage, double magicdamage, double armor, double manapool, double Strength, double Dexterity, double Constitution, double Intellisence, Item item, int lvl/*, int exp*/) : base(name, health, damage, magicdamage, armor, manapool, Strength, Dexterity, Constitution, Intellisence, item, lvl/*, exp*/)
        {
        }
    }
}
