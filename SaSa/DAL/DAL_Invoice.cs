using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaSa.DAL
{
    public class DAL_Invoice
    {
        //--- 1. Viết hàm gọi Stored Procedure không có tham số và trả ra SqlDataReader
        public SqlDataReader getDataStoredProcedure(string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, DAL_Connect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                return dr;

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Thông báo!", MessageBoxButtons.OK);
                return null;
            }
        }

        //--- 1. Viết hàm thêm hoá đơn bán
        public void HDB_THEM(DTO.DTO_Invoice cus)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("HDB_THEM", DAL_Connect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@MAHDB", System.Data.SqlDbType.Char, 10).Value = cus.MAHDB.ToString();
                cmd.Parameters.Add("@MANV", System.Data.SqlDbType.Char, 10).Value = cus.MANV.ToString();
                cmd.Parameters.Add("@NGAY_HDB", System.Data.SqlDbType.DateTime).Value = cus.NGAY_HDB.ToString();
                cmd.Parameters.Add("@MAKH", System.Data.SqlDbType.Char, 10).Value = cus.MAKH.ToString();
                cmd.Parameters.Add("@TONGTIEN", System.Data.SqlDbType.Decimal).Value = cus.TONGTIEN.ToString();
                cmd.Parameters.Add("@DATHU", System.Data.SqlDbType.Decimal).Value = cus.DATHU.ToString();
                cmd.Parameters.Add("@CHUATHU", System.Data.SqlDbType.Decimal).Value = cus.CHUATHU.ToString();
                cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo!", MessageBoxButtons.OK);
            }
        }
    }
}
