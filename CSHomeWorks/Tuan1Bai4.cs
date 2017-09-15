using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan1.Bai4
{
    class Work : HomeWork
    {
        public void RunHomeWork()
        {
            Student student = new Student();
            Console.WriteLine("Enter student's name:");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter student's score #1:");
            student.Score1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter student's score #2:");
            student.Score2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter student's score #3:");
            student.Score3 = Double.Parse(Console.ReadLine());
            Console.WriteLine(student.Name);
            Console.WriteLine("Average score: " + student.getAverage());

        }
    }
    class Student
    {
        private string name;
        private double score1;
        private double score2;
        private double score3;

        public string Name { get => name; set => name = value; }
        public double Score1 { get => score1; set => score1 = value; }
        public double Score2 { get => score2; set => score2 = value; }
        public double Score3 { get => score3; set => score3 = value; }
        public double getAverage()
        {
            return Math.Round((Score1 + Score2 + Score3) / 3f, 2);
        }
    }
}
