using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeGameWinForms
{
    class FootMan : Unit
    {
        public FootMan(string name, double health, double damage, double magicdamage, double armor, double manapool) : base(name, health, damage, magicdamage, armor, manapool)
        {
        }
    }
}
