using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_extension_LINQ
{
    internal class stock
    {
        //public string Name { get; set; }
        //public double Price { get; set; }
        //public delegate void StockEventHandler();
        //public event StockEventHandler PriceChanged;

        //public void StockUpdate() 
        //{



        //}
        private float price;
        public string Name { get; set; }

        public delegate void StockEventHandler(object sender, EventArgs args);
        public event StockEventHandler PriceChanged;
        public event StockEventHandler PriceAlert;

        public float Price
        {
            get { return price; }
            set
            {
                if (Math.Abs(value - price) > price * 0.10)
                    PriceAlert?.Invoke(this, EventArgs.Empty);

                price = value;
                PriceChanged?.Invoke(this, EventArgs.Empty);
            }
        }
              

    }


}
