namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //DatabaseConnection.Instance.SayHello();
            //DatabaseConnection.Instance.SayHello();

            Login login = new Login();

            Signup signup = new Signup();


            //someone click on log in 

            login.logInUserNamePassword("Tzahc", "1234");



            //someone click on log in 

            login.logInSms("05555555");



            //someone registered

            signup.signUpInSms("0522222");
        }
    }
}