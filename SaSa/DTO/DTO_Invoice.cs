using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaSa.DTO
{
    public class DTO_Invoice
    {
        string _MAHDB;
        string _MANV;
        DateTime _NGAY_HDB;
        string _MAKH;
        decimal _TONGTIEN;
        decimal _DATHU;
        decimal _CHUATHU;

        public string MAHDB { get => _MAHDB; set => _MAHDB = value; }
        public string MANV { get => _MANV; set => _MANV = value; }
        public DateTime NGAY_HDB { get => _NGAY_HDB; set => _NGAY_HDB = value; }
        public string MAKH { get => _MAKH; set => _MAKH = value; }
        public decimal TONGTIEN { get => _TONGTIEN; set => _TONGTIEN = value; }
        public decimal DATHU { get => _DATHU; set => _DATHU = value; }
        public decimal CHUATHU { get => _CHUATHU; set => _CHUATHU = value; }

        public DTO_Invoice(string mahdb, string manv, DateTime ngayhdb, string makh, decimal tongtien, decimal dathu, decimal chuathu)
        {
            this.MAHDB = mahdb;
            this.MANV = manv;
            this.NGAY_HDB = ngayhdb;
            this.MAKH = makh;
            this.TONGTIEN = tongtien;
            this.DATHU = dathu;
            this.CHUATHU = chuathu;
        }
    }
}
