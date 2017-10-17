using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryOfObjects
{
    public class Account
    {
        private string accName;
        private string acid;
        private double balance;

        public Account()
        {
        }

        public Account(string accName, string acid, double balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }

        public string AccName
        {
            set { this.accName = value; }
            get { return this.accName; }
        }

        public string Acid
        {
            set { this.acid = value; }
            get { return this.acid; }
        }

        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }

        // deposit
        public void Deposit(double amount)
        {
            this.balance = this.balance + amount;
        }

        public void WithDraw(double amount)
        {
            if (amount < this.balance)
            {
                this.balance = this.balance - amount;
            }
            else
            {
                Console.WriteLine("account withdraw not possible.... :( :(");
            }


        }

        public void Transfer(double amount, Account receiver)
        {
            this.balance = this.balance - amount;
            receiver.Deposit(amount);

            Console.WriteLine("Amount transferred to " + receiver.AccName + ": " + receiver.Balance);
        }
    }
}