using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMangment
{
    internal interface IStorage<T>
    {
        void SaveToFile(string path,List<T> items);
        List<T> LoadFromFile(string path);
    }
}
