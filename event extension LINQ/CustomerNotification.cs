using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static event_extension_LINQ.stock;

namespace event_extension_LINQ
{
    internal class CustomerNotification
    {
        public void OnOrderPlaced(object sender, EventArgs e)
        {
            Console.WriteLine("Notification: Your order has been placed.");
        }

        public void OnOrderShipped(object sender, EventArgs e)
        {
            Console.WriteLine("Notification: Your order has been shipped.");
        }

        public void OnOrderDelivered(object sender, EventArgs e)
        {
            Console.WriteLine("Notification: Your order has been delivered.");


        }
    }
}
