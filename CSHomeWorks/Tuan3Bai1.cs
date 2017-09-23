using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSHomeWorks.Tuan3Bai1;

namespace CSHomeWorks.Tuan3.Bai1
{
    class Work : HomeWork
    {
        public void RunHomeWork()
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Student #" + i);
                Student student = new Student();
                student.input();
                students.Add(student);

            }
            foreach(Student student in students)
            {
                Console.WriteLine("Student #" + students.IndexOf(student));
                student.output();
            }
        }
    }
}
