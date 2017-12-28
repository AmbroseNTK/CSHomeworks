using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan11
{
    class VIPAccount : Account
    {
        private bool promotion;
        protected bool Promotion { get => promotion; set => promotion = value; }

        public VIPAccount(string code, string name, double balance,bool promotion) : base(code, name, balance)
        {
            this.promotion = promotion;
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Promotion = " + (promotion ? "true" : "false"));
        }
    }
}
