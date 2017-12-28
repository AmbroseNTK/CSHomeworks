using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Review142
{
    class Book
    {
        private int code;
        private string title;
        private string author;
        private string publisher;
        private int numOfPage;
        private double price;

        public Book()
        {
        }

        public Book(int code, string title, string author, string publisher, int numOfPage, double price)
        {
            this.code = code;
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.numOfPage = numOfPage;
            this.price = price;
        }

        public int Code { get => code; set => code = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public int NumOfPage { get => numOfPage; set => numOfPage = value < 0 ? 0 : value; }
        public double Price { get => price; set => price = value < 0 ? 0 : value; }
        public static void OutputHeader()
        {
            Console.WriteLine("Code - Title - Author - Publisher - Num Of Page - Price");
        }
        public void OutputDetail()
        {
            Console.WriteLine("Code: {0}\nTitle: {1}\nAuthor: {2}\nPublisher: {3}\nNum of page: {4}\nPrice: {5}", title, author, publisher, numOfPage, price);
        }
    }
   
}
