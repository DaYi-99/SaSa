using SaSa.BUS;
using SaSa.DAL;
using SaSa.DTO;
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
        BUS_Invoice bus_invoice = new BUS_Invoice();
        BUS_Customer bus_kh = new BUS_Customer();

        //------ Khai báo biến thuộc lớp DataTable ----------
        DataTable myTable = new DataTable();
        DataRow myRow = null;

        public FormInvoice()
        {
            InitializeComponent();
            //Set di chuyển form theo thanh tiêu đề
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            
        }

        private void ptClose_Click_1(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Hoá đơn sẽ bị huỷ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                SqlCommand cmd = new SqlCommand(
                "alter table HDB_CT nocheck constraint all \n" +
                "delete from HDB where MAHDB='" + txtMahdb.Text + "'\n" +
                "alter table HDB_CT check constraint all\n" +
                "delete from HDB_CT where MAHDB='" + txtMahdb.Text + "'", DAL_Connect.myconn);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Close();
                this.Close();
            }
        }

        public void cbonv()
        {
            var cmd = new SqlCommand("select * from NHANVIEN", DAL_Connect.myconn);
            var rd = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(rd);
            rd.Dispose();
            cboTennv.DisplayMember = "TENNV";
            cboTennv.DataSource = dt;
        }

        public void cbosp()
        {
            var cmd = new SqlCommand("select * from SANPHAM", DAL_Connect.myconn);
            var rd = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(rd);
            rd.Dispose();
            cboTensp.DisplayMember = "TENSP";
            cboTensp.DataSource = dt;
        }

        public void cbokh()
        {
            var cmd = new SqlCommand("select * from KHACHHANG", DAL_Connect.myconn);
            var rd = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(rd);
            rd.Dispose();
            cboTenKH.DisplayMember = "TENKH";
            cboTenKH.DataSource = dt;
        }


        // HÀM LOAD FORM HOÁ ĐƠN
        private void FormInvoice_Load(object sender, EventArgs e)
        {
            //Tạo câu hỏi khách hàng mới
            DialogResult tb = MessageBox.Show("Đây có phải là khách hàng mới","Thông báo!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(tb == DialogResult.Yes)
            {
                SqlDataReader dr = bus_kh.getDataStoredProcedure("KH_TAOMAKH");
                if (dr.Read() == true)
                {
                    this.txtMakh.Text = dr.GetString(0).ToString();
                }
                dr.Close();
                txtTenkh.Show();
                cboTenKH.Hide();
            }
            else if (tb == DialogResult.No)
            {
                txtTenkh.Hide();
                cboTenKH.Show();
                txtdiachi.Enabled = false;
                txtsdt.Enabled = false;
                cbokh();
            }

            //Khởi tạo mã hoá đơn bán
            SqlDataReader hdb = bus_invoice.getDataStoredProcedure("HDB_TAOMAHDB");
            if (hdb.Read() == true)
            {
                this.txtMahdb.Text = hdb.GetString(0).ToString();
            }
            hdb.Close();


            txtMakh.Enabled = false;
            txtchuathu.Text = "0";
            txtdathu.Text = "0";
            //txtTongtien.Text = "0";
            //txtTongtien.Text = string.Format("{0:#,##0}", txtTongtien.Text);

            cbonv();
            cbosp();



            lbdv.Visible = false;
            txtDongia.Enabled = false;

            ptADD.Enabled = false;
            
        }

        // update cột tổng tiền
        private void UpdateTT()
        {
            if (drvHDB.Rows.Count > 0)
            {
                // tong thanh tien
                SqlCommand cmd2 = new SqlCommand("select SUM(THANHTIEN) from HDB_CT_Tam where MAHDB='" + txtMahdb.Text + "'", DAL_Connect.myconn);
                SqlDataReader rd2 = cmd2.ExecuteReader();
                if (rd2.Read() == true)
                {
                    txtTongtien.Text = rd2.GetDecimal(0).ToString()/* + Convert.ToString("000")*/;
                    txtTongtien.Text = string.Format("{0:#,##0}", txtTongtien.Text);
                }
                rd2.Close();

                SqlCommand uptt = new SqlCommand("update HDB_Tam set TongTien =" + Decimal.Parse(txtTongtien.Text) + " where MAHDB = '" + txtMahdb.Text + "'", DAL_Connect.myconn);
                SqlDataReader rd3 = uptt.ExecuteReader();
                rd3.Read();
                rd3.Close();
            }
        }



        // Thêm sản phẩm vào hoá đơn
        private void ptADD_Click(object sender, EventArgs e)
        {
            //UpdateSL();
            // THÊM MỚI KHÁCH HÀNG NẾU LÀ KHÁCH HÀNG MỚI
            if (txtsdt.Enabled==true)
            {
                SqlCommand newkh = new SqlCommand("insert into KHACHHANG values ('" 
                    + this.txtMakh.Text.Trim() + "',N'" 
                    + this.txtTenkh.Text.Trim() + "','"
                    + this.txtsdt.Text.Trim() + "','"
                    + this.txtdiachi.Text.Trim() + "')" , DAL_Connect.myconn);
                SqlDataReader rd = newkh.ExecuteReader();
                rd.Read();
                rd.Close();
            }

            // THÊM MỚI HOÁ ĐƠN VÀO BẢNG TẠM
            //if (myTable.Rows.Count == 0)
            //{
            //    SqlCommand cmd1 = new SqlCommand(
            //    " insert into HDB_Tam values ('" + txtMahdb.Text + "','" + txtManv.Text + "',getdate(),'" + txtMakh.Text + "'," + txtTongtien.Text + "," + txtdathu.Text + "," + txtchuathu.Text + ")"
            //            , DAL_Connect.myconn);
            //    SqlDataReader rd1 = cmd1.ExecuteReader();
            //    rd1.Close();
            //}

            bool Found = false;
            if (drvHDB.Rows.Count > 0 )
            {
                //Check if the product Id exists with the same Price
                foreach (DataGridViewRow row in drvHDB.Rows)
                {
                    if (Convert.ToString(row.Cells[1].Value) == txtMasp.Text)
                    {
                        //Update the Quantity of the found row
                        row.Cells[3].Value = Convert.ToString(Convert.ToInt32(txtSoluong.Text) + Convert.ToInt32(row.Cells[3].Value));
                        Found = true;

                        SqlCommand upsl = new SqlCommand("update HDB_CT_Tam set SL =" + row.Cells[3].Value + " where " +
                            "MAHDB = '" + txtMahdb.Text + "' and MASP='" + row.Cells[1].Value + "'", DAL_Connect.myconn);
                        SqlDataReader rdsl = upsl.ExecuteReader();
                        rdsl.Read();
                        rdsl.Close();
                    }

                }
                if (!Found)
                {
                    //Add the row to grid view

                    SqlCommand cmd = new SqlCommand(
                    "INSERT INTO HDB_CT_Tam(MAHDB, MASP, SL, DONGIA, THANHTIEN) " +
                    "VALUES('" + txtMahdb.Text.Trim() + "','" + txtMasp.Text.Trim() + "',"
                    + txtSoluong.Text + "," + txtDongia.Text + ","
                    + txtThanhtien.Text + ")", DAL_Connect.myconn);
                    SqlDataReader rd = cmd.ExecuteReader();
                    rd.Close();
                    myTable.Clear();
                    FillHDB();
                }
            }
            else
            {
                //drvHDB.Rows.Clear();

                SqlCommand cmd = new SqlCommand(
                "INSERT INTO HDB_CT_Tam(MAHDB, MASP, SL, DONGIA, THANHTIEN) " +
                "VALUES('" + txtMahdb.Text.Trim() + "','" + txtMasp.Text.Trim() + "',"
                + txtSoluong.Text + "," + txtDongia.Text + ","
                + txtThanhtien.Text + ")", DAL_Connect.myconn);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Close();
                FillHDB();
            }

            foreach (DataGridViewRow row in drvHDB.Rows)
            {
                // sua thanh tien theo so luong
                row.Cells[drvHDB.Columns[5].Index].Value =
                    (Convert.ToDouble(row.Cells[drvHDB.Columns[4].Index].Value) * Convert.ToDouble(row.Cells[drvHDB.Columns[3].Index].Value));

                SqlCommand uptt = new SqlCommand("update HDB_CT_Tam set THANHTIEN =" + row.Cells[5].Value + " where " +
                            "MAHDB = '" + txtMahdb.Text + "' and MASP='" + row.Cells[1].Value + "'", DAL_Connect.myconn);
                SqlDataReader rdtt = uptt.ExecuteReader();
                rdtt.Read();
                rdtt.Close();
            }
            UpdateTT();
            numbertotext();
        }

        //private void UpdateSL()
        //{
        //    string masp1 = txtMasp.Text;
        //    for (int row = 0; row < drvHDB.Rows.Count - 1; row++)
        //    {
        //        int sl = Int32.Parse(txtSoluong.Text);
        //        string masp2 = drvHDB.Rows[row].Cells[1].Value.ToString();
        //        if (masp1 == masp2)
        //        {
        //            SqlCommand upsp = new SqlCommand("update HDB_CT_Tam set SL=" +
        //                "(select SL from HDB_CT_Tam where MASP='" + masp2 + "') + " + sl + " where MASP='" + masp2 + "'", DAL_Connect.myconn);
        //            SqlDataReader rdsp = upsp.ExecuteReader();
        //            rdsp.Read();
        //            rdsp.Close();
        //            //MessageBox.Show("đã chay duoc toi day");
        //            myTable.Clear();
        //            FillHDB();
        //        }
        //    }
        //}


        // HIỆN SẢN PHẨM ĐÃ THÊM VÀO DATAGRIDVIEW
        private void FillHDB()
        {   
            SqlCommand s = new SqlCommand("Select a.MASP, b.TENSP, a.SL, a.DONGIA, a.THANHTIEN " +
                    "from HDB_CT_Tam as a, SANPHAM as b where a.MAHDB = '" + txtMahdb.Text + "' and " +
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


        //fill data nhanvien theo cbo
        private void cboTennv_TextChanged(object sender, EventArgs e)
        {
            SqlCommand str = new SqlCommand(
                        "select * from NHANVIEN where TENNV =  N'" + cboTennv.Text.Trim() + "'", DAL_Connect.myconn);
            SqlDataReader rd = str.ExecuteReader();
            if (rd.Read())
            {
                txtManv.Text = rd.GetString(0).ToString();
            }
            rd.Close();
        }


        // fill data khach hang theo cbo
        private void cboTenKH_TextChanged(object sender, EventArgs e)
        {
            SqlCommand str = new SqlCommand(
            "select * from KHACHHANG where TENKH =  N'" + cboTenKH.Text.Trim() + "'", DAL_Connect.myconn);
            SqlDataReader rd = str.ExecuteReader();
            if (rd.Read() == true)
            {
                txtMakh.Text = rd.GetString(0).ToString();
                txtsdt.Text = rd.GetString(2).ToString();
                txtdiachi.Text = rd.GetString(3).ToString();
            }
            rd.Close();
        }


        // fill data sản phẩm theo cbo
        private void cboTensp_TextChanged(object sender, EventArgs e)
        {
            SqlCommand str = new SqlCommand(
                        "select * from SANPHAM where TENSP =  N'" + cboTensp.Text.Trim() + "'", DAL_Connect.myconn);
            SqlDataReader rd = str.ExecuteReader();
            if (rd.Read())
            {
                txtMasp.Text = rd.GetString(0).ToString();
                txtDongia.Text = rd.GetDecimal(3).ToString();
            }
            rd.Close();
            txtSoluong.Text = "";
            txtThanhtien.Text = "";
            txtDongia.Text = string.Format("{0:#,##0}", double.Parse(txtDongia.Text));
        }


        // CẬP NHẬT TEXTBOX THÀNH TIỀN THEO SỐ LƯỢNG THAY ĐỔI
        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            if(txtSoluong.Text!="")
            {
                double sl = Double.Parse(txtSoluong.Text);
                double dg = Double.Parse(txtDongia.Text);
                double tt;
                tt = sl * dg;
                txtThanhtien.Text = string.Format("{0:#,##0}", double.Parse(tt.ToString()));
            }
        }



        // NÚT HUỶ HOÁ ĐƠN
        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                "delete from HDB_Tam where MAHDB = '" + txtMahdb.Text + "'" +
                "delete from HDB_CT_Tam where MAHDB = '" + txtMahdb.Text + "'", DAL_Connect.myconn);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Close();

            myTable.Clear();
            txtTongtien.Text = "0";

            ptADD.Enabled = false;
            btnTaoHD.Enabled = true;
            txtTongtien.Visible = false;
            lbdv.Visible = false;
            lbTongtien.Visible = false;
        }


        // NHẤN ĐÚP HÀNG ĐỂ XOÁ SẢN PHẨM KHỎI DATAGRIDVIEW
        private void drvHDB_DoubleClick(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                int r = drvHDB.CurrentCell.RowIndex;

                string masp = drvHDB.Rows[r].Cells[1].Value.ToString();

                SqlCommand cmd = new SqlCommand(

                "delete HDB_CT_Tam where MAHDB='" + txtMahdb.Text + "' and MASP='" + masp + "'"
                , DAL_Connect.myconn);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Close();
            }
            myTable.Clear();
            FillHDB();
        }


        // dữ liệu nhập vào txtSDT phải là số
        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            PrintInvoice prt = new PrintInvoice(txtMahdb.Text);
            prt.Show();

            //SqlDataAdapter da = new SqlDataAdapter("Select distinct(b.TENSP), b.DVT, a.SL, a.DONGIA, a.THANHTIEN, " +
            //        "(select TongTien from HDB where MAHDB='" + txtMahdb.Text + "') as TongTien from HDB_CT as a, SANPHAM as b where a.MAHDB = '" + txtMahdb.Text + "' and " +
            //        "a.MASP = b.MASP",
            //        DAL_Connect.myconn);
            //SqlDataAdapter da = new SqlDataAdapter("select * from HDB_CT where MAHDB='HDB_1'", DAL.DAL_Connect.myconn);
            //SqlDataAdapter da = new SqlDataAdapter("select TongTien from HDB where MAHDB='HDB_1'", DAL.DAL_Connect.myconn);

            //DataTable dt = new DataTable("Hoadonban"); /*DataTable dtt = new DataTable("Hoadonban");*/
            //da.Fill(dt); /*daptt.Fill(dtt);*/
            //CR_Invoice cr = new CR_Invoice();
            //cr.SetDataSource(dt); /*cr.SetDataSource(dtt);*/
            //PrintInvoice prt = new PrintInvoice();
            //prt.crvInvoice.ReportSource = cr;
            //prt.ShowDialog();
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


        private void txtTongtien_TextChanged(object sender, EventArgs e)
        {
            lbdv.Visible = true;
            txtTongtien.Visible = true;
            lbdv.Visible = true;
            lbTongtien.Visible = true;
        }

        private void numbertotext()
        {
            string[] Ones = { "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười", "Mười một", "Mười hai", "Mười ba", "Mười bốn", "Mười lăm", "Mười sáu", "Mười bảy", "Mười tám", "Mười chín" };
            string[] Tens = { "Mười", "Hai Mươi Ngàn", "Ba Nươi Ngàn", "Bốn Mươi Ngàn", "Năm Mươi Ngàn", "Sáu Mươi Ngàn", "Bảy Mươi Ngàn", "Tám Mươi Ngàn", "Chín Mươi Ngàn" };

            int no = int.Parse(txtTongtien.Text);
            string strWords = "";

            if (no > 999 && no < 10000)
            {
                int i = no / 1000;
                strWords = strWords + Ones[i - 1] + " Ngàn ";
                no = no % 1000;
            }


            if (no > 99 && no < 1000)
            {
                int i = no / 100;
                strWords = strWords + Ones[i - 1] + " Trăm ";
                no = no % 100;
            }

            if (no > 19 && no < 100)
            {
                int i = no / 10;
                strWords = strWords + Tens[i - 1] + " Ngàn ";
                no = no % 10;
            }

            if (no > 0 && no < 20)
            {
                strWords = strWords + Ones[no - 1];
            }

            lbTongtien.Text = strWords;
        }


       
        private void drvHDB_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // FORMAT CHO CỘT ĐƠN GIÁ
            if(e.ColumnIndex == 4 && e.RowIndex != this.drvHDB.NewRowIndex)
            {
                if(drvHDB.Rows[e.RowIndex].Cells[4].Value != null)
                {
                    double val = double.Parse(e.Value.ToString());
                    e.Value = val.ToString("N3");
                }
            }
            // FORMAT CHO CỘT THÀNH TIỀN
            if (e.ColumnIndex == 5 && e.RowIndex != this.drvHDB.NewRowIndex)
            {
                if (drvHDB.Rows[e.RowIndex].Cells[5].Value != null)
                {
                    double val = double.Parse(e.Value.ToString());
                    e.Value = val.ToString("N3");
                }
            }
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            // THÊM MỚI KHÁCH HÀNG NẾU LÀ KHÁCH HÀNG MỚI
            if (txtsdt.Enabled == true)
            {
                SqlCommand newkh = new SqlCommand("insert into KHACHHANG values ('"
                    + this.txtMakh.Text.Trim() + "',N'"
                    + this.txtTenkh.Text.Trim() + "','"
                    + this.txtsdt.Text.Trim() + "','"
                    + this.txtdiachi.Text.Trim() + "')", DAL_Connect.myconn);
                SqlDataReader rd = newkh.ExecuteReader();
                rd.Read();
                rd.Close();
            }

            // THÊM MỚI HOÁ ĐƠN VÀO BẢNG TẠM
                SqlCommand cmd1 = new SqlCommand(
                " insert into HDB_Tam values ('" + txtMahdb.Text + "','" + txtManv.Text + "',getdate(),'" + txtMakh.Text + "'," + txtTongtien.Text + "," + txtdathu.Text + "," + txtchuathu.Text + ")"
                        , DAL_Connect.myconn);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                rd1.Close();

            ptADD.Enabled = true;
            btnTaoHD.Enabled = false;
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
