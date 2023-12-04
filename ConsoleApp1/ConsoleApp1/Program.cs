using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {

            BankAccount myBA = new BankAccount("Tzach", "NIS", 1000);

            myBA.SetCredit(10000);
            myBA.Deposit(2500);
            myBA.Deposit(500);
            myBA.Deposit(1500);
            myBA.ChangeCurrency("USD", 3.5);

            myBA.PrintDetails();


            //create instance of Point in different ways
            //Point p1 = new Point (10, 5);
            //Point p2 = new Point(5);
            //Point p3 = new Point();
            //Point p4 = new Point(0, 0);

            //Console.WriteLine(p3.Distance(p4));

        }

        static void RefVsValueTypes()
        {
            //value types - int , float, char , struct!! ... 
            int x = 10;
            int y = x;
            x = 15;
            // Console.WriteLine(y);

            //ref types - string, array, object ... 
            int[] arr = { 1, 2, 3, 4 };
            int[] arr2 = arr;
            arr[2] = 100;
            //Console.WriteLine(arr2[2]);

            string str1 = "Hello";
            string str2 = str1;
            str1 = "Something";
            //Console.WriteLine(str2);


        }
        public struct BankAccount
        {
            public string name;
            public int money = 0;
            public string currency;
            public string[] account = new string[10];
            public int credit = 0;

            public BankAccount(string name, string currency)
            {
                this.name = name;
                this.currency = currency;
            }
            public BankAccount(string name, string currency, int money)
            {
                this.name = name;
                this.currency = currency;
                this.money = money;
            }

            public void SetCredit(int credit)
            {
                this.credit = credit;
            }

            public void Deposit(int amount)
            {
                this.money += amount;
                AddNewDetail($"{amount} {this.currency} has been deposited");

            }

            public void Withdrawal(int amount)
            {
                if (this.money - amount > this.credit * -1)
                {
                    this.money -= amount;
                    AddNewDetail($"{amount} {this.currency} has been withdrawaled");
                }
                else
                {
                    Console.WriteLine("You dont have enough money");
                }
            }

            public void ChangeCurrency(string newCurrency, double exchangeRate)
            {
                this.currency = newCurrency;
                double newMoney = this.money / exchangeRate;
                this.money = (int)newMoney;
                AddNewDetail("The currency of the account has been changed");
            }
            public void AddNewDetail(string detail)
            {
                for (int i = 0; i < account.Length - 1; i++)
                {
                    account[i] = account[i + 1];
                }
                account[account.Length - 1] = detail;
            }
            public void PrintDetails()
            {
                foreach (string item in account)
                {

                    Console.WriteLine(item);
                }
            }
        }


        struct Point
        {
            //properties
            public int x;
            public int y;

            //constructor
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            //overload examples
            public Point(int xy)
            {
                this.x = xy;
                this.y = xy;
            }
            public Point()
            {
                this.x = 10;
                this.y = 10;
            }

            //methods
            public double DistanceFrom00()
            {
                double xSquare = Math.Pow(this.x, 2);
                double ySquare = Math.Pow(this.y, 2);
                return Math.Sqrt(xSquare + ySquare);

                //return this.Distance(new Point(0, 0));

            }

            //כתוב מתודה המקבלת נקודה אחרת במרחב ומחזירה את המרחק בין 2 הנקודות
            public double Distance(Point p)
            {
                double dx = this.x - p.x;
                double dy = this.y - p.y;
                return Math.Sqrt(dx * dx + dy * dy);
            }
          
        }

    }





}
   





   


    

