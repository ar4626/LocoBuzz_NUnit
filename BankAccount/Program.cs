using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccounts
    {
        private double balance;
        public BankAccounts() { }

        public BankAccounts(double balance)
        {
            this.balance = balance;
        }

        public double Balance
        {
            get { return balance; }
        }

        public void Add(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            this.balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            this.balance -= amount;
        }

        public void transferToOtherAccount(BankAccounts otherAccount, double amount)
        {
            if(otherAccount is null)
            {
                throw new ArgumentNullException(nameof(otherAccount));
            }

            Withdraw(amount);
            otherAccount.Add(amount);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
