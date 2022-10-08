using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeGameWinForms
{
    class Item
    {
        public Item(string itemName, int count)
        {
            ItemName = itemName;
            Count = count;
        }

        public string ItemName { get; set; }
        public int Count { get; set; }
    }
}
