using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lock_sml
{
    internal class account
    {
        private int _balance;
        private object lockObject = new object();

        public account(int initialDeposite)
        {
            _balance = initialDeposite;
        }

        public int GetBalance => _balance;

        public void Deposit(int amount)
        {
            lock (lockObject)
            {
                _balance += amount;
            }
        }
        public void Withdraw(int amount)
        {
            lock (lockObject)
            {
                _balance -= amount;
            }
        }
    }
}
