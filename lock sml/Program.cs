using System.Security.Principal;

namespace lock_sml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            account myAccount = new account(0);

            Thread t1 = new Thread(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    myAccount.Deposit(200);
                }
            });
            Thread t2 = new Thread(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    myAccount.Withdraw(100);
                }
            });
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine("The balance is " + myAccount.GetBalance);
        }
    }
}