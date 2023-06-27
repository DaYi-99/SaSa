using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaSa.DTO
{
    public class DTO_ProductType
    {
        string _MAMH;
        string _TENMH;

        public string MAMH { get => _MAMH; set => _MAMH = value; }
        public string TENMH { get => _TENMH; set => _TENMH = value; }
    }
}
