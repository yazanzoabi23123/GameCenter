using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_extension_LINQ
{
    internal class Order
    {
        public delegate void OrderEventHandler(object sender, EventArgs args);
        public event OrderEventHandler OrderPlaced;
        public event OrderEventHandler OrderShipped;
        public event OrderEventHandler OrderDelivered;

        public void PlaceOrder()
        {
            Console.WriteLine("Order placed!");
            OrderPlaced?.Invoke(this, EventArgs.Empty);
        }

        public void ShipOrder()
        {
            Console.WriteLine("Order shipped!");
            OrderShipped?.Invoke(this, EventArgs.Empty);
        }

        public void DeliverOrder()
        {
            Console.WriteLine("Order delivered!");
            OrderDelivered?.Invoke(this, EventArgs.Empty);



        }
    }
}
