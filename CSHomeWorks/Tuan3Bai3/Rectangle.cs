using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan3Bai3
{
    class Rectangle
    {
        private double width;
        private double height;

        public Rectangle() { }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

        public double calcPerimeter()
        {
            return 2 * (Width + Height);
        }
        public double calcSize()
        {
            return Width * Height;
        }
        public double calcCrossLength()
        {
            return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
        }
        public void viewInfo()
        {
            Console.WriteLine("Width = "+Width);
            Console.WriteLine("Height = "+Height);
            Console.WriteLine("Perimeter = "+calcPerimeter());
            Console.WriteLine("Size = "+calcSize());
            Console.WriteLine("Cross length = "+calcCrossLength());
        }
    }
}
