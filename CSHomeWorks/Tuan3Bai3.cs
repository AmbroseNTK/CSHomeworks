using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSHomeWorks.Tuan3Bai3;

namespace CSHomeWorks.Tuan3.Bai3
{
    class Work : HomeWork
    {
        public void RunHomeWork()
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Width:");
            rectangle.Width = Double.Parse(Console.ReadLine());
            Console.WriteLine("Height:");
            rectangle.Height = Double.Parse(Console.ReadLine());
            rectangle.viewInfo();
        }
    }
}
