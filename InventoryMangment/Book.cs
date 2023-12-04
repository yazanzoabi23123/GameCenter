using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMangment
{
    internal class Book :InventoryItem
    {
        public string Publisher {get;set;}
        public string Author { get;set;}
    }
}
