using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan3Bai1
{
    class Student
    {
        private string studentID;
        private string studentName;
        private double[] scores;

        public string StudentID { get => studentID; set => studentID = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public double[] Scores { get => scores; set => scores = value;  }

        public Student() { }
        public Student(string id, string name, double[] scores)
        {
            StudentID = id;
            StudentName = name;
            Scores = scores;
        }
        public void input()
        {
            Console.WriteLine("ID");
            StudentID = Console.ReadLine();
            Console.WriteLine("Name");
            StudentName = Console.ReadLine();
            Scores = new double[3];
            for(int i = 0; i < Scores.Length; i++)
            {
                Console.WriteLine("Score #"+i);
                Scores[i] = Double.Parse(Console.ReadLine());
            }

        }
        public double calcAverage()
        {
            double avg = 0;
            for (int i = 0; i < Scores.Length; i++)
                avg += Scores[i];
            return avg / Scores.Length;
        }
        public string rank(double avg)
        {
            if (avg < 3)
                return "Y";
            else if (avg < 5)
                return "TB";
            else if (avg < 8)
                return "K";
            else
                return "G";
        }
        public void output()
        {
            double avg = calcAverage();
            Console.WriteLine("Toi ten la: " + StudentName + "\nMSSV: " + StudentID + "\nDTB: " + avg + "\nXep hang: " + rank(avg));
        }
    }
}
