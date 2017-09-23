using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan3Bai4
{
    class Circle : Shape
    {
        public Circle()
        {
        }

        public Circle(double width) : base(width)
        {
        }

        public override double calcPerimeter()
        {
            return 2 * Width * Math.PI;
        }

        public override double calcSize()
        {
            return Math.Pow(Width, 2) * Math.PI;
        }
        public override void viewData()
        {
            Console.WriteLine("Circle");
            Console.WriteLine("R = " + Width);
            base.viewData();
        }
    }
}
