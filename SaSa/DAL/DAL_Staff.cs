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
    public class DAL_Staff
    {
        //-- 1. Kiểm tra đăng nhập
        public SqlDataReader getDataStoredProcedure(string sql, DTO.DTO_Staff cus)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, DAL.DAL_Connect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@UN", System.Data.SqlDbType.Char, 30).Value = cus.UN.ToString();
                cmd.Parameters.Add("@PW", System.Data.SqlDbType.Char, 30).Value = cus.PW.ToString();

                object kq = cmd.ExecuteScalar();
                int code = Convert.ToInt32(kq);
                if (code == 1)
                {
                    //MessageBox.Show("Đăng nhập tài khoản "+ cus.UN.ToString() + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (code == 2)
                {
                    DialogResult dlr = MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dlr == DialogResult.OK)
                    {
                        Application.Restart();
                        //Application.Exit();
                    }
                }
                else
                {
                    DialogResult dlr = MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dlr == DialogResult.OK)
                    {
                        Application.Restart();
                        //Application.Exit();
                    }
                }


                SqlDataReader dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Thông báo!", MessageBoxButtons.OK);
                return null;
            }
        }

        //--- 2. Viết hàm gọi Stored Procedure không có tham số và trả ra SqlDataReader
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


        //--- 3. Viết hàm gọi Store Procedure thêm nhân viên mới
        public void pr_THEMNV(DTO.DTO_Staff cus)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_THEMNV", DAL_Connect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@MANV", System.Data.SqlDbType.Char, 10).Value = cus.MANV.ToString();
                cmd.Parameters.Add("@TENNV", System.Data.SqlDbType.NVarChar, 200).Value = cus.TENNV.ToString();
                cmd.Parameters.Add("@SDT", System.Data.SqlDbType.Char, 10).Value = cus.SDT.ToString();
                cmd.Parameters.Add("@CCCD", System.Data.SqlDbType.Char, 12).Value = cus.CCCD.ToString();
                cmd.Parameters.Add("@NGAYSINH", System.Data.SqlDbType.Date).Value = cus.NGAYSINH.ToString();
                cmd.Parameters.Add("@EMAIL", System.Data.SqlDbType.VarChar, 50).Value = cus.EMAIL.ToString();
                cmd.Parameters.Add("@UN", System.Data.SqlDbType.Char, 10).Value = cus.UN.ToString();
                cmd.Parameters.Add("@PW", System.Data.SqlDbType.Char, 10).Value = cus.PW.ToString();
                cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo!", MessageBoxButtons.OK);
            }
        }

        //--- 3. Viết hàm gọi Store Procedure xoá nhân viên
        public void pr_XOANV(DTO.DTO_Staff xnv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_XOANV", DAL_Connect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@MANV", SqlDbType.Char, 10).Value = xnv.MANV.ToString();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo!", MessageBoxButtons.OK);
            }
        }

        //--- 4. Viết hàm gọi Stored Procedure tìm kiếm nhân viên
        public SqlDataReader getDataStoredProcedured(string sql, DTO.DTO_Staff tnv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, DAL_Connect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@TENNV", SqlDbType.NVarChar, 200).Value = tnv.TENNV.ToString();
                cmd.Parameters.Add("@SDT", SqlDbType.Char, 10).Value = tnv.SDT.ToString();
                cmd.Parameters.Add("@CCCD", SqlDbType.NChar, 12).Value = tnv.CCCD.ToString();
                SqlDataReader dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Thông báo!", MessageBoxButtons.OK);
                return null;
            }
        }

        public void pr_SUANV(DTO.DTO_Staff cus)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_SUANV", DAL_Connect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@MANV", System.Data.SqlDbType.Char, 10).Value = cus.MANV.ToString();
                cmd.Parameters.Add("@TENNV", System.Data.SqlDbType.NVarChar, 200).Value = cus.TENNV.ToString();
                cmd.Parameters.Add("@SDT", System.Data.SqlDbType.Char, 10).Value = cus.SDT.ToString();
                cmd.Parameters.Add("@CCCD", System.Data.SqlDbType.Char, 12).Value = cus.CCCD.ToString();
                cmd.Parameters.Add("@NGAYSINH", System.Data.SqlDbType.Date).Value = cus.NGAYSINH.ToString();
                cmd.Parameters.Add("@EMAIL", System.Data.SqlDbType.VarChar, 50).Value = cus.EMAIL.ToString();
                cmd.Parameters.Add("@UN", System.Data.SqlDbType.Char, 10).Value = cus.UN.ToString();
                cmd.Parameters.Add("@PW", System.Data.SqlDbType.Char, 10).Value = cus.PW.ToString();
                cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo!", MessageBoxButtons.OK);
            }
        }
    }
}
