using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMangment
{
    internal class FileStorage<T> : IStorage<T> where T : InventoryItem
    {
        public void SaveToFile(string path, List<T> items)
        {

            using (StreamWriter sw = new StreamWriter(path))
            {

                foreach (T item in items)
                {
                    sw.WriteLine($"{item.ID},{item.Description},{item.Name},{item.Quantity}");

                }
            }

        }
        public List<T> LoadFromFile(string path)
        {
            List<T> items = new List<T>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    T item = (T) Activator.CreateInstance(typeof(T));
                    item.ID = (parts[0]);
                    item.Name = parts[1];
                    item.Description = parts[2];
                    item.Quantity = int.Parse(parts[3]);
                    items.Add(item);
                }
                return items;
            }
        }

    }
}
