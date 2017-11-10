using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan9.Bai3
{
    class HocSinh : Nguoi
    {
        private double dTB;

        public double DTB { get => dTB; set => dTB = value; }

        public HocSinh() : base()
        {
            dTB = 0;
        }
        public HocSinh(string ten, DateTime ngaySinh, GioiTinh gioiTinh,double dTB) : base(ten, ngaySinh, gioiTinh)
        {
            this.dTB = dTB;
        }
        public void Input()
        {
            base.Input();
            Console.WriteLine("Diem TB: ");
            dTB = double.Parse(Console.ReadLine());
        }
        public bool XetKhenThuong()
        {
            return dTB >= 9;
        }
        public void ThongBaoKetQuaKhenThuong()
        {
            if (XetKhenThuong())
            {
                Console.WriteLine(base.HoTen + " duoc khen thuong");
            }
            else
            {
                Console.WriteLine(base.HoTen + " khong duoc khen thuong");
            }
        }

    }
}
