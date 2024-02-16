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
    public partial class FormProductType : Form
    {

        //------ Khai báo biến thuộc lớp DataTable ----------
        DataTable myTable = new DataTable();
        DataRow myRow = null;

        public FormProductType()
        {
            InitializeComponent();
            //Set di chuyển form theo thanh tiêu đề
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProductType_Load(object sender, EventArgs e)
        {
            FillData();
            btnSave.Enabled = false;

            lbtb.Hide();
        }

        private void FillData()
        {
            // Đổ dữ liệu từ database vào Datagridview cho form mặt hàng
            SqlCommand cmd = new SqlCommand("select * from MATHANG", DAL_Connect.myconn);
            SqlDataReader rd = cmd.ExecuteReader();
            //myTable.Clear();
            myTable = this.dtsProductType.Tables[0]; //dataset
            int STT = 1;
            while (rd.Read() == true)
            {
                myRow = myTable.NewRow();
                myRow[0] = STT;
                myRow[1] = rd.GetString(0).ToString(); //mamh
                myRow[2] = rd.GetString(1).ToString(); //tenmh
                myTable.Rows.Add(myRow);
                STT += 1;
            }
            this.drvProductType.DataSource = myTable;
            rd.Close();
        }

        private void ptAdd_Click(object sender, EventArgs e)
        {
            txtMAMH.Focus();
            lbtb.Text = "Bạn đang thực hiện thao tác THÊM";
            lbtb.Show();
            ptAdd.Hide();
            btnSave.Enabled = true;
            txtVal.Text = "1" ;
            ptDelete.Show();
            ptEdit.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtVal.Text=="1")
            {
                if(txtMAMH.Text=="" || txtTENMH.Text=="")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                }
                else
                {
                    SqlCommand newmh = new SqlCommand(
                    "insert into MATHANG values ('" + txtMAMH.Text + "',N'" + txtTENMH.Text + "')", DAL_Connect.myconn);
                    SqlDataReader rd = newmh.ExecuteReader();
                    rd.Close();
                    myTable.Clear();
                    FillData();
                    btnSave.Enabled = false;
                    ptAdd.Show();
                }
            }
            else if(txtVal.Text=="2")
            {
                if (txtMAMH.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn mặt hàng muốn xoá!", "Thông báo");
                    return;
                }
                if ((MessageBox.Show("Bạn có chắc chắn muốn xóa "+txtTENMH.Text+" không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    SqlCommand newmh = new SqlCommand(
                    "delete from MATHANG where MAMH='" + txtMAMH.Text + "'", DAL_Connect.myconn);
                    SqlDataReader rd = newmh.ExecuteReader();
                    rd.Close();
                    myTable.Clear();
                    FillData();
                    btnSave.Enabled = false;
                    ptDelete.Show();
                }
            }
            else if(txtVal.Text=="3")
            {
                if (txtMAMH.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn mặt hàng muốn sửa!", "Thông báo");
                    return;
                }
                if ((MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin thành [" + txtTENMH.Text + "] không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    SqlCommand newmh = new SqlCommand(
                    "update MATHANG set TENMH=N'" + txtTENMH.Text + "' where MAMH='" + txtMAMH.Text + "'", DAL_Connect.myconn);
                    SqlDataReader rd = newmh.ExecuteReader();
                    rd.Close();
                    myTable.Clear();
                    FillData();
                    btnSave.Enabled = false;
                    ptDelete.Show();
                }
            }

        }

        private void ptDelete_Click(object sender, EventArgs e)
        {
            lbtb.Text = "Bạn đang thực hiện thao tác XOÁ";
            lbtb.Show();
            btnSave.Enabled = true;

            txtVal.Text = "2";

            ptDelete.Hide();
            ptAdd.Show();
            ptEdit.Show();

        }

        private void drvProductType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            DataGridViewRow row = drvProductType.Rows[i];
            txtMAMH.Text = row.Cells[1].Value.ToString();
            txtTENMH.Text = row.Cells[2].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMAMH.Text = "";
            txtTENMH.Text = "";
            btnSave.Enabled = false;
            ptAdd.Show();
            ptDelete.Show();
            ptEdit.Show();

            lbtb.Hide();
        }

        private void ptEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            lbtb.Text = "Bạn đang thực hiện thao tác SỬA";
            lbtb.Show();
            txtVal.Text = "3";

            ptDelete.Show();
            ptAdd.Show();
            ptEdit.Hide();
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
