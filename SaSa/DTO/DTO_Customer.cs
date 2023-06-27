using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaSa.DTO
{
    public class DTO_Customer
    {
        string _MAKH;
        string _TENKH;
        string _SDT;
        string _DC;

        public string MAKH { get => _MAKH; set => _MAKH = value; }
        public string TENKH { get => _TENKH; set => _TENKH = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string DC { get => _DC; set => _DC = value; }

        //-- 2. Viết hàm Thêm mới khách hàng
        public DTO_Customer(string makh, string tenkh, string sdt, string diachi)
        {
            this.MAKH = makh;
            this.TENKH = tenkh;
            this.SDT = sdt;
            this.DC = diachi;
        }

        //-- 3. Viết hàm Xoá khách hàng
        public DTO_Customer(string makh)
        {
            this.MAKH = makh;
        }

        //-- 4. Viết hàm Sửa khách hàng
        public DTO_Customer(string tenkh, string sdt, string diachi)
        {
            this.TENKH = tenkh;
            this.SDT = sdt;
            this.DC = diachi;
        }

        //-- 5. Viết hàm Tìm kiếm khách hàng
        public DTO_Customer(string makh, string tenkh)
        {
            this.MAKH = makh;
            this.TENKH = tenkh;
        }
    }
}
