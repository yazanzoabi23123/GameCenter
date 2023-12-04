using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Class
{
    internal class SavingAccount:BankAccount
    {
        public override double CalculateInterest()
        {
            return 21;
        }
    }
}
