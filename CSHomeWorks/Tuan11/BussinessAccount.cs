using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan11
{
    class BussinessAccount : Account
    {
        private double interestRate;
        protected double InterestRate { get => interestRate; set => interestRate = value; }
        public BussinessAccount(string code, string name, double balance, double interestRate) : base(code, name, balance)
        {
            this.interestRate = interestRate;
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Interest Rate = " + interestRate);
        }
    }
}
