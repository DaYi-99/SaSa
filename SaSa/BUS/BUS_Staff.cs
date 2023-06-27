using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaSa.BUS
{
    public class BUS_Staff
    {
        DAL.DAL_Staff cus = new DAL.DAL_Staff();

        //--- 1. Viết hàm gọi Stored Procedure kiểm tra đăng nhập
        public SqlDataReader getDataStoredProcedure(string sql, DTO.DTO_Staff ktl)
        {
            return cus.getDataStoredProcedure(sql, ktl);
        }

        //--- 2. Gọi SP (không có tham số) từ DAL 
        public SqlDataReader getDataStoredProcedure(string sql)
        {
            return cus.getDataStoredProcedure(sql);
        }

        //--- 3. Viết hàm gọi Stored Procedure thêm nhân viên
        public void pr_THEMNV(DTO.DTO_Staff c)
        {
            cus.pr_THEMNV(c);
        }

        //--- 4. Viết hàm gọi Stored Procedure xoá nhân viên
        public void pr_XOANV(DTO.DTO_Staff xnv)
        {
            cus.pr_XOANV(xnv);
        }

        //--- 5. Viết hàm gọi Stored Procedure tìm nhân viên
        public SqlDataReader getDataStoredProcedured(string sql, DTO.DTO_Staff ct)
        {
            return cus.getDataStoredProcedured(sql, ct);

        }

        //--- 6. Viết hàm gọi Stored Procedure sửa thông tin nhân viên
        public void pr_SUANV(DTO.DTO_Staff snv)
        {
            cus.pr_SUANV(snv);
        }

    }
}
