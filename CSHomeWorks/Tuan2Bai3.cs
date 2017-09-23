using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan2.Bai3
{
    class Work : HomeWork
    {
        public void RunHomeWork()
        {
            string name = getName();
            double[] scores = new double[3];
            int i = 0;
            do
            {
                scores[i] = getScore("Enter score #" + (i + 1));
                if (scores[i] >= 0 && scores[i] <= 10)
                    i++;
            }
            while (i < 3);
            exportDetails(name, scores);
            
        }
        public string getName()
        {
            Console.WriteLine("Enter your name: ");
            return Console.ReadLine();
        }
        public double getScore(string caption)
        {
            Console.WriteLine(caption);
            return Double.Parse(Console.ReadLine());
        }
        public double calcAverage(double[] scores)
        {
            double avg = 0;
            foreach(double score in scores)
                avg += score;
            return avg / scores.Length;

        }
        public string getRank(double averageScore)
        {
            if (averageScore < 3d)
                return "Y";
            else if (averageScore < 5d)
                return "TB";
            else if (averageScore < 8d)
                return "K";
            else
                return "G";
        }
        public void exportDetails(string name, double[] scores)
        {
            double avg = calcAverage(scores);
            Console.WriteLine("Name: " + name + "\n" +
                               "Average score: " + avg + "\n" +
                               "Rank: " + getRank(avg));
        }

    }
}
