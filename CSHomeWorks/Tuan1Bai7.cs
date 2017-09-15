using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan1.Bai7
{
    class Work : HomeWork
    {
        public void RunHomeWork()
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            name = name.ToUpper();
            if (name.Contains("THI"))
                Console.WriteLine("You are woman");
            else if (name.Contains("VAN"))
                Console.WriteLine("You are man");
            else
                Console.WriteLine("Unknown");
        }
    }
}
