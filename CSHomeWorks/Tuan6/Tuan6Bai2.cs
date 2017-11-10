using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan6
{
    class Tuan6Bai2 : HomeWork
    {
        public void RunHomeWork()
        {
            Sanpham sanpham1 = new Sanpham("Abc", 10.5f, 2);
            Sanpham sanpham2 = new Sanpham("CBA", 125.25f, 10);
            Sanpham sanpham3 = new Sanpham("BCS", 200.123f, 50);
            sanpham1.XuatThongTin();
            sanpham2.XuatThongTin();
            sanpham3.XuatThongTin();
            Sanpham.XuatTongTien();
        }
    }
}
