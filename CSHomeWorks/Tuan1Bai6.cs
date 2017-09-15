using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan1.Bai6
{
    class Work : HomeWork
    {
        public void RunHomeWork()
        {
            Console.WriteLine("Triangle's edge a: ");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Triangle's edge b: ");
            double b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Triangle's edge c: ");
            double c = Double.Parse(Console.ReadLine());
            if ((a == b) && (b == c))
                Console.WriteLine("Tam giac deu");
            else if ((a == b) && (c * c == a * a + b * b))
                Console.WriteLine("Vuong can tai C");
            else if ((a == c) && (b * b == a * a + c * c))
                Console.WriteLine("Vuong can tai B");
            else if ((c == b) && (a * a == c * c + b * b))
                Console.WriteLine("Vuong can tai A");
            else if (c * c == a * a + b * b)
                Console.WriteLine("Vuong tai C");
            else if (b * b == a * a + c * c)
                Console.WriteLine("Vuong tai B");
            else if (a * a == c * c + b * b)
                Console.WriteLine("Vuong tai A");
            else if (a == b)
                Console.WriteLine("Can tai C");
            else if (a == c)
                Console.WriteLine("Can tai B");
            else if (c == b)
                Console.WriteLine("Can tai A");
            else
                Console.WriteLine("Tam giac thuong");

        }
    }
}
