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
    public partial class FormProductType : Form
    {

        //------ Khai báo biến thuộc lớp DataTable ----------
        DataTable myTable = new DataTable();
        DataRow myRow = null;

        public FormProductType()
        {
            InitializeComponent();
        }

        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProductType_Load(object sender, EventArgs e)
        {
            // Đổ dữ liệu từ database vào Datagridview cho form Sản phẩm
            SqlCommand cmd = new SqlCommand("select * from MATHANG", DAL_Connect.myconn);
            SqlDataReader rd = cmd.ExecuteReader();
            //myTable.Clear();
            myTable = this.dtsProductType.Tables[0]; //dataset
            int STT = 1;
            while (rd.Read() == true)
            {
                myRow = myTable.NewRow();
                myRow[0] = STT;
                myRow[1] = rd.GetString(0).ToString(); //masp
                myRow[2] = rd.GetString(1).ToString(); //tensp
                myTable.Rows.Add(myRow);
                STT += 1;
            }
            this.drvProductType.DataSource = myTable;
            rd.Close();
        }
    }
}
