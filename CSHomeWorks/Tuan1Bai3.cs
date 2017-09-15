using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan1.Bai3
{
    class Work : HomeWork
    {
        public void RunHomeWork()
        {
            Console.WriteLine("Enter first name #1");
            string firstName1 = Console.ReadLine();
            Console.WriteLine("Enter last name #1");
            string lastName1 = Console.ReadLine();
            Console.WriteLine("Enter first name #2");
            string firstName2 = Console.ReadLine();
            Console.WriteLine("Enter last name #2");
            string lastName2 = Console.ReadLine();
            Console.WriteLine("Than goi "+lastName1+" "+firstName1+"!\n"+
                "Nhan dip sinh nhat cua "+firstName1+", cho phep "+firstName2+" goi den "+firstName1+" nhung loi chuc tot dep nhat ve suc khoe, hanh phuc va thanh cong trong moi linh vuc.\n"+
                "Goi loi tham suc khoe hai bac cua "+firstName1+".\n"+
                "Ban cua "+firstName1+"\n"+
                lastName2+" "+firstName2+"\n"+
                "TB: Ba ma "+firstName2+" thuong nhac den "+firstName1+" luon");
        }
       
    }
   
}
