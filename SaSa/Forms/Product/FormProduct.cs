using SaSa.BUS;
using SaSa.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaSa.Forms.Product
{
    public partial class FormProduct : Form
    {
        BUS_Product bus_pro = new BUS_Product();

        //------ Khai báo biến thuộc lớp DataTable ----------
        DataTable myTable = new DataTable();
        DataRow myRow = null;

        public FormProduct()
        {
            InitializeComponent();
            //Set di chuyển form theo thanh tiêu đề
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }


        private void FormProduct_Load(object sender, EventArgs e)
        {
            FillData();
            showcbo();
            btnLuu.Enabled = false;

            //enable textbox
            txtMasp.Enabled = false;
            txtTensp.Enabled = false;
            txtTongsl.Enabled = false;
            txtDongia.Enabled = false;

            lbSK.Hide();
        }
        public void showcbo()
        {
            var cmd = new SqlCommand("select * from MATHANG", DAL_Connect.myconn);
            var rd = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(rd);
            rd.Dispose();
            cboMH.DisplayMember = "TENMH";
            cboMH.DataSource = dt;
        }



        // Thao tác dữ liệu -- O
        private void FillData()
        {
            // Đổ dữ liệu từ database vào Datagridview cho form Sản phẩm
            SqlCommand cmd = new SqlCommand("select * from SANPHAM", DAL_Connect.myconn);
            SqlDataReader rd = cmd.ExecuteReader();
            //myTable.Clear();
            myTable = this.dtsProduct.Tables[0]; //dataset
            int STT = 1;
            while (rd.Read() == true)
            {
                myRow = myTable.NewRow();
                myRow[0] = STT;
                myRow[1] = rd.GetString(0).ToString(); //masp
                myRow[2] = rd.GetString(1).ToString(); //tensp
                myRow[3] = rd.GetString(2).ToString(); //dvt
                myRow[4] = rd.GetDecimal(3).ToString();  //dongia
                myRow[5] = rd.GetInt32(4).ToString();  //slton
                myRow[6] = rd.GetString(5).ToString(); //mamh
                myRow[7] = rd.GetDateTime(6).ToString(); //ngaycn
                myTable.Rows.Add(myRow);
                STT += 1;
            }
            this.drvProduct.DataSource = myTable;
            rd.Close();
        }
        private void drvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            DataGridViewRow row = drvProduct.Rows[i];
            txtMasp.Texts = row.Cells[1].Value.ToString();
            txtTensp.Texts = row.Cells[2].Value.ToString();
            cboDvt.Text = row.Cells[3].Value.ToString(); ;
            txtDongia.Texts = row.Cells[4].Value.ToString();
            txtTongsl.Texts = row.Cells[5].Value.ToString();
            dtpNgaycn.Text = row.Cells[7].Value.ToString();
            }
        // Thao tác dữ liệu -- X


        // Window icon -- O
        private void ptMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Window icon -- X


        


        // Các nút sự kiện -- O
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMasp.Focus();
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtTensp.Texts = "";
            txtTongsl.Texts = "";
            txtDongia.Texts = "";


            btnLuu.Enabled = true;

            //Khởi tạo mã sản phẩm
            SqlDataReader newsp = bus_pro.getDataStoredProcedure("SP_TAOMASP");
            if (newsp.Read() == true)
            {
                this.txtMasp.Texts = newsp.GetString(0).ToString();
            }
            newsp.Close();

            txtTensp.Enabled = true;
            txtTongsl.Enabled = true;
            txtDongia.Enabled = true;

            lbSK.Text = "THÊM";
            lbSK.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMasp.Texts = "";
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;

            lbSK.Text = "XOÁ";
            lbSK.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMasp.Texts = "";
            txtDongia.Enabled = true;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;

            lbSK.Text = "SỬA";
            lbSK.Show();
        }
        // Các nút sự kiện -- X



        // Các nút submit -- O
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Xủ lý cho thao tác thêm
            if (btnThem.Enabled == false) 
            {
                //tạo truy vấn sql lấy ra mã mặt hàng theo tên mặt hàng trong combobox
                SqlCommand m1 = new SqlCommand();
                m1.CommandType = CommandType.Text;
                m1.CommandText = "select MAMH from MATHANG where TENMH = N'" + cboMH.Text + "'";
                m1.Connection = DAL_Connect.myconn;
                string mamh = (string)m1.ExecuteScalar();

                //Thực hiện thêm sản phẩm mới
                if (txtTensp.Texts == "" || txtTongsl.Texts == "" || txtDongia.Texts == "" || cboDvt.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi thêm mới!");
                }
                else
                {
                    SqlCommand newsp = new SqlCommand(
                    "insert into SANPHAM values ('" + txtMasp.Texts + "',N'"
                    + txtTensp.Texts + "',N'"
                    + cboDvt.Text + "','"
                    + txtDongia.Texts + "','"
                    + txtTongsl.Texts + "','"
                    + mamh
                    + "',getdate())", DAL_Connect.myconn);
                    SqlDataReader rd = newsp.ExecuteReader();
                    rd.Close();
                    myTable.Clear();
                    FillData();
                    btnThem.Enabled = true;
                    btnLuu.Enabled = false;
                }
            }
            // Xủ lý cho thao tác xoá
            else if (btnXoa.Enabled == false) 
            {
                if (txtMasp.Texts == "")
                {
                    MessageBox.Show("Bạn chưa chọn sản phẩm muốn xoá!", "Thông báo");
                    return;
                }
                if ((MessageBox.Show("Bạn có chắc chắn muốn xóa [ " + txtTensp.Texts + " ] không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    SqlCommand newmh = new SqlCommand(
                        "alter table HDB_CT nocheck constraint all \n" +
                        "alter table HDM_CT nocheck constraint all \n" +
                        "delete from SANPHAM where MASP='" + txtMasp.Texts + "'\n" +
                        "alter table HDB_CT check constraint all\n" +
                        "alter table HDM_CT check constraint all\n"
                    /*"delete from SANPHAM where MASP='" + txtMasp.Texts + "'"*/, DAL_Connect.myconn);
                    SqlDataReader rd = newmh.ExecuteReader();
                    rd.Close();
                    myTable.Clear();
                    FillData();
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    txtMasp.Texts = "";
                }
            }
            // Xủ lý cho thao tác sửa
            else if (btnSua.Enabled == false) 
            {
                if (txtMasp.Texts == "")
                {
                    MessageBox.Show("Bạn chưa chọn sản phẩm muốn sửa!", "Thông báo");
                    return;
                }
                if ((MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin [ " + txtTensp.Texts + " ] không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    SqlCommand newmh = new SqlCommand(
                    "update SANPHAM set DONGIA = '" + txtDongia.Texts + "' , NGAYCN = getdate() where MASP='" + txtMasp.Texts + "'", DAL_Connect.myconn);
                    SqlDataReader rd = newmh.ExecuteReader();
                    rd.Close();
                    myTable.Clear();
                    FillData();
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMasp.Texts = "";
            txtTensp.Texts = "";
            txtDongia.Texts = "";
            txtTongsl.Texts = "";

            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

            lbSK.Hide();
        }
        // Các nút submit -- X



        


        


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
