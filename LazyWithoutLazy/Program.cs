namespace LazyWithoutLazy
{
    internal class Program
    {
        static ResourceLoader resourceLoader = new ResourceLoader();
       
        static void Main(string[] args)
        {
            Lazy<ResourceLoader> resourceLoader = new Lazy<ResourceLoader> ();
            Console.WriteLine("Press any key to print the data");
            string click = Console.ReadLine();  
            if (click != null)
            {
                resourceLoader.Value.
            }
        }
    }
}