using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan2.Bai4
{
    class Work : HomeWork
    {
        public void RunHomeWork()
        {
            printDetails();
        }
        public double[] getWidthAndHeight()
        {
            double[] dimesion = new double[2];
            Console.WriteLine("Width = ");
            dimesion[0] = Double.Parse(Console.ReadLine());
            Console.WriteLine("Height = ");
            dimesion[1] = Double.Parse(Console.ReadLine());
            return dimesion;
        }
        public double calcPerimeter(double width, double height)
        {
            return (width + height) * 2;
        }
        public double calcSize(double width, double height)
        {
            return width * height;
        }
        public void printDetails()
        {
            double[] dimesion = getWidthAndHeight();
            Console.WriteLine("Perimeter = " + calcPerimeter(dimesion[0], dimesion[1]));
            Console.WriteLine("Size = " + calcSize(dimesion[0], dimesion[1]));
        }
    }
}
