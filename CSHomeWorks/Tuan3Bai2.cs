using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSHomeWorks.Tuan3Bai2;

namespace CSHomeWorks.Tuan3.Bai2
{
    class Work : HomeWork
    {
        public void RunHomeWork()
        {
            Wallet wallet = new Wallet();
            Console.WriteLine("Account's name: ");
            wallet.Name = Console.ReadLine();
            Console.WriteLine("Account's address: ");
            wallet.Address = Console.ReadLine();
            Console.WriteLine("Account's open date: ");
            wallet.OpenDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Private information: ");
            wallet.setPrivateInformation();
            wallet.viewAll();
        }
    }
}
