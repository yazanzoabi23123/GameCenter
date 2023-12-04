using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMangment
{
    internal abstract class InventoryItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ID { get; set; }
        public int Quantity { get; set; }

        public void AddStock(int amuont) => Quantity += amuont ;
        public void ReduceStock(int amuont) => Quantity = (amuont > Quantity) ? 0: Quantity - amuont  ;

    }

}
