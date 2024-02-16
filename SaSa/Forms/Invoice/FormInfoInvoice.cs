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

namespace SaSa.Forms.Invoice
{
    public partial class FormInfoInvoice : Form
    {

        //------ Khai báo biến thuộc lớp DataTable ----------
        DataTable myTable = new DataTable();
        DataRow myRow = null;


        public FormInfoInvoice(string txt)
        {
            InitializeComponent();
            lbTenkh.Text = txt;
        }

        private void FormInfoInvoice_Load(object sender, EventArgs e)
        {
            SqlCommand mahdb = new SqlCommand("select MAHDB from HDB_Tam where MAKH ='" + txtmakh.Text + "'", DAL_Connect.myconn);
            SqlDataReader rd1 = mahdb.ExecuteReader();
            while (rd1.Read() == true)
            {
                txthdb.Text = rd1[0].ToString();
            }
            rd1.Close();

            showInfo();
        }

        private void lbTenkh_TextChanged(object sender, EventArgs e)
        {
            SqlCommand makh = new SqlCommand("select MAKH from KHACHHANG where TENKH ='" + lbTenkh.Text + "'", DAL_Connect.myconn);
            SqlDataReader rd = makh.ExecuteReader();
            while (rd.Read() == true)
            {
                txtmakh.Text = rd[0].ToString();
            }
            rd.Close();

            
        }

        private void txtmakh_TextChanged(object sender, EventArgs e)
        {
            //SqlCommand mahdb = new SqlCommand("select MAHDB from HDB_Tam where MAKKH ='" + txtmakh.Text + "'", DAL_Connect.myconn);
            //SqlDataReader rd1 = mahdb.ExecuteReader();
            //while (rd1.Read() == true)
            //{
            //    txthdb.Text = rd1[0].ToString();
            //}
            //rd1.Close();
        }

        private void showInfo()
        {
            SqlCommand s = new SqlCommand("Select b.TENSP, a.SL, a.DONGIA, a.THANHTIEN " +
                    "from HDB_CT_Tam as a, SANPHAM as b where a.MAHDB = '" + txthdb.Text + "' and " +
                    "a.MASP = b.MASP",
                    DAL_Connect.myconn);
            SqlDataReader r = s.ExecuteReader();
            myTable = this.dtsInfoDDH.Tables[0]; //dataset
            int STT = 1;
            while (r.Read() == true)
            {
                myRow = myTable.NewRow();
                myRow[0] = STT;
                //myRow[1] = r.GetString(0).ToString(); //masp
                myRow[1] = r.GetString(0).ToString(); //tensp
                myRow[2] = r.GetInt32(1).ToString(); //sl
                myRow[3] = r.GetDecimal(2).ToString(); //dongia
                myRow[4] = r.GetDecimal(3).ToString(); //thanhtien
                myTable.Rows.Add(myRow);
                STT += 1;
            }
            this.drvInfoDDH.DataSource = myTable;
            r.Close();
        }
    }
}
