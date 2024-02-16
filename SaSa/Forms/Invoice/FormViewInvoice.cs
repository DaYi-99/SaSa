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
            SqlCommand tenkh = new SqlCommand("select TENKH from KHACHHANG",DAL_Connect.myconn);
            SqlDataReader rd = tenkh.ExecuteReader();
            while(rd.Read() == true)
            {
                listBox1.Items.Add(rd[0].ToString());
            }
            rd.Close();
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

        private void FillData()
        {
            SqlCommand s = new SqlCommand("Select * FROM HDB where MAKH=''", DAL_Connect.myconn);
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
                myTable.Rows.Add(myRow);
                STT += 1;
            }
            this.drvData.DataSource = myTable;
            r.Close();
        }

        private void FillDDH()
        {
            SqlCommand s = new SqlCommand("select a.TENKH from KHACHHANG as a, HDB_Tam as b where a.MAKH = b.MAKH", DAL_Connect.myconn);
            SqlDataReader r = s.ExecuteReader();
            myTable = this.dtsDDH.Tables[0]; //dataset
            int STT = 1;
            while (r.Read() == true)
            {
                myRow = myTable.NewRow();
                myRow[0] = STT;
                myRow[1] = r.GetString(0).ToString(); // ten kh
                myTable.Rows.Add(myRow);
                STT += 1;
            }
            this.drvDDH.DataSource = myTable;
            r.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedTab = tabControl1.SelectedTab.Name.ToString();

            if (SelectedTab == "tabDDH")
            {
                FillDDH();
            }
        }

        private void drvDDH_DoubleClick(object sender, EventArgs e)
        {
            int r = drvDDH.CurrentCell.RowIndex;

            string tenkh = drvDDH.Rows[r].Cells[1].Value.ToString();

            FormInfoInvoice fii = new FormInfoInvoice(tenkh);
            fii.Show();
        }

        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
