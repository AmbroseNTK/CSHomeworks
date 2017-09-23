using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan2.Bai2
{
    class Work : HomeWork
    {
        public void RunHomeWork()
        {
            string name;
            getName(out name);
            sayHello(name);
        }
        public void getName(out string name)
        {
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
        }
        public void sayHello(string name)
        {
            Console.WriteLine("Hello! " + name.ToUpper());
        }
    }
}
