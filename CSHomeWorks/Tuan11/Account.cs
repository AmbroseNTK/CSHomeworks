using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan11
{
    class Account
    {
        protected string code;
        protected string name;
        protected double balance;

        public Account(string code, string name, double balance)
        {
            this.code = code;
            this.name = name;
            this.balance = balance;
        }

        protected string Code { get => code; set => code = value; }
        protected string Name { get => name; set => name = value; }
        protected double Balance { get => balance; set => balance = value; }
        
        public virtual void Output()
        {
            Console.WriteLine("Code = " + code);
            Console.WriteLine("Name = " + name);
            Console.WriteLine("Balance = " + balance);
        }
        public double GetBalance()
        {
            return balance;
        }
    }
}
