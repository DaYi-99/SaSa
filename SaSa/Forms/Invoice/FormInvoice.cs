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




        // Set di chuyển form theo thanh tiêu đề -- O
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


        // Xử lý nút đóng form
        private void ptClose_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Hoá đơn sẽ bị huỷ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                SqlCommand cmd = new SqlCommand(
                "alter table HDB_CT nocheck constraint all \n" +
                "delete from HDB where MAHDB='" + txtmahd.Text + "'\n" +
                "alter table HDB_CT check constraint all\n" +
                "delete from HDB_CT where MAHDB='" + txtmahd.Text + "'", DAL_Connect.myconn);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Close();
                this.Close();
            }
        }


        // Chuyển số thành chữ
        private void numbertotext()
        {
            string[] Ones = { "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười", "Mười một", "Mười hai", "Mười ba", "Mười bốn", "Mười lăm", "Mười sáu", "Mười bảy", "Mười tám", "Mười chín" };
            string[] Tens = { "Mười", "Hai Mươi Ngàn", "Ba Nươi Ngàn", "Bốn Mươi Ngàn", "Năm Mươi Ngàn", "Sáu Mươi Ngàn", "Bảy Mươi Ngàn", "Tám Mươi Ngàn", "Chín Mươi Ngàn" };

            int no = int.Parse(lbtongtien.Text);
            string strWords = "";

            //
            if(no > 10000)
            {
                int i = no / 10000;
                strWords = strWords + Ones[i - 1] + " Triệu";
                no = no % 10000;
            }
            //
            if (no > 999 && no < 10000)
            {
                int i = no / 1000;
                strWords = strWords + Ones[i - 1] + " ";
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
                strWords = strWords + Tens[i - 1] + " ";
                no = no % 10;
            }

            if (no > 0 && no < 20)
            {
                strWords = strWords + Ones[no - 1];
            }

            lbtonghd.Text = strWords;
        }

        // Dữ liệu nhập vào txtSDT phải là số
        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        // Đổ dữ liệu ra combobox nhân viên
        public void cbonv()
        {
            var cmd = new SqlCommand("select * from NHANVIEN", DAL_Connect.myconn);
            var rd = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(rd);
            rd.Dispose();
            cbotennv.DisplayMember = "TENNV";
            cbotennv.DataSource = dt;
        }

        // Đổ dữ liệu ra combobox tên sản phẩm
        public void cbosp()
        {
            var cmd = new SqlCommand("select * from SANPHAM", DAL_Connect.myconn);
            var rd = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(rd);
            rd.Dispose();
            cbotensp.DisplayMember = "TENSP";
            cbotensp.DataSource = dt;
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


        // Update cột tổng hoá đơn
        private void UpdateTT()
        {
            if (drvHDB.Rows.Count > 0)
            {
                // tong thanh tien
                SqlCommand cmd2 = new SqlCommand("select SUM(THANHTIEN) from HDB_CT_Tam where MAHDB='" + txtmahd.Text + "'", DAL_Connect.myconn);
                SqlDataReader rd2 = cmd2.ExecuteReader();
                if (rd2.Read() == true)
                {
                    lbtongtien.Text = rd2.GetDecimal(0).ToString();
                    //txttonghd.Text = string.Format("{0:#,##0}", double.Parse(rd2.GetDecimal(0).ToString("N3")));
                    

                }
                rd2.Close();

                SqlCommand uptt = new SqlCommand("update HDB_Tam set TongTien =" + Decimal.Parse(lbtongtien.Text) + " where MAHDB = '" + txtmahd.Text + "'", DAL_Connect.myconn);
                SqlDataReader rd3 = uptt.ExecuteReader();
                rd3.Read();
                rd3.Close();
            }
        }


        // HIỆN SẢN PHẨM ĐÃ THÊM VÀO DATAGRIDVIEW
        private void FillHDB()
        {
            SqlCommand s = new SqlCommand("Select a.MASP, b.TENSP, a.SL, a.DONGIA, a.THANHTIEN " +
                    "from HDB_CT_Tam as a, SANPHAM as b where a.MAHDB = '" + txtmahd.Text + "' and " +
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

        
        // fill mã nhân viên theo tên nhân viên
        private void cbotennv_TextChanged(object sender, EventArgs e)
        {
            SqlCommand str = new SqlCommand(
                        "select * from NHANVIEN where TENNV =  N'" + cbotennv.Text.Trim() + "'", DAL_Connect.myconn);
            SqlDataReader rd = str.ExecuteReader();
            if (rd.Read())
            {
                txtmanv.Text = rd.GetString(0).ToString();
            }
            rd.Close();
        }


        // fill thông tin khách hàng theo tên khách hàng
        private void cbotenkh_TextChanged(object sender, EventArgs e)
        {
            SqlCommand str = new SqlCommand(
            "select * from KHACHHANG where TENKH =  N'" + cbotenkh.Text.Trim() + "'", DAL_Connect.myconn);
            SqlDataReader rd = str.ExecuteReader();
            if (rd.Read() == true)
            {
                txtmakh.Text = rd.GetString(0).ToString();
                txtsdt.Text = rd.GetString(2).ToString();
                txtdiachi.Text = rd.GetString(3).ToString();
            }
            rd.Close();
        }


        // fill thông tin sản phẩm theo tên sản phẩm
        private void cbotensp_TextChanged(object sender, EventArgs e)
        {
            SqlCommand str = new SqlCommand(
                        "select * from SANPHAM where TENSP =  N'" + cbotensp.Text.Trim() + "'", DAL_Connect.myconn);
            SqlDataReader rd = str.ExecuteReader();
            if (rd.Read())
            {
                txtmasp.Text = rd.GetString(0).ToString();
                //txtdongia.Text = rd.GetDecimal(3).ToString();
                //txtdongia.Text = string.Format("{0:#,##0}", double.Parse(rd.GetDecimal(3).ToString()));
                txtdongia.Text = rd.GetDecimal(3).ToString("#,##0");
            }
            rd.Close();

            txtsoluong.Text = "";
            txtthanhtien.Text = "";
        }


        // Cập nhật ô thành tiền theo số lượng thay đổi
        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            if (txtsoluong.Text != "")
            {
                double sl = Double.Parse(txtsoluong.Text);
                double dg = Double.Parse(txtdongia.Text);
                double tt;
                tt = sl * dg;
                //txtthanhtien.Text = string.Format("{0:#,##0}", double.Parse(tt.ToString()));
                txtthanhtien.Text = tt.ToString("#,##0");
            }
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            // THÊM MỚI KHÁCH HÀNG NẾU LÀ KHÁCH HÀNG MỚI
            if (txtsdt.Enabled == true)
            {
                SqlCommand newkh = new SqlCommand("insert into KHACHHANG values ('"
                    + this.txtmakh.Text.Trim() + "',N'"
                    + this.txttenkh.Text.Trim() + "','"
                    + this.txtsdt.Text.Trim() + "','"
                    + this.txtdiachi.Text.Trim() + "')", DAL_Connect.myconn);
                SqlDataReader rd = newkh.ExecuteReader();
                rd.Read();
                rd.Close();
            }

            // THÊM MỚI HOÁ ĐƠN VÀO BẢNG TẠM
            SqlCommand cmd1 = new SqlCommand(
            " insert into HDB_Tam values ('" + txtmahd.Text + "','" + txtmanv.Text + "',getdate(),'" + txtmakh.Text + "',0,0,0)"
                    , DAL_Connect.myconn);
            SqlDataReader rd1 = cmd1.ExecuteReader();
            rd1.Close();

            btnThem.Enabled = true;
            btnTaoHD.Enabled = false;
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã thêm đặt hàng");
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // THÊM MỚI KHÁCH HÀNG NẾU LÀ KHÁCH HÀNG MỚI
            if (txtsdt.Enabled == true)
            {
                SqlCommand newkh = new SqlCommand("insert into KHACHHANG values ('"
                    + this.txtmakh.Text.Trim() + "',N'"
                    + this.txttenkh.Text.Trim() + "','"
                    + this.txtsdt.Text.Trim() + "','"
                    + this.txtdiachi.Text.Trim() + "')", DAL_Connect.myconn);
                SqlDataReader rd = newkh.ExecuteReader();
                rd.Read();
                rd.Close();
            }
            bool Found = false;
            if (drvHDB.Rows.Count > 0)
            {
                // Kiểm tra xem mã sản phẩm đã có trong drv chưa
                foreach (DataGridViewRow row in drvHDB.Rows)
                {
                    if (Convert.ToString(row.Cells[1].Value) == txtmasp.Text)
                    {
                        // Lấy ra mã sp nếu trùng thì cho cập nhật số lượng
                        row.Cells[3].Value = Convert.ToString(Convert.ToInt32(txtsoluong.Text) + Convert.ToInt32(row.Cells[3].Value));
                        Found = true;

                        SqlCommand upsl = new SqlCommand("update HDB_CT_Tam set SL =" + row.Cells[3].Value + " where " +
                            "MAHDB = '" + txtmahd.Text + "' and MASP='" + row.Cells[1].Value + "'", DAL_Connect.myconn);
                        SqlDataReader rdsl = upsl.ExecuteReader();
                        rdsl.Read();
                        rdsl.Close();
                    }

                }
                if (!Found)
                {
                    // Nếu mã sp chưa tồn tại thì thêm mới dòng vào drv
                    SqlCommand cmd = new SqlCommand(
                    "INSERT INTO HDB_CT_Tam(MAHDB, MASP, SL, DONGIA, THANHTIEN) " +
                    "VALUES('" + txtmahd.Text.Trim() + "','" + txtmasp.Text.Trim() + "',"
                    + txtsoluong.Text + "," + Double.Parse(txtdongia.Text) + ","
                    + txtthanhtien.Text + ")", DAL_Connect.myconn); ;
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
                "VALUES('" + txtmahd.Text.Trim() + "','" + txtmasp.Text.Trim() + "',"
                + txtsoluong.Text + "," + txtdongia.Text + ","
                + txtthanhtien.Text + ")", DAL_Connect.myconn);
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
                            "MAHDB = '" + txtmahd.Text + "' and MASP='" + row.Cells[1].Value + "'", DAL_Connect.myconn);
                SqlDataReader rdtt = uptt.ExecuteReader();
                rdtt.Read();
                rdtt.Close();
            }
            UpdateTT();
            //numbertotext();
            string nb = lbtongtien.Text;
            lbtonghd.Text = ConvertAmount(double.Parse(nb));
            //lbtonghd.Show();
            lbtongtien.Show();
        }

        private void FormInvoice_Load(object sender, EventArgs e)
        {
            //Tạo câu hỏi khách hàng mới
            DialogResult tb = MessageBox.Show("Đây có phải là khách hàng mới", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                // Nếu là khách hàng mới thì khởi tạo mã kh
                SqlDataReader dr = bus_kh.getDataStoredProcedure("KH_TAOMAKH");
                if (dr.Read() == true)
                {
                    this.txtmakh.Text = dr.GetString(0).ToString();
                }
                dr.Close();
                txttenkh.Show();
                cbotenkh.Hide();
            }
            // Nếu là kh cũ thì cho chọn tên khách hàng
            else if (tb == DialogResult.No)
            {
                txttenkh.Hide();
                cbotenkh.Show();
                txtdiachi.Enabled = false;
                txtsdt.Enabled = false;
                cbokh();
            }

            // Khởi tạo mã hoá đơn bán
            SqlDataReader hdb = bus_invoice.getDataStoredProcedure("HDB_TAOMAHDB");
            if (hdb.Read() == true)
            {
                this.txtmahd.Text = hdb.GetString(0).ToString();
            }
            hdb.Close();



            if(myTable.Rows.Count > 0)
            {
                btnDatHang.Show();
                btnInHD.Show();
            }
            else
            {
                btnDatHang.Hide();
                btnInHD.Hide();
            }

            txtmakh.Enabled = false;

            cbonv();
            cbosp();

            txtdongia.Enabled = false;
            btnThem.Enabled = false;

            lbtongtien.Hide();
            lbtonghd.Hide();
            lbdv.Hide();
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                "delete from HDB_Tam where MAHDB = '" + txtmahd.Text + "'" +
                "delete from HDB_CT_Tam where MAHDB = '" + txtmahd.Text + "'", DAL_Connect.myconn);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Close();

            myTable.Clear();
            lbtongtien.Text = "0";

            btnThem.Enabled = false;
            btnTaoHD.Enabled = true;

            lbtongtien.Hide();
            lbtonghd.Hide();
            lbdv.Hide();
        }


        private void drvHDB_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // FORMAT CHO CỘT ĐƠN GIÁ
            if (e.ColumnIndex == 4 && e.RowIndex != this.drvHDB.NewRowIndex)
            {
                if (drvHDB.Rows[e.RowIndex].Cells[4].Value != null)
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

        private void btnInHD_Click(object sender, EventArgs e)
        {

        }

        private void lbtongtien_TextChanged(object sender, EventArgs e)
        {
            lbtonghd.Show();
            lbdv.Show();
        }



        String[] units  = { "Không", "Một", "Hai", "Ba","Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười", "Mười Một",
                            "Mười Hai", "Mười Ba", "Mười Bốn", "Mười Lăm", "Mười Sáu",
                            "Mười Bảy", "Mười Tám", "Mười Chín" };
        String[] tens   = { "", "", "Hai Mươi", "Ba Mươi", "Bốn Mươi","Năm Mươi", "Sáu Mươi", "Bảy Mươi", "Tám Mươi", "Chín Mươi" };

        public String ConvertAmount(double amount)
        {
            try
            {
                Int64 amount_int = (Int64)amount;
                Int64 amount_dec = (Int64)Math.Round((amount - (double)(amount_int)) * 100);
                if (amount_dec == 0)
                {
                    return Cast(amount_int) + " Ngàn.";
                }
                else
                {
                    return Cast(amount_int) + " Point " + Cast(amount_dec) + " Only.";
                }
            }
            catch (Exception e)
            {
                // TODO: handle exception  
            }
            return "";
        }

        public String Cast(Int64 i)
        {
            if (i < 20)
            {
                return units[i];
            }
            if (i < 100)
            {
                return tens[i / 10] + ((i % 10 > 0) ? " " + Cast(i % 10) : "");
            }
            if (i < 1000)
            {
                return units[i / 100] + " Trăm"
                        + ((i % 100 > 0) ? " " + Cast(i % 100) : "");
            }
            if (i < 100000)
            {
                return Cast(i / 1000) + " Triệu"
                + ((i % 1000 > 0) ? " " + Cast(i % 1000) : "");
            }
            if (i < 10000000)
            {
                return Cast(i / 100000) + " Lakh "
                        + ((i % 100000 > 0) ? " " + Cast(i % 100000) : "");
            }
            if (i < 1000000000)
            {
                return Cast(i / 10000000) + " Crore "
                        + ((i % 10000000 > 0) ? " " + Cast(i % 10000000) : "");
            }
            return Cast(i / 1000000000) + " Arab "
                    + ((i % 1000000000 > 0) ? " " + Cast(i % 1000000000) : "");
        }
    }
}
