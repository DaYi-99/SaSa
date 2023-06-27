using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaSa.DTO
{
    public class DTO_Staff
    {
        string _MANV;
        string _TENNV;
        string _SDT;
        DateTime _NGAYSINH;
        string _CCCD;
        string _EMAIL;
        string _UN;
        string _PW;

        public string MANV { get => _MANV; set => _MANV = value; }
        public string TENNV { get => _TENNV; set => _TENNV = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public DateTime NGAYSINH { get => _NGAYSINH; set => _NGAYSINH = value; }
        public string CCCD { get => _CCCD; set => _CCCD = value; }
        public string EMAIL { get => _EMAIL; set => _EMAIL = value; }
        public string UN { get => _UN; set => _UN = value; }
        public string PW { get => _PW; set => _PW = value; }

        //-- 1. Kiểm tra đăng nhập --
        public DTO_Staff(string un, string pw)
        {
            this.UN = un;
            this.PW = pw;
        }

        //-- 2. Viết hàm thêm mới nhân viên -- sửa 
        public DTO_Staff(string manv, string tennv, string sdt, string cccd, DateTime ngaysinh, 
            string email, string un, string pw)
        {
            this.MANV = manv;
            this.TENNV = tennv;
            this.SDT = sdt;
            this.CCCD = cccd;
            this.NGAYSINH = ngaysinh;
            this.EMAIL = email;
            this.UN = un;
            this.PW = pw;
        }

        //-- 3. Viết hàm Xoá nhân viên --
        public DTO_Staff(string manv)
        {
            this.MANV = manv;
        }

        //-- 4. Viết hàm Tìm kiếm nhân viên --
        public DTO_Staff(string tennv, string sdt, string cccd)
        {
            this.TENNV = tennv;
            this.SDT = sdt;
            this.CCCD = cccd;
        }
    }
}
