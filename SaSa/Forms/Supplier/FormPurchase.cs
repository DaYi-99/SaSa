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

namespace SaSa.Forms.Supplier
{
    public partial class FormPurchase : Form
    {
        public FormPurchase()
        {
            InitializeComponent();
            //Set di chuyển form theo thanh tiêu đề
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }


        BUS_Purchase bus_pur = new BUS_Purchase();

        //------ Khai báo biến thuộc lớp DataTable ----------
        DataTable myTable = new DataTable();
        DataRow myRow = null;

        private void ptClose_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Hoá đơn sẽ bị huỷ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                SqlCommand cmd = new SqlCommand(
                "alter table HDM_CT nocheck constraint all \n" +
                "delete from HDM where MAHDM='" + txtMahdm.Texts + "'\n" +
                "alter table HDM_CT check constraint all\n" +
                "delete from HDM_CT where MAHDM='" + txtMahdm.Texts + "'", DAL_Connect.myconn);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Close();
                this.Close();
            }
            this.Close();
        }

        private void ptMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void showLH()
        {
            var cmd = new SqlCommand("select * from MATHANG where MAMH = 'MH_1' or MAMH = 'MH_2'", DAL_Connect.myconn);
            var rd = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(rd);
            rd.Dispose();
            cboLH.DisplayMember = "TENMH";
            cboLH.DataSource = dt;
        }

        public void showNCU()
        {
            var cmd = new SqlCommand("select * from NCU", DAL_Connect.myconn);
            var rd = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(rd);
            rd.Dispose();
            cboTenncu.DisplayMember = "TENNCU";
            cboTenncu.DataSource = dt;
        }

        public void showSP()
        {
            var cmd = new SqlCommand("select * from SANPHAM where MAMH = 'MH_1' or MAMH = 'MH_2'", DAL_Connect.myconn);
            var rd = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(rd);
            rd.Dispose();
            cboSP.DisplayMember = "TENSP";
            cboSP.DataSource = dt;
        }


        private void FormPurchase_Load(object sender, EventArgs e)
        {
            showLH();
            showNCU();
            showSP();

            //Khởi tạo mã hoá đơn mua
            SqlDataReader hdm = bus_pur.getDataStoredProcedure("HDM_TAOMAHDM");
            if (hdm.Read() == true)
            {
                this.txtMahdm.Texts = hdm.GetString(0).ToString();
            }
            hdm.Close();

            
        }


        private void FillHDM()
        {
            SqlCommand s = new SqlCommand("Select a.MASP,  b.TENSP, a.SL, a.DONGIA, a.THANHTIEN " +
                    "from HDM_CT as a, SANPHAM as b where a.MAHDM = '" + txtMahdm.Texts + "' and " +
                    "a.MASP = b.MASP",
                    DAL_Connect.myconn);
            SqlDataReader r = s.ExecuteReader();
            myTable = this.dtsPurchase.Tables[0]; //dataset
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
            this.drvPurchase.DataSource = myTable;
            r.Close();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            // Thêm mới hoá đơn bán
            if (myTable.Rows.Count == 0)
            {
                SqlCommand cmd1 = new SqlCommand(
                " insert into HDM values ('" + txtMahdm.Texts + "','" + txtMancu.Texts + "','" + cboTenncu.Text + "',getdate(),"  + txtTongtien.Texts + "," + txtDatt.Texts + "," + txtChuatt.Texts + ")"
                        , DAL_Connect.myconn);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                rd1.Close();
            }


            // Thêm sản phẩm vào datagridview và database bảng HDM_CT
            if (txtMahdm.Texts != "")
            {
                //tạo truy vấn sql lấy ra mã mặt hàng theo tên mặt hàng trong combobox
                SqlCommand m1 = new SqlCommand();
                m1.CommandType = CommandType.Text;
                m1.CommandText = "select MAMH from MATHANG where TENMH = N'" + cboLH.Text + "'";
                m1.Connection = DAL_Connect.myconn;
                string mamh = (string)m1.ExecuteScalar();

                myTable.Clear();
                
                if(myTable.Rows.Count == 0)
                {
                    SqlCommand cmd = new SqlCommand(
                                    "INSERT INTO HDM_CT VALUES('" + txtMahdm.Texts + "','" + txtMasp.Texts + "','" + mamh + "',"
                                    + txtSoluong.Texts + "," + txtDongia.Texts + ","
                                    + txtThanhtien.Texts + ")", DAL_Connect.myconn);
                    SqlDataReader rd = cmd.ExecuteReader();
                    rd.Close();
                    FillHDM();
                }
                //else
                //{
                //    int r = drvPurchase.CurrentCell.RowIndex;

                //    string masp = drvPurchase.Rows[r].Cells[1].Value.ToString();

                //    SqlCommand cmd = new SqlCommand(

                //    "delete HDM_CT where MAHDM='" + txtMahdm.Text + "' and MASP='" + masp + "'"
                //    , DAL_Connect.myconn);
                //    SqlDataReader rd = cmd.ExecuteReader();
                //    rd.Close();
                //}
            }

            // Cập nhật lại tổng hoá đơn khi thêm sản phầm vào datagridview
            SqlCommand cmd2 = new SqlCommand("select SUM(THANHTIEN) from HDM_CT where MAHDM='" + txtMahdm.Texts + "'", DAL_Connect.myconn);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            if (rd2.Read() == true)
            {
                txtTongtien.Texts = rd2.GetDecimal(0).ToString();
                //if (txtTongtien.Text != "")
                txtTongtien.Texts = string.Format("{0:#,##0}", double.Parse(txtTongtien.Texts));
            }
            rd2.Close();

            SqlCommand uptt = new SqlCommand("update HDM set TONGTIEN =" + Decimal.Parse(txtTongtien.Texts) + " where MAHDM = '" + txtMahdm.Texts + "'", DAL_Connect.myconn);
            SqlDataReader rd3 = uptt.ExecuteReader();
            rd3.Read();
            rd3.Close();
        }

        private void cboTenncu_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand str = new SqlCommand(
            "select * from NCU where TENNCU =  N'" + cboTenncu.Text.Trim() + "'", DAL_Connect.myconn);
            SqlDataReader rd = str.ExecuteReader();
            if (rd.Read())
            {
                txtMancu.Texts = rd.GetString(0).ToString();
            }
            rd.Close();
        }

        private void cboSP_TextChanged(object sender, EventArgs e)
        {
            SqlCommand str = new SqlCommand(
            "select * from SANPHAM where TENSP =  N'" + cboSP.Text.Trim() + "'", DAL_Connect.myconn);
            SqlDataReader rd = str.ExecuteReader();
            if (rd.Read())
            {
                txtMasp.Texts = rd.GetString(0).ToString();
                txtDongia.Texts = rd.GetDecimal(3).ToString();
            }
            rd.Close();
        }



        private void txtSoluong_MouseLeave(object sender, EventArgs e)
        {
            ////Tính tồng thành tiền theo số lượng
            if (txtSoluong.Texts != "")
            {
                double sl = Double.Parse(txtSoluong.Texts);
                double dg = Double.Parse(txtDongia.Texts);
                double tt;
                tt = sl * dg;
                txtThanhtien.Texts = tt.ToString();
            }
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                "alter table HDM_CT nocheck constraint all \n" +
                "delete from HDM where MAHDM='" + txtMahdm.Texts + "'\n" +
                "alter table HDM_CT check constraint all\n" +
                "delete from HDM_CT where MAHDM='" + txtMahdm.Texts + "'", DAL_Connect.myconn);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Close();

            myTable.Clear();
            FillHDM();
        }

        private void drvPurchase_DoubleClick(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                int r = drvPurchase.CurrentCell.RowIndex;

                string masp = drvPurchase.Rows[r].Cells[1].Value.ToString();

                SqlCommand cmd = new SqlCommand(

                "delete HDM_CT where MAHDM='" + txtMahdm.Texts + "' and MASP='" + masp + "'"
                , DAL_Connect.myconn);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Close();
            }
            myTable.Clear();
            FillHDM();
        }



        //Set di chuyển form theo thanh tiêu đề -- O
        bool drag = false;
        Point star = new Point(0, 0);
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            star = new Point(e.X, e.Y);
        }

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - star.X, p.Y - star.Y);
            }
        }

        private void panelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        //Set di chuyển form theo thanh tiêu đề -- X
    }

}
