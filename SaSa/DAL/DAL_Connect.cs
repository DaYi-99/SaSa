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
    public class DAL_Connect
    {
        //--- 1. Khai báo biến thuộc lớp SqlConnection
        public static SqlConnection myconn = null;

        ////--- 2. Viết hàm kết nối CSDL
        public bool DBKetNoi(DTO.DTO_Connect lg)
        {
            try
            {
                myconn = new SqlConnection("Data Source=" + lg.Servername +
                                            "; Initial Catalog=" + lg.Database +
                                            "; User ID=" + lg.UserID +
                                            "; Password=" + lg.Password);
                myconn.Open(); //-- Mở kết nối CSDL
                return true;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Thông báo", MessageBoxButtons.OK);
                return false;
            }
        }

        //internal bool DBKetNoi(DAL_Connect lg)
        //{
        //    throw new NotImplementedException();
        //}

        //--- 3. Viết hàm huỷ hết nối CSDL
        //public bool DisDBConnect()
        //{
        //    try
        //    {
        //        if (myconn.State == System.Data.ConnectionState.Open)
        //            myconn.Close(); //-- Đóng kết nối CSDL
        //        return true;
        //    }
        //    catch (Exception x)
        //    {
        //        MessageBox.Show(x.ToString(), "Thông báo", MessageBoxButtons.OK);
        //        return false;
        //    }
        //}

        //---- 4. Viết hàm đưa dữ liệu DataTable và trả về DataTable
        public DataTable getDataTable(DataTable dt, string sql)
        {
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter(sql, DAL_Connect.myconn);
                sqlDA.Fill(dt);
                return dt;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Thông báo!", MessageBoxButtons.OK);
                return null;
            }
        }
    }
}
