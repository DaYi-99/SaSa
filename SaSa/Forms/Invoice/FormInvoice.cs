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
    public partial class FormInvoice : Form
    {

        //------ Khai báo biến thuộc lớp DataTable ----------
        DataTable myTable = new DataTable();
        DataRow myRow = null;

        public FormInvoice()
        {
            InitializeComponent();
        }

        private void ptClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cbonv()
        {
            var cmd = new SqlCommand("select * from NHANVIEN", DAL_Connect.myconn);
            var rd = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(rd);
            rd.Dispose();
            cboManv.DisplayMember = "MANV";
            cboManv.DataSource = dt;
        }

        public void cbokh()
        {
            var cmd = new SqlCommand("select * from KHACHHANG", DAL_Connect.myconn);
            var rd = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(rd);
            rd.Dispose();
            cboMakh.DisplayMember = "MAKH";
            cboMakh.DataSource = dt;
        }

        public void cbosp()
        {
            var cmd = new SqlCommand("select * from SANPHAM", DAL_Connect.myconn);
            var rd = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(rd);
            rd.Dispose();
            cboMasp.DisplayMember = "MASP";
            cboMasp.DataSource = dt;
        }

        
        private void FormInvoice_Load(object sender, EventArgs e)
        {
            cbonv();
            cbokh();
            cbosp();
            dtpNgayban.CustomFormat = "dd-MM-yyyy";
            dtpNgayban.Format = DateTimePickerFormat.Custom;

            string sql = @"select SUM(THANHTIEN) from HDB_CT";
            SqlCommand cmd2 = new SqlCommand(sql, DAL_Connect.myconn);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            while (rd2.Read())
            {
                txtTongtien.Text = rd2[0].ToString();
                if (txtTongtien.Text != "")
                    txtTongtien.Text = string.Format("{0:#,##0}", double.Parse(txtTongtien.Text));
            }
            rd2.Close();

        }

        private void ptADD_Click(object sender, EventArgs e)
        {
            //SqlCommand cmd1 = new SqlCommand(
            //    "INSERT INTO HDB" +
            //    "VALUES ('" + txtMahdb.Text.Trim() + "','"
            //            + cboManv.Text + "',"
            //            + DateTime.Parse(dtpNgayban.Text) + ",'"
            //            + cboMakh.Text + "',"
            //            + txtTongtien.Text + ","
            //            + txtdathu.Text + ","
            //            + txtchuathu.Text + ")", DAL_Connect.myconn);
            //SqlDataReader rd1 = cmd1.ExecuteReader();
            //rd1.Read();

            if (txtMahdb.Text != "")
            {
                SqlCommand cmd = new SqlCommand(
                "INSERT INTO HDB_CT(MAHDB, MASP, SL, DONGIA, THANHTIEN) " +
                "VALUES('" + txtMahdb.Text.Trim() + "','" + cboMasp.Text.Trim() + "',"
                + txtSoluong.Text + "," + txtDongia.Text + ","
                + txtThanhtien.Text + ")", DAL_Connect.myconn);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Close();
                SqlCommand s = new SqlCommand("Select a.MASP, b.TENSP, a.SL, a.DONGIA, a.THANHTIEN " +
                    "from HDB_CT as a, SANPHAM as b where a.MAHDB = '"+ txtMahdb.Text + "' and " +
                    "a.MASP = b.MASP", 
                    DAL_Connect.myconn);
                SqlDataReader r = s.ExecuteReader();
                myTable = this.dtsHDB.Tables[0]; //dataset
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
                this.drvHDB.DataSource = myTable;
                r.Close();
            }

        }

        //fill data nhanvien theo cbo
        private void cboManv_TextChanged(object sender, EventArgs e)
        {
                SqlCommand str = new SqlCommand(
            "select TENNV from NHANVIEN where MANV =  N'" + cboManv.Text.Trim() + "'", DAL_Connect.myconn);
                SqlDataReader rd = str.ExecuteReader();
                if (rd.Read())
                {
                    txtTennv.Text = rd.GetString(0).ToString();
                }
                rd.Close();
            
        }

        // fill data khach hang theo cbo
        private void cboMakh_TextChanged(object sender, EventArgs e)
        {
                SqlCommand str = new SqlCommand(
            "select * from KHACHHANG where MAKH =  N'" + cboMakh.Text.Trim() + "'", DAL_Connect.myconn);
                SqlDataReader rd = str.ExecuteReader();
                if (rd.Read())
                {
                    txtTenkh.Text = rd.GetString(1).ToString();
                    txtsdt.Text = rd.GetString(2).ToString();
                    txtdiachi.Text = rd.GetString(3).ToString();
                }
                rd.Close();
            
        }

        private void drvHDB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (myTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                SqlCommand cmd = new SqlCommand(
                "INSERT INTO HDB_CT(MAHDB, MASP, SL, DONGIA, THANHTIEN) " +
                "VALUES('" + txtMahdb.Text.Trim() + "','" + cboMasp.Text.Trim() + "',"
                + txtSoluong.Text + "," + txtDongia.Text + ","
                + txtThanhtien.Text + ")", DAL_Connect.myconn);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Close();
            }
        }
    }
}
