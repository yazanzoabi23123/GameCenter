using introToOOP;

namespace introOOP
{
    class Program
    {
        static void Main()

        {
            Vehicle myVehicle1 = new Vehicle(1930, "black", "mercedes");
            Vehicle myVehicle2 = new Vehicle(2020, "blue", "Mazda");
            Console.WriteLine(myVehicle1);


            //יש להגדיר 2 רכבות
            //יש לערוך נתון מסוים ב2 הרכבות
            //יש להדפיס נתון מסוים מ2 הרכבות
            int[] cars1 = { 50, 50, 50, 50, 0, 0, 0, 0, 0, 0 };
            int[] cars2 = { 50, 50, 50, 50, 50, 50, 50, 0, 0, 0 };

            Train t1 = new Train(cars1, "11111", 200, 2020, "Black", "mercedes");
            Train t2 = new Train(cars2, "22222", 250, 2023, "Black", "Jp");

            t1.MaxSpeed = 220;
            t2.Color = "Red";

            Console.WriteLine(t1.MaxSpeed);
            Console.WriteLine(t2.Color);
        }
    }
}