using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaSa.BUS
{
    public class BUS_Invoice
    {
        DAL.DAL_Invoice cus = new DAL.DAL_Invoice();


        //--- 1. Gọi SP (không có tham số) từ DAL 
        public SqlDataReader getDataStoredProcedure(string sql)
        {
            return cus.getDataStoredProcedure(sql);
        }

        public void HDB_THEM(DTO.DTO_Invoice thdb)
        {
            cus.HDB_THEM(thdb);
        }
    }
}
