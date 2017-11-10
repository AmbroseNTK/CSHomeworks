using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan6
{
   
    class SinhVien
    {
        private string hoTen;
        private static string lop;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string Lop { get => lop; set => lop = value; }

        public SinhVien(string hoTen, string lop)
        {
            this.hoTen = hoTen;
            SinhVien.lop = lop;
        }
    }
}
