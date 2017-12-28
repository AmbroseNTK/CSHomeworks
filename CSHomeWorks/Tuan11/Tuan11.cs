using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan11
{
    class Tuan11 : HomeWork
    {
        public static Random random;
        public void RunHomeWork()
        {
           
            random = new Random();
            Bank bank = new Bank();
            for(int i = 0; i < 1; i++)
            {
                Account account1 = new Account(GenRandomString(), GenRandomString(), random.Next(1000,10000) );
                Account account2 = new VIPAccount(GenRandomString(), GenRandomString(), random.Next(1000, 10000),true);
                Account account3 = new BussinessAccount(GenRandomString(), GenRandomString(), random.Next(1000, 10000), random.Next(1000, 10000));

                bank.Add(account1);
                bank.Add(account2);
                bank.Add(account3);
            }
            bank.Output();

            var maxAccount = bank.Max<Account>(acc => acc.GetBalance());
            var minAccount = bank.Min<Account>(acc => acc.GetBalance());
            Console.WriteLine("Max = "+maxAccount);
            Console.WriteLine("Min = "+minAccount);
        }
        private static string GenRandomString()
        {
            int length = 10;
            const string pool = "abcdefghijklmnopqrstuvwxyz0123456789";
            var builder = new StringBuilder();

            for (var i = 0; i < length; i++)
            {
                var c = pool[random.Next(0, pool.Length)];
                builder.Append(c);
            }

            return builder.ToString();
        }
    }
}
