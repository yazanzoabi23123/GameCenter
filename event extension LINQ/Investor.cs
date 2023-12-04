using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace event_extension_LINQ
{
    internal class Investor
    {


        public void OnPriceChanged(object sender, EventArgs e)
        {
            stock Stock = sender as stock;
            Console.WriteLine($"Price of {Stock.Name} has changed to {Stock.Price}.");
        }

        public void OnPriceAlert(object sender, EventArgs e)
        {
            stock Stock = sender as stock;
            Console.WriteLine($"ALERT! Price of {Stock.Name} has dropped by more than 10%!");
        }
    }
}
