using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan9.Bai3
{
    class Tuan9Bai3 : HomeWork
    {
        public void RunHomeWork()
        {
            HocSinh hocSinh = new HocSinh();
            SinhVien sinhVien = new SinhVien();
            GiaoVien giaoVien = new GiaoVien();
            GiangVien giangVien = new GiangVien();

            hocSinh.Input();
            sinhVien.Input();
            giaoVien.Input();
            giangVien.Input();

            hocSinh.ThongBaoKetQuaKhenThuong();
            sinhVien.ThongBaoKetQuaKhenThuong();
            giaoVien.ThongBaoKetQuaKhenThuong();
            giangVien.ThongBaoKetQuaKhenThuong();

         
        }
    }
}
