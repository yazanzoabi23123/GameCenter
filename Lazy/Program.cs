namespace Lazy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Click 1 for international or 2 for Israel");
            string choose = Console.ReadLine();
            Lazy<DataRepository> internationalGames = new Lazy<DataRepository>(() => new DataRepository("data.json"));
            Lazy<DataRepository> IsraelGames = new Lazy<DataRepository>(() => new DataRepository("dataIl.json"));

            if (choose == "1")
            {

                internationalGames.Value.printResultDict();
            }
            if (choose == "2")
            {
                IsraelGames.Value.printResultDict();

            }
        }
}