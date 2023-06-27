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

namespace SaSa.Forms.Customer
{
    public partial class FormC_Details : Form
    {
        //------ Khai báo biến thuộc lớp DataTable ----------
        DataTable myTable = new DataTable();
        DataRow myRow = null;

        public FormC_Details(string txt)
        {
            InitializeComponent();
            txtmakh.Text = txt;
        }

        private void FormC_Details_Load(object sender, EventArgs e)
        {
            if(txtmakh.Text=="NGHIA")
            {
                // Đổ dữ liệu từ database vào Datagridview cho form Khách hàng
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM HDB where TENKH = 'NGHIA'", DAL_Connect.myconn);
                //SqlCommand cmd = new SqlCommand("select * from KHACHHANG", DAL_Connect.myconn);
                SqlDataReader rd = cmd.ExecuteReader();
                //myTable.Clear();
                myTable = this.dtsC_Details.Tables[0]; //dataset
                int STT = 1;
                while (rd.Read() == true)
                {
                    myRow = myTable.NewRow();
                    myRow[0] = STT;
                    myRow[1] = rd.GetInt32(0).ToString(); //mahd
                    myRow[2] = rd.GetString(1).ToString(); //tennv
                    myRow[3] = rd.GetString(2).ToString(); //tenkh
                    myRow[4] = rd.GetString(4).ToString();  //tensp
                    myRow[5] = rd.GetInt32(5).ToString();  //sl
                    myRow[6] = rd.GetDecimal(7).ToString();  //dongia
                    myRow[7] = rd.GetDecimal(8).ToString();  //thanhtien
                    myRow[8] = rd.GetDateTime(9).ToString();  //ngayban
                    myRow[9] = rd.GetString(10).ToString();  //ttgh
                    myRow[10] = rd.GetDecimal(11).ToString();  //tongtien
                    myRow[11] = rd.GetDecimal(12).ToString();  //dathu
                    myRow[12] = rd.GetDecimal(13).ToString();  //chuathu
                    myTable.Rows.Add(myRow);
                    STT += 1;
                }
                this.drvC_Details.DataSource = myTable;
                rd.Close();
            }
        }

        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
