using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan3Bai4
{
    public abstract class Shape
    {
        private double width;

        public double Width { get => width; set => width = value; }

        public Shape() { }
        public Shape(double width)
        {
            this.width = width;
        }
        public abstract double calcPerimeter();
        public abstract double calcSize();
        public virtual void viewData()
        {
            Console.WriteLine("Perimeter = "+calcPerimeter());
            Console.WriteLine("Size = " + calcSize());
        }
    }
}
