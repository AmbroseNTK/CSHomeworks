using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Review14
{
    class Review14 : HomeWork
    {
        public void RunHomeWork()
        {
            ProductList productList = new ProductList();
            Console.WriteLine("Quantity? ");
            int quan = 0;
            int.TryParse(Console.ReadLine(), out quan);
            for(int i = 0; i < quan; i++)
            {
                productList.Add();
            }
            productList.Display();
            int minWeight = 0;
            int maxWeight = 0;
            Console.WriteLine("Min weight: ");
            int.TryParse(Console.ReadLine(), out minWeight);
            Console.WriteLine("Max weight: ");
            int.TryParse(Console.ReadLine(), out maxWeight);
            productList.Display(minWeight, maxWeight);
           
        }
    }
}
