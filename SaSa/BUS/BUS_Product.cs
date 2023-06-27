using SaSa.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaSa.BUS
{
    public class BUS_Product
    {
        //----- 1. Khai báo biến thuộc lớp DAL_SanPham của tầng DAL
        DAL_Product cus = new DAL_Product();

        //----- 2. Gọi SP (không có tham số) từ DAL 
        public SqlDataReader getDataStoredProcedure(string sql)
        {
            return cus.getDataStoredProcedure(sql);
        }
    }
}
