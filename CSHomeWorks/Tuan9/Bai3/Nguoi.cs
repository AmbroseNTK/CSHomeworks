using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan9.Bai3
{
    public enum GioiTinh
    {
        Nam,
        Nu,
        KhongXacDinh
    }
    class Nguoi
    {
        private string hoTen;
        private DateTime ngaySinh;
        private GioiTinh gioiTinh;

        public Nguoi()
        {
            hoTen = "";
            ngaySinh = new DateTime();
            gioiTinh = GioiTinh.KhongXacDinh;
        }
        public Nguoi(string hoTen, DateTime ngaySinh, GioiTinh gioiTinh)
        {
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
        }

        protected string HoTen { get => hoTen; set => hoTen = value; }
        protected DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        protected GioiTinh GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public void Input()
        {
            Console.WriteLine("Name: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("DOB: ");
            ngaySinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Gioi Tinh");
            gioiTinh = (GioiTinh)(GioiTinh.Parse(typeof(GioiTinh), Console.ReadLine()));
        }
    }
}
