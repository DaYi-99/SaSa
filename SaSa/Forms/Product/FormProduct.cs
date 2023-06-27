using SaSa.BUS;
using SaSa.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaSa.Forms.Product
{
    public partial class FormProduct : Form
    {
        BUS_Product bus = new BUS_Product();

        //------ Khai báo biến thuộc lớp DataTable ----------
        DataTable myTable = new DataTable();
        DataRow myRow = null;

        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            // Đổ dữ liệu từ database vào Datagridview cho form Sản phẩm
            SqlCommand cmd = new SqlCommand("select * from SANPHAM", DAL_Connect.myconn);
            SqlDataReader rd = cmd.ExecuteReader();
            //myTable.Clear();
            myTable = this.dtsProduct.Tables[0]; //dataset
            int STT = 1;
            while (rd.Read() == true)
            {
                myRow = myTable.NewRow();
                myRow[0] = STT;
                myRow[1] = rd.GetInt32(0).ToString(); //masp
                myRow[2] = rd.GetString(1).ToString(); //tensp
                myRow[3] = rd.GetString(2).ToString(); //dvt
                myRow[4] = rd.GetDecimal(3).ToString();  //dongia
                myRow[5] = rd.GetInt32(4).ToString();  //slton
                myRow[6] = rd.GetInt32(5).ToString(); //mamh
                myRow[7] = rd.GetDateTime(6).ToString(); //ngaycn
                myTable.Rows.Add(myRow);
                STT += 1;
            }
            this.drvProduct.DataSource = myTable;
            rd.Close();

            showcbo();
        }

        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void showcbo()
        {
            var cmd = new SqlCommand("select * from MATHANG", DAL_Connect.myconn);
            var rd = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(rd);
            rd.Dispose();
            cboMH.DisplayMember = "TENMH";
            cboMH.DataSource = dt;
        }
    }
}
