using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan1.Bai2
{
    class Work : HomeWork
    {
        public void RunHomeWork()
        {
            People people = new People();
            Console.WriteLine("Enter name: ");
            people.Name = Console.ReadLine();
            Console.WriteLine("Enter year of birth: ");
            people.YearOfBirth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Age: " + people.getAge());
            Console.WriteLine("Age from 2010: " + people.getAgeFrom2010());
        }
    }
    class People
    {
        private string name;
        private int yearOfBirth;

        public string Name { get => name; set => name = value; }
        public int YearOfBirth { get => yearOfBirth; set => yearOfBirth = value; }

        public int getAge()
        {
            return DateTime.Now.Year - YearOfBirth;
        }
        public int getAgeFrom2010()
        {
            return 2010 - YearOfBirth;
        }
    }
}
