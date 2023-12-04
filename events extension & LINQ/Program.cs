using System.Security.Claims;

namespace events_extension___LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Alarm a1 = new Alarm();

            //SecurityAgency s1 = new SecurityAgency();

            //a1.AlarmRung += s1.OnAlarmRung;


            Order o1 = new Order();
            CustomerNotification customerNotification = new CustomerNotification();
            o1.OrderPlaced += customerNotification.SendOrderConfirmation;
            o1.OrderShipped += customerNotification.SendTrackingNumber;
            o1.OrderDelivered += customerNotification.SendDeliveryUpdate;
            o1.PlaceOrder(1111);
            o1.ShipOrder();
            o1.DeliverOrder();
        }

        //internal class Alarm
        //{

        //    public delegate void AlarmEventHandler();

        //    public event AlarmEventHandler AlarmRung;



        //    public void TriggerAlarm()
        //    {

        //        Console.WriteLine("THE ALARAM IS ON!!!");

        //        AlarmRung?.Invoke();

        //    }

        //}



        //internal class SecurityAgency
        //{

        //    public void OnAlarmRung()
        //    {

        //        Console.WriteLine("Security agency alerted!");

        //    }
        //}

        class Order
        {
            public event Action<int> OrderPlaced;
            public event Action<int> OrderShipped;
            public event Action<int> OrderDelivered;

            public void PlaceOrder(int specialCode)
            {
                Console.WriteLine("New order has been placed");
                OrderPlaced?.Invoke(specialCode);
            }
            public void ShipOrder()
            {
                Console.WriteLine("The order has been shipped");
                OrderShipped?.Invoke(GenerateCode());
            }
            public void DeliverOrder()
            {
                Console.WriteLine("The order has been delivered");
                OrderDelivered?.Invoke(GenerateCode());
            }

            static public int GenerateCode()
            {
                Random random = new Random();
                return random.Next(10000);
            }
        }

        class CustomerNotification
        {
            public void SendOrderConfirmation(int code)
            {
                Console.WriteLine("Order confirmation sent. The code is " + code);
            }

            public void SendTrackingNumber(int code)
            {
                Console.WriteLine("Tracking number sent. The code is " + code);
            }

            public void SendDeliveryUpdate(int code)
            {
                Console.WriteLine("Delivery update sent.The code is " + code);
            }
        }

    }   

}