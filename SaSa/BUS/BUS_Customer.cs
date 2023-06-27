using SaSa.DAL;
using SaSa.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaSa.BUS
{
    public class BUS_Customer
    {
        //----- Khai báo biến thuộc lớp DAL_CDBCustomer của tầng DAL
        DAL_Customer cus = new DAL_Customer();

        //--- 1. Gọi SP (không có tham số) từ DAL 
        public SqlDataReader getDataStoredProcedure(string sql)
        {
            return cus.getDataStoredProcedure(sql);
        }

        //--- 2. Viết hàm gọi Stored Procedure thêm khách hàng mới
        public void pr_THEMKH(DTO_Customer c)
        {
            cus.pr_THEMKH(c);
        }

        //--- 3. Viết hàm gọi Stored Procedure xoá khách hàng
        public void pr_XOAKH(DTO_Customer xkh)
        {
            cus.pr_XOAKH(xkh);
        }

        //--- 4. Viết hàm gọi Stored Procedure sửa thông tin khách hàng
        public void pr_SUAKH(DTO_Customer skh)
        {
            cus.pr_SUAKH(skh);
        }


        //--- 5. Viết hàm gọi Stored Procedure tìm khách hàng
        public SqlDataReader getDataStoredProcedure(string sql, DTO_Customer ct)
        {
            return cus.getDataStoredProcedure(sql, ct);

        }

        
    }
}
