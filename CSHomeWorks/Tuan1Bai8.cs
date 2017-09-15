using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan1.Bai8
{
    class Work : HomeWork
    {
        public void RunHomeWork()
        {
            int day, month, year;
            Console.WriteLine("Enter day:");
            day = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter month:");
            month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter year:");
            year = Int32.Parse(Console.ReadLine());
            if (month < 3)
            {
                month += 12;
                year--;
            }
            switch (Math.Abs(day + 2 * month + 3 * (month + 1) / 5 + year + year / 4) % 7)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("Sunday");
                    break;
                case 4:
                    Console.WriteLine("Sunday");
                    break;
                case 5:
                    Console.WriteLine("Sunday");
                    break;
                case 6:
                    Console.WriteLine("Sunday");
                    break;
            }
        }
    }
}
