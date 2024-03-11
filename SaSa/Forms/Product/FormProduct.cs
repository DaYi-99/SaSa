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


        private void FormProduct_Load(object sender, EventArgs e)
        {
            FillData();
            showcbo();
            btnLuu.Enabled = false;
            btnFile.Hide();

            //enable textbox
            //txtMasp.Enabled = false;
            //txtTensp.Enabled = false;
            //txtTongsl.Enabled = false;
            //txtDongia.Enabled = false;

            //lbSK.Hide();
        }

        // Xoá textbox
        private void ClearTxt()
        {
            txtmasp.Text = "";
            txttensp.Text = "";
            txtdongia.Text = "";
            txtsoluong.Text = "";
            dtpngaycn.Text = "";
        }

        // Hiện tên mặt hàng lên cbobox
        public void showcbo()
        {
            var cmd = new SqlCommand("select * from MATHANG", DAL_Connect.myconn);
            var rd = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(rd);
            rd.Dispose();
            cbomh.DisplayMember = "TENMH";
            cbomh.DataSource = dt;
        }

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

        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Lưu thao tác thêm sản phẩm
            if(txtcode.Text == "0")
            {
                //tạo truy vấn sql lấy ra mã mặt hàng theo tên mặt hàng trong combobox
                SqlCommand m1 = new SqlCommand();
                m1.CommandType = CommandType.Text;
                m1.CommandText = "select MAMH from MATHANG where TENMH = N'" + cbomh.Text + "'";
                m1.Connection = DAL_Connect.myconn;
                string mamh = (string)m1.ExecuteScalar();

                //Thực hiện thêm sản phẩm mới
                if (txttensp.Text == "" || txtsoluong.Text == "" || txtdongia.Text == "" || cbodvt.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi thêm mới!");
                }
                else
                {
                    SqlCommand newsp = new SqlCommand(
                    "insert into SANPHAM values ('" + txtmasp.Text + "',N'"
                    + txttensp.Text + "',N'"
                    + cbodvt.Text + "','"
                    + txtdongia.Text + "','"
                    + txtsoluong.Text + "','"
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
            //
            else if(txtcode.Text == "1")
            {

            }

            else if (txtcode.Text == "2")
            {
                SqlCommand upd = new SqlCommand("update SANPHAM set " +
                        "TENSP =N'" + txttensp.Text + "'," +
                        "DVT =N'" + cbodvt.Text + "'," +
                        "DONGIA ='" + txtdongia.Text + "'," +
                        "SLTON ='" + txtsoluong.Text + "'," +
                        "NGAYCN = getdate() " +
                        "where MASP='" + txtmasp.Text + "'", DAL_Connect.myconn);
                SqlDataReader rupd = upd.ExecuteReader();
                rupd.Read();
                rupd.Close();

                MessageBox.Show("Sửa sản phẩm [" + this.txttensp.Text.ToString() + "] thành công!");
                myTable.Clear();
                FillData();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnFile.Hide();
            ClearTxt();
        }

        private void drvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (drvProduct.Columns[e.ColumnIndex].Name == "del")
            {
                txtcode.Text = "1";

                int r = drvProduct.CurrentCell.RowIndex;

                txtmasp.Text = drvProduct.Rows[r].Cells[1].Value.ToString();
                txttensp.Text = drvProduct.Rows[r].Cells[2].Value.ToString();

                DialogResult dr = MessageBox.Show("Bạn có muốn xoá sản phẩm - " + txttensp.Text, "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    SqlCommand delkh = new SqlCommand("delete from SANPHAM where MASP='" + txtmasp.Text + "' ", DAL_Connect.myconn);
                    SqlDataReader rdelkh = delkh.ExecuteReader();
                    rdelkh.Read();
                    rdelkh.Close();

                    MessageBox.Show("Xoá sản phẩm [ " + this.txttensp.Text.ToString() + " ] thành công!");
                    myTable.Clear();
                    FillData();

                    ClearTxt();
                }
            }
            else if (drvProduct.Columns[e.ColumnIndex].Name == "upd")
            {

                ClearTxt();
                btnLuu.Enabled = true;
                txtcode.Text = "2";

                int r = drvProduct.CurrentCell.RowIndex;

                txtmasp.Text    = drvProduct.Rows[r].Cells[1].Value.ToString();
                txttensp.Text   = drvProduct.Rows[r].Cells[2].Value.ToString();
                cbodvt.Text     = drvProduct.Rows[r].Cells[3].Value.ToString();
                txtdongia.Text  = drvProduct.Rows[r].Cells[4].Value.ToString();
                txtsoluong.Text = drvProduct.Rows[r].Cells[5].Value.ToString();
                txtmamh.Text      = drvProduct.Rows[r].Cells[6].Value.ToString();
                dtpngaycn.Text  = drvProduct.Rows[r].Cells[7].Value.ToString();

                var cmd = new SqlCommand("select * from MATHANG where MAMH='"+txtmamh.Text+"'", DAL_Connect.myconn);
                var rd = cmd.ExecuteReader();
                var dt = new DataTable();
                dt.Load(rd);
                rd.Dispose();
                cbomh.DisplayMember = "TENMH";
                cbomh.DataSource = dt;

                txtdongia.Text = string.Format("{0:#,##0}", double.Parse(drvProduct.Rows[r].Cells[4].Value.ToString()));
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtcode.Text = "0";
            btnFile.Show();

            // Khởi tạo mã sản phẩm
            SqlDataReader newsp = bus_pro.getDataStoredProcedure("SP_TAOMASP");
            if (newsp.Read() == true)
            {
                this.txtmasp.Text = newsp.GetString(0).ToString();
            }
            newsp.Close();

            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            txttensp.Focus();
        }

        private void drvProduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // FORMAT CHO CỘT ĐƠN GIÁ
            if (e.ColumnIndex == 4 && e.RowIndex != this.drvProduct.NewRowIndex)
            {
                if (drvProduct.Rows[e.RowIndex].Cells[4].Value != null)
                {
                    double val = double.Parse(e.Value.ToString());
                    e.Value = val.ToString("N0");
                }
            }
        }
    }
}
