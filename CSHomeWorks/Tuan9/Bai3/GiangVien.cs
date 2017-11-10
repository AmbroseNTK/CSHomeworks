using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan9.Bai3
{
    class GiangVien:GiaoVien
    {
        private int lVTN;

        public int LVTN { get => lVTN; set => lVTN = value; }

        public GiangVien() : base()
        {
            lVTN = 0;
        }
        public GiangVien(string hoTen, DateTime ngaySinh, GioiTinh gioiTinh, double diemFeedback, int lVTN) : base(hoTen, ngaySinh, gioiTinh, diemFeedback)
        {
            this.lVTN = lVTN;
        }
        public void Input()
        {
            base.Input();
            Console.WriteLine("So luong sinh vien huong dan luan van: ");
            lVTN = int.Parse(Console.ReadLine());
        }
        public bool XetKhenThuong()
        {
            return lVTN >= 10 && base.XetKhenThuong();
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
