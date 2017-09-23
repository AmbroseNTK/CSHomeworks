using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSHomeWorks.Tuan3Bai4;

namespace CSHomeWorks.Tuan3.Bai4
{
    class Work : HomeWork
    {
        public void RunHomeWork()
        {
            Shape shape = new Square();
            Console.WriteLine("Enter square's width: ");
            shape.Width = Double.Parse(Console.ReadLine());
            shape.viewData();

            shape = new Circle();
            Console.WriteLine("\nEnter circle's R:");
            shape.Width = Double.Parse(Console.ReadLine());
            shape.viewData();
        }
    }
}
