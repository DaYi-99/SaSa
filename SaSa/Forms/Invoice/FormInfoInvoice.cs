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
            SqlCommand makh = new SqlCommand("select MAKH from KHACHHANG where TENKH =N'" + lbTenkh.Text + "'", DAL_Connect.myconn);
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
            SqlCommand s = new SqlCommand("Select b.MASP,  b.TENSP, a.SL, a.DONGIA, a.THANHTIEN " +
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
                myRow[1] = r.GetString(0).ToString(); //masp
                myRow[2] = r.GetString(1).ToString(); //tensp
                myRow[3] = r.GetInt32(2).ToString(); //sl
                myRow[4] = r.GetDecimal(3).ToString(); //dongia
                myRow[5] = r.GetDecimal(4).ToString(); //thanhtien
                myTable.Rows.Add(myRow);
                STT += 1;
            }
            this.drvInfoDDH.DataSource = myTable;
            r.Close();
        }

        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void btnInHD_Click(object sender, EventArgs e)
        {
            //INSERT INTO Bang2(Cot1, Cot2, Cot3)
            //SELECT Cot1, Cot2, Cot3
            //FROM Bang1

            // chuyen du lieu hdb-tam qua hdb
            SqlCommand ahd = new SqlCommand(
                "insert into HDB(MAHDB,MANV,NGAY_HDB,MAKH,TongTien,DATHU,CHUATHU)" +
                "select * from HDB_Tam where MAHDB='" + txthdb.Text + "'"
                , DAL_Connect.myconn);
            SqlDataReader rhd = ahd.ExecuteReader();
            rhd.Read();
            rhd.Close();


            // chuyen du lieu tu bang tam sang bang hoa don ban
            SqlCommand add = new SqlCommand(
                "insert into HDB_CT(MAHDB,MASP,SL,DONGIA,THANHTIEN)" +
                "select * from HDB_CT_Tam where MAHDB='" + txthdb.Text + "'"
                , DAL_Connect.myconn);
            SqlDataReader ra = add.ExecuteReader();
            ra.Read();
            ra.Close();

            // xoa du lieu cua bang tam
            SqlCommand del1 = new SqlCommand(
                "delete from HDB_CT_Tam where MAHDB='" + txthdb.Text + "'"
                , DAL_Connect.myconn);
            SqlDataReader r1 = del1.ExecuteReader();
            r1.Read();
            r1.Close();

            // xoa du lieu cua bang tam
            SqlCommand del2 = new SqlCommand(
                "delete from HDB_Tam where MAHDB='" + txthdb.Text + "'"
                , DAL_Connect.myconn);
            SqlDataReader r2 = del2.ExecuteReader();
            r2.Read();
            r2.Close();

            // lay ra gia tri tong tien theo ma hoa don
            SqlCommand ltt = new SqlCommand(
                "select TongTien from HDB where MAHDB='" + txthdb.Text + "'"
                ,DAL_Connect.myconn);
            SqlDataReader rltt = ltt.ExecuteReader();
            while(rltt.Read()==true)
            {
                txtTongtien.Text = rltt[0].ToString();
            }
            rltt.Close();

            // cap nhat lai tong tien trong hoa don va so tien da thu
            SqlCommand utt = new SqlCommand(
                "update HDB set TongTien = " + txtTongtien.Text +"," +
                "DATHU = TongTien - CHUATHU  where MAHDB='" + txthdb.Text + "'"
                , DAL_Connect.myconn);
            SqlDataReader rutt = utt.ExecuteReader();
            rutt.Read();
            rutt.Close();


            //send data to update





            this.Close();
        }
    }
}
