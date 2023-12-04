using Microsoft.Extensions.Configuration;


namespace working_with_sensitve_data
{
    internal class Program
    {
        static void Main(string[] args)
        {
        var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
        string apiKey = config["apiKey"];
        string secret = Environment.GetEnvironmentVariable("secret");
        Console.WriteLine("The api key is " + secret);

        }
       
    }
    
}
