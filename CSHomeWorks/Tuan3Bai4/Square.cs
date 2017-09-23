using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan3Bai4
{
    class Square : Shape
    {
        public Square() { }
        public Square(double width) : base(width)
        {
        }

        public override double calcPerimeter()
        {
            return Width + Width;
        }

        public override double calcSize()
        {
            return Width * Width;
        }
        public override void viewData()
        {
            Console.WriteLine("Square: ");
            Console.WriteLine("Width = "+Width);
            base.viewData();
        }
    }
}
