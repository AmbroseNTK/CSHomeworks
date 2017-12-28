using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Review14
{
    class ProductList : List<Product>
    {
        public ProductList()
        {
        }
        public void Add()
        {
            Product product = new Product();
            Console.WriteLine("Enter code =");
            product.Code = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name =");
            product.Name = Console.ReadLine();
            Console.WriteLine("Enter price =");
            product.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter weight =");
            product.Weight = int.Parse(Console.ReadLine());
            this.Add(product);
        }
        public new void Add(Product obj)
        {
            base.Add(obj);
        }
        public void Display()
        {
            foreach(Product product in this)
            {
                Console.WriteLine(product.ToString());
            }
        }
        public void Display(int minWeigth, int maxWeight)
        {
            var result = this.Where((product) => (product.Weight > minWeigth && product.Weight < maxWeight));
            foreach (Product product in result)
            {
                Console.WriteLine(product.ToString());
            }
        }
        public static int CompareToPrice(Product obj1, Product obj2) => (obj1.Weight==obj2.Weight?0:(obj1.Weight>obj2.Weight?1:-1));
        public Product GetMaxWeightProduct()
        {
            var max = this.Where((pro) => (pro.Weight == this.Max((product) => (product.Weight))));
            return max.ToList()[0];
        }
    }
}
