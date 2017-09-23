using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan2.Bai1
{
    class Work : HomeWork
    {
        public void RunHomeWork()
        {
            int n = inputN();
            int m = inputN("Enter m");
            Console.WriteLine(n+" + "+m+" = "+sumOf1(n, m));
            int sum = 0;
            sumOf2(n, m, out sum);
            Console.WriteLine(n + " + " + m + " = " + sum);

        }
        public int inputN(string caption = "Enter n")
        {
            Console.WriteLine(caption);
            return Int32.Parse(Console.ReadLine());
        }
        public int sumOf1(int a, int b)
        {
            return a + b;
        }
        public void sumOf2(int a, int b, out int sum)
        {
            sum = a + b;
        }
    }
}
