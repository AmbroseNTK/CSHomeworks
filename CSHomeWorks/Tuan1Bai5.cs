using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan1.Bai5
{
    class Work : HomeWork
    {
        public void RunHomeWork()
        {
            Console.WriteLine("Tuan 1 Homework");
            Console.WriteLine("Enter custom's name: ");
            Custom custom = new Custom(Console.ReadLine());
            custom.UnitPrice = 2035;
            Console.WriteLine("Enter product's quality: ");
            custom.Quality = Int32.Parse(Console.ReadLine());
            custom.getReceipt();
        }
    }
    class Custom
    {
        private string customName;
        private int quality;
        private int unitPrice;
        public string CustomName { get => customName; set => customName = value; }
        public int Quality { get => quality; set => quality = value; }
        public int UnitPrice { get => unitPrice; set => unitPrice = value; }
        public Custom(string customName)
        {
            CustomName = customName;
        }
        public int getGift()
        {
            return Quality / 5;
        }
        public int getSale()
        {
            return Quality % 5;
        }
        public float getTotal()
        {
            return UnitPrice * Quality - getSale() * Quality * 0.02f;
        }
        public void getReceipt()
        {
            Console.WriteLine("Name: "+CustomName);
            Console.WriteLine("Quality: " + Quality);
            Console.WriteLine("Gift(s): " + getGift());
            Console.WriteLine("Sale product(s): " + getSale());
            Console.WriteLine("Total: " + getTotal());
        }
    }
}
