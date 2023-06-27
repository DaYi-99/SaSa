using SaSa.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaSa.DAL
{
    public class DAL_Customer
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

        //--- 2. Viết hàm gọi Store Procedure thêm khách hàng mới
        public void pr_THEMKH(DTO_Customer cus)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("KH_THEMKH", DAL_Connect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@MAKH", System.Data.SqlDbType.Char, 10).Value = cus.MAKH.ToString();
                cmd.Parameters.Add("@TENKH", System.Data.SqlDbType.NVarChar, 200).Value = cus.TENKH.ToString();
                cmd.Parameters.Add("@SDT", System.Data.SqlDbType.Char, 10).Value = cus.SDT.ToString();
                cmd.Parameters.Add("@DC", System.Data.SqlDbType.NVarChar, 500).Value = cus.DC.ToString();
                cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo!", MessageBoxButtons.OK);
            }
        }

      
        public void pr_XOAKH(DTO_Customer xkh)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("KH_XOAKH", DAL_Connect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@MAKH", SqlDbType.Char, 10).Value = xkh.MAKH.ToString();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo!", MessageBoxButtons.OK);
            }
        }


        //--- 3. Viết hàm gọi Store Procedure sửa thông tin khách hàng
        public void pr_SUAKH(DTO_Customer cus)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("KH_SUAKH", DAL_Connect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@TENKH", System.Data.SqlDbType.NVarChar, 200).Value = cus.TENKH.ToString();
                cmd.Parameters.Add("@SDT", System.Data.SqlDbType.Char, 10).Value = cus.SDT.ToString();
                cmd.Parameters.Add("@DC", System.Data.SqlDbType.NVarChar, 500).Value = cus.DC.ToString();
                cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo!", MessageBoxButtons.OK);
            }
        }


        //--- 4. Viết hàm gọi Stored Procedure tìm kiếm khách hàng
        public SqlDataReader getDataStoredProcedure(string sql, DTO_Customer tkh)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, DAL_Connect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@MAKH", System.Data.SqlDbType.Char, 10).Value = tkh.MAKH.ToString();
                cmd.Parameters.Add("@TENKH", System.Data.SqlDbType.NVarChar, 200).Value = tkh.TENKH.ToString();
                SqlDataReader dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Thông báo!", MessageBoxButtons.OK);
                return null;
            }
        }
    }
}
