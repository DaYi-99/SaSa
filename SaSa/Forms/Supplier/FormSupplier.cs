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
    public partial class FormSupplier : Form
    {
        public FormSupplier()
        {
            InitializeComponent();
            //Set di chuyển form theo thanh tiêu đề
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        //------ Khai báo biến thuộc lớp DataTable ----------
        DataTable myTable = new DataTable();
        DataRow myRow = null;


        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            FillData();
        }

        private void FillData()
        {
            // Đổ dữ liệu từ database vào Datagridview cho form Nhà cung ứng
            SqlCommand cmd = new SqlCommand("select * from NCU", DAL_Connect.myconn);
            SqlDataReader rd = cmd.ExecuteReader();

            //myTable.Clear();
            myTable = this.dsSupplier.Tables[0]; //dataset
            int STT = 1;
            while (rd.Read() == true)
            {
                myRow = myTable.NewRow();
                myRow[0] = STT;
                myRow[1] = rd.GetString(0).ToString(); //mancu
                myRow[2] = rd.GetString(1).ToString(); //tenncu
                myRow[3] = rd.GetString(2).ToString(); //sdt
                myRow[4] = rd.GetString(3).ToString();  //diachi
                myRow[5] = rd.GetString(4).ToString();  //tensale
                myRow[6] = rd.GetString(5).ToString();  //tensep
                myRow[7] = rd.GetString(6).ToString();  //sdtsep
                myTable.Rows.Add(myRow);
                STT += 1;
            }
            this.drvSupplier.DataSource = myTable;
            rd.Close();
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(btnThem.Enabled==false)
            {
                SqlCommand cmd1 = new SqlCommand(
                " insert into NCU values ('" + txtMaNCU.Text + "',N'" + txtTenNCU.Text + "'," + txtDT.Text + ",N'" + txtDC.Text + "',N'" + txtTenSale.Text + "',N'" + txtTenChu.Text + "','" + txtSdtChu.Text + "')"
                        , DAL_Connect.myconn);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                rd1.Close();
                MessageBox.Show("Thêm Nhà cung ứng thành công!", "Thông báo");
                myTable.Clear();
                FillData();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

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
    }
}
