namespace event_extension_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();
            LogSystem logSystem = new LogSystem();
            EmailSystem emailSystem = new EmailSystem();
            userRegistration.OnUserRegistered += logSystem.logoSystem;
        }
    }
}