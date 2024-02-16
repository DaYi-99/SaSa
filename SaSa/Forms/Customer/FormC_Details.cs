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
            //Set di chuyển form theo thanh tiêu đề
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            txtmakh.Text = txt;
        }

        // Taskbar icon
        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Taskbar icon

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

        private void FormC_Details_Load(object sender, EventArgs e)
        {
                LabelTenKH();
                txtmakh.Focus();
                // Đổ dữ liệu từ database vào Datagridview cho form Khách hàng
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM HDB where MAKH = '"+txtmakh.Text+"'", DAL_Connect.myconn);
                SqlDataReader rd = cmd.ExecuteReader();
                myTable = this.dtsC_Details.Tables[0]; //dataset
                int STT = 1;
                while (rd.Read() == true)
                {
                    myRow = myTable.NewRow();
                    myRow[0] = STT;
                    myRow[1] = rd.GetString(0).ToString(); //mahd
                    myRow[2] = rd.GetString(1).ToString(); //manv
                    myRow[3] = rd.GetDateTime(2).ToString();  //ngayban
                    myRow[4] = rd.GetString(3).ToString();  //makh
                    myRow[5] = rd.GetDecimal(4).ToString();  //tongtien
                    myRow[6] = rd.GetDecimal(5).ToString();  //dathu
                    myRow[7] = rd.GetDecimal(6).ToString();  //chuathu
                    myTable.Rows.Add(myRow);
                    STT += 1;
                }
                this.drvC_Details.DataSource = myTable;
                rd.Close();

            //hien so luong san pham
            //SqlCommand slsp = new SqlCommand(
            //    "select (select sum(SL) from HDB_CT where MASP=N'SP_01'), " +
            //    "(select sum(SL) from HDB_CT where MASP=N'SP_2')," +
            //    "(select sum(SL) from HDB_CT where MASP=N'SP_3')," +
            //    "(select sum(SL) from HDB_CT where MASP=N'SP_4') from HDB where MAKH=N'" + txtmakh.Text + "'", 
            //    DAL_Connect.myconn);
            //SqlDataReader rdsp = slsp.ExecuteReader();
            //while (rdsp.Read() == true)
            //{
            //    txtCT.Texts = rdsp[0].ToString();
            //}
            //rdsp.Close();

            //hien tong thanh toan
            SqlCommand tt = new SqlCommand(
                "select (select sum(THANHTIEN) from HDB_CT) from HDB where MAKH=N'" + txtmakh.Text + "'", DAL_Connect.myconn);
            SqlDataReader rdtt = tt.ExecuteReader();
            while (rdtt.Read() == true)
            {
                txtTongtt.Texts = rdtt[0].ToString();
                txtTongtt.Texts = string.Format("{0:#,##0}", double.Parse(txtTongtt.Texts));
            }
            rdtt.Close();
        }

        private void HienTongSP(string tenkh)
        {
            if (tenkh == "Quán 86")
            {
                if(cboThang.Text=="")
                {
                    SqlCommand slsp = new SqlCommand(
                                "select (select sum(SL) from HDB_CT where MASP=N'SP_01'), " +
                                "(select sum(SL) from HDB_CT where MASP=N'SP_07') from HDB where MAKH=N'" + txtmakh.Text + "'" +
                                "and year(NGAY_HDB)='" + cboNam.Text + "'"
                                , DAL_Connect.myconn);
                    SqlDataReader rdsp = slsp.ExecuteReader();
                    while (rdsp.Read() == true)
                    {
                        txtCT.Texts = rdsp[0].ToString();
                        txtKL.Texts = rdsp[1].ToString();
                    }
                    rdsp.Close();
                }
                else
                {
                    txtCT.Texts = "0";
                    txtKL.Texts = "0";
                    SqlCommand slsp = new SqlCommand(
            "select (select sum(SL) from HDB_CT where MASP=N'SP_01'), " +
            "(select sum(SL) from HDB_CT where MASP=N'SP_07') from HDB where MAKH=N'" + txtmakh.Text + "'" +
            "and month(NGAY_HDB)='" + cboThang.Text + "'" +
            "and year(NGAY_HDB)='" + cboNam.Text + "'"
            , DAL_Connect.myconn);
                    SqlDataReader rdsp = slsp.ExecuteReader();
                    while (rdsp.Read() == true)
                    {
                        txtCT.Texts = rdsp[0].ToString();
                        txtKL.Texts = rdsp[1].ToString();
                    }
                    rdsp.Close();
                }
            }
        }

        private void LabelTenKH()
        {
            SqlCommand tenkh = new SqlCommand("select TENKH from KHACHHANG where MAKH = '" + txtmakh.Text + "'", DAL_Connect.myconn);
            SqlDataReader rkh = tenkh.ExecuteReader();
            while(rkh.Read()==true)
            {
                labelKH.Text = rkh[0].ToString();
            }
            rkh.Close();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            myTable.Clear();
            // Đổ dữ liệu từ database vào Datagridview cho form Khách hàng
            if(cboThang.Text=="")
            {
                SqlCommand cmd = new SqlCommand(
                "SELECT * FROM HDB where MAKH = '" + txtmakh.Text + "' and " +
                "year(NGAY_HDB)= '" + cboNam.Text + "'", DAL_Connect.myconn);
                SqlDataReader rd = cmd.ExecuteReader();
                myTable = this.dtsC_Details.Tables[0]; //dataset
                int STT = 1;
                while (rd.Read() == true)
                {
                    myRow = myTable.NewRow();
                    myRow[0] = STT;
                    myRow[1] = rd.GetString(0).ToString(); //mahd
                    myRow[2] = rd.GetString(1).ToString(); //manv
                    myRow[3] = rd.GetDateTime(2).ToString();  //ngayban
                    myRow[4] = rd.GetString(3).ToString();  //makh
                    myRow[5] = rd.GetDecimal(4).ToString();  //tongtien
                    myRow[6] = rd.GetDecimal(5).ToString();  //dathu
                    myRow[7] = rd.GetDecimal(6).ToString();  //chuathu
                    myTable.Rows.Add(myRow);
                    STT += 1;
                }
                this.drvC_Details.DataSource = myTable;
                rd.Close();
            }
            else
            {
                SqlCommand cmd = new SqlCommand(
                "SELECT * FROM HDB where MAKH = '" + txtmakh.Text + "' and " +
                "month(NGAY_HDB)= '" + cboThang.Text + "' and " +
                "year(NGAY_HDB)= '" + cboNam.Text + "'", DAL_Connect.myconn);
                SqlDataReader rd = cmd.ExecuteReader();
                myTable = this.dtsC_Details.Tables[0]; //dataset
                int STT = 1;
                while (rd.Read() == true)
                {
                    myRow = myTable.NewRow();
                    myRow[0] = STT;
                    myRow[1] = rd.GetString(0).ToString(); //mahd
                    myRow[2] = rd.GetString(1).ToString(); //manv
                    myRow[3] = rd.GetDateTime(2).ToString();  //ngayban
                    myRow[4] = rd.GetString(3).ToString();  //makh
                    myRow[5] = rd.GetDecimal(4).ToString();  //tongtien
                    myRow[6] = rd.GetDecimal(5).ToString();  //dathu
                    myRow[7] = rd.GetDecimal(6).ToString();  //chuathu
                    myTable.Rows.Add(myRow);
                    STT += 1;
                }
                this.drvC_Details.DataSource = myTable;
                rd.Close();
            }

            HienTongSP(labelKH.Text);
        }
    }
}
