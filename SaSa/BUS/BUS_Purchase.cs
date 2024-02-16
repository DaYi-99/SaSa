using SaSa.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaSa.BUS
{
    public class BUS_Purchase
    {
        DAL_Purchase cus = new DAL_Purchase();

        //--- 1. Gọi SP (không có tham số) từ DAL 
        public SqlDataReader getDataStoredProcedure(string sql)
        {
            return cus.getDataStoredProcedure(sql);
        }
    }
}
