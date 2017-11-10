using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan6
{
    class Sanpham
    {
        private string ten;
        private float gia;
        private int soLuong;
        private float thanhTien;
        private static double tongTien=0;
        public Sanpham(string ten, float gia, int soLuong)
        {
            this.ten = ten;
            this.gia = gia;
            this.soLuong = soLuong;
        }

        public string Ten { get => ten; set => ten = value; }
        public float Gia { get => gia; set => gia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double ThanhTien
        {
            get {
                tongTien -= thanhTien;
                thanhTien = Gia * SoLuong;
                tongTien += thanhTien;
                return thanhTien;
            }

        }
        public double TongTien {
            get {
                tongTien += ThanhTien;
                return tongTien;
            }
        }

       

        public void XuatThongTin()
        {
            Console.WriteLine("Ten: "+Ten);
            Console.WriteLine("Gia: "+Gia);
            Console.WriteLine("So luong: "+SoLuong);
            Console.WriteLine("Thanh tien: "+ThanhTien);
            
        }
        public static void XuatTongTien()
        {
            Console.WriteLine("Tong tien: " + tongTien);
        }

    }
}
