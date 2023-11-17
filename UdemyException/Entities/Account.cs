using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyException.Entities.Exception;

namespace UdemyException.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder)
        {
            Number = number;
            Holder = holder;
            Balance = 0;
            WithdrawLimit = 0;
        }
        public void deposit(double amount)
        {
            Balance += amount;
        }
        public void withdraw(double amount)
        {
            if (Balance == 0)
            {
                throw new DomainException("No funds");
            }
            else if (Balance - amount < 0)
            {
                throw new DomainException("No enough funds");
            }
            else if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            else
            {
                Balance -= amount;
            }

        }
    }
}
