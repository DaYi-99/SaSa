using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaSa.DTO
{
    public class DTO_Product
    {
        string _MASP;
        string _TENSP;
        string _DVT;
        double _DONGIA;
        int _SLTON;
        int _MAMH;
        DateTime _NGAYCN;

        public string MASP { get => _MASP; set => _MASP = value; }
        public string TENSP { get => _TENSP; set => _TENSP = value; }
        public string DVT { get => _DVT; set => _DVT = value; }
        public double DONGIA { get => _DONGIA; set => _DONGIA = value; }
        public int SLTON { get => _SLTON; set => _SLTON = value; }
        public int MAMH { get => _MAMH; set => _MAMH = value; }
        public DateTime NGAYCN { get => _NGAYCN; set => _NGAYCN = value; }
    }
}
