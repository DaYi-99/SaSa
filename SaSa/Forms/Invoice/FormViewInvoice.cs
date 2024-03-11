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
    public partial class FormViewInvoice : Form
    {
        //------ Khai báo biến thuộc lớp DataTable ----------
        DataTable myTable = new DataTable();
        DataRow myRow = null;

        public FormViewInvoice()
        {
            InitializeComponent();
        }

        private void FormViewInvoice_Load(object sender, EventArgs e)
        {
            cbokh();


        }

        //Set di chuyển form theo thanh tiêu đề -- O
        bool drag = false;
        Point star = new Point(0, 0);
        private void panelTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            star = new Point(e.X, e.Y);
        }

        private void panelTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - star.X, p.Y - star.Y);
            }
        }

        private void panelTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        //Set di chuyển form theo thanh tiêu đề -- X


        // do du lieu cho bang tat ca hoa don
        private void FillData()
        {
            SqlCommand s = new SqlCommand("Select * FROM HDB", DAL_Connect.myconn);
            SqlDataReader r = s.ExecuteReader();
            myTable = this.dtsData.Tables[0]; //dataset
            int STT = 1;
            while (r.Read() == true)
            {
                myRow = myTable.NewRow();
                myRow[0] = STT;
                myRow[1] = r.GetString(0).ToString(); //mahdb
                myRow[2] = r.GetString(1).ToString(); //manv
                myRow[3] = r.GetDateTime(2).ToString(); //ngay ban
                myRow[4] = r.GetString(3).ToString(); //makh
                myRow[5] = r.GetDecimal(4).ToString(); //tong tien
                myRow[6] = r.GetDecimal(5).ToString(); //da thu
                myRow[7] = r.GetDecimal(6).ToString(); //chua thu
                myTable.Rows.Add(myRow);
                STT += 1;
            }
            this.drvData.DataSource = myTable;
            r.Close();
        }

        // do du lieu cho don dat hang
        private void FillDDH()
        {
            SqlCommand s = new SqlCommand("select a.TENKH from KHACHHANG as a, HDB_Tam as b where a.MAKH = b.MAKH", DAL_Connect.myconn);
            SqlDataReader r = s.ExecuteReader();
            myTable = this.dtsDDH.Tables[0]; //dataset
            int STT = 1;
            string dt = "Chi tiết";
            while (r.Read() == true)
            {
                myRow = myTable.NewRow();
                myRow[0] = STT;
                myRow[1] = r.GetString(0).ToString(); // ten kh
                myRow[2] = dt;
                myTable.Rows.Add(myRow);
                STT += 1;

            }
            this.drvDDH.DataSource = myTable;
            r.Close();
        }


        // Đổ dữ liệu ra combobox tên khách hàng
        public void cbokh()
        {
            var cmd = new SqlCommand("select * from KHACHHANG", DAL_Connect.myconn);
            var rd = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(rd);
            rd.Dispose();
            cbotenkh.DisplayMember = "TENKH";
            cbotenkh.DataSource = dt;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            SqlCommand smakh = new SqlCommand("Select MAKH FROM KHACHHANG where TENKH='"+ cbotenkh.Text +"'", DAL_Connect.myconn);
            SqlDataReader rmakh = smakh.ExecuteReader();
            while(rmakh.Read()==true)
            {
                 txtmakh.Text = rmakh[0].ToString();
            }
            rmakh.Close();

            myTable.Clear();

            SqlCommand s = new SqlCommand("Select * FROM HDB where MAKH='"+ txtmakh.Text +"'", DAL_Connect.myconn);
            SqlDataReader r = s.ExecuteReader();
            myTable = this.dtsData.Tables[0]; //dataset
            int STT = 1;
            while (r.Read() == true)
            {
                myRow = myTable.NewRow();
                myRow[0] = STT;
                myRow[1] = r.GetString(0).ToString(); //mahdb
                myRow[2] = r.GetString(1).ToString(); //manv
                myRow[3] = r.GetDateTime(2).ToString(); //ngay ban
                myRow[4] = r.GetString(3).ToString(); //makh
                myRow[5] = r.GetDecimal(4).ToString(); //tong tien
                myRow[6] = r.GetDecimal(5).ToString(); //da thu
                myRow[7] = r.GetDecimal(6).ToString(); //chua thu
                myTable.Rows.Add(myRow);
                STT += 1;
            }
            this.drvData.DataSource = myTable;
            r.Close();
        }


        // thao tac cac tabpage 
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedTab = tabControl.SelectedTab.Name.ToString();

            //tabpage tat ca hoa don
            if(SelectedTab == "tabHD")
            {
                myTable.Clear();
                FillData();
            }
            // tabpage don dat hang
            if (SelectedTab == "tabDDH")
            {
                myTable.Clear();
                FillDDH();
            }
        }

        private void drvDDH_DoubleClick(object sender, EventArgs e)
        {
            //int r = drvDDH.CurrentCell.RowIndex;

            //string tenkh = drvDDH.Rows[r].Cells[1].Value.ToString();

            //FormInfoInvoice fii = new FormInfoInvoice(tenkh);
            //fii.Show();
        }

        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // xu ly nut xem chi tiet don hang
        private void drvDDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(drvDDH.Columns[e.ColumnIndex].Name=="X")
            {
                int r = drvDDH.CurrentCell.RowIndex;

                string tenkh = drvDDH.Rows[r].Cells[1].Value.ToString();

                FormInfoInvoice fii = new FormInfoInvoice(tenkh);
                fii.Show();
                //MessageBox.Show("muon xoa?", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            myTable.Clear();
            FillData();

        }
    }
}
