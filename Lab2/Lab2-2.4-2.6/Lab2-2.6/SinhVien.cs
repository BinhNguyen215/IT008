using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2._6
{
    public class SinhVien
    {
        public string MaSinhVien { get; set; }
        public string TenSinhVien { get; set; }
        public string Lop { get; set; }
        public SinhVien(string maSinhVien, string tenSinhVien, string lop)
        {
            MaSinhVien = maSinhVien;
            TenSinhVien = tenSinhVien;
            Lop = lop;
        }
    }

}
