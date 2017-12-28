using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Review14
{
    class Product
    {
        protected int code;
        protected string name;
        protected int price;
        protected int weight;

        public Product()
        {
            code = 0;
            name = String.Empty;
            price = 0;
            weight = 0;
        }

        public Product(int code, string name, int price, int weight)
        {
            this.code = code;
            this.name = name;
            this.price = price;
            this.weight = weight;
        }

        public int Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Weight { get => weight; set => weight = value; }
        public override string ToString()
        {
            return code + "-" + name + "-" + price + "-" + weight;
        }
    }
}
