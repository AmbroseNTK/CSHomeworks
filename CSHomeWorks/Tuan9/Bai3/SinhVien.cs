using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan9.Bai3
{
    class SinhVien : Nguoi
    {
        private bool nckh;

        public bool Nckh { get => nckh; set => nckh = value; }

        public SinhVien() : base()
        {
            nckh = false;
        }
        public SinhVien(string hoTen, DateTime ngaySinh, GioiTinh gioiTinh,bool nckh) : base(hoTen, ngaySinh, gioiTinh)
        {
            this.nckh = nckh;
        }
        public bool XetKhenThuong()
        {
           
        }
    }
}
