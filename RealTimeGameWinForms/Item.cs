using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeGameWinForms
{
    class Item
    {
        public Item(string itemName)
        {
            ItemName = itemName;
        }

        public string ItemName { get; set; }
    }
}
