using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan9.Bai3
{
    class GiaoVien : Nguoi
    {
        private double diemFeedback;

        public double DiemFeedback { get => diemFeedback; set => diemFeedback = value; }

        public GiaoVien() : base()
        {
            diemFeedback = 0;
        }
        public GiaoVien(string hoTen, DateTime ngaySinh, GioiTinh gioiTinh, double diemFeedback) : base(hoTen, ngaySinh, gioiTinh)
        {
            this.diemFeedback = diemFeedback;
        }
        public void Input()
        {
            base.Input();
            Console.WriteLine("Diem Feedback: ");
            diemFeedback = double.Parse(Console.ReadLine());
        }
        public bool XetKhenThuong()
        {
            return diemFeedback >= 4.5d;
        }
        public void ThongBaoKetQuaKhenThuong()
        {
            if (XetKhenThuong())
                Console.WriteLine(base.HoTen + " duoc khen thuong");
            else
                Console.WriteLine(base.HoTen + " khong duoc khen thuong");
        }
    }
}
