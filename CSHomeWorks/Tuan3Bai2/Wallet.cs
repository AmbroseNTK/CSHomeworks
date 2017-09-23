using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan3Bai2
{
    class Wallet
    {
        private string name;
        private string address;
        private DateTime openDate;

        private string phoneNumber;
        private string accountID;
        private double amount;
        private DateTime term;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public DateTime OpenDate { get => openDate; set => openDate = value; }

        public Wallet() { }
        public Wallet(string name, string address, DateTime openDate)
        {
            this.Name = name;
            this.Address = address;
            this.OpenDate = openDate;
        }
        public void setPrivateInformation()
        {
            Console.WriteLine("Phone's number: ");
            phoneNumber = Console.ReadLine();
            Console.WriteLine("Account ID:");
            accountID = Console.ReadLine();
            Console.WriteLine("Amount:");
            amount = Double.Parse(Console.ReadLine());
            Console.WriteLine("Term: ");
            term = DateTime.Parse(Console.ReadLine());
        }
        public void viewAll()
        {
            Console.WriteLine("Account's name: "+Name);
            Console.WriteLine("Account's address: " + Name);
            Console.WriteLine("Account's open date: " + OpenDate.ToLongDateString());
            Console.WriteLine("Phone's number: "+phoneNumber);
            Console.WriteLine("Account ID: "+accountID);
            Console.WriteLine("Amount: "+amount);
            Console.WriteLine("Term: "+term.ToLongDateString());
        }
    }
}
